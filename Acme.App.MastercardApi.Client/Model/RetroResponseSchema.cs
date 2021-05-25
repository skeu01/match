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
    /// RetroResponseSchema
    /// </summary>
    [DataContract(Name = "RetroResponseSchema")]
    public partial class RetroResponseSchema : IEquatable<RetroResponseSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetroResponseSchema" /> class.
        /// </summary>
        /// <param name="retroResponse">retroResponse.</param>
        public RetroResponseSchema(Retros retroResponse = default(Retros))
        {
            this.RetroResponse = retroResponse;
        }

        /// <summary>
        /// Gets or Sets RetroResponse
        /// </summary>
        [DataMember(Name = "RetroResponse", EmitDefaultValue = false)]
        public Retros RetroResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetroResponseSchema {\n");
            sb.Append("  RetroResponse: ").Append(RetroResponse).Append("\n");
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
            return this.Equals(input as RetroResponseSchema);
        }

        /// <summary>
        /// Returns true if RetroResponseSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of RetroResponseSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetroResponseSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RetroResponse == input.RetroResponse ||
                    (this.RetroResponse != null &&
                    this.RetroResponse.Equals(input.RetroResponse))
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
                if (this.RetroResponse != null)
                    hashCode = hashCode * 59 + this.RetroResponse.GetHashCode();
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
