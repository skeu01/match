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
    /// TerminationInquiryRequestSchema
    /// </summary>
    [DataContract(Name = "TerminationInquiryRequestSchema")]
    public partial class TerminationInquiryRequestSchema : IEquatable<TerminationInquiryRequestSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminationInquiryRequestSchema" /> class.
        /// </summary>
        /// <param name="terminationInquiryRequest">terminationInquiryRequest.</param>
        public TerminationInquiryRequestSchema(TerminationInquiryRequest terminationInquiryRequest = default(TerminationInquiryRequest))
        {
            this.TerminationInquiryRequest = terminationInquiryRequest;
        }

        /// <summary>
        /// Gets or Sets TerminationInquiryRequest
        /// </summary>
        [DataMember(Name = "TerminationInquiryRequest", EmitDefaultValue = false)]
        public TerminationInquiryRequest TerminationInquiryRequest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TerminationInquiryRequestSchema {\n");
            sb.Append("  TerminationInquiryRequest: ").Append(TerminationInquiryRequest).Append("\n");
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
            return this.Equals(input as TerminationInquiryRequestSchema);
        }

        /// <summary>
        /// Returns true if TerminationInquiryRequestSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of TerminationInquiryRequestSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminationInquiryRequestSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TerminationInquiryRequest == input.TerminationInquiryRequest ||
                    (this.TerminationInquiryRequest != null &&
                    this.TerminationInquiryRequest.Equals(input.TerminationInquiryRequest))
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
                if (this.TerminationInquiryRequest != null)
                    hashCode = hashCode * 59 + this.TerminationInquiryRequest.GetHashCode();
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
