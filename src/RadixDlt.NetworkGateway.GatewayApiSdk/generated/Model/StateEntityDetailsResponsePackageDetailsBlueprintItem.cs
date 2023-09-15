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

/*
 * Babylon Gateway API - RCnet V3
 *
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers. For simple use cases, you can typically use the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs-babylon.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Migration guide  Please see [the latest release notes](https://github.com/radixdlt/babylon-gateway/releases).  ## Integration and forward compatibility guarantees  We give no guarantees that other endpoints will not change before Babylon mainnet launch, although changes are expected to be minimal. 
 *
 * The version of the OpenAPI document: 0.5.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using FileParameter = RadixDlt.NetworkGateway.GatewayApiSdk.Client.FileParameter;
using OpenAPIDateConverter = RadixDlt.NetworkGateway.GatewayApiSdk.Client.OpenAPIDateConverter;

namespace RadixDlt.NetworkGateway.GatewayApiSdk.Model
{
    /// <summary>
    /// StateEntityDetailsResponsePackageDetailsBlueprintItem
    /// </summary>
    [DataContract(Name = "StateEntityDetailsResponsePackageDetailsBlueprintItem")]
    public partial class StateEntityDetailsResponsePackageDetailsBlueprintItem : IEquatable<StateEntityDetailsResponsePackageDetailsBlueprintItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateEntityDetailsResponsePackageDetailsBlueprintItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StateEntityDetailsResponsePackageDetailsBlueprintItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StateEntityDetailsResponsePackageDetailsBlueprintItem" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="definition">definition (required).</param>
        /// <param name="dependantEntities">dependantEntities.</param>
        /// <param name="authTemplate">authTemplate.</param>
        /// <param name="authTemplateIsLocked">authTemplateIsLocked.</param>
        /// <param name="royaltyConfig">royaltyConfig.</param>
        /// <param name="royaltyConfigIsLocked">royaltyConfigIsLocked.</param>
        public StateEntityDetailsResponsePackageDetailsBlueprintItem(string name = default(string), string version = default(string), Object definition = default(Object), List<string> dependantEntities = default(List<string>), Object authTemplate = default(Object), bool? authTemplateIsLocked = default(bool?), Object royaltyConfig = default(Object), bool? royaltyConfigIsLocked = default(bool?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for StateEntityDetailsResponsePackageDetailsBlueprintItem and cannot be null");
            }
            this.Name = name;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new ArgumentNullException("version is a required property for StateEntityDetailsResponsePackageDetailsBlueprintItem and cannot be null");
            }
            this._Version = version;
            // to ensure "definition" is required (not null)
            if (definition == null)
            {
                throw new ArgumentNullException("definition is a required property for StateEntityDetailsResponsePackageDetailsBlueprintItem and cannot be null");
            }
            this.Definition = definition;
            this.DependantEntities = dependantEntities;
            this.AuthTemplate = authTemplate;
            this.AuthTemplateIsLocked = authTemplateIsLocked;
            this.RoyaltyConfig = royaltyConfig;
            this.RoyaltyConfigIsLocked = royaltyConfigIsLocked;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string _Version { get; set; }

        /// <summary>
        /// Gets or Sets Definition
        /// </summary>
        [DataMember(Name = "definition", IsRequired = true, EmitDefaultValue = true)]
        public Object Definition { get; set; }

        /// <summary>
        /// Gets or Sets DependantEntities
        /// </summary>
        [DataMember(Name = "dependant_entities", EmitDefaultValue = true)]
        public List<string> DependantEntities { get; set; }

        /// <summary>
        /// Gets or Sets AuthTemplate
        /// </summary>
        [DataMember(Name = "auth_template", EmitDefaultValue = true)]
        public Object AuthTemplate { get; set; }

        /// <summary>
        /// Gets or Sets AuthTemplateIsLocked
        /// </summary>
        [DataMember(Name = "auth_template_is_locked", EmitDefaultValue = true)]
        public bool? AuthTemplateIsLocked { get; set; }

        /// <summary>
        /// Gets or Sets RoyaltyConfig
        /// </summary>
        [DataMember(Name = "royalty_config", EmitDefaultValue = true)]
        public Object RoyaltyConfig { get; set; }

        /// <summary>
        /// Gets or Sets RoyaltyConfigIsLocked
        /// </summary>
        [DataMember(Name = "royalty_config_is_locked", EmitDefaultValue = true)]
        public bool? RoyaltyConfigIsLocked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StateEntityDetailsResponsePackageDetailsBlueprintItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
            sb.Append("  DependantEntities: ").Append(DependantEntities).Append("\n");
            sb.Append("  AuthTemplate: ").Append(AuthTemplate).Append("\n");
            sb.Append("  AuthTemplateIsLocked: ").Append(AuthTemplateIsLocked).Append("\n");
            sb.Append("  RoyaltyConfig: ").Append(RoyaltyConfig).Append("\n");
            sb.Append("  RoyaltyConfigIsLocked: ").Append(RoyaltyConfigIsLocked).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StateEntityDetailsResponsePackageDetailsBlueprintItem);
        }

        /// <summary>
        /// Returns true if StateEntityDetailsResponsePackageDetailsBlueprintItem instances are equal
        /// </summary>
        /// <param name="input">Instance of StateEntityDetailsResponsePackageDetailsBlueprintItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateEntityDetailsResponsePackageDetailsBlueprintItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Definition == input.Definition ||
                    (this.Definition != null &&
                    this.Definition.Equals(input.Definition))
                ) && 
                (
                    this.DependantEntities == input.DependantEntities ||
                    this.DependantEntities != null &&
                    input.DependantEntities != null &&
                    this.DependantEntities.SequenceEqual(input.DependantEntities)
                ) && 
                (
                    this.AuthTemplate == input.AuthTemplate ||
                    (this.AuthTemplate != null &&
                    this.AuthTemplate.Equals(input.AuthTemplate))
                ) && 
                (
                    this.AuthTemplateIsLocked == input.AuthTemplateIsLocked ||
                    (this.AuthTemplateIsLocked != null &&
                    this.AuthTemplateIsLocked.Equals(input.AuthTemplateIsLocked))
                ) && 
                (
                    this.RoyaltyConfig == input.RoyaltyConfig ||
                    (this.RoyaltyConfig != null &&
                    this.RoyaltyConfig.Equals(input.RoyaltyConfig))
                ) && 
                (
                    this.RoyaltyConfigIsLocked == input.RoyaltyConfigIsLocked ||
                    (this.RoyaltyConfigIsLocked != null &&
                    this.RoyaltyConfigIsLocked.Equals(input.RoyaltyConfigIsLocked))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.Definition != null)
                {
                    hashCode = (hashCode * 59) + this.Definition.GetHashCode();
                }
                if (this.DependantEntities != null)
                {
                    hashCode = (hashCode * 59) + this.DependantEntities.GetHashCode();
                }
                if (this.AuthTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.AuthTemplate.GetHashCode();
                }
                if (this.AuthTemplateIsLocked != null)
                {
                    hashCode = (hashCode * 59) + this.AuthTemplateIsLocked.GetHashCode();
                }
                if (this.RoyaltyConfig != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyConfig.GetHashCode();
                }
                if (this.RoyaltyConfigIsLocked != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyConfigIsLocked.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}