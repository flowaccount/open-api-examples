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
    /// Contact
    /// </summary>
    [DataContract(Name = "Contact")]
    public partial class Contact : IEquatable<Contact>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ContactType
        /// </summary>
        [DataMember(Name = "contactType", EmitDefaultValue = false)]
        public ContactTypes? ContactType { get; set; }

        /// <summary>
        /// Gets or Sets ContactGroup
        /// </summary>
        [DataMember(Name = "contactGroup", EmitDefaultValue = false)]
        public ContactGroups? ContactGroup { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="nameLocal">nameLocal.</param>
        /// <param name="nameForeign">nameForeign.</param>
        /// <param name="addressLocal">addressLocal.</param>
        /// <param name="addressForeign">addressForeign.</param>
        /// <param name="addressLocalLine2">addressLocalLine2.</param>
        /// <param name="addressForeignLine2">addressForeignLine2.</param>
        /// <param name="addressLocalLine3">addressLocalLine3.</param>
        /// <param name="addressForeignLine3">addressForeignLine3.</param>
        /// <param name="branch">branch.</param>
        /// <param name="branchForeign">branchForeign.</param>
        /// <param name="companyTaxId">companyTaxId.</param>
        /// <param name="fax">fax.</param>
        /// <param name="phone1">phone1.</param>
        /// <param name="phone2">phone2.</param>
        /// <param name="phone3">phone3.</param>
        /// <param name="websites">websites.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="modifiedOn">modifiedOn.</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        /// <param name="isDelete">isDelete.</param>
        /// <param name="isDefault">isDefault.</param>
        /// <param name="logoImage">logoImage.</param>
        /// <param name="defaultCreditDays">defaultCreditDays.</param>
        /// <param name="vatRate">vatRate.</param>
        /// <param name="email">email.</param>
        /// <param name="contactPerson">contactPerson.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="contactType">contactType.</param>
        /// <param name="contactGroup">contactGroup.</param>
        /// <param name="remarks">remarks.</param>
        /// <param name="galleryId">galleryId.</param>
        /// <param name="branchCode">branchCode.</param>
        /// <param name="transactionId">transactionId.</param>
        /// <param name="resetTransactionId">resetTransactionId.</param>
        /// <param name="contactCode">contactCode.</param>
        /// <param name="internalNotes">internalNotes.</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        /// <param name="zipCode">zipCode.</param>
        /// <param name="swiftCode">swiftCode.</param>
        /// <param name="bankAddress">bankAddress.</param>
        /// <param name="useForeignBank">useForeignBank.</param>
        /// <param name="isMigrate">isMigrate.</param>
        public Contact(long id = default(long), string nameLocal = default(string), string nameForeign = default(string), string addressLocal = default(string), string addressForeign = default(string), string addressLocalLine2 = default(string), string addressForeignLine2 = default(string), string addressLocalLine3 = default(string), string addressForeignLine3 = default(string), string branch = default(string), string branchForeign = default(string), string companyTaxId = default(string), string fax = default(string), string phone1 = default(string), string phone2 = default(string), string phone3 = default(string), string websites = default(string), DateTime createdOn = default(DateTime), DateTime modifiedOn = default(DateTime), long modifiedBy = default(long), bool isDelete = default(bool), bool isDefault = default(bool), string logoImage = default(string), int? defaultCreditDays = default(int?), int vatRate = default(int), string email = default(string), string contactPerson = default(string), bool isActive = default(bool), ContactTypes? contactType = default(ContactTypes?), ContactGroups? contactGroup = default(ContactGroups?), string remarks = default(string), long? galleryId = default(long?), string branchCode = default(string), string transactionId = default(string), long? resetTransactionId = default(long?), string contactCode = default(string), string internalNotes = default(string), string shippingAddress = default(string), string zipCode = default(string), string swiftCode = default(string), string bankAddress = default(string), bool? useForeignBank = default(bool?), bool isMigrate = default(bool))
        {
            this.Id = id;
            this.NameLocal = nameLocal;
            this.NameForeign = nameForeign;
            this.AddressLocal = addressLocal;
            this.AddressForeign = addressForeign;
            this.AddressLocalLine2 = addressLocalLine2;
            this.AddressForeignLine2 = addressForeignLine2;
            this.AddressLocalLine3 = addressLocalLine3;
            this.AddressForeignLine3 = addressForeignLine3;
            this.Branch = branch;
            this.BranchForeign = branchForeign;
            this.CompanyTaxId = companyTaxId;
            this.Fax = fax;
            this.Phone1 = phone1;
            this.Phone2 = phone2;
            this.Phone3 = phone3;
            this.Websites = websites;
            this.CreatedOn = createdOn;
            this.ModifiedOn = modifiedOn;
            this.ModifiedBy = modifiedBy;
            this.IsDelete = isDelete;
            this.IsDefault = isDefault;
            this.LogoImage = logoImage;
            this.DefaultCreditDays = defaultCreditDays;
            this.VatRate = vatRate;
            this.Email = email;
            this.ContactPerson = contactPerson;
            this.IsActive = isActive;
            this.ContactType = contactType;
            this.ContactGroup = contactGroup;
            this.Remarks = remarks;
            this.GalleryId = galleryId;
            this.BranchCode = branchCode;
            this.TransactionId = transactionId;
            this.ResetTransactionId = resetTransactionId;
            this.ContactCode = contactCode;
            this.InternalNotes = internalNotes;
            this.ShippingAddress = shippingAddress;
            this.ZipCode = zipCode;
            this.SwiftCode = swiftCode;
            this.BankAddress = bankAddress;
            this.UseForeignBank = useForeignBank;
            this.IsMigrate = isMigrate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets NameLocal
        /// </summary>
        [DataMember(Name = "nameLocal", EmitDefaultValue = true)]
        public string NameLocal { get; set; }

        /// <summary>
        /// Gets or Sets NameForeign
        /// </summary>
        [DataMember(Name = "nameForeign", EmitDefaultValue = true)]
        public string NameForeign { get; set; }

        /// <summary>
        /// Gets or Sets AddressLocal
        /// </summary>
        [DataMember(Name = "addressLocal", EmitDefaultValue = true)]
        public string AddressLocal { get; set; }

        /// <summary>
        /// Gets or Sets AddressForeign
        /// </summary>
        [DataMember(Name = "addressForeign", EmitDefaultValue = true)]
        public string AddressForeign { get; set; }

        /// <summary>
        /// Gets or Sets AddressLocalLine2
        /// </summary>
        [DataMember(Name = "addressLocalLine2", EmitDefaultValue = true)]
        public string AddressLocalLine2 { get; set; }

        /// <summary>
        /// Gets or Sets AddressForeignLine2
        /// </summary>
        [DataMember(Name = "addressForeignLine2", EmitDefaultValue = true)]
        public string AddressForeignLine2 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLocalLine3
        /// </summary>
        [DataMember(Name = "addressLocalLine3", EmitDefaultValue = true)]
        public string AddressLocalLine3 { get; set; }

        /// <summary>
        /// Gets or Sets AddressForeignLine3
        /// </summary>
        [DataMember(Name = "addressForeignLine3", EmitDefaultValue = true)]
        public string AddressForeignLine3 { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name = "branch", EmitDefaultValue = true)]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or Sets BranchForeign
        /// </summary>
        [DataMember(Name = "branchForeign", EmitDefaultValue = true)]
        public string BranchForeign { get; set; }

        /// <summary>
        /// Gets or Sets CompanyTaxId
        /// </summary>
        [DataMember(Name = "companyTaxId", EmitDefaultValue = true)]
        public string CompanyTaxId { get; set; }

        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name = "fax", EmitDefaultValue = true)]
        public string Fax { get; set; }

        /// <summary>
        /// Gets or Sets Phone1
        /// </summary>
        [DataMember(Name = "phone1", EmitDefaultValue = true)]
        public string Phone1 { get; set; }

        /// <summary>
        /// Gets or Sets Phone2
        /// </summary>
        [DataMember(Name = "phone2", EmitDefaultValue = true)]
        public string Phone2 { get; set; }

        /// <summary>
        /// Gets or Sets Phone3
        /// </summary>
        [DataMember(Name = "phone3", EmitDefaultValue = true)]
        public string Phone3 { get; set; }

        /// <summary>
        /// Gets or Sets Websites
        /// </summary>
        [DataMember(Name = "websites", EmitDefaultValue = true)]
        public string Websites { get; set; }

        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedOn
        /// </summary>
        [DataMember(Name = "modifiedOn", EmitDefaultValue = false)]
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
        public long ModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets IsDelete
        /// </summary>
        [DataMember(Name = "isDelete", EmitDefaultValue = true)]
        public bool IsDelete { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "isDefault", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets LogoImage
        /// </summary>
        [DataMember(Name = "logoImage", EmitDefaultValue = true)]
        public string LogoImage { get; set; }

        /// <summary>
        /// Gets or Sets DefaultCreditDays
        /// </summary>
        [DataMember(Name = "defaultCreditDays", EmitDefaultValue = true)]
        public int? DefaultCreditDays { get; set; }

        /// <summary>
        /// Gets or Sets VatRate
        /// </summary>
        [DataMember(Name = "vatRate", EmitDefaultValue = false)]
        public int VatRate { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets ContactPerson
        /// </summary>
        [DataMember(Name = "contactPerson", EmitDefaultValue = true)]
        public string ContactPerson { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets Remarks
        /// </summary>
        [DataMember(Name = "remarks", EmitDefaultValue = true)]
        public string Remarks { get; set; }

        /// <summary>
        /// Gets or Sets GalleryId
        /// </summary>
        [DataMember(Name = "galleryId", EmitDefaultValue = true)]
        public long? GalleryId { get; set; }

        /// <summary>
        /// Gets or Sets BranchCode
        /// </summary>
        [DataMember(Name = "branchCode", EmitDefaultValue = true)]
        public string BranchCode { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name = "transactionId", EmitDefaultValue = true)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets ResetTransactionId
        /// </summary>
        [DataMember(Name = "resetTransactionId", EmitDefaultValue = true)]
        public long? ResetTransactionId { get; set; }

        /// <summary>
        /// Gets or Sets ContactCode
        /// </summary>
        [DataMember(Name = "contactCode", EmitDefaultValue = true)]
        public string ContactCode { get; set; }

        /// <summary>
        /// Gets or Sets InternalNotes
        /// </summary>
        [DataMember(Name = "internalNotes", EmitDefaultValue = true)]
        public string InternalNotes { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "shippingAddress", EmitDefaultValue = true)]
        public string ShippingAddress { get; set; }

        /// <summary>
        /// Gets or Sets ZipCode
        /// </summary>
        [DataMember(Name = "zipCode", EmitDefaultValue = true)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or Sets SwiftCode
        /// </summary>
        [DataMember(Name = "swiftCode", EmitDefaultValue = true)]
        public string SwiftCode { get; set; }

        /// <summary>
        /// Gets or Sets BankAddress
        /// </summary>
        [DataMember(Name = "bankAddress", EmitDefaultValue = true)]
        public string BankAddress { get; set; }

        /// <summary>
        /// Gets or Sets UseForeignBank
        /// </summary>
        [DataMember(Name = "useForeignBank", EmitDefaultValue = true)]
        public bool? UseForeignBank { get; set; }

        /// <summary>
        /// Gets or Sets IsMigrate
        /// </summary>
        [DataMember(Name = "isMigrate", EmitDefaultValue = true)]
        public bool IsMigrate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Contact {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NameLocal: ").Append(NameLocal).Append("\n");
            sb.Append("  NameForeign: ").Append(NameForeign).Append("\n");
            sb.Append("  AddressLocal: ").Append(AddressLocal).Append("\n");
            sb.Append("  AddressForeign: ").Append(AddressForeign).Append("\n");
            sb.Append("  AddressLocalLine2: ").Append(AddressLocalLine2).Append("\n");
            sb.Append("  AddressForeignLine2: ").Append(AddressForeignLine2).Append("\n");
            sb.Append("  AddressLocalLine3: ").Append(AddressLocalLine3).Append("\n");
            sb.Append("  AddressForeignLine3: ").Append(AddressForeignLine3).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  BranchForeign: ").Append(BranchForeign).Append("\n");
            sb.Append("  CompanyTaxId: ").Append(CompanyTaxId).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Phone1: ").Append(Phone1).Append("\n");
            sb.Append("  Phone2: ").Append(Phone2).Append("\n");
            sb.Append("  Phone3: ").Append(Phone3).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  IsDelete: ").Append(IsDelete).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  LogoImage: ").Append(LogoImage).Append("\n");
            sb.Append("  DefaultCreditDays: ").Append(DefaultCreditDays).Append("\n");
            sb.Append("  VatRate: ").Append(VatRate).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  ContactType: ").Append(ContactType).Append("\n");
            sb.Append("  ContactGroup: ").Append(ContactGroup).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  GalleryId: ").Append(GalleryId).Append("\n");
            sb.Append("  BranchCode: ").Append(BranchCode).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  ResetTransactionId: ").Append(ResetTransactionId).Append("\n");
            sb.Append("  ContactCode: ").Append(ContactCode).Append("\n");
            sb.Append("  InternalNotes: ").Append(InternalNotes).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  SwiftCode: ").Append(SwiftCode).Append("\n");
            sb.Append("  BankAddress: ").Append(BankAddress).Append("\n");
            sb.Append("  UseForeignBank: ").Append(UseForeignBank).Append("\n");
            sb.Append("  IsMigrate: ").Append(IsMigrate).Append("\n");
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
            return this.Equals(input as Contact);
        }

        /// <summary>
        /// Returns true if Contact instances are equal
        /// </summary>
        /// <param name="input">Instance of Contact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contact input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.NameLocal == input.NameLocal ||
                    (this.NameLocal != null &&
                    this.NameLocal.Equals(input.NameLocal))
                ) && 
                (
                    this.NameForeign == input.NameForeign ||
                    (this.NameForeign != null &&
                    this.NameForeign.Equals(input.NameForeign))
                ) && 
                (
                    this.AddressLocal == input.AddressLocal ||
                    (this.AddressLocal != null &&
                    this.AddressLocal.Equals(input.AddressLocal))
                ) && 
                (
                    this.AddressForeign == input.AddressForeign ||
                    (this.AddressForeign != null &&
                    this.AddressForeign.Equals(input.AddressForeign))
                ) && 
                (
                    this.AddressLocalLine2 == input.AddressLocalLine2 ||
                    (this.AddressLocalLine2 != null &&
                    this.AddressLocalLine2.Equals(input.AddressLocalLine2))
                ) && 
                (
                    this.AddressForeignLine2 == input.AddressForeignLine2 ||
                    (this.AddressForeignLine2 != null &&
                    this.AddressForeignLine2.Equals(input.AddressForeignLine2))
                ) && 
                (
                    this.AddressLocalLine3 == input.AddressLocalLine3 ||
                    (this.AddressLocalLine3 != null &&
                    this.AddressLocalLine3.Equals(input.AddressLocalLine3))
                ) && 
                (
                    this.AddressForeignLine3 == input.AddressForeignLine3 ||
                    (this.AddressForeignLine3 != null &&
                    this.AddressForeignLine3.Equals(input.AddressForeignLine3))
                ) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && 
                (
                    this.BranchForeign == input.BranchForeign ||
                    (this.BranchForeign != null &&
                    this.BranchForeign.Equals(input.BranchForeign))
                ) && 
                (
                    this.CompanyTaxId == input.CompanyTaxId ||
                    (this.CompanyTaxId != null &&
                    this.CompanyTaxId.Equals(input.CompanyTaxId))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.Phone1 == input.Phone1 ||
                    (this.Phone1 != null &&
                    this.Phone1.Equals(input.Phone1))
                ) && 
                (
                    this.Phone2 == input.Phone2 ||
                    (this.Phone2 != null &&
                    this.Phone2.Equals(input.Phone2))
                ) && 
                (
                    this.Phone3 == input.Phone3 ||
                    (this.Phone3 != null &&
                    this.Phone3.Equals(input.Phone3))
                ) && 
                (
                    this.Websites == input.Websites ||
                    (this.Websites != null &&
                    this.Websites.Equals(input.Websites))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.ModifiedOn == input.ModifiedOn ||
                    (this.ModifiedOn != null &&
                    this.ModifiedOn.Equals(input.ModifiedOn))
                ) && 
                (
                    this.ModifiedBy == input.ModifiedBy ||
                    this.ModifiedBy.Equals(input.ModifiedBy)
                ) && 
                (
                    this.IsDelete == input.IsDelete ||
                    this.IsDelete.Equals(input.IsDelete)
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
                ) && 
                (
                    this.LogoImage == input.LogoImage ||
                    (this.LogoImage != null &&
                    this.LogoImage.Equals(input.LogoImage))
                ) && 
                (
                    this.DefaultCreditDays == input.DefaultCreditDays ||
                    (this.DefaultCreditDays != null &&
                    this.DefaultCreditDays.Equals(input.DefaultCreditDays))
                ) && 
                (
                    this.VatRate == input.VatRate ||
                    this.VatRate.Equals(input.VatRate)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.ContactPerson == input.ContactPerson ||
                    (this.ContactPerson != null &&
                    this.ContactPerson.Equals(input.ContactPerson))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.ContactType == input.ContactType ||
                    this.ContactType.Equals(input.ContactType)
                ) && 
                (
                    this.ContactGroup == input.ContactGroup ||
                    this.ContactGroup.Equals(input.ContactGroup)
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
                ) && 
                (
                    this.GalleryId == input.GalleryId ||
                    (this.GalleryId != null &&
                    this.GalleryId.Equals(input.GalleryId))
                ) && 
                (
                    this.BranchCode == input.BranchCode ||
                    (this.BranchCode != null &&
                    this.BranchCode.Equals(input.BranchCode))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.ResetTransactionId == input.ResetTransactionId ||
                    (this.ResetTransactionId != null &&
                    this.ResetTransactionId.Equals(input.ResetTransactionId))
                ) && 
                (
                    this.ContactCode == input.ContactCode ||
                    (this.ContactCode != null &&
                    this.ContactCode.Equals(input.ContactCode))
                ) && 
                (
                    this.InternalNotes == input.InternalNotes ||
                    (this.InternalNotes != null &&
                    this.InternalNotes.Equals(input.InternalNotes))
                ) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && 
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
                ) && 
                (
                    this.SwiftCode == input.SwiftCode ||
                    (this.SwiftCode != null &&
                    this.SwiftCode.Equals(input.SwiftCode))
                ) && 
                (
                    this.BankAddress == input.BankAddress ||
                    (this.BankAddress != null &&
                    this.BankAddress.Equals(input.BankAddress))
                ) && 
                (
                    this.UseForeignBank == input.UseForeignBank ||
                    (this.UseForeignBank != null &&
                    this.UseForeignBank.Equals(input.UseForeignBank))
                ) && 
                (
                    this.IsMigrate == input.IsMigrate ||
                    this.IsMigrate.Equals(input.IsMigrate)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.NameLocal != null)
                {
                    hashCode = (hashCode * 59) + this.NameLocal.GetHashCode();
                }
                if (this.NameForeign != null)
                {
                    hashCode = (hashCode * 59) + this.NameForeign.GetHashCode();
                }
                if (this.AddressLocal != null)
                {
                    hashCode = (hashCode * 59) + this.AddressLocal.GetHashCode();
                }
                if (this.AddressForeign != null)
                {
                    hashCode = (hashCode * 59) + this.AddressForeign.GetHashCode();
                }
                if (this.AddressLocalLine2 != null)
                {
                    hashCode = (hashCode * 59) + this.AddressLocalLine2.GetHashCode();
                }
                if (this.AddressForeignLine2 != null)
                {
                    hashCode = (hashCode * 59) + this.AddressForeignLine2.GetHashCode();
                }
                if (this.AddressLocalLine3 != null)
                {
                    hashCode = (hashCode * 59) + this.AddressLocalLine3.GetHashCode();
                }
                if (this.AddressForeignLine3 != null)
                {
                    hashCode = (hashCode * 59) + this.AddressForeignLine3.GetHashCode();
                }
                if (this.Branch != null)
                {
                    hashCode = (hashCode * 59) + this.Branch.GetHashCode();
                }
                if (this.BranchForeign != null)
                {
                    hashCode = (hashCode * 59) + this.BranchForeign.GetHashCode();
                }
                if (this.CompanyTaxId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyTaxId.GetHashCode();
                }
                if (this.Fax != null)
                {
                    hashCode = (hashCode * 59) + this.Fax.GetHashCode();
                }
                if (this.Phone1 != null)
                {
                    hashCode = (hashCode * 59) + this.Phone1.GetHashCode();
                }
                if (this.Phone2 != null)
                {
                    hashCode = (hashCode * 59) + this.Phone2.GetHashCode();
                }
                if (this.Phone3 != null)
                {
                    hashCode = (hashCode * 59) + this.Phone3.GetHashCode();
                }
                if (this.Websites != null)
                {
                    hashCode = (hashCode * 59) + this.Websites.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedOn.GetHashCode();
                }
                if (this.ModifiedOn != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedOn.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ModifiedBy.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDelete.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDefault.GetHashCode();
                if (this.LogoImage != null)
                {
                    hashCode = (hashCode * 59) + this.LogoImage.GetHashCode();
                }
                if (this.DefaultCreditDays != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultCreditDays.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VatRate.GetHashCode();
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.ContactPerson != null)
                {
                    hashCode = (hashCode * 59) + this.ContactPerson.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                hashCode = (hashCode * 59) + this.ContactType.GetHashCode();
                hashCode = (hashCode * 59) + this.ContactGroup.GetHashCode();
                if (this.Remarks != null)
                {
                    hashCode = (hashCode * 59) + this.Remarks.GetHashCode();
                }
                if (this.GalleryId != null)
                {
                    hashCode = (hashCode * 59) + this.GalleryId.GetHashCode();
                }
                if (this.BranchCode != null)
                {
                    hashCode = (hashCode * 59) + this.BranchCode.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.ResetTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.ResetTransactionId.GetHashCode();
                }
                if (this.ContactCode != null)
                {
                    hashCode = (hashCode * 59) + this.ContactCode.GetHashCode();
                }
                if (this.InternalNotes != null)
                {
                    hashCode = (hashCode * 59) + this.InternalNotes.GetHashCode();
                }
                if (this.ShippingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ShippingAddress.GetHashCode();
                }
                if (this.ZipCode != null)
                {
                    hashCode = (hashCode * 59) + this.ZipCode.GetHashCode();
                }
                if (this.SwiftCode != null)
                {
                    hashCode = (hashCode * 59) + this.SwiftCode.GetHashCode();
                }
                if (this.BankAddress != null)
                {
                    hashCode = (hashCode * 59) + this.BankAddress.GetHashCode();
                }
                if (this.UseForeignBank != null)
                {
                    hashCode = (hashCode * 59) + this.UseForeignBank.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsMigrate.GetHashCode();
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
            // BranchCode (string) maxLength
            if (this.BranchCode != null && this.BranchCode.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BranchCode, length must be less than 50.", new [] { "BranchCode" });
            }

            // BranchCode (string) minLength
            if (this.BranchCode != null && this.BranchCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BranchCode, length must be greater than 0.", new [] { "BranchCode" });
            }

            // TransactionId (string) maxLength
            if (this.TransactionId != null && this.TransactionId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionId, length must be less than 50.", new [] { "TransactionId" });
            }

            // TransactionId (string) minLength
            if (this.TransactionId != null && this.TransactionId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionId, length must be greater than 0.", new [] { "TransactionId" });
            }

            yield break;
        }
    }

}