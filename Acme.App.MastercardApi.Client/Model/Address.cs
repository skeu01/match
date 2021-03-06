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
    /// Address
    /// </summary>
    [DataContract(Name = "Address")]
    public partial class Address : IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Address() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="line1">Line 1 of the street address for the merchant location. Usually includes street number and name. (required).</param>
        /// <param name="line2">Line 2 of the street address,usually an apartment number or suite number..</param>
        /// <param name="city">The name of the city for a merchant location. (required).</param>
        /// <param name="countrySubdivision">The abbreviated state or province code for a merchant location (only supported for US and Canada merchants)..</param>
        /// <param name="province">The name of the province for the location..</param>
        /// <param name="postalCode">The postal code for a merchant location (only supported for US and Canada merchants). (required).</param>
        /// <param name="country">The three digit country code of the principal owner. Valid values are Three digit alpha country codes as defined in ISO 3166-1. (required).</param>
        public Address(string line1 = default(string), string line2 = default(string), string city = default(string), string countrySubdivision = default(string), string province = default(string), string postalCode = default(string), string country = default(string))
        {
            // to ensure "line1" is required (not null)
            this.Line1 = line1 ?? throw new ArgumentNullException("line1 is a required property for Address and cannot be null");
            // to ensure "city" is required (not null)
            this.City = city ?? throw new ArgumentNullException("city is a required property for Address and cannot be null");
            // to ensure "postalCode" is required (not null)
            this.PostalCode = postalCode ?? throw new ArgumentNullException("postalCode is a required property for Address and cannot be null");
            // to ensure "country" is required (not null)
            this.Country = country ?? throw new ArgumentNullException("country is a required property for Address and cannot be null");
            this.Line2 = line2;
            this.CountrySubdivision = countrySubdivision;
            this.Province = province;
        }

        /// <summary>
        /// Line 1 of the street address for the merchant location. Usually includes street number and name.
        /// </summary>
        /// <value>Line 1 of the street address for the merchant location. Usually includes street number and name.</value>
        [DataMember(Name = "Line1", IsRequired = true, EmitDefaultValue = false)]
        public string Line1 { get; set; }

        /// <summary>
        /// Line 2 of the street address,usually an apartment number or suite number.
        /// </summary>
        /// <value>Line 2 of the street address,usually an apartment number or suite number.</value>
        [DataMember(Name = "Line2", EmitDefaultValue = false)]
        public string Line2 { get; set; }

        /// <summary>
        /// The name of the city for a merchant location.
        /// </summary>
        /// <value>The name of the city for a merchant location.</value>
        [DataMember(Name = "City", IsRequired = true, EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The abbreviated state or province code for a merchant location (only supported for US and Canada merchants).
        /// </summary>
        /// <value>The abbreviated state or province code for a merchant location (only supported for US and Canada merchants).</value>
        [DataMember(Name = "CountrySubdivision", EmitDefaultValue = false)]
        public string CountrySubdivision { get; set; }

        /// <summary>
        /// The name of the province for the location.
        /// </summary>
        /// <value>The name of the province for the location.</value>
        [DataMember(Name = "Province", EmitDefaultValue = false)]
        public string Province { get; set; }

        /// <summary>
        /// The postal code for a merchant location (only supported for US and Canada merchants).
        /// </summary>
        /// <value>The postal code for a merchant location (only supported for US and Canada merchants).</value>
        [DataMember(Name = "PostalCode", IsRequired = true, EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The three digit country code of the principal owner. Valid values are Three digit alpha country codes as defined in ISO 3166-1.
        /// </summary>
        /// <value>The three digit country code of the principal owner. Valid values are Three digit alpha country codes as defined in ISO 3166-1.</value>
        [DataMember(Name = "Country", IsRequired = true, EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountrySubdivision: ").Append(CountrySubdivision).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Line1 == input.Line1 ||
                    (this.Line1 != null &&
                    this.Line1.Equals(input.Line1))
                ) && 
                (
                    this.Line2 == input.Line2 ||
                    (this.Line2 != null &&
                    this.Line2.Equals(input.Line2))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CountrySubdivision == input.CountrySubdivision ||
                    (this.CountrySubdivision != null &&
                    this.CountrySubdivision.Equals(input.CountrySubdivision))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.Line1 != null)
                    hashCode = hashCode * 59 + this.Line1.GetHashCode();
                if (this.Line2 != null)
                    hashCode = hashCode * 59 + this.Line2.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.CountrySubdivision != null)
                    hashCode = hashCode * 59 + this.CountrySubdivision.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
