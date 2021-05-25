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
    /// PossibleInquiryMatches
    /// </summary>
    [DataContract(Name = "PossibleInquiryMatches")]
    public partial class PossibleInquiryMatches : IEquatable<PossibleInquiryMatches>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PossibleInquiryMatches" /> class.
        /// </summary>
        /// <param name="totalLength">The total length of the result set from possible merchant matches of inquiry..</param>
        /// <param name="inquiredMerchant">inquiredMerchant.</param>
        public PossibleInquiryMatches(int totalLength = default(int), List<InquiredMerchant> inquiredMerchant = default(List<InquiredMerchant>))
        {
            this.TotalLength = totalLength;
            this.InquiredMerchant = inquiredMerchant;
        }

        /// <summary>
        /// The total length of the result set from possible merchant matches of inquiry.
        /// </summary>
        /// <value>The total length of the result set from possible merchant matches of inquiry.</value>
        [DataMember(Name = "TotalLength", EmitDefaultValue = false)]
        public int TotalLength { get; set; }

        /// <summary>
        /// Gets or Sets InquiredMerchant
        /// </summary>
        [DataMember(Name = "InquiredMerchant", EmitDefaultValue = false)]
        public List<InquiredMerchant> InquiredMerchant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PossibleInquiryMatches {\n");
            sb.Append("  TotalLength: ").Append(TotalLength).Append("\n");
            sb.Append("  InquiredMerchant: ").Append(InquiredMerchant).Append("\n");
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
            return this.Equals(input as PossibleInquiryMatches);
        }

        /// <summary>
        /// Returns true if PossibleInquiryMatches instances are equal
        /// </summary>
        /// <param name="input">Instance of PossibleInquiryMatches to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PossibleInquiryMatches input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalLength == input.TotalLength ||
                    this.TotalLength.Equals(input.TotalLength)
                ) && 
                (
                    this.InquiredMerchant == input.InquiredMerchant ||
                    this.InquiredMerchant != null &&
                    input.InquiredMerchant != null &&
                    this.InquiredMerchant.SequenceEqual(input.InquiredMerchant)
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
                hashCode = hashCode * 59 + this.TotalLength.GetHashCode();
                if (this.InquiredMerchant != null)
                    hashCode = hashCode * 59 + this.InquiredMerchant.GetHashCode();
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
