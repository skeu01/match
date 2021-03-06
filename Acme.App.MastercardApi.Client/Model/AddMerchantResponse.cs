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
    /// AddMerchantResponse
    /// </summary>
    [DataContract(Name = "AddMerchantResponse")]
    public partial class AddMerchantResponse : IEquatable<AddMerchantResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddMerchantResponse" /> class.
        /// </summary>
        /// <param name="merchantReferenceNumber">A number assigned by the MATCH system to uniquely identify the newly added merchant. Return of this number indicates a successful add..</param>
        /// <param name="name">Name of the merchant that was added to the MATCH system as verification of what was added..</param>
        public AddMerchantResponse(string merchantReferenceNumber = default(string), string name = default(string))
        {
            this.MerchantReferenceNumber = merchantReferenceNumber;
            this.Name = name;
        }

        /// <summary>
        /// A number assigned by the MATCH system to uniquely identify the newly added merchant. Return of this number indicates a successful add.
        /// </summary>
        /// <value>A number assigned by the MATCH system to uniquely identify the newly added merchant. Return of this number indicates a successful add.</value>
        [DataMember(Name = "MerchantReferenceNumber", EmitDefaultValue = false)]
        public string MerchantReferenceNumber { get; set; }

        /// <summary>
        /// Name of the merchant that was added to the MATCH system as verification of what was added.
        /// </summary>
        /// <value>Name of the merchant that was added to the MATCH system as verification of what was added.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddMerchantResponse {\n");
            sb.Append("  MerchantReferenceNumber: ").Append(MerchantReferenceNumber).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as AddMerchantResponse);
        }

        /// <summary>
        /// Returns true if AddMerchantResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AddMerchantResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddMerchantResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantReferenceNumber == input.MerchantReferenceNumber ||
                    (this.MerchantReferenceNumber != null &&
                    this.MerchantReferenceNumber.Equals(input.MerchantReferenceNumber))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.MerchantReferenceNumber != null)
                    hashCode = hashCode * 59 + this.MerchantReferenceNumber.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
