/*
 * MATCH API
 *
 * Helps acquirers identify potentially high-risk merchants before entering to a merchant agreement.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: apisupport@mastercard.com
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Acme.App.MastercardApi.Client.Client.OpenAPIDateConverter;

namespace Acme.App.MastercardApi.Client.Model
{
    /// <summary>
    /// TerminatedMerchant
    /// </summary>
    [DataContract(Name = "TerminatedMerchant")]
    public partial class TerminatedMerchant : IEquatable<TerminatedMerchant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminatedMerchant" /> class.
        /// </summary>
        /// <param name="merchant">merchant.</param>
        /// <param name="merchantMatch">merchantMatch.</param>
        public TerminatedMerchant(Merchant merchant = default(Merchant), MerchantMatch merchantMatch = default(MerchantMatch))
        {
            this.Merchant = merchant;
            this.MerchantMatch = merchantMatch;
        }

        /// <summary>
        /// Gets or Sets Merchant
        /// </summary>
        [DataMember(Name = "Merchant", EmitDefaultValue = false)]
        public Merchant Merchant { get; set; }

        /// <summary>
        /// Gets or Sets MerchantMatch
        /// </summary>
        [DataMember(Name = "MerchantMatch", EmitDefaultValue = false)]
        public MerchantMatch MerchantMatch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TerminatedMerchant {\n");
            sb.Append("  Merchant: ").Append(Merchant).Append("\n");
            sb.Append("  MerchantMatch: ").Append(MerchantMatch).Append("\n");
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
            return this.Equals(input as TerminatedMerchant);
        }

        /// <summary>
        /// Returns true if TerminatedMerchant instances are equal
        /// </summary>
        /// <param name="input">Instance of TerminatedMerchant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminatedMerchant input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Merchant == input.Merchant ||
                    (this.Merchant != null &&
                    this.Merchant.Equals(input.Merchant))
                ) && 
                (
                    this.MerchantMatch == input.MerchantMatch ||
                    (this.MerchantMatch != null &&
                    this.MerchantMatch.Equals(input.MerchantMatch))
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
                if (this.Merchant != null)
                    hashCode = hashCode * 59 + this.Merchant.GetHashCode();
                if (this.MerchantMatch != null)
                    hashCode = hashCode * 59 + this.MerchantMatch.GetHashCode();
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

}
