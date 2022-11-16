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

﻿using System;
using System.Numerics;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RadixDlt.NetworkGateway.PostgresIntegration.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "entities",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fromstateversion = table.Column<long>(name: "from_state_version", type: "bigint", nullable: false),
                    address = table.Column<byte[]>(type: "bytea", nullable: false),
                    globaladdress = table.Column<byte[]>(name: "global_address", type: "bytea", nullable: true),
                    ancestorids = table.Column<long[]>(name: "ancestor_ids", type: "bigint[]", nullable: true),
                    parentancestorid = table.Column<long>(name: "parent_ancestor_id", type: "bigint", nullable: true),
                    ownerancestorid = table.Column<long>(name: "owner_ancestor_id", type: "bigint", nullable: true),
                    globalancestorid = table.Column<long>(name: "global_ancestor_id", type: "bigint", nullable: true),
                    discriminator = table.Column<string>(type: "text", nullable: false),
                    packageid = table.Column<long>(name: "package_id", type: "bigint", nullable: true),
                    divisibility = table.Column<long>(type: "bigint", nullable: true),
                    code = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entities", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "entity_metadata_history",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fromstateversion = table.Column<long>(name: "from_state_version", type: "bigint", nullable: false),
                    entityid = table.Column<long>(name: "entity_id", type: "bigint", nullable: false),
                    keys = table.Column<string[]>(type: "text[]", nullable: false),
                    values = table.Column<string[]>(type: "text[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entity_metadata_history", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "entity_resource_aggregate_history",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fromstateversion = table.Column<long>(name: "from_state_version", type: "bigint", nullable: false),
                    entityid = table.Column<long>(name: "entity_id", type: "bigint", nullable: false),
                    ismostrecent = table.Column<bool>(name: "is_most_recent", type: "boolean", nullable: false),
                    fungibleresourceids = table.Column<long[]>(name: "fungible_resource_ids", type: "bigint[]", nullable: false),
                    nonfungibleresourceids = table.Column<long[]>(name: "non_fungible_resource_ids", type: "bigint[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entity_resource_aggregate_history", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "entity_resource_history",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fromstateversion = table.Column<long>(name: "from_state_version", type: "bigint", nullable: false),
                    ownerentityid = table.Column<long>(name: "owner_entity_id", type: "bigint", nullable: false),
                    globalentityid = table.Column<long>(name: "global_entity_id", type: "bigint", nullable: false),
                    resourceentityid = table.Column<long>(name: "resource_entity_id", type: "bigint", nullable: false),
                    discriminator = table.Column<string>(type: "text", nullable: false),
                    balance = table.Column<BigInteger>(type: "numeric(1000,0)", precision: 1000, scale: 0, nullable: true),
                    idscount = table.Column<long>(name: "ids_count", type: "bigint", nullable: true),
                    ids = table.Column<byte[][]>(type: "bytea[]", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entity_resource_history", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fungible_resource_supply_history",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fromstateversion = table.Column<long>(name: "from_state_version", type: "bigint", nullable: false),
                    resourceentityid = table.Column<long>(name: "resource_entity_id", type: "bigint", nullable: false),
                    totalsupply = table.Column<BigInteger>(name: "total_supply", type: "numeric(1000,0)", precision: 1000, scale: 0, nullable: false),
                    totalminted = table.Column<BigInteger>(name: "total_minted", type: "numeric(1000,0)", precision: 1000, scale: 0, nullable: false),
                    totalburnt = table.Column<BigInteger>(name: "total_burnt", type: "numeric(1000,0)", precision: 1000, scale: 0, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fungible_resource_supply_history", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ledger_transactions",
                columns: table => new
                {
                    stateversion = table.Column<long>(name: "state_version", type: "bigint", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    transactionaccumulator = table.Column<byte[]>(name: "transaction_accumulator", type: "bytea", nullable: false),
                    message = table.Column<byte[]>(type: "bytea", nullable: true),
                    epoch = table.Column<long>(type: "bigint", nullable: false),
                    indexinepoch = table.Column<long>(name: "index_in_epoch", type: "bigint", nullable: false),
                    roundinepoch = table.Column<long>(name: "round_in_epoch", type: "bigint", nullable: false),
                    isstartofepoch = table.Column<bool>(name: "is_start_of_epoch", type: "boolean", nullable: false),
                    isstartofround = table.Column<bool>(name: "is_start_of_round", type: "boolean", nullable: false),
                    referencedentities = table.Column<long[]>(name: "referenced_entities", type: "bigint[]", nullable: false),
                    feepaid = table.Column<BigInteger>(name: "fee_paid", type: "numeric(1000,0)", precision: 1000, scale: 0, nullable: false),
                    tippaid = table.Column<BigInteger>(name: "tip_paid", type: "numeric(1000,0)", precision: 1000, scale: 0, nullable: false),
                    roundtimestamp = table.Column<DateTimeOffset>(name: "round_timestamp", type: "timestamp with time zone", nullable: false),
                    createdtimestamp = table.Column<DateTimeOffset>(name: "created_timestamp", type: "timestamp with time zone", nullable: false),
                    normalizedroundtimestamp = table.Column<DateTimeOffset>(name: "normalized_round_timestamp", type: "timestamp with time zone", nullable: false),
                    discriminator = table.Column<string>(type: "text", nullable: false),
                    payloadhash = table.Column<byte[]>(name: "payload_hash", type: "bytea", nullable: true),
                    intenthash = table.Column<byte[]>(name: "intent_hash", type: "bytea", nullable: true),
                    signedintenthash = table.Column<byte[]>(name: "signed_intent_hash", type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ledger_transactions", x => x.stateversion);
                });

            migrationBuilder.CreateTable(
                name: "network_configuration",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    networkname = table.Column<string>(name: "network_name", type: "text", nullable: false),
                    packagehrp = table.Column<string>(name: "package_hrp", type: "text", nullable: false),
                    normalcomponenthrp = table.Column<string>(name: "normal_component_hrp", type: "text", nullable: false),
                    accountcomponenthrp = table.Column<string>(name: "account_component_hrp", type: "text", nullable: false),
                    systemcomponenthrp = table.Column<string>(name: "system_component_hrp", type: "text", nullable: false),
                    resourcehrp = table.Column<string>(name: "resource_hrp", type: "text", nullable: false),
                    validatorhrp = table.Column<string>(name: "validator_hrp", type: "text", nullable: false),
                    nodehrp = table.Column<string>(name: "node_hrp", type: "text", nullable: false),
                    accountpackageaddress = table.Column<string>(name: "account_package_address", type: "text", nullable: false),
                    xrdaddress = table.Column<string>(name: "xrd_address", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_network_configuration", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "non_fungible_id_history",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fromstateversion = table.Column<long>(name: "from_state_version", type: "bigint", nullable: false),
                    nonfungiblestoreentityid = table.Column<long>(name: "non_fungible_store_entity_id", type: "bigint", nullable: false),
                    nonfungibleresourcemanagerentityid = table.Column<long>(name: "non_fungible_resource_manager_entity_id", type: "bigint", nullable: false),
                    nonfungibleid = table.Column<byte[]>(name: "non_fungible_id", type: "bytea", nullable: false),
                    immutabledata = table.Column<byte[]>(name: "immutable_data", type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_non_fungible_id_history", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "non_fungible_id_mutable_data_history",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fromstateversion = table.Column<long>(name: "from_state_version", type: "bigint", nullable: false),
                    nonfungibleidhistoryid = table.Column<long>(name: "non_fungible_id_history_id", type: "bigint", nullable: false),
                    isdeleted = table.Column<bool>(name: "is_deleted", type: "boolean", nullable: false),
                    mutabledata = table.Column<byte[]>(name: "mutable_data", type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_non_fungible_id_mutable_data_history", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pending_transactions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    payloadhash = table.Column<byte[]>(name: "payload_hash", type: "bytea", nullable: false),
                    intenthash = table.Column<byte[]>(name: "intent_hash", type: "bytea", nullable: false),
                    signedintenthash = table.Column<byte[]>(name: "signed_intent_hash", type: "bytea", nullable: false),
                    notarizedtransactionblob = table.Column<byte[]>(name: "notarized_transaction_blob", type: "bytea", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    submittedbythisgateway = table.Column<bool>(name: "submitted_by_this_gateway", type: "boolean", nullable: false),
                    firstsubmittedtogatewaytimestamp = table.Column<DateTimeOffset>(name: "first_submitted_to_gateway_timestamp", type: "timestamp with time zone", nullable: true),
                    lastsubmittedtogatewaytimestamp = table.Column<DateTimeOffset>(name: "last_submitted_to_gateway_timestamp", type: "timestamp with time zone", nullable: true),
                    lastsubmittedtonodetimestamp = table.Column<DateTimeOffset>(name: "last_submitted_to_node_timestamp", type: "timestamp with time zone", nullable: true),
                    lastsubmittedtonodename = table.Column<string>(name: "last_submitted_to_node_name", type: "text", nullable: true),
                    submissioncount = table.Column<int>(name: "submission_count", type: "integer", nullable: false),
                    firstseeninmempooltimestamp = table.Column<DateTimeOffset>(name: "first_seen_in_mempool_timestamp", type: "timestamp with time zone", nullable: true),
                    lastmissingfrommempooltimestamp = table.Column<DateTimeOffset>(name: "last_missing_from_mempool_timestamp", type: "timestamp with time zone", nullable: true),
                    committimestamp = table.Column<DateTimeOffset>(name: "commit_timestamp", type: "timestamp with time zone", nullable: true),
                    failurereason = table.Column<string>(name: "failure_reason", type: "text", nullable: true),
                    failureexplanation = table.Column<string>(name: "failure_explanation", type: "text", nullable: true),
                    failuretimestamp = table.Column<DateTimeOffset>(name: "failure_timestamp", type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pending_transactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "raw_transactions",
                columns: table => new
                {
                    stateversion = table.Column<long>(name: "state_version", type: "bigint", nullable: false),
                    payloadhash = table.Column<byte[]>(name: "payload_hash", type: "bytea", nullable: false),
                    payload = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_raw_transactions", x => x.stateversion);
                });

            migrationBuilder.CreateTable(
                name: "ledger_status",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    topofledgerstateversion = table.Column<long>(name: "top_of_ledger_state_version", type: "bigint", nullable: false),
                    syncstatustargetstateversion = table.Column<long>(name: "sync_status_target_state_version", type: "bigint", nullable: false),
                    lastupdated = table.Column<DateTimeOffset>(name: "last_updated", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ledger_status", x => x.id);
                    table.ForeignKey(
                        name: "FK_ledger_status_ledger_transactions_top_of_ledger_state_versi~",
                        column: x => x.topofledgerstateversion,
                        principalTable: "ledger_transactions",
                        principalColumn: "state_version");
                });

            migrationBuilder.CreateIndex(
                name: "IX_entities_address",
                table: "entities",
                column: "address")
                .Annotation("Npgsql:IndexMethod", "hash");

            migrationBuilder.CreateIndex(
                name: "IX_entities_global_address",
                table: "entities",
                column: "global_address",
                filter: "global_address IS NOT NULL")
                .Annotation("Npgsql:IndexMethod", "hash");

            migrationBuilder.CreateIndex(
                name: "IX_entity_metadata_history_entity_id_from_state_version",
                table: "entity_metadata_history",
                columns: new[] { "entity_id", "from_state_version" });

            migrationBuilder.CreateIndex(
                name: "IX_entity_resource_aggregate_history_entity_id_from_state_vers~",
                table: "entity_resource_aggregate_history",
                columns: new[] { "entity_id", "from_state_version" });

            migrationBuilder.CreateIndex(
                name: "IX_entity_resource_aggregate_history_is_most_recent_entity_id",
                table: "entity_resource_aggregate_history",
                columns: new[] { "is_most_recent", "entity_id" },
                filter: "is_most_recent IS TRUE");

            migrationBuilder.CreateIndex(
                name: "IX_entity_resource_history_global_entity_id_from_state_version",
                table: "entity_resource_history",
                columns: new[] { "global_entity_id", "from_state_version" });

            migrationBuilder.CreateIndex(
                name: "IX_entity_resource_history_owner_entity_id_from_state_version",
                table: "entity_resource_history",
                columns: new[] { "owner_entity_id", "from_state_version" });

            migrationBuilder.CreateIndex(
                name: "IX_fungible_resource_supply_history_resource_entity_id_from_st~",
                table: "fungible_resource_supply_history",
                columns: new[] { "resource_entity_id", "from_state_version" });

            migrationBuilder.CreateIndex(
                name: "IX_ledger_status_top_of_ledger_state_version",
                table: "ledger_status",
                column: "top_of_ledger_state_version");

            migrationBuilder.CreateIndex(
                name: "IX_ledger_transactions_epoch",
                table: "ledger_transactions",
                column: "epoch",
                unique: true,
                filter: "is_start_of_epoch = true");

            migrationBuilder.CreateIndex(
                name: "IX_ledger_transactions_epoch_round_in_epoch",
                table: "ledger_transactions",
                columns: new[] { "epoch", "round_in_epoch" },
                unique: true,
                filter: "is_start_of_round = true");

            migrationBuilder.CreateIndex(
                name: "IX_ledger_transactions_intent_hash",
                table: "ledger_transactions",
                column: "intent_hash",
                filter: "intent_hash IS NOT NULL")
                .Annotation("Npgsql:IndexMethod", "hash");

            migrationBuilder.CreateIndex(
                name: "IX_ledger_transactions_payload_hash",
                table: "ledger_transactions",
                column: "payload_hash",
                filter: "payload_hash IS NOT NULL")
                .Annotation("Npgsql:IndexMethod", "hash");

            migrationBuilder.CreateIndex(
                name: "IX_ledger_transactions_round_timestamp",
                table: "ledger_transactions",
                column: "round_timestamp");

            migrationBuilder.CreateIndex(
                name: "IX_ledger_transactions_signed_intent_hash",
                table: "ledger_transactions",
                column: "signed_intent_hash",
                filter: "signed_intent_hash IS NOT NULL")
                .Annotation("Npgsql:IndexMethod", "hash");

            migrationBuilder.CreateIndex(
                name: "IX_non_fungible_id_history_non_fungible_resource_manager_enti~1",
                table: "non_fungible_id_history",
                columns: new[] { "non_fungible_resource_manager_entity_id", "non_fungible_id" });

            migrationBuilder.CreateIndex(
                name: "IX_non_fungible_id_history_non_fungible_resource_manager_entit~",
                table: "non_fungible_id_history",
                columns: new[] { "non_fungible_resource_manager_entity_id", "from_state_version" });

            migrationBuilder.CreateIndex(
                name: "IX_non_fungible_id_mutable_data_history_non_fungible_id_histor~",
                table: "non_fungible_id_mutable_data_history",
                columns: new[] { "non_fungible_id_history_id", "from_state_version" });

            migrationBuilder.CreateIndex(
                name: "IX_pending_transactions_payload_hash",
                table: "pending_transactions",
                column: "payload_hash")
                .Annotation("Npgsql:IndexMethod", "hash");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "entities");

            migrationBuilder.DropTable(
                name: "entity_metadata_history");

            migrationBuilder.DropTable(
                name: "entity_resource_aggregate_history");

            migrationBuilder.DropTable(
                name: "entity_resource_history");

            migrationBuilder.DropTable(
                name: "fungible_resource_supply_history");

            migrationBuilder.DropTable(
                name: "ledger_status");

            migrationBuilder.DropTable(
                name: "network_configuration");

            migrationBuilder.DropTable(
                name: "non_fungible_id_history");

            migrationBuilder.DropTable(
                name: "non_fungible_id_mutable_data_history");

            migrationBuilder.DropTable(
                name: "pending_transactions");

            migrationBuilder.DropTable(
                name: "raw_transactions");

            migrationBuilder.DropTable(
                name: "ledger_transactions");
        }
    }
}