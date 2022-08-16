/*
 * Radix Core API
 *
 * This API provides endpoints from a node for integration with the Radix ledger.  # Overview  > WARNING > > The Core API is __NOT__ intended to be available on the public web. It is > designed to be accessed in a private network.  The Core API is separated into three: * The **Data API** is a read-only api which allows you to view and sync to the state of the ledger. * The **Construction API** allows you to construct and submit a transaction to the network. * The **Key API** allows you to use the keys managed by the node to sign transactions.  The Core API is a low level API primarily designed for network integrations such as exchanges, ledger analytics providers, or hosted ledger data dashboards where detailed ledger data is required and the integrator can be expected to run their node to provide the Core API for their own consumption.  For a higher level API, see the [Gateway API](https://redocly.github.io/redoc/?url=https://raw.githubusercontent.com/radixdlt/radixdlt-network-gateway/main/generation/gateway-api-spec.yaml).  For node monitoring, see the [System API](https://redocly.github.io/redoc/?url=https://raw.githubusercontent.com/radixdlt/radixdlt/main/radixdlt-core/radixdlt/src/main/java/com/radixdlt/api/system/api.yaml).  ## Rosetta  The Data API and Construction API is inspired from [Rosetta API](https://www.rosetta-api.org/) most notably:   * Use of a JSON-Based RPC protocol on top of HTTP Post requests   * Use of Operations, Amounts, and Identifiers as universal language to   express asset movement for reading and writing  There are a few notable exceptions to note:   * Fetching of ledger data is through a Transaction stream rather than a   Block stream   * Use of `EntityIdentifier` rather than `AccountIdentifier`   * Use of `OperationGroup` rather than `related_operations` to express related   operations   * Construction endpoints perform coin selection on behalf of the caller.   This has the unfortunate effect of not being able to support high frequency   transactions from a single account. This will be addressed in future updates.   * Construction endpoints are online rather than offline as required by Rosetta  Future versions of the api will aim towards a fully-compliant Rosetta API.  ## Enabling Endpoints  All endpoints are enabled when running a node with the exception of two endpoints, each of which need to be manually configured to access: * `/transactions` endpoint must be enabled with configuration `api.transaction.enable=true`. This is because the transactions endpoint requires additional database storage which may not be needed for users who aren't using this endpoint * `/key/sign` endpoint must be enable with configuration `api.sign.enable=true`. This is a potentially dangerous endpoint if accessible publicly so it must be enabled manually.  ## Client Code Generation  We have found success with generating clients against the [api.yaml specification](https://raw.githubusercontent.com/radixdlt/radixdlt/main/radixdlt-core/radixdlt/src/main/java/com/radixdlt/api/core/api.yaml). See https://openapi-generator.tech/ for more details.  The OpenAPI generator only supports openapi version 3.0.0 at present, but you can change 3.1.0 to 3.0.0 in the first line of the spec without affecting generation.  # Data API Flow  The Data API can be used to synchronize a full or partial view of the ledger, transaction by transaction.  ![Data API Flow](https://raw.githubusercontent.com/radixdlt/radixdlt/feature/update-documentation/radixdlt-core/radixdlt/src/main/java/com/radixdlt/api/core/documentation/data_sequence_flow.png)  # Construction API Flow  The Construction API can be used to construct and submit transactions to the network.  ![Construction API Flow](https://raw.githubusercontent.com/radixdlt/radixdlt/feature/open-api/radixdlt-core/radixdlt/src/main/java/com/radixdlt/api/core/documentation/construction_sequence_flow.png)  Unlike the Rosetta Construction API [specification](https://www.rosetta-api.org/docs/construction_api_introduction.html), this Construction API selects UTXOs on behalf of the caller. This has the unfortunate side effect of not being able to support high frequency transactions from a single account due to UTXO conflicts. This will be addressed in a future release. 
 *
 * The version of the OpenAPI document: 1.0.0
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using FileParameter = RadixDlt.CoreApiSdk.Client.FileParameter;
using OpenAPIDateConverter = RadixDlt.CoreApiSdk.Client.OpenAPIDateConverter;

namespace RadixDlt.CoreApiSdk.Model
{
    /// <summary>
    /// ResourceWithdrawOperationNotSupportedByEntityError
    /// </summary>
    [DataContract(Name = "ResourceWithdrawOperationNotSupportedByEntityError")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(AboveMaximumValidatorFeeIncreaseError), "AboveMaximumValidatorFeeIncreaseError")]
    [JsonSubtypes.KnownSubType(typeof(BelowMinimumStakeError), "BelowMinimumStakeError")]
    [JsonSubtypes.KnownSubType(typeof(DataObjectNotSupportedByEntityError), "DataObjectNotSupportedByEntityError")]
    [JsonSubtypes.KnownSubType(typeof(FeeConstructionError), "FeeConstructionError")]
    [JsonSubtypes.KnownSubType(typeof(InternalServerError), "InternalServerError")]
    [JsonSubtypes.KnownSubType(typeof(InvalidAddressError), "InvalidAddressError")]
    [JsonSubtypes.KnownSubType(typeof(InvalidDataObjectError), "InvalidDataObjectError")]
    [JsonSubtypes.KnownSubType(typeof(InvalidFeePayerEntityError), "InvalidFeePayerEntityError")]
    [JsonSubtypes.KnownSubType(typeof(InvalidHexError), "InvalidHexError")]
    [JsonSubtypes.KnownSubType(typeof(InvalidJsonError), "InvalidJsonError")]
    [JsonSubtypes.KnownSubType(typeof(InvalidPartialStateIdentifierError), "InvalidPartialStateIdentifierError")]
    [JsonSubtypes.KnownSubType(typeof(InvalidPublicKeyError), "InvalidPublicKeyError")]
    [JsonSubtypes.KnownSubType(typeof(InvalidSignatureError), "InvalidSignatureError")]
    [JsonSubtypes.KnownSubType(typeof(InvalidSubEntityError), "InvalidSubEntityError")]
    [JsonSubtypes.KnownSubType(typeof(InvalidTransactionError), "InvalidTransactionError")]
    [JsonSubtypes.KnownSubType(typeof(InvalidTransactionHashError), "InvalidTransactionHashError")]
    [JsonSubtypes.KnownSubType(typeof(MempoolFullError), "MempoolFullError")]
    [JsonSubtypes.KnownSubType(typeof(MessageTooLongError), "MessageTooLongError")]
    [JsonSubtypes.KnownSubType(typeof(NetworkNotSupportedError), "NetworkNotSupportedError")]
    [JsonSubtypes.KnownSubType(typeof(NotEnoughNativeTokensForFeesError), "NotEnoughNativeTokensForFeesError")]
    [JsonSubtypes.KnownSubType(typeof(NotEnoughResourcesError), "NotEnoughResourcesError")]
    [JsonSubtypes.KnownSubType(typeof(NotValidatorEntityError), "NotValidatorEntityError")]
    [JsonSubtypes.KnownSubType(typeof(NotValidatorOwnerError), "NotValidatorOwnerError")]
    [JsonSubtypes.KnownSubType(typeof(PublicKeyNotSupportedError), "PublicKeyNotSupportedError")]
    [JsonSubtypes.KnownSubType(typeof(ResourceDepositOperationNotSupportedByEntityError), "ResourceDepositOperationNotSupportedByEntityError")]
    [JsonSubtypes.KnownSubType(typeof(ResourceWithdrawOperationNotSupportedByEntityError), "ResourceWithdrawOperationNotSupportedByEntityError")]
    [JsonSubtypes.KnownSubType(typeof(StateIdentifierNotFoundError), "StateIdentifierNotFoundError")]
    [JsonSubtypes.KnownSubType(typeof(SubstateDependencyNotFoundError), "SubstateDependencyNotFoundError")]
    [JsonSubtypes.KnownSubType(typeof(TransactionNotFoundError), "TransactionNotFoundError")]
    public partial class ResourceWithdrawOperationNotSupportedByEntityError : CoreError, IEquatable<ResourceWithdrawOperationNotSupportedByEntityError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceWithdrawOperationNotSupportedByEntityError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceWithdrawOperationNotSupportedByEntityError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceWithdrawOperationNotSupportedByEntityError" /> class.
        /// </summary>
        /// <param name="entityIdentifier">entityIdentifier (required).</param>
        /// <param name="resourceWithdrawNotSupported">resourceWithdrawNotSupported (required).</param>
        /// <param name="type">type (required) (default to &quot;ResourceWithdrawOperationNotSupportedByEntityError&quot;).</param>
        public ResourceWithdrawOperationNotSupportedByEntityError(EntityIdentifier entityIdentifier = default(EntityIdentifier), ResourceIdentifier resourceWithdrawNotSupported = default(ResourceIdentifier), string type = "ResourceWithdrawOperationNotSupportedByEntityError") : base(type)
        {
            // to ensure "entityIdentifier" is required (not null)
            if (entityIdentifier == null)
            {
                throw new ArgumentNullException("entityIdentifier is a required property for ResourceWithdrawOperationNotSupportedByEntityError and cannot be null");
            }
            this.EntityIdentifier = entityIdentifier;
            // to ensure "resourceWithdrawNotSupported" is required (not null)
            if (resourceWithdrawNotSupported == null)
            {
                throw new ArgumentNullException("resourceWithdrawNotSupported is a required property for ResourceWithdrawOperationNotSupportedByEntityError and cannot be null");
            }
            this.ResourceWithdrawNotSupported = resourceWithdrawNotSupported;
        }

        /// <summary>
        /// Gets or Sets EntityIdentifier
        /// </summary>
        [DataMember(Name = "entity_identifier", IsRequired = true, EmitDefaultValue = true)]
        public EntityIdentifier EntityIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets ResourceWithdrawNotSupported
        /// </summary>
        [DataMember(Name = "resource_withdraw_not_supported", IsRequired = true, EmitDefaultValue = true)]
        public ResourceIdentifier ResourceWithdrawNotSupported { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResourceWithdrawOperationNotSupportedByEntityError {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EntityIdentifier: ").Append(EntityIdentifier).Append("\n");
            sb.Append("  ResourceWithdrawNotSupported: ").Append(ResourceWithdrawNotSupported).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ResourceWithdrawOperationNotSupportedByEntityError);
        }

        /// <summary>
        /// Returns true if ResourceWithdrawOperationNotSupportedByEntityError instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceWithdrawOperationNotSupportedByEntityError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceWithdrawOperationNotSupportedByEntityError input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.EntityIdentifier == input.EntityIdentifier ||
                    (this.EntityIdentifier != null &&
                    this.EntityIdentifier.Equals(input.EntityIdentifier))
                ) && base.Equals(input) && 
                (
                    this.ResourceWithdrawNotSupported == input.ResourceWithdrawNotSupported ||
                    (this.ResourceWithdrawNotSupported != null &&
                    this.ResourceWithdrawNotSupported.Equals(input.ResourceWithdrawNotSupported))
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
                int hashCode = base.GetHashCode();
                if (this.EntityIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.EntityIdentifier.GetHashCode();
                }
                if (this.ResourceWithdrawNotSupported != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceWithdrawNotSupported.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
