/* 
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]  
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@bybit.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// PriceFilter
    /// </summary>
    [DataContract]
    public partial class PriceFilter :  IEquatable<PriceFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceFilter" /> class.
        /// </summary>
        /// <param name="minPrice">minPrice.</param>
        /// <param name="maxPrice">maxPrice.</param>
        /// <param name="tickSize">tickSize.</param>
        public PriceFilter(string minPrice = default(string), string maxPrice = default(string), string tickSize = default(string))
        {
            this.MinPrice = minPrice;
            this.MaxPrice = maxPrice;
            this.TickSize = tickSize;
        }
        
        /// <summary>
        /// Gets or Sets MinPrice
        /// </summary>
        [DataMember(Name="min_price", EmitDefaultValue=false)]
        public string MinPrice { get; set; }

        /// <summary>
        /// Gets or Sets MaxPrice
        /// </summary>
        [DataMember(Name="max_price", EmitDefaultValue=false)]
        public string MaxPrice { get; set; }

        /// <summary>
        /// Gets or Sets TickSize
        /// </summary>
        [DataMember(Name="tick_size", EmitDefaultValue=false)]
        public string TickSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceFilter {\n");
            sb.Append("  MinPrice: ").Append(MinPrice).Append("\n");
            sb.Append("  MaxPrice: ").Append(MaxPrice).Append("\n");
            sb.Append("  TickSize: ").Append(TickSize).Append("\n");
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
            return this.Equals(input as PriceFilter);
        }

        /// <summary>
        /// Returns true if PriceFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of PriceFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriceFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MinPrice == input.MinPrice ||
                    (this.MinPrice != null &&
                    this.MinPrice.Equals(input.MinPrice))
                ) && 
                (
                    this.MaxPrice == input.MaxPrice ||
                    (this.MaxPrice != null &&
                    this.MaxPrice.Equals(input.MaxPrice))
                ) && 
                (
                    this.TickSize == input.TickSize ||
                    (this.TickSize != null &&
                    this.TickSize.Equals(input.TickSize))
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
                if (this.MinPrice != null)
                    hashCode = hashCode * 59 + this.MinPrice.GetHashCode();
                if (this.MaxPrice != null)
                    hashCode = hashCode * 59 + this.MaxPrice.GetHashCode();
                if (this.TickSize != null)
                    hashCode = hashCode * 59 + this.TickSize.GetHashCode();
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
