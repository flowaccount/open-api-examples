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
    /// DocumentQuery
    /// </summary>
    [DataContract(Name = "DocumentQuery")]
    public partial class DocumentQuery : IEquatable<DocumentQuery>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DateType
        /// </summary>
        [DataMember(Name = "dateType", EmitDefaultValue = false)]
        public DateType? DateType { get; set; }

        /// <summary>
        /// Gets or Sets Range
        /// </summary>
        [DataMember(Name = "range", EmitDefaultValue = false)]
        public DataRange? Range { get; set; }

        /// <summary>
        /// Gets or Sets ReportType
        /// </summary>
        [DataMember(Name = "reportType", EmitDefaultValue = false)]
        public ReportTypes? ReportType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentQuery" /> class.
        /// </summary>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="currentPage">currentPage.</param>
        /// <param name="totalRecords">totalRecords.</param>
        /// <param name="dateType">dateType.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="day">day.</param>
        /// <param name="month">month.</param>
        /// <param name="year">year.</param>
        /// <param name="range">range.</param>
        /// <param name="isFirstCurrent">isFirstCurrent.</param>
        /// <param name="hashTags">hashTags.</param>
        /// <param name="reportType">reportType.</param>
        /// <param name="filter">filter.</param>
        /// <param name="sortBy">sortBy.</param>
        /// <param name="totalValue">totalValue.</param>
        /// <param name="totalVAT">totalVAT.</param>
        /// <param name="isReceived">isReceived.</param>
        /// <param name="documentType">documentType.</param>
        /// <param name="revenue">revenue.</param>
        /// <param name="expenses">expenses.</param>
        /// <param name="previousMonths">previousMonths.</param>
        /// <param name="previousYears">previousYears.</param>
        /// <param name="customDocumentModels">customDocumentModels.</param>
        public DocumentQuery(int? pageSize = default(int?), int? currentPage = default(int?), int totalRecords = default(int), DateType? dateType = default(DateType?), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), int day = default(int), int month = default(int), int year = default(int), DataRange? range = default(DataRange?), int isFirstCurrent = default(int), List<string> hashTags = default(List<string>), ReportTypes? reportType = default(ReportTypes?), List<FilterOptions> filter = default(List<FilterOptions>), List<SortOptions> sortBy = default(List<SortOptions>), decimal totalValue = default(decimal), decimal totalVAT = default(decimal), bool isReceived = default(bool), List<DocumentTypes> documentType = default(List<DocumentTypes>), List<ListItem> revenue = default(List<ListItem>), List<ListItem> expenses = default(List<ListItem>), List<ListItem> previousMonths = default(List<ListItem>), List<ListItem> previousYears = default(List<ListItem>), List<CustomDocumentModel> customDocumentModels = default(List<CustomDocumentModel>))
        {
            this.PageSize = pageSize;
            this.CurrentPage = currentPage;
            this.TotalRecords = totalRecords;
            this.DateType = dateType;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Day = day;
            this.Month = month;
            this.Year = year;
            this.Range = range;
            this.IsFirstCurrent = isFirstCurrent;
            this.HashTags = hashTags;
            this.ReportType = reportType;
            this.Filter = filter;
            this.SortBy = sortBy;
            this.TotalValue = totalValue;
            this.TotalVAT = totalVAT;
            this.IsReceived = isReceived;
            this.DocumentType = documentType;
            this.Revenue = revenue;
            this.Expenses = expenses;
            this.PreviousMonths = previousMonths;
            this.PreviousYears = previousYears;
            this.CustomDocumentModels = customDocumentModels;
        }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "pageSize", EmitDefaultValue = true)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPage
        /// </summary>
        [DataMember(Name = "currentPage", EmitDefaultValue = true)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Gets or Sets TotalRecords
        /// </summary>
        [DataMember(Name = "totalRecords", EmitDefaultValue = false)]
        public int TotalRecords { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name = "day", EmitDefaultValue = false)]
        public int Day { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name = "month", EmitDefaultValue = false)]
        public int Month { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets IsFirstCurrent
        /// </summary>
        [DataMember(Name = "isFirstCurrent", EmitDefaultValue = false)]
        public int IsFirstCurrent { get; set; }

        /// <summary>
        /// Gets or Sets HashTags
        /// </summary>
        [DataMember(Name = "hashTags", EmitDefaultValue = true)]
        public List<string> HashTags { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = true)]
        public List<FilterOptions> Filter { get; set; }

        /// <summary>
        /// Gets or Sets SortBy
        /// </summary>
        [DataMember(Name = "sortBy", EmitDefaultValue = true)]
        public List<SortOptions> SortBy { get; set; }

        /// <summary>
        /// Gets or Sets TotalValue
        /// </summary>
        [DataMember(Name = "totalValue", EmitDefaultValue = false)]
        public decimal TotalValue { get; set; }

        /// <summary>
        /// Gets or Sets TotalVAT
        /// </summary>
        [DataMember(Name = "totalVAT", EmitDefaultValue = false)]
        public decimal TotalVAT { get; set; }

        /// <summary>
        /// Gets or Sets IsReceived
        /// </summary>
        [DataMember(Name = "isReceived", EmitDefaultValue = true)]
        public bool IsReceived { get; set; }

        /// <summary>
        /// Gets or Sets DocumentType
        /// </summary>
        [DataMember(Name = "documentType", EmitDefaultValue = true)]
        public List<DocumentTypes> DocumentType { get; set; }

        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name = "revenue", EmitDefaultValue = true)]
        public List<ListItem> Revenue { get; set; }

        /// <summary>
        /// Gets or Sets Expenses
        /// </summary>
        [DataMember(Name = "expenses", EmitDefaultValue = true)]
        public List<ListItem> Expenses { get; set; }

        /// <summary>
        /// Gets or Sets PreviousMonths
        /// </summary>
        [DataMember(Name = "previousMonths", EmitDefaultValue = true)]
        public List<ListItem> PreviousMonths { get; set; }

        /// <summary>
        /// Gets or Sets PreviousYears
        /// </summary>
        [DataMember(Name = "previousYears", EmitDefaultValue = true)]
        public List<ListItem> PreviousYears { get; set; }

        /// <summary>
        /// Gets or Sets CustomDocumentModels
        /// </summary>
        [DataMember(Name = "customDocumentModels", EmitDefaultValue = true)]
        public List<CustomDocumentModel> CustomDocumentModels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentQuery {\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  DateType: ").Append(DateType).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  IsFirstCurrent: ").Append(IsFirstCurrent).Append("\n");
            sb.Append("  HashTags: ").Append(HashTags).Append("\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  TotalValue: ").Append(TotalValue).Append("\n");
            sb.Append("  TotalVAT: ").Append(TotalVAT).Append("\n");
            sb.Append("  IsReceived: ").Append(IsReceived).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  Expenses: ").Append(Expenses).Append("\n");
            sb.Append("  PreviousMonths: ").Append(PreviousMonths).Append("\n");
            sb.Append("  PreviousYears: ").Append(PreviousYears).Append("\n");
            sb.Append("  CustomDocumentModels: ").Append(CustomDocumentModels).Append("\n");
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
            return this.Equals(input as DocumentQuery);
        }

        /// <summary>
        /// Returns true if DocumentQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentQuery input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.CurrentPage == input.CurrentPage ||
                    (this.CurrentPage != null &&
                    this.CurrentPage.Equals(input.CurrentPage))
                ) && 
                (
                    this.TotalRecords == input.TotalRecords ||
                    this.TotalRecords.Equals(input.TotalRecords)
                ) && 
                (
                    this.DateType == input.DateType ||
                    this.DateType.Equals(input.DateType)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Day == input.Day ||
                    this.Day.Equals(input.Day)
                ) && 
                (
                    this.Month == input.Month ||
                    this.Month.Equals(input.Month)
                ) && 
                (
                    this.Year == input.Year ||
                    this.Year.Equals(input.Year)
                ) && 
                (
                    this.Range == input.Range ||
                    this.Range.Equals(input.Range)
                ) && 
                (
                    this.IsFirstCurrent == input.IsFirstCurrent ||
                    this.IsFirstCurrent.Equals(input.IsFirstCurrent)
                ) && 
                (
                    this.HashTags == input.HashTags ||
                    this.HashTags != null &&
                    input.HashTags != null &&
                    this.HashTags.SequenceEqual(input.HashTags)
                ) && 
                (
                    this.ReportType == input.ReportType ||
                    this.ReportType.Equals(input.ReportType)
                ) && 
                (
                    this.Filter == input.Filter ||
                    this.Filter != null &&
                    input.Filter != null &&
                    this.Filter.SequenceEqual(input.Filter)
                ) && 
                (
                    this.SortBy == input.SortBy ||
                    this.SortBy != null &&
                    input.SortBy != null &&
                    this.SortBy.SequenceEqual(input.SortBy)
                ) && 
                (
                    this.TotalValue == input.TotalValue ||
                    this.TotalValue.Equals(input.TotalValue)
                ) && 
                (
                    this.TotalVAT == input.TotalVAT ||
                    this.TotalVAT.Equals(input.TotalVAT)
                ) && 
                (
                    this.IsReceived == input.IsReceived ||
                    this.IsReceived.Equals(input.IsReceived)
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    this.DocumentType != null &&
                    input.DocumentType != null &&
                    this.DocumentType.SequenceEqual(input.DocumentType)
                ) && 
                (
                    this.Revenue == input.Revenue ||
                    this.Revenue != null &&
                    input.Revenue != null &&
                    this.Revenue.SequenceEqual(input.Revenue)
                ) && 
                (
                    this.Expenses == input.Expenses ||
                    this.Expenses != null &&
                    input.Expenses != null &&
                    this.Expenses.SequenceEqual(input.Expenses)
                ) && 
                (
                    this.PreviousMonths == input.PreviousMonths ||
                    this.PreviousMonths != null &&
                    input.PreviousMonths != null &&
                    this.PreviousMonths.SequenceEqual(input.PreviousMonths)
                ) && 
                (
                    this.PreviousYears == input.PreviousYears ||
                    this.PreviousYears != null &&
                    input.PreviousYears != null &&
                    this.PreviousYears.SequenceEqual(input.PreviousYears)
                ) && 
                (
                    this.CustomDocumentModels == input.CustomDocumentModels ||
                    this.CustomDocumentModels != null &&
                    input.CustomDocumentModels != null &&
                    this.CustomDocumentModels.SequenceEqual(input.CustomDocumentModels)
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
                if (this.PageSize != null)
                {
                    hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                }
                if (this.CurrentPage != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentPage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalRecords.GetHashCode();
                hashCode = (hashCode * 59) + this.DateType.GetHashCode();
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Day.GetHashCode();
                hashCode = (hashCode * 59) + this.Month.GetHashCode();
                hashCode = (hashCode * 59) + this.Year.GetHashCode();
                hashCode = (hashCode * 59) + this.Range.GetHashCode();
                hashCode = (hashCode * 59) + this.IsFirstCurrent.GetHashCode();
                if (this.HashTags != null)
                {
                    hashCode = (hashCode * 59) + this.HashTags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReportType.GetHashCode();
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
                }
                if (this.SortBy != null)
                {
                    hashCode = (hashCode * 59) + this.SortBy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalValue.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalVAT.GetHashCode();
                hashCode = (hashCode * 59) + this.IsReceived.GetHashCode();
                if (this.DocumentType != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentType.GetHashCode();
                }
                if (this.Revenue != null)
                {
                    hashCode = (hashCode * 59) + this.Revenue.GetHashCode();
                }
                if (this.Expenses != null)
                {
                    hashCode = (hashCode * 59) + this.Expenses.GetHashCode();
                }
                if (this.PreviousMonths != null)
                {
                    hashCode = (hashCode * 59) + this.PreviousMonths.GetHashCode();
                }
                if (this.PreviousYears != null)
                {
                    hashCode = (hashCode * 59) + this.PreviousYears.GetHashCode();
                }
                if (this.CustomDocumentModels != null)
                {
                    hashCode = (hashCode * 59) + this.CustomDocumentModels.GetHashCode();
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