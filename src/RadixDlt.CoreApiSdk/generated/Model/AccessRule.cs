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
 * This API is exposed by the Babylon Radix node to give clients access to the Radix Engine, Mempool and State in the node. It is intended for use by node-runners on a private network, and is not intended to be exposed publicly. Heavy load may impact the node's function.  If you require queries against historical ledger state, you may also wish to consider using the [Gateway API](https://betanet-gateway.redoc.ly/). 
 *
 * The version of the OpenAPI document: 0.2.0
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
using FileParameter = RadixDlt.CoreApiSdk.Client.FileParameter;
using OpenAPIDateConverter = RadixDlt.CoreApiSdk.Client.OpenAPIDateConverter;
using System.Reflection;

namespace RadixDlt.CoreApiSdk.Model
{
    /// <summary>
    /// AccessRule
    /// </summary>
    [JsonConverter(typeof(AccessRuleJsonConverter))]
    [DataContract(Name = "AccessRule")]
    public partial class AccessRule : AbstractOpenAPISchema, IEquatable<AccessRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRule" /> class
        /// with the <see cref="ProtectedAccessRule" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ProtectedAccessRule.</param>
        public AccessRule(ProtectedAccessRule actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRule" /> class
        /// with the <see cref="AllowAllAccessRule" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AllowAllAccessRule.</param>
        public AccessRule(AllowAllAccessRule actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRule" /> class
        /// with the <see cref="DenyAllAccessRule" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DenyAllAccessRule.</param>
        public AccessRule(DenyAllAccessRule actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
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
                if (value.GetType() == typeof(AllowAllAccessRule))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DenyAllAccessRule))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ProtectedAccessRule))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AllowAllAccessRule, DenyAllAccessRule, ProtectedAccessRule");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ProtectedAccessRule`. If the actual instance is not `ProtectedAccessRule`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ProtectedAccessRule</returns>
        public ProtectedAccessRule GetProtectedAccessRule()
        {
            return (ProtectedAccessRule)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AllowAllAccessRule`. If the actual instance is not `AllowAllAccessRule`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AllowAllAccessRule</returns>
        public AllowAllAccessRule GetAllowAllAccessRule()
        {
            return (AllowAllAccessRule)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DenyAllAccessRule`. If the actual instance is not `DenyAllAccessRule`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DenyAllAccessRule</returns>
        public DenyAllAccessRule GetDenyAllAccessRule()
        {
            return (DenyAllAccessRule)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessRule {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AccessRule.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AccessRule
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AccessRule</returns>
        public static AccessRule FromJson(string jsonString)
        {
            AccessRule newAccessRule = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAccessRule;
            }

            try
            {
                var discriminatorObj = JObject.Parse(jsonString)["type"];
                string discriminatorValue =  discriminatorObj == null ?string.Empty :discriminatorObj.ToString();
                switch (discriminatorValue)
                {
                    case "AllowAll":
                        newAccessRule = new AccessRule(JsonConvert.DeserializeObject<AllowAllAccessRule>(jsonString, AccessRule.AdditionalPropertiesSerializerSettings));
                        return newAccessRule;
                    case "AllowAllAccessRule":
                        newAccessRule = new AccessRule(JsonConvert.DeserializeObject<AllowAllAccessRule>(jsonString, AccessRule.AdditionalPropertiesSerializerSettings));
                        return newAccessRule;
                    case "DenyAll":
                        newAccessRule = new AccessRule(JsonConvert.DeserializeObject<DenyAllAccessRule>(jsonString, AccessRule.AdditionalPropertiesSerializerSettings));
                        return newAccessRule;
                    case "DenyAllAccessRule":
                        newAccessRule = new AccessRule(JsonConvert.DeserializeObject<DenyAllAccessRule>(jsonString, AccessRule.AdditionalPropertiesSerializerSettings));
                        return newAccessRule;
                    case "Protected":
                        newAccessRule = new AccessRule(JsonConvert.DeserializeObject<ProtectedAccessRule>(jsonString, AccessRule.AdditionalPropertiesSerializerSettings));
                        return newAccessRule;
                    case "ProtectedAccessRule":
                        newAccessRule = new AccessRule(JsonConvert.DeserializeObject<ProtectedAccessRule>(jsonString, AccessRule.AdditionalPropertiesSerializerSettings));
                        return newAccessRule;
                    default:
                        System.Diagnostics.Debug.WriteLine(string.Format("Failed to lookup discriminator value `{0}` for AccessRule. Possible values: AllowAll AllowAllAccessRule DenyAll DenyAllAccessRule Protected ProtectedAccessRule", discriminatorValue));
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to parse the json data : `{0}` {1}", jsonString, ex.ToString()));
            }

            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AllowAllAccessRule).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRule = new AccessRule(JsonConvert.DeserializeObject<AllowAllAccessRule>(jsonString, AccessRule.SerializerSettings));
                }
                else
                {
                    newAccessRule = new AccessRule(JsonConvert.DeserializeObject<AllowAllAccessRule>(jsonString, AccessRule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AllowAllAccessRule");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AllowAllAccessRule: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DenyAllAccessRule).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRule = new AccessRule(JsonConvert.DeserializeObject<DenyAllAccessRule>(jsonString, AccessRule.SerializerSettings));
                }
                else
                {
                    newAccessRule = new AccessRule(JsonConvert.DeserializeObject<DenyAllAccessRule>(jsonString, AccessRule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DenyAllAccessRule");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DenyAllAccessRule: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ProtectedAccessRule).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRule = new AccessRule(JsonConvert.DeserializeObject<ProtectedAccessRule>(jsonString, AccessRule.SerializerSettings));
                }
                else
                {
                    newAccessRule = new AccessRule(JsonConvert.DeserializeObject<ProtectedAccessRule>(jsonString, AccessRule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ProtectedAccessRule");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ProtectedAccessRule: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newAccessRule;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessRule);
        }

        /// <summary>
        /// Returns true if AccessRule instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessRule input)
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

    }

    /// <summary>
    /// Custom JSON converter for AccessRule
    /// </summary>
    public class AccessRuleJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AccessRule).GetMethod("ToJson").Invoke(value, null)));
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
                return AccessRule.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
