/*
 * FlowAccount Open API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// BatchHistory
    /// </summary>
    [DataContract(Name = "BatchHistory")]
    public partial class BatchHistory : IEquatable<BatchHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchHistory" /> class.
        /// </summary>
        /// <param name="metadataList">metadataList.</param>
        public BatchHistory(List<BatchImportMetadata> metadataList = default(List<BatchImportMetadata>))
        {
            this.MetadataList = metadataList;
        }

        /// <summary>
        /// Gets or Sets MetadataList
        /// </summary>
        [DataMember(Name = "metadataList", EmitDefaultValue = true)]
        public List<BatchImportMetadata> MetadataList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchHistory {\n");
            sb.Append("  MetadataList: ").Append(MetadataList).Append("\n");
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
            return this.Equals(input as BatchHistory);
        }

        /// <summary>
        /// Returns true if BatchHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchHistory input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MetadataList == input.MetadataList ||
                    this.MetadataList != null &&
                    input.MetadataList != null &&
                    this.MetadataList.SequenceEqual(input.MetadataList)
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
                if (this.MetadataList != null)
                {
                    hashCode = (hashCode * 59) + this.MetadataList.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}