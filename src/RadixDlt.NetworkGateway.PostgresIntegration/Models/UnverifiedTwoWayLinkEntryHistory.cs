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

using RadixDlt.NetworkGateway.Abstractions;
using RadixDlt.NetworkGateway.Abstractions.StandardMetadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace RadixDlt.NetworkGateway.PostgresIntegration.Models;

[Table("unverified_two_way_link_entry_history")]
internal abstract class UnverifiedTwoWayLinkEntryHistory
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("from_state_version")]
    public long FromStateVersion { get; set; }

    [Column("entity_id")]
    public long EntityId { get; set; }

    [Column("is_deleted")]
    public bool IsDeleted { get; set; }

    [Column("is_locked")]
    public bool IsLocked { get; set; }

    [Column(CommonDbContext.DiscriminatorColumnName)]
    public StandardMetadataKey Discriminator { get; set; }

    public abstract IEnumerable<long> ReferencedEntityIds();

    public abstract UnverifiedTwoWayLink MapToDomain(IDictionary<long, EntityAddress> correlatedEntities);
}

internal abstract class StringBasedUnverifiedTwoWayLinkEntryHistory : UnverifiedTwoWayLinkEntryHistory, IAggregateHolder
{
    [Column("values")]
    public string[]? Values { get; set; }

    public override IEnumerable<long> ReferencedEntityIds() => Enumerable.Empty<long>();

    public IEnumerable<(string Name, int TotalCount)> AggregateCounts()
    {
        if (Values != null)
        {
            yield return (nameof(Values), Values.Length);
        }
    }

    [MemberNotNull(nameof(Values))]
    protected void EnsureMappable()
    {
        if (IsDeleted || Values == null || Values.Length == 0)
        {
            throw new InvalidOperationException("Cannot map deleted / incomplete object");
        }
    }
}

internal abstract class EntityBasedUnverifiedTwoWayLinkEntryHistory : UnverifiedTwoWayLinkEntryHistory, IAggregateHolder
{
    [Column("entity_ids")]
    public long[]? EntityIds { get; set; }

    public override IEnumerable<long> ReferencedEntityIds() => EntityIds ?? Enumerable.Empty<long>();

    public IEnumerable<(string Name, int TotalCount)> AggregateCounts()
    {
        if (EntityIds != null)
        {
            yield return (nameof(EntityIds), EntityIds.Length);
        }
    }

    [MemberNotNull(nameof(EntityIds))]
    protected void EnsureMappable()
    {
        if (IsDeleted || EntityIds == null || EntityIds.Length == 0)
        {
            throw new InvalidOperationException("Cannot map deleted / incomplete object");
        }
    }
}

internal class DappAccountTypeUnverifiedTwoWayLinkEntryHistory : StringBasedUnverifiedTwoWayLinkEntryHistory
{
    [NotMapped]
    public string? Value
    {
        get => Values?.FirstOrDefault();
        set => Values = value == null ? null : new[] { value };
    }

    public override UnverifiedTwoWayLink MapToDomain(IDictionary<long, EntityAddress> correlatedEntities)
    {
        EnsureMappable();

        return new DappAccountTypeUnverifiedTwoWayLink
        {
            FromStateVersion = FromStateVersion,
            EntityAddress = correlatedEntities[EntityId],
            Value = Values.First(),
        };
    }
}

internal class DappClaimedWebsitesUnverifiedTwoWayLinkEntryHistory : StringBasedUnverifiedTwoWayLinkEntryHistory
{
    [NotMapped]
    public string[]? ClaimedWebsites
    {
        get => Values;
        set => Values = value;
    }

    public override UnverifiedTwoWayLink MapToDomain(IDictionary<long, EntityAddress> correlatedEntities)
    {
        EnsureMappable();

        return new DappClaimedWebsitesUnverifiedTwoWayLink
        {
            FromStateVersion = FromStateVersion,
            EntityAddress = correlatedEntities[EntityId],
            ClaimedWebsites = Values.Select(x => new Uri(x)).ToList(),
        };
    }
}

internal class DappDefinitionUnverifiedTwoWayLinkEntryHistory : EntityBasedUnverifiedTwoWayLinkEntryHistory
{
    [NotMapped]
    public long? DappDefinitionEntityId
    {
        get => EntityIds?.FirstOrDefault();
        set => EntityIds = !value.HasValue ? null : new[] { value.Value };
    }

    public override UnverifiedTwoWayLink MapToDomain(IDictionary<long, EntityAddress> correlatedEntities)
    {
        EnsureMappable();

        return new DappDefinitionUnverifiedTwoWayLink
        {
            FromStateVersion = FromStateVersion,
            EntityAddress = correlatedEntities[EntityId],
            DappDefinition = correlatedEntities[EntityIds.First()],
        };
    }
}

internal class DappDefinitionsUnverifiedTwoWayLinkEntryHistory : EntityBasedUnverifiedTwoWayLinkEntryHistory
{
    [NotMapped]
    public long[]? DappDefinitionEntityIds
    {
        get => EntityIds;
        set => EntityIds = value;
    }

    public override UnverifiedTwoWayLink MapToDomain(IDictionary<long, EntityAddress> correlatedEntities)
    {
        EnsureMappable();

        return new DappDefinitionsUnverifiedTwoWayLink
        {
            FromStateVersion = FromStateVersion,
            EntityAddress = correlatedEntities[EntityId],
            DappDefinitions = EntityIds.Select(x => correlatedEntities[x]).ToList(),
        };
    }
}

internal class DappClaimedEntitiesUnverifiedTwoWayLinkEntryHistory : EntityBasedUnverifiedTwoWayLinkEntryHistory
{
    [NotMapped]
    public long[]? ClaimedEntityIds
    {
        get => EntityIds;
        set => EntityIds = value;
    }

    public override UnverifiedTwoWayLink MapToDomain(IDictionary<long, EntityAddress> correlatedEntities)
    {
        EnsureMappable();

        return new DappClaimedEntitiesUnverifiedTwoWayLink
        {
            FromStateVersion = FromStateVersion,
            EntityAddress = correlatedEntities[EntityId],
            ClaimedEntities = EntityIds.Select(x => correlatedEntities[x]).ToList(),
        };
    }
}

internal class DappAccountLockerUnverifiedTwoWayLinkEntryHistory : EntityBasedUnverifiedTwoWayLinkEntryHistory
{
    [NotMapped]
    public long? AccountLockerEntityId
    {
        get => EntityIds?.FirstOrDefault();
        set => EntityIds = !value.HasValue ? null : new[] { value.Value };
    }

    public override UnverifiedTwoWayLink MapToDomain(IDictionary<long, EntityAddress> correlatedEntities)
    {
        EnsureMappable();

        return new DappAccountLockerUnverifiedTwoWayLink
        {
            FromStateVersion = FromStateVersion,
            EntityAddress = correlatedEntities[EntityId],
            LockerAddress = correlatedEntities[EntityIds.First()],
        };
    }
}
