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
 * Babylon Core API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.0
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
using System.Reflection;

namespace RadixDlt.CoreApiSdk.Model
{
    /// <summary>
    /// DynamicAuthorization
    /// </summary>
    [JsonConverter(typeof(DynamicAuthorizationJsonConverter))]
    [DataContract(Name = "DynamicAuthorization")]
    public partial class DynamicAuthorization : AbstractOpenAPISchema, IEquatable<DynamicAuthorization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicAuthorization" /> class
        /// with the <see cref="ProtectedDynamicAuthorization" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ProtectedDynamicAuthorization.</param>
        public DynamicAuthorization(ProtectedDynamicAuthorization actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicAuthorization" /> class
        /// with the <see cref="AllowAllDynamicAuthorization" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AllowAllDynamicAuthorization.</param>
        public DynamicAuthorization(AllowAllDynamicAuthorization actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicAuthorization" /> class
        /// with the <see cref="DenyAllDynamicAuthorization" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DenyAllDynamicAuthorization.</param>
        public DynamicAuthorization(DenyAllDynamicAuthorization actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(AllowAllDynamicAuthorization))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DenyAllDynamicAuthorization))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ProtectedDynamicAuthorization))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AllowAllDynamicAuthorization, DenyAllDynamicAuthorization, ProtectedDynamicAuthorization");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ProtectedDynamicAuthorization`. If the actual instance is not `ProtectedDynamicAuthorization`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ProtectedDynamicAuthorization</returns>
        public ProtectedDynamicAuthorization GetProtectedDynamicAuthorization()
        {
            return (ProtectedDynamicAuthorization)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AllowAllDynamicAuthorization`. If the actual instance is not `AllowAllDynamicAuthorization`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AllowAllDynamicAuthorization</returns>
        public AllowAllDynamicAuthorization GetAllowAllDynamicAuthorization()
        {
            return (AllowAllDynamicAuthorization)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DenyAllDynamicAuthorization`. If the actual instance is not `DenyAllDynamicAuthorization`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DenyAllDynamicAuthorization</returns>
        public DenyAllDynamicAuthorization GetDenyAllDynamicAuthorization()
        {
            return (DenyAllDynamicAuthorization)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicAuthorization {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, DynamicAuthorization.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of DynamicAuthorization
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of DynamicAuthorization</returns>
        public static DynamicAuthorization FromJson(string jsonString)
        {
            DynamicAuthorization newDynamicAuthorization = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newDynamicAuthorization;
            }

            try
            {
                newDynamicAuthorization = new DynamicAuthorization(JsonConvert.DeserializeObject<AllowAllDynamicAuthorization>(jsonString, DynamicAuthorization.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newDynamicAuthorization;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AllowAllDynamicAuthorization: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newDynamicAuthorization = new DynamicAuthorization(JsonConvert.DeserializeObject<DenyAllDynamicAuthorization>(jsonString, DynamicAuthorization.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newDynamicAuthorization;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DenyAllDynamicAuthorization: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newDynamicAuthorization = new DynamicAuthorization(JsonConvert.DeserializeObject<ProtectedDynamicAuthorization>(jsonString, DynamicAuthorization.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newDynamicAuthorization;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ProtectedDynamicAuthorization: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DynamicAuthorization);
        }

        /// <summary>
        /// Returns true if DynamicAuthorization instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicAuthorization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicAuthorization input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for DynamicAuthorization
    /// </summary>
    public class DynamicAuthorizationJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(DynamicAuthorization).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return DynamicAuthorization.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}