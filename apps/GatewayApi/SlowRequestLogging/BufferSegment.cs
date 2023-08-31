/* Copyright 2021 Radix Publishing Ltd incorporated in Jersey (Channel Islands).
 *
 * Licensed under the Radix License, Version 1.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at:
 *
 * radixfoundation.org/licenses/LICENSE-v1
 *
 * The Licensor hereby grants permission for the Canonical version of the Work to be
 * published, distributed and used under or by reference to the Licensor’s trademark
 * Radix ® and use of any unregistered trade names, logos or get-up.
 *
 * The Licensor provides the Work (and each Contributor provides its Contributions) on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied,
 * including, without limitation, any warranties or conditions of TITLE, NON-INFRINGEMENT,
 * MERCHANTABILITY, or FITNESS FOR A PARTICULAR PURPOSE.
 *
 * Whilst the Work is capable of being deployed, used and adopted (instantiated) to create
 * a distributed ledger it is your responsibility to test and validate the code, together
 * with all logic and performance of that code under all foreseeable scenarios.
 *
 * The Licensor does not make or purport to make and hereby excludes liability for all
 * and any representation, warranty or undertaking in any form whatsoever, whether express
 * or implied, to any entity or person, including any representation, warranty or
 * undertaking, as to the functionality security use, value or other characteristics of
 * any distributed ledger nor in respect the functioning or value of any tokens which may
 * be created stored or transferred using the Work. The Licensor does not warrant that the
 * Work or any use of the Work complies with any law or regulation in any territory where
 * it may be implemented or used or that it will be appropriate for any specific purpose.
 *
 * Neither the licensor nor any current or former employees, officers, directors, partners,
 * trustees, representatives, agents, advisors, contractors, or volunteers of the Licensor
 * shall be liable for any direct or indirect, special, incidental, consequential or other
 * losses of any kind, in tort, contract or otherwise (including but not limited to loss
 * of revenue, income or profits, or loss of use or data, or loss of reputation, or loss
 * of any economic or other opportunity of whatsoever nature or howsoever arising), arising
 * out of or in connection with (without limitation of any use, misuse, of any ledger system
 * or use made or its functionality or any performance or operation of any code or protocol
 * caused by bugs or programming or logic errors or otherwise);
 *
 * A. any offer, purchase, holding, use, sale, exchange or transmission of any
 * cryptographic keys, tokens or assets created, exchanged, stored or arising from any
 * interaction with the Work;
 *
 * B. any failure in a transmission or loss of any token or assets keys or other digital
 * artefacts due to errors in transmission;
 *
 * C. bugs, hacks, logic errors or faults in the Work or any communication;
 *
 * D. system software or apparatus including but not limited to losses caused by errors
 * in holding or transmitting tokens by any third-party;
 *
 * E. breaches or failure of security including hacker attacks, loss or disclosure of
 * password, loss of private key, unauthorised use or misuse of such passwords or keys;
 *
 * F. any losses including loss of anticipated savings or other benefits resulting from
 * use of the Work or any changes to the Work (however implemented).
 *
 * You are solely responsible for; testing, validating and evaluation of all operation
 * logic, functionality, security and appropriateness of using the Work for any commercial
 * or non-commercial purpose and for any reproduction or redistribution by You of the
 * Work. You assume all risks associated with Your use of the Work and the exercise of
 * permissions under this License.
 */

// <auto-generated>
#nullable enable

using System;
using System.Buffers;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GatewayApi.SlowRequestLogging;

internal sealed class BufferSegment : ReadOnlySequenceSegment<byte>
{
    private IMemoryOwner<byte>? _memoryOwner;
    private byte[]? _array;
    private BufferSegment? _next;
    private int _end;

    /// <summary>
    /// The End represents the offset into AvailableMemory where the range of "active" bytes ends. At the point when the block is leased
    /// the End is guaranteed to be equal to Start. The value of Start may be assigned anywhere between 0 and
    /// Buffer.Length, and must be equal to or less than End.
    /// </summary>
    public int End
    {
        get => _end;
        set
        {
            Debug.Assert(value <= AvailableMemory.Length);

            _end = value;
            Memory = AvailableMemory.Slice(0, value);
        }
    }

    /// <summary>
    /// Reference to the next block of data when the overall "active" bytes spans multiple blocks. At the point when the block is
    /// leased Next is guaranteed to be null. Start, End, and Next are used together in order to create a linked-list of discontiguous
    /// working memory. The "active" memory is grown when bytes are copied in, End is increased, and Next is assigned. The "active"
    /// memory is shrunk when bytes are consumed, Start is increased, and blocks are returned to the pool.
    /// </summary>
    public BufferSegment? NextSegment
    {
        get => _next;
        set
        {
            Next = value;
            _next = value;
        }
    }

    public void SetOwnedMemory(IMemoryOwner<byte> memoryOwner)
    {
        _memoryOwner = memoryOwner;
        AvailableMemory = memoryOwner.Memory;
    }

    public void SetOwnedMemory(byte[] arrayPoolBuffer)
    {
        _array = arrayPoolBuffer;
        AvailableMemory = arrayPoolBuffer;
    }

    // Resets memory and internal state, should be called when removing the segment from the linked list
    public void Reset()
    {
        ResetMemory();

        Next = null;
        RunningIndex = 0;
        _next = null;
    }

    // Resets memory only, should be called when keeping the BufferSegment in the linked list and only swapping out the memory
    public void ResetMemory()
    {
        IMemoryOwner<byte>? memoryOwner = _memoryOwner;
        if (memoryOwner != null)
        {
            _memoryOwner = null;
            memoryOwner.Dispose();
        }
        else
        {
            Debug.Assert(_array != null);
            ArrayPool<byte>.Shared.Return(_array);
            _array = null;
        }


        Memory = default;
        _end = 0;
        AvailableMemory = default;
    }

    // Exposed for testing
    internal object? MemoryOwner => (object?)_memoryOwner ?? _array;

    public Memory<byte> AvailableMemory { get; private set; }

    public int Length => End;

    public int WritableBytes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => AvailableMemory.Length - End;
    }

    public void SetNext(BufferSegment segment)
    {
        Debug.Assert(segment != null);
        Debug.Assert(Next == null);

        NextSegment = segment;

        segment = this;

        while (segment.Next != null)
        {
            Debug.Assert(segment.NextSegment != null);
            segment.NextSegment.RunningIndex = segment.RunningIndex + segment.Length;
            segment = segment.NextSegment;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static long GetLength(BufferSegment startSegment, int startIndex, BufferSegment endSegment, int endIndex)
    {
        return (endSegment.RunningIndex + (uint)endIndex) - (startSegment.RunningIndex + (uint)startIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static long GetLength(long startPosition, BufferSegment endSegment, int endIndex)
    {
        return (endSegment.RunningIndex + (uint)endIndex) - startPosition;
    }
}
