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
    /// BatchMessageStatus
    /// </summary>
    [DataContract(Name = "BatchMessageStatus")]
    public partial class BatchMessageStatus : IEquatable<BatchMessageStatus>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public BatchImportStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMessageStatus" /> class.
        /// </summary>
        /// <param name="companyUserGuid">companyUserGuid.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="batchId">batchId.</param>
        /// <param name="status">status.</param>
        /// <param name="messageId">messageId.</param>
        /// <param name="failedReason">failedReason.</param>
        /// <param name="payload">payload.</param>
        /// <param name="retryCount">retryCount.</param>
        /// <param name="documentSerial">documentSerial.</param>
        /// <param name="sqlId">sqlId.</param>
        /// <param name="rowIndex">rowIndex.</param>
        public BatchMessageStatus(string companyUserGuid = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string batchId = default(string), BatchImportStatus? status = default(BatchImportStatus?), string messageId = default(string), string failedReason = default(string), string payload = default(string), int retryCount = default(int), string documentSerial = default(string), long sqlId = default(long), int rowIndex = default(int))
        {
            this.CompanyUserGuid = companyUserGuid;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.BatchId = batchId;
            this.Status = status;
            this.MessageId = messageId;
            this.FailedReason = failedReason;
            this.Payload = payload;
            this.RetryCount = retryCount;
            this.DocumentSerial = documentSerial;
            this.SqlId = sqlId;
            this.RowIndex = rowIndex;
        }

        /// <summary>
        /// Gets or Sets CompanyUserGuid
        /// </summary>
        [DataMember(Name = "companyUserGuid", EmitDefaultValue = true)]
        public string CompanyUserGuid { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets BatchId
        /// </summary>
        [DataMember(Name = "batchId", EmitDefaultValue = true)]
        public string BatchId { get; set; }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "messageId", EmitDefaultValue = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or Sets FailedReason
        /// </summary>
        [DataMember(Name = "failedReason", EmitDefaultValue = true)]
        public string FailedReason { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = true)]
        public string Payload { get; set; }

        /// <summary>
        /// Gets or Sets RetryCount
        /// </summary>
        [DataMember(Name = "retryCount", EmitDefaultValue = false)]
        public int RetryCount { get; set; }

        /// <summary>
        /// Gets or Sets DocumentSerial
        /// </summary>
        [DataMember(Name = "documentSerial", EmitDefaultValue = true)]
        public string DocumentSerial { get; set; }

        /// <summary>
        /// Gets or Sets SqlId
        /// </summary>
        [DataMember(Name = "sqlId", EmitDefaultValue = false)]
        public long SqlId { get; set; }

        /// <summary>
        /// Gets or Sets RowIndex
        /// </summary>
        [DataMember(Name = "rowIndex", EmitDefaultValue = false)]
        public int RowIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchMessageStatus {\n");
            sb.Append("  CompanyUserGuid: ").Append(CompanyUserGuid).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  FailedReason: ").Append(FailedReason).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  RetryCount: ").Append(RetryCount).Append("\n");
            sb.Append("  DocumentSerial: ").Append(DocumentSerial).Append("\n");
            sb.Append("  SqlId: ").Append(SqlId).Append("\n");
            sb.Append("  RowIndex: ").Append(RowIndex).Append("\n");
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
            return this.Equals(input as BatchMessageStatus);
        }

        /// <summary>
        /// Returns true if BatchMessageStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchMessageStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchMessageStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CompanyUserGuid == input.CompanyUserGuid ||
                    (this.CompanyUserGuid != null &&
                    this.CompanyUserGuid.Equals(input.CompanyUserGuid))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.BatchId == input.BatchId ||
                    (this.BatchId != null &&
                    this.BatchId.Equals(input.BatchId))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.FailedReason == input.FailedReason ||
                    (this.FailedReason != null &&
                    this.FailedReason.Equals(input.FailedReason))
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) && 
                (
                    this.RetryCount == input.RetryCount ||
                    this.RetryCount.Equals(input.RetryCount)
                ) && 
                (
                    this.DocumentSerial == input.DocumentSerial ||
                    (this.DocumentSerial != null &&
                    this.DocumentSerial.Equals(input.DocumentSerial))
                ) && 
                (
                    this.SqlId == input.SqlId ||
                    this.SqlId.Equals(input.SqlId)
                ) && 
                (
                    this.RowIndex == input.RowIndex ||
                    this.RowIndex.Equals(input.RowIndex)
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
                if (this.CompanyUserGuid != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyUserGuid.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.BatchId != null)
                {
                    hashCode = (hashCode * 59) + this.BatchId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.MessageId != null)
                {
                    hashCode = (hashCode * 59) + this.MessageId.GetHashCode();
                }
                if (this.FailedReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailedReason.GetHashCode();
                }
                if (this.Payload != null)
                {
                    hashCode = (hashCode * 59) + this.Payload.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RetryCount.GetHashCode();
                if (this.DocumentSerial != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentSerial.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SqlId.GetHashCode();
                hashCode = (hashCode * 59) + this.RowIndex.GetHashCode();
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