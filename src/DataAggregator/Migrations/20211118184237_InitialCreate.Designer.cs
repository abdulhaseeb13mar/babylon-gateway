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

﻿// <auto-generated />
using System;
using System.Numerics;
using Common.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAggregator.Migrations
{
    [DbContext(typeof(CommonDbContext))]
    [Migration("20211118184237_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Common.Database.Models.Ledger.History.AccountResourceBalanceHistory", b =>
                {
                    b.Property<string>("AccountAddress")
                        .HasColumnType("text")
                        .HasColumnName("account_address");

                    b.Property<string>("ResourceIdentifier")
                        .HasColumnType("text")
                        .HasColumnName("rri");

                    b.Property<long>("FromStateVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("from_state_version");

                    b.Property<BigInteger>("Balance")
                        .HasPrecision(1000)
                        .HasColumnType("numeric(1000)")
                        .HasColumnName("balance");

                    b.Property<long?>("ToStateVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("bigint")
                        .HasColumnName("to_state_version");

                    b.HasKey("AccountAddress", "ResourceIdentifier", "FromStateVersion")
                        .HasName("pk_account_resource_balance_history");

                    b.HasIndex("AccountAddress", "FromStateVersion")
                        .HasDatabaseName("ix_account_resource_balance_history_account_address_from_state");

                    b.HasIndex("AccountAddress", "ResourceIdentifier")
                        .IsUnique()
                        .HasDatabaseName("ix_account_resource_balance_history_current_balance")
                        .HasFilter("to_state_version is null");

                    b.HasIndex("ResourceIdentifier", "FromStateVersion")
                        .HasDatabaseName("ix_account_resource_balance_history_rri_from_state_version");

                    b.HasIndex("ResourceIdentifier", "AccountAddress", "FromStateVersion")
                        .HasDatabaseName("ix_account_resource_balance_history_rri_account_address_from_s");

                    b.ToTable("account_resource_balance_history", (string)null);
                });

            modelBuilder.Entity("Common.Database.Models.Ledger.LedgerOperationGroup", b =>
                {
                    b.Property<long>("ResultantStateVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("state_version");

                    b.Property<int>("OperationGroupIndex")
                        .HasColumnType("integer")
                        .HasColumnName("operation_group_index");

                    b.HasKey("ResultantStateVersion", "OperationGroupIndex")
                        .HasName("pk_operation_groups");

                    b.ToTable("operation_groups", (string)null);
                });

            modelBuilder.Entity("Common.Database.Models.Ledger.LedgerTransaction", b =>
                {
                    b.Property<long>("ResultantStateVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("state_version");

                    b.Property<long?>("EndOfEpochRound")
                        .HasColumnType("bigint")
                        .HasColumnName("end_of_round");

                    b.Property<long>("Epoch")
                        .HasColumnType("bigint")
                        .HasColumnName("epoch");

                    b.Property<BigInteger>("FeePaid")
                        .HasPrecision(1000)
                        .HasColumnType("numeric(1000)")
                        .HasColumnName("fee_paid");

                    b.Property<long>("IndexInEpoch")
                        .HasColumnType("bigint")
                        .HasColumnName("index_in_epoch");

                    b.Property<bool>("IsEndOfEpoch")
                        .HasColumnType("boolean")
                        .HasColumnName("is_end_of_epoch");

                    b.Property<bool>("IsOnlyRoundChange")
                        .HasColumnType("boolean")
                        .HasColumnName("is_only_round_change");

                    b.Property<byte[]>("Message")
                        .HasColumnType("bytea")
                        .HasColumnName("message");

                    b.Property<long?>("ParentStateVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("parent_state_version");

                    b.Property<byte[]>("SignedBy")
                        .HasColumnType("bytea")
                        .HasColumnName("signed_by");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("timestamp");

                    b.Property<byte[]>("TransactionAccumulator")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("transaction_accumulator");

                    b.Property<byte[]>("TransactionIdentifierHash")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("transaction_id");

                    b.HasKey("ResultantStateVersion")
                        .HasName("pk_ledger_transactions");

                    b.HasAlternateKey("TransactionAccumulator")
                        .HasName("ak_ledger_transactions_transaction_accumulator");

                    b.HasAlternateKey("TransactionIdentifierHash")
                        .HasName("ak_ledger_transactions_transaction_id");

                    b.HasIndex("ParentStateVersion")
                        .HasDatabaseName("ix_ledger_transactions_parent_state_version");

                    b.HasIndex("Timestamp")
                        .HasDatabaseName("ix_ledger_transactions_timestamp");

                    b.HasIndex("Epoch", "EndOfEpochRound")
                        .IsUnique()
                        .HasDatabaseName("ix_ledger_transactions_epoch_end_of_round")
                        .HasFilter("end_of_round IS NOT NULL");

                    NpgsqlIndexBuilderExtensions.IncludeProperties(b.HasIndex("Epoch", "EndOfEpochRound"), new[] { "Timestamp" });

                    b.ToTable("ledger_transactions", (string)null);

                    b.HasCheckConstraint("CK_CompleteHistory", "state_version = 1 OR state_version = parent_state_version + 1");
                });

            modelBuilder.Entity("Common.Database.Models.Ledger.Substates.AccountResourceBalanceSubstate", b =>
                {
                    b.Property<long>("UpStateVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("up_state_version");

                    b.Property<int>("UpOperationGroupIndex")
                        .HasColumnType("integer")
                        .HasColumnName("up_operation_group_index");

                    b.Property<int>("UpOperationIndexInGroup")
                        .HasColumnType("integer")
                        .HasColumnName("up_operation_index_in_group");

                    b.Property<string>("AccountAddress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("account_address");

                    b.Property<BigInteger>("Amount")
                        .HasPrecision(1000)
                        .HasColumnType("numeric(1000)")
                        .HasColumnName("amount");

                    b.Property<int?>("DownOperationGroupIndex")
                        .HasColumnType("integer")
                        .HasColumnName("down_operation_group_index");

                    b.Property<int?>("DownOperationIndexInGroup")
                        .HasColumnType("integer")
                        .HasColumnName("down_operation_index_in_group");

                    b.Property<long?>("DownStateVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("bigint")
                        .HasColumnName("down_state_version");

                    b.Property<string>("ResourceIdentifier")
                        .HasColumnType("text")
                        .HasColumnName("rri");

                    b.Property<byte[]>("SubstateIdentifier")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("substate_identifier");

                    b.HasKey("UpStateVersion", "UpOperationGroupIndex", "UpOperationIndexInGroup")
                        .HasName("pk_account_resource_balance_substates");

                    b.HasAlternateKey("SubstateIdentifier")
                        .HasName("ak_account_resource_balance_substates_substate_identifier");

                    b.HasIndex("AccountAddress", "ResourceIdentifier")
                        .HasDatabaseName("ix_account_resource_balance_substates_account_address_rri");

                    b.HasIndex("DownStateVersion", "DownOperationGroupIndex")
                        .HasDatabaseName("ix_account_resource_balance_substates_down_state_version_down_");

                    b.HasIndex("ResourceIdentifier", "AccountAddress")
                        .HasDatabaseName("ix_account_resource_balance_substates_rri_account_address");

                    b.HasIndex("AccountAddress", "ResourceIdentifier", "Amount")
                        .HasDatabaseName("IX_AccountResourceBalanceSubstate_CurrentUnspentUTXOs")
                        .HasFilter("down_state_version is null");

                    NpgsqlIndexBuilderExtensions.IncludeProperties(b.HasIndex("AccountAddress", "ResourceIdentifier", "Amount"), new[] { "SubstateIdentifier" });

                    b.ToTable("account_resource_balance_substates", (string)null);
                });

            modelBuilder.Entity("Common.Database.Models.Ledger.Substates.AccountStakeOwnershipBalanceSubstate", b =>
                {
                    b.Property<long>("UpStateVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("up_state_version");

                    b.Property<int>("UpOperationGroupIndex")
                        .HasColumnType("integer")
                        .HasColumnName("up_operation_group_index");

                    b.Property<int>("UpOperationIndexInGroup")
                        .HasColumnType("integer")
                        .HasColumnName("up_operation_index_in_group");

                    b.Property<string>("AccountAddress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("account_address");

                    b.Property<BigInteger>("Amount")
                        .HasPrecision(1000)
                        .HasColumnType("numeric(1000)")
                        .HasColumnName("amount");

                    b.Property<int?>("DownOperationGroupIndex")
                        .HasColumnType("integer")
                        .HasColumnName("down_operation_group_index");

                    b.Property<int?>("DownOperationIndexInGroup")
                        .HasColumnType("integer")
                        .HasColumnName("down_operation_index_in_group");

                    b.Property<long?>("DownStateVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("bigint")
                        .HasColumnName("down_state_version");

                    b.Property<byte[]>("SubstateIdentifier")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("substate_identifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type");

                    b.Property<string>("ValidatorAddress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("validator_address");

                    b.HasKey("UpStateVersion", "UpOperationGroupIndex", "UpOperationIndexInGroup")
                        .HasName("pk_account_stake_ownership_balance_substates");

                    b.HasAlternateKey("SubstateIdentifier")
                        .HasName("ak_account_stake_ownership_balance_substates_substate_identifi");

                    b.HasIndex("AccountAddress", "ValidatorAddress")
                        .HasDatabaseName("ix_account_stake_ownership_balance_substates_account_address_v");

                    b.HasIndex("DownStateVersion", "DownOperationGroupIndex")
                        .HasDatabaseName("ix_account_stake_ownership_balance_substates_down_state_versio");

                    b.HasIndex("ValidatorAddress", "AccountAddress")
                        .HasDatabaseName("ix_account_stake_ownership_balance_substates_validator_address");

                    b.ToTable("account_stake_ownership_balance_substates", (string)null);
                });

            modelBuilder.Entity("Common.Database.Models.Ledger.Substates.AccountXrdStakeBalanceSubstate", b =>
                {
                    b.Property<long>("UpStateVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("up_state_version");

                    b.Property<int>("UpOperationGroupIndex")
                        .HasColumnType("integer")
                        .HasColumnName("up_operation_group_index");

                    b.Property<int>("UpOperationIndexInGroup")
                        .HasColumnType("integer")
                        .HasColumnName("up_operation_index_in_group");

                    b.Property<string>("AccountAddress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("account_address");

                    b.Property<BigInteger>("Amount")
                        .HasPrecision(1000)
                        .HasColumnType("numeric(1000)")
                        .HasColumnName("amount");

                    b.Property<int?>("DownOperationGroupIndex")
                        .HasColumnType("integer")
                        .HasColumnName("down_operation_group_index");

                    b.Property<int?>("DownOperationIndexInGroup")
                        .HasColumnType("integer")
                        .HasColumnName("down_operation_index_in_group");

                    b.Property<long?>("DownStateVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("bigint")
                        .HasColumnName("down_state_version");

                    b.Property<byte[]>("SubstateIdentifier")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("substate_identifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type");

                    b.Property<long?>("UnlockEpoch")
                        .HasColumnType("bigint")
                        .HasColumnName("unlock_epoch");

                    b.Property<string>("ValidatorAddress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("validator_address");

                    b.HasKey("UpStateVersion", "UpOperationGroupIndex", "UpOperationIndexInGroup")
                        .HasName("pk_account_xrd_stake_balance_substates");

                    b.HasAlternateKey("SubstateIdentifier")
                        .HasName("ak_account_xrd_stake_balance_substates_substate_identifier");

                    b.HasIndex("AccountAddress", "ValidatorAddress")
                        .HasDatabaseName("ix_account_xrd_stake_balance_substates_account_address_validat");

                    b.HasIndex("DownStateVersion", "DownOperationGroupIndex")
                        .HasDatabaseName("ix_account_xrd_stake_balance_substates_down_state_version_down");

                    b.HasIndex("ValidatorAddress", "AccountAddress")
                        .HasDatabaseName("ix_account_xrd_stake_balance_substates_validator_address_accou");

                    b.ToTable("account_xrd_stake_balance_substates", (string)null);
                });

            modelBuilder.Entity("Common.Database.Models.Ledger.Substates.ValidatorStakeBalanceSubstate", b =>
                {
                    b.Property<long>("UpStateVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("up_state_version");

                    b.Property<int>("UpOperationGroupIndex")
                        .HasColumnType("integer")
                        .HasColumnName("up_operation_group_index");

                    b.Property<int>("UpOperationIndexInGroup")
                        .HasColumnType("integer")
                        .HasColumnName("up_operation_index_in_group");

                    b.Property<BigInteger>("Amount")
                        .HasPrecision(1000)
                        .HasColumnType("numeric(1000)")
                        .HasColumnName("amount");

                    b.Property<int?>("DownOperationGroupIndex")
                        .HasColumnType("integer")
                        .HasColumnName("down_operation_group_index");

                    b.Property<int?>("DownOperationIndexInGroup")
                        .HasColumnType("integer")
                        .HasColumnName("down_operation_index_in_group");

                    b.Property<long?>("DownStateVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("bigint")
                        .HasColumnName("down_state_version");

                    b.Property<long>("EndOfEpoch")
                        .HasColumnType("bigint")
                        .HasColumnName("epoch");

                    b.Property<byte[]>("SubstateIdentifier")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("substate_identifier");

                    b.Property<string>("ValidatorAddress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("validator_address");

                    b.HasKey("UpStateVersion", "UpOperationGroupIndex", "UpOperationIndexInGroup")
                        .HasName("pk_validator_stake_balance_substates");

                    b.HasAlternateKey("SubstateIdentifier")
                        .HasName("ak_validator_stake_balance_substates_substate_identifier");

                    b.HasIndex("ValidatorAddress")
                        .HasDatabaseName("ix_validator_stake_balance_substates_validator_address");

                    b.HasIndex("DownStateVersion", "DownOperationGroupIndex")
                        .HasDatabaseName("ix_validator_stake_balance_substates_down_state_version_down_o");

                    b.HasIndex("EndOfEpoch", "ValidatorAddress")
                        .IsUnique()
                        .HasDatabaseName("ix_validator_stake_balance_substates_epoch_validator_address");

                    b.ToTable("validator_stake_balance_substates", (string)null);
                });

            modelBuilder.Entity("Common.Database.Models.Node", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<bool>("EnabledForIndexing")
                        .HasColumnType("boolean")
                        .HasColumnName("enabled_for_indexing");

                    b.Property<decimal>("TrustWeighting")
                        .HasColumnType("numeric")
                        .HasColumnName("trust_weighting");

                    b.HasKey("Name")
                        .HasName("pk_nodes");

                    b.ToTable("nodes", (string)null);
                });

            modelBuilder.Entity("Common.Database.Models.RawTransaction", b =>
                {
                    b.Property<byte[]>("TransactionIdentifierHash")
                        .HasColumnType("bytea")
                        .HasColumnName("transaction_id");

                    b.Property<byte[]>("Payload")
                        .HasColumnType("bytea")
                        .HasColumnName("payload");

                    b.Property<DateTime?>("SubmittedTimestamp")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("submitted_timestamp");

                    b.HasKey("TransactionIdentifierHash")
                        .HasName("pk_raw_transactions");

                    b.ToTable("raw_transactions", (string)null);
                });

            modelBuilder.Entity("Common.Database.Models.Ledger.LedgerOperationGroup", b =>
                {
                    b.HasOne("Common.Database.Models.Ledger.LedgerTransaction", "LedgerTransaction")
                        .WithMany()
                        .HasForeignKey("ResultantStateVersion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_operation_groups_ledger_transactions_state_version");

                    b.OwnsOne("Common.Database.Models.Ledger.InferredAction", "InferredAction", b1 =>
                        {
                            b1.Property<long>("LedgerOperationGroupResultantStateVersion")
                                .HasColumnType("bigint")
                                .HasColumnName("state_version");

                            b1.Property<int>("LedgerOperationGroupOperationGroupIndex")
                                .HasColumnType("integer")
                                .HasColumnName("operation_group_index");

                            b1.Property<BigInteger?>("Amount")
                                .HasPrecision(1000)
                                .HasColumnType("numeric(1000)")
                                .HasColumnName("inferred_action_amount");

                            b1.Property<string>("FromAddress")
                                .HasColumnType("text")
                                .HasColumnName("inferred_action_from");

                            b1.Property<string>("ResourceIdentifier")
                                .HasColumnType("text")
                                .HasColumnName("inferred_action_rri");

                            b1.Property<string>("ToAddress")
                                .HasColumnType("text")
                                .HasColumnName("inferred_action_to");

                            b1.Property<string>("Type")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("inferred_action_type");

                            b1.HasKey("LedgerOperationGroupResultantStateVersion", "LedgerOperationGroupOperationGroupIndex");

                            b1.ToTable("operation_groups");

                            b1.WithOwner()
                                .HasForeignKey("LedgerOperationGroupResultantStateVersion", "LedgerOperationGroupOperationGroupIndex")
                                .HasConstraintName("fk_operation_groups_operation_groups_inferred_action_ledger_op");
                        });

                    b.Navigation("InferredAction");

                    b.Navigation("LedgerTransaction");
                });

            modelBuilder.Entity("Common.Database.Models.Ledger.LedgerTransaction", b =>
                {
                    b.HasOne("Common.Database.Models.Ledger.LedgerTransaction", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentStateVersion")
                        .HasConstraintName("fk_ledger_transactions_ledger_transactions_parent_state_version");

                    b.HasOne("Common.Database.Models.RawTransaction", "RawTransaction")
                        .WithMany()
                        .HasForeignKey("TransactionIdentifierHash")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_ledger_transactions_raw_transactions_transaction_id");

                    b.Navigation("Parent");

                    b.Navigation("RawTransaction");
                });

            modelBuilder.Entity("Common.Database.Models.Ledger.Substates.AccountResourceBalanceSubstate", b =>
                {
                    b.HasOne("Common.Database.Models.Ledger.LedgerOperationGroup", "DownOperationGroup")
                        .WithMany()
                        .HasForeignKey("DownStateVersion", "DownOperationGroupIndex")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_t_substate_down_operation_group");

                    b.HasOne("Common.Database.Models.Ledger.LedgerOperationGroup", "UpOperationGroup")
                        .WithMany()
                        .HasForeignKey("UpStateVersion", "UpOperationGroupIndex")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_t_substate_up_operation_group");

                    b.Navigation("DownOperationGroup");

                    b.Navigation("UpOperationGroup");
                });

            modelBuilder.Entity("Common.Database.Models.Ledger.Substates.AccountStakeOwnershipBalanceSubstate", b =>
                {
                    b.HasOne("Common.Database.Models.Ledger.LedgerOperationGroup", "DownOperationGroup")
                        .WithMany()
                        .HasForeignKey("DownStateVersion", "DownOperationGroupIndex")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_t_substate_down_operation_group");

                    b.HasOne("Common.Database.Models.Ledger.LedgerOperationGroup", "UpOperationGroup")
                        .WithMany()
                        .HasForeignKey("UpStateVersion", "UpOperationGroupIndex")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_t_substate_up_operation_group");

                    b.Navigation("DownOperationGroup");

                    b.Navigation("UpOperationGroup");
                });

            modelBuilder.Entity("Common.Database.Models.Ledger.Substates.AccountXrdStakeBalanceSubstate", b =>
                {
                    b.HasOne("Common.Database.Models.Ledger.LedgerOperationGroup", "DownOperationGroup")
                        .WithMany()
                        .HasForeignKey("DownStateVersion", "DownOperationGroupIndex")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_t_substate_down_operation_group");

                    b.HasOne("Common.Database.Models.Ledger.LedgerOperationGroup", "UpOperationGroup")
                        .WithMany()
                        .HasForeignKey("UpStateVersion", "UpOperationGroupIndex")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_t_substate_up_operation_group");

                    b.Navigation("DownOperationGroup");

                    b.Navigation("UpOperationGroup");
                });

            modelBuilder.Entity("Common.Database.Models.Ledger.Substates.ValidatorStakeBalanceSubstate", b =>
                {
                    b.HasOne("Common.Database.Models.Ledger.LedgerOperationGroup", "DownOperationGroup")
                        .WithMany()
                        .HasForeignKey("DownStateVersion", "DownOperationGroupIndex")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_t_substate_down_operation_group");

                    b.HasOne("Common.Database.Models.Ledger.LedgerOperationGroup", "UpOperationGroup")
                        .WithMany()
                        .HasForeignKey("UpStateVersion", "UpOperationGroupIndex")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_t_substate_up_operation_group");

                    b.Navigation("DownOperationGroup");

                    b.Navigation("UpOperationGroup");
                });
#pragma warning restore 612, 618
        }
    }
}
