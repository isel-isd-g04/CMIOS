// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ValidationModels.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ValidationModels {

  /// <summary>Holder for reflection information generated from ValidationModels.proto</summary>
  public static partial class ValidationModelsReflection {

    #region Descriptor
    /// <summary>File descriptor for ValidationModels.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ValidationModelsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZWYWxpZGF0aW9uTW9kZWxzLnByb3RvEhBWYWxpZGF0aW9uTW9kZWxzItAB",
            "ChFWYWxpZGF0aW9uUmVxdWVzdBIQCghDb2RlQ1NNUBgBIAEoCRIYChBVc2Vy",
            "RmlzY2FsTnVtYmVyGAIgASgJEhAKCFVzZXJJQkFOGAMgASgJEhAKCERhdGVU",
            "aW1lGAQgASgDEhMKC1Bvc2l0aW9uR1BTGAUgASgJEhAKCENvZGVDTU9JGAYg",
            "ASgJEg8KB0NNT0lOSUIYByABKAkSDwoHQ01PSU5JRhgIIAEoCRITCgtWYWxp",
            "ZGF0b3JJRBgJIAEoCRINCgVQcmljZRgKIAEoAiJ9Cg9WYWxpZGF0aW9uUmVw",
            "bHkSEAoIQ29kZUNTTVAYASABKAkSGAoQVXNlckZpc2NhbE51bWJlchgCIAEo",
            "CRIQCghEYXRlVGltZRgDIAEoAxIYChBUcmFuc2ZlcnJlZFZhbHVlGAYgASgJ",
            "EhIKCkF1dGhvcmlzZWQYByABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ValidationModels.ValidationRequest), global::ValidationModels.ValidationRequest.Parser, new[]{ "CodeCSMP", "UserFiscalNumber", "UserIBAN", "DateTime", "PositionGPS", "CodeCMOI", "CMOINIB", "CMOINIF", "ValidatorID", "Price" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ValidationModels.ValidationReply), global::ValidationModels.ValidationReply.Parser, new[]{ "CodeCSMP", "UserFiscalNumber", "DateTime", "TransferredValue", "Authorised" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ValidationRequest : pb::IMessage<ValidationRequest> {
    private static readonly pb::MessageParser<ValidationRequest> _parser = new pb::MessageParser<ValidationRequest>(() => new ValidationRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ValidationRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ValidationModels.ValidationModelsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValidationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValidationRequest(ValidationRequest other) : this() {
      codeCSMP_ = other.codeCSMP_;
      userFiscalNumber_ = other.userFiscalNumber_;
      userIBAN_ = other.userIBAN_;
      dateTime_ = other.dateTime_;
      positionGPS_ = other.positionGPS_;
      codeCMOI_ = other.codeCMOI_;
      cMOINIB_ = other.cMOINIB_;
      cMOINIF_ = other.cMOINIF_;
      validatorID_ = other.validatorID_;
      price_ = other.price_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValidationRequest Clone() {
      return new ValidationRequest(this);
    }

    /// <summary>Field number for the "CodeCSMP" field.</summary>
    public const int CodeCSMPFieldNumber = 1;
    private string codeCSMP_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CodeCSMP {
      get { return codeCSMP_; }
      set {
        codeCSMP_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "UserFiscalNumber" field.</summary>
    public const int UserFiscalNumberFieldNumber = 2;
    private string userFiscalNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserFiscalNumber {
      get { return userFiscalNumber_; }
      set {
        userFiscalNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "UserIBAN" field.</summary>
    public const int UserIBANFieldNumber = 3;
    private string userIBAN_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserIBAN {
      get { return userIBAN_; }
      set {
        userIBAN_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DateTime" field.</summary>
    public const int DateTimeFieldNumber = 4;
    private long dateTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long DateTime {
      get { return dateTime_; }
      set {
        dateTime_ = value;
      }
    }

    /// <summary>Field number for the "PositionGPS" field.</summary>
    public const int PositionGPSFieldNumber = 5;
    private string positionGPS_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PositionGPS {
      get { return positionGPS_; }
      set {
        positionGPS_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CodeCMOI" field.</summary>
    public const int CodeCMOIFieldNumber = 6;
    private string codeCMOI_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CodeCMOI {
      get { return codeCMOI_; }
      set {
        codeCMOI_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CMOINIB" field.</summary>
    public const int CMOINIBFieldNumber = 7;
    private string cMOINIB_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CMOINIB {
      get { return cMOINIB_; }
      set {
        cMOINIB_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CMOINIF" field.</summary>
    public const int CMOINIFFieldNumber = 8;
    private string cMOINIF_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CMOINIF {
      get { return cMOINIF_; }
      set {
        cMOINIF_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ValidatorID" field.</summary>
    public const int ValidatorIDFieldNumber = 9;
    private string validatorID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ValidatorID {
      get { return validatorID_; }
      set {
        validatorID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Price" field.</summary>
    public const int PriceFieldNumber = 10;
    private float price_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ValidationRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ValidationRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CodeCSMP != other.CodeCSMP) return false;
      if (UserFiscalNumber != other.UserFiscalNumber) return false;
      if (UserIBAN != other.UserIBAN) return false;
      if (DateTime != other.DateTime) return false;
      if (PositionGPS != other.PositionGPS) return false;
      if (CodeCMOI != other.CodeCMOI) return false;
      if (CMOINIB != other.CMOINIB) return false;
      if (CMOINIF != other.CMOINIF) return false;
      if (ValidatorID != other.ValidatorID) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Price, other.Price)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CodeCSMP.Length != 0) hash ^= CodeCSMP.GetHashCode();
      if (UserFiscalNumber.Length != 0) hash ^= UserFiscalNumber.GetHashCode();
      if (UserIBAN.Length != 0) hash ^= UserIBAN.GetHashCode();
      if (DateTime != 0L) hash ^= DateTime.GetHashCode();
      if (PositionGPS.Length != 0) hash ^= PositionGPS.GetHashCode();
      if (CodeCMOI.Length != 0) hash ^= CodeCMOI.GetHashCode();
      if (CMOINIB.Length != 0) hash ^= CMOINIB.GetHashCode();
      if (CMOINIF.Length != 0) hash ^= CMOINIF.GetHashCode();
      if (ValidatorID.Length != 0) hash ^= ValidatorID.GetHashCode();
      if (Price != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Price);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CodeCSMP.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CodeCSMP);
      }
      if (UserFiscalNumber.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UserFiscalNumber);
      }
      if (UserIBAN.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(UserIBAN);
      }
      if (DateTime != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(DateTime);
      }
      if (PositionGPS.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(PositionGPS);
      }
      if (CodeCMOI.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(CodeCMOI);
      }
      if (CMOINIB.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(CMOINIB);
      }
      if (CMOINIF.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(CMOINIF);
      }
      if (ValidatorID.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(ValidatorID);
      }
      if (Price != 0F) {
        output.WriteRawTag(85);
        output.WriteFloat(Price);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CodeCSMP.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CodeCSMP);
      }
      if (UserFiscalNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserFiscalNumber);
      }
      if (UserIBAN.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserIBAN);
      }
      if (DateTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(DateTime);
      }
      if (PositionGPS.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PositionGPS);
      }
      if (CodeCMOI.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CodeCMOI);
      }
      if (CMOINIB.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CMOINIB);
      }
      if (CMOINIF.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CMOINIF);
      }
      if (ValidatorID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ValidatorID);
      }
      if (Price != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ValidationRequest other) {
      if (other == null) {
        return;
      }
      if (other.CodeCSMP.Length != 0) {
        CodeCSMP = other.CodeCSMP;
      }
      if (other.UserFiscalNumber.Length != 0) {
        UserFiscalNumber = other.UserFiscalNumber;
      }
      if (other.UserIBAN.Length != 0) {
        UserIBAN = other.UserIBAN;
      }
      if (other.DateTime != 0L) {
        DateTime = other.DateTime;
      }
      if (other.PositionGPS.Length != 0) {
        PositionGPS = other.PositionGPS;
      }
      if (other.CodeCMOI.Length != 0) {
        CodeCMOI = other.CodeCMOI;
      }
      if (other.CMOINIB.Length != 0) {
        CMOINIB = other.CMOINIB;
      }
      if (other.CMOINIF.Length != 0) {
        CMOINIF = other.CMOINIF;
      }
      if (other.ValidatorID.Length != 0) {
        ValidatorID = other.ValidatorID;
      }
      if (other.Price != 0F) {
        Price = other.Price;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CodeCSMP = input.ReadString();
            break;
          }
          case 18: {
            UserFiscalNumber = input.ReadString();
            break;
          }
          case 26: {
            UserIBAN = input.ReadString();
            break;
          }
          case 32: {
            DateTime = input.ReadInt64();
            break;
          }
          case 42: {
            PositionGPS = input.ReadString();
            break;
          }
          case 50: {
            CodeCMOI = input.ReadString();
            break;
          }
          case 58: {
            CMOINIB = input.ReadString();
            break;
          }
          case 66: {
            CMOINIF = input.ReadString();
            break;
          }
          case 74: {
            ValidatorID = input.ReadString();
            break;
          }
          case 85: {
            Price = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ValidationReply : pb::IMessage<ValidationReply> {
    private static readonly pb::MessageParser<ValidationReply> _parser = new pb::MessageParser<ValidationReply>(() => new ValidationReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ValidationReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ValidationModels.ValidationModelsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValidationReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValidationReply(ValidationReply other) : this() {
      codeCSMP_ = other.codeCSMP_;
      userFiscalNumber_ = other.userFiscalNumber_;
      dateTime_ = other.dateTime_;
      transferredValue_ = other.transferredValue_;
      authorised_ = other.authorised_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValidationReply Clone() {
      return new ValidationReply(this);
    }

    /// <summary>Field number for the "CodeCSMP" field.</summary>
    public const int CodeCSMPFieldNumber = 1;
    private string codeCSMP_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CodeCSMP {
      get { return codeCSMP_; }
      set {
        codeCSMP_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "UserFiscalNumber" field.</summary>
    public const int UserFiscalNumberFieldNumber = 2;
    private string userFiscalNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserFiscalNumber {
      get { return userFiscalNumber_; }
      set {
        userFiscalNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DateTime" field.</summary>
    public const int DateTimeFieldNumber = 3;
    private long dateTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long DateTime {
      get { return dateTime_; }
      set {
        dateTime_ = value;
      }
    }

    /// <summary>Field number for the "TransferredValue" field.</summary>
    public const int TransferredValueFieldNumber = 6;
    private string transferredValue_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TransferredValue {
      get { return transferredValue_; }
      set {
        transferredValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Authorised" field.</summary>
    public const int AuthorisedFieldNumber = 7;
    private bool authorised_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Authorised {
      get { return authorised_; }
      set {
        authorised_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ValidationReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ValidationReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CodeCSMP != other.CodeCSMP) return false;
      if (UserFiscalNumber != other.UserFiscalNumber) return false;
      if (DateTime != other.DateTime) return false;
      if (TransferredValue != other.TransferredValue) return false;
      if (Authorised != other.Authorised) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CodeCSMP.Length != 0) hash ^= CodeCSMP.GetHashCode();
      if (UserFiscalNumber.Length != 0) hash ^= UserFiscalNumber.GetHashCode();
      if (DateTime != 0L) hash ^= DateTime.GetHashCode();
      if (TransferredValue.Length != 0) hash ^= TransferredValue.GetHashCode();
      if (Authorised != false) hash ^= Authorised.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CodeCSMP.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CodeCSMP);
      }
      if (UserFiscalNumber.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UserFiscalNumber);
      }
      if (DateTime != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(DateTime);
      }
      if (TransferredValue.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TransferredValue);
      }
      if (Authorised != false) {
        output.WriteRawTag(56);
        output.WriteBool(Authorised);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CodeCSMP.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CodeCSMP);
      }
      if (UserFiscalNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserFiscalNumber);
      }
      if (DateTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(DateTime);
      }
      if (TransferredValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TransferredValue);
      }
      if (Authorised != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ValidationReply other) {
      if (other == null) {
        return;
      }
      if (other.CodeCSMP.Length != 0) {
        CodeCSMP = other.CodeCSMP;
      }
      if (other.UserFiscalNumber.Length != 0) {
        UserFiscalNumber = other.UserFiscalNumber;
      }
      if (other.DateTime != 0L) {
        DateTime = other.DateTime;
      }
      if (other.TransferredValue.Length != 0) {
        TransferredValue = other.TransferredValue;
      }
      if (other.Authorised != false) {
        Authorised = other.Authorised;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CodeCSMP = input.ReadString();
            break;
          }
          case 18: {
            UserFiscalNumber = input.ReadString();
            break;
          }
          case 24: {
            DateTime = input.ReadInt64();
            break;
          }
          case 50: {
            TransferredValue = input.ReadString();
            break;
          }
          case 56: {
            Authorised = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code