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
    /// ContactRequest
    /// </summary>
    [DataContract(Name = "ContactRequest")]
    public partial class ContactRequest : IEquatable<ContactRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactRequest" /> class.
        /// </summary>
        /// <param name="acquirerId">The acquiring bank ICA number whose contact information is to be fetched. (required).</param>
        public ContactRequest(string acquirerId = default(string))
        {
            // to ensure "acquirerId" is required (not null)
            this.AcquirerId = acquirerId ?? throw new ArgumentNullException("acquirerId is a required property for ContactRequest and cannot be null");
        }

        /// <summary>
        /// The acquiring bank ICA number whose contact information is to be fetched.
        /// </summary>
        /// <value>The acquiring bank ICA number whose contact information is to be fetched.</value>
        [DataMember(Name = "AcquirerId", IsRequired = true, EmitDefaultValue = false)]
        public string AcquirerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactRequest {\n");
            sb.Append("  AcquirerId: ").Append(AcquirerId).Append("\n");
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
            return this.Equals(input as ContactRequest);
        }

        /// <summary>
        /// Returns true if ContactRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcquirerId == input.AcquirerId ||
                    (this.AcquirerId != null &&
                    this.AcquirerId.Equals(input.AcquirerId))
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
                if (this.AcquirerId != null)
                    hashCode = hashCode * 59 + this.AcquirerId.GetHashCode();
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
