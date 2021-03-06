/* 
 * Shipping API
 *
 * Shipping API Sample.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@pb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = shippingapi.Client.OpenAPIDateConverter;

namespace shippingapi.Model
{
    /// <summary>
    /// ServicesParameterRule
    /// </summary>
    [DataContract]
    public partial class ServicesParameterRule :  IEquatable<ServicesParameterRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesParameterRule" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="brandedName">brandedName.</param>
        /// <param name="required">required.</param>
        /// <param name="minValue">minValue.</param>
        /// <param name="maxValue">maxValue.</param>
        /// <param name="freeValue">freeValue.</param>
        /// <param name="format">format.</param>
        /// <param name="description">description.</param>
        public ServicesParameterRule(string name = default(string), string brandedName = default(string), bool required = default(bool), decimal minValue = default(decimal), decimal maxValue = default(decimal), decimal freeValue = default(decimal), string format = default(string), string description = default(string))
        {
            this.Name = name;
            this.BrandedName = brandedName;
            this.Required = required;
            this.MinValue = minValue;
            this.MaxValue = maxValue;
            this.FreeValue = freeValue;
            this.Format = format;
            this.Description = description;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets BrandedName
        /// </summary>
        [DataMember(Name="brandedName", EmitDefaultValue=false)]
        public string BrandedName { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool Required { get; set; }

        /// <summary>
        /// Gets or Sets MinValue
        /// </summary>
        [DataMember(Name="minValue", EmitDefaultValue=false)]
        public decimal MinValue { get; set; }

        /// <summary>
        /// Gets or Sets MaxValue
        /// </summary>
        [DataMember(Name="maxValue", EmitDefaultValue=false)]
        public decimal MaxValue { get; set; }

        /// <summary>
        /// Gets or Sets FreeValue
        /// </summary>
        [DataMember(Name="freeValue", EmitDefaultValue=false)]
        public decimal FreeValue { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServicesParameterRule {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BrandedName: ").Append(BrandedName).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  MinValue: ").Append(MinValue).Append("\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  FreeValue: ").Append(FreeValue).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServicesParameterRule);
        }

        /// <summary>
        /// Returns true if ServicesParameterRule instances are equal
        /// </summary>
        /// <param name="input">Instance of ServicesParameterRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServicesParameterRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.BrandedName == input.BrandedName ||
                    (this.BrandedName != null &&
                    this.BrandedName.Equals(input.BrandedName))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.MinValue == input.MinValue ||
                    (this.MinValue != null &&
                    this.MinValue.Equals(input.MinValue))
                ) && 
                (
                    this.MaxValue == input.MaxValue ||
                    (this.MaxValue != null &&
                    this.MaxValue.Equals(input.MaxValue))
                ) && 
                (
                    this.FreeValue == input.FreeValue ||
                    (this.FreeValue != null &&
                    this.FreeValue.Equals(input.FreeValue))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BrandedName != null)
                    hashCode = hashCode * 59 + this.BrandedName.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.MinValue != null)
                    hashCode = hashCode * 59 + this.MinValue.GetHashCode();
                if (this.MaxValue != null)
                    hashCode = hashCode * 59 + this.MaxValue.GetHashCode();
                if (this.FreeValue != null)
                    hashCode = hashCode * 59 + this.FreeValue.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
