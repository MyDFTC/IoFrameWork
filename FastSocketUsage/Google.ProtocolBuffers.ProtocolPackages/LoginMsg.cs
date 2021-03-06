// Generated by ProtoGen, Version=2.4.1.555, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace protocol {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class LoginMsg {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_protocol_LoginReq__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::protocol.LoginReq, global::protocol.LoginReq.Builder> internal__static_protocol_LoginReq__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_protocol_LoginRsp__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::protocol.LoginRsp, global::protocol.LoginRsp.Builder> internal__static_protocol_LoginRsp__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static LoginMsg() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5Mb2dpbk1zZy5wcm90bxIIcHJvdG9jb2waEVByb3RvRGVmaW5lLnByb3Rv", 
            "Ik0KCExvZ2luUmVxEgsKA01hYxgBIAIoCRIOCgZNYWNNZDUYAiACKAkSJAoG", 
            "RGV2aWNlGAMgAigOMhQucHJvdG9jb2wuRGV2aWNlVHlwZSIYCghMb2dpblJz", 
          "cBIMCgRDb2RlGAEgAigN"));
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_protocol_LoginReq__Descriptor = Descriptor.MessageTypes[0];
        internal__static_protocol_LoginReq__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::protocol.LoginReq, global::protocol.LoginReq.Builder>(internal__static_protocol_LoginReq__Descriptor,
                new string[] { "Mac", "MacMd5", "Device", });
        internal__static_protocol_LoginRsp__Descriptor = Descriptor.MessageTypes[1];
        internal__static_protocol_LoginRsp__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::protocol.LoginRsp, global::protocol.LoginRsp.Builder>(internal__static_protocol_LoginRsp__Descriptor,
                new string[] { "Code", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::protocol.ProtoDefine.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class LoginReq : pb::GeneratedMessage<LoginReq, LoginReq.Builder> {
    private LoginReq() { }
    private static readonly LoginReq defaultInstance = new LoginReq().MakeReadOnly();
    private static readonly string[] _loginReqFieldNames = new string[] { "Device", "Mac", "MacMd5" };
    private static readonly uint[] _loginReqFieldTags = new uint[] { 24, 10, 18 };
    public static LoginReq DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override LoginReq DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override LoginReq ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::protocol.LoginMsg.internal__static_protocol_LoginReq__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<LoginReq, LoginReq.Builder> InternalFieldAccessors {
      get { return global::protocol.LoginMsg.internal__static_protocol_LoginReq__FieldAccessorTable; }
    }
    
    public const int MacFieldNumber = 1;
    private bool hasMac;
    private string mac_ = "";
    public bool HasMac {
      get { return hasMac; }
    }
    public string Mac {
      get { return mac_; }
    }
    
    public const int MacMd5FieldNumber = 2;
    private bool hasMacMd5;
    private string macMd5_ = "";
    public bool HasMacMd5 {
      get { return hasMacMd5; }
    }
    public string MacMd5 {
      get { return macMd5_; }
    }
    
    public const int DeviceFieldNumber = 3;
    private bool hasDevice;
    private global::protocol.DeviceType device_ = global::protocol.DeviceType.D_3716;
    public bool HasDevice {
      get { return hasDevice; }
    }
    public global::protocol.DeviceType Device {
      get { return device_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasMac) return false;
        if (!hasMacMd5) return false;
        if (!hasDevice) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _loginReqFieldNames;
      if (hasMac) {
        output.WriteString(1, field_names[1], Mac);
      }
      if (hasMacMd5) {
        output.WriteString(2, field_names[2], MacMd5);
      }
      if (hasDevice) {
        output.WriteEnum(3, field_names[0], (int) Device, Device);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        return CalcSerializedSize();
      }
    }
    
    private int CalcSerializedSize() {
      int size = memoizedSerializedSize;
      if (size != -1) return size;
      
      size = 0;
      if (hasMac) {
        size += pb::CodedOutputStream.ComputeStringSize(1, Mac);
      }
      if (hasMacMd5) {
        size += pb::CodedOutputStream.ComputeStringSize(2, MacMd5);
      }
      if (hasDevice) {
        size += pb::CodedOutputStream.ComputeEnumSize(3, (int) Device);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static LoginReq ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static LoginReq ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static LoginReq ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static LoginReq ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static LoginReq ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static LoginReq ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static LoginReq ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static LoginReq ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static LoginReq ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static LoginReq ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private LoginReq MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(LoginReq prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<LoginReq, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(LoginReq cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private LoginReq result;
      
      private LoginReq PrepareBuilder() {
        if (resultIsReadOnly) {
          LoginReq original = result;
          result = new LoginReq();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override LoginReq MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::protocol.LoginReq.Descriptor; }
      }
      
      public override LoginReq DefaultInstanceForType {
        get { return global::protocol.LoginReq.DefaultInstance; }
      }
      
      public override LoginReq BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is LoginReq) {
          return MergeFrom((LoginReq) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(LoginReq other) {
        if (other == global::protocol.LoginReq.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasMac) {
          Mac = other.Mac;
        }
        if (other.HasMacMd5) {
          MacMd5 = other.MacMd5;
        }
        if (other.HasDevice) {
          Device = other.Device;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_loginReqFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _loginReqFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasMac = input.ReadString(ref result.mac_);
              break;
            }
            case 18: {
              result.hasMacMd5 = input.ReadString(ref result.macMd5_);
              break;
            }
            case 24: {
              object unknown;
              if(input.ReadEnum(ref result.device_, out unknown)) {
                result.hasDevice = true;
              } else if(unknown is int) {
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                unknownFields.MergeVarintField(3, (ulong)(int)unknown);
              }
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasMac {
        get { return result.hasMac; }
      }
      public string Mac {
        get { return result.Mac; }
        set { SetMac(value); }
      }
      public Builder SetMac(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasMac = true;
        result.mac_ = value;
        return this;
      }
      public Builder ClearMac() {
        PrepareBuilder();
        result.hasMac = false;
        result.mac_ = "";
        return this;
      }
      
      public bool HasMacMd5 {
        get { return result.hasMacMd5; }
      }
      public string MacMd5 {
        get { return result.MacMd5; }
        set { SetMacMd5(value); }
      }
      public Builder SetMacMd5(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasMacMd5 = true;
        result.macMd5_ = value;
        return this;
      }
      public Builder ClearMacMd5() {
        PrepareBuilder();
        result.hasMacMd5 = false;
        result.macMd5_ = "";
        return this;
      }
      
      public bool HasDevice {
       get { return result.hasDevice; }
      }
      public global::protocol.DeviceType Device {
        get { return result.Device; }
        set { SetDevice(value); }
      }
      public Builder SetDevice(global::protocol.DeviceType value) {
        PrepareBuilder();
        result.hasDevice = true;
        result.device_ = value;
        return this;
      }
      public Builder ClearDevice() {
        PrepareBuilder();
        result.hasDevice = false;
        result.device_ = global::protocol.DeviceType.D_3716;
        return this;
      }
    }
    static LoginReq() {
      object.ReferenceEquals(global::protocol.LoginMsg.Descriptor, null);
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class LoginRsp : pb::GeneratedMessage<LoginRsp, LoginRsp.Builder> {
    private LoginRsp() { }
    private static readonly LoginRsp defaultInstance = new LoginRsp().MakeReadOnly();
    private static readonly string[] _loginRspFieldNames = new string[] { "Code" };
    private static readonly uint[] _loginRspFieldTags = new uint[] { 8 };
    public static LoginRsp DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override LoginRsp DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override LoginRsp ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::protocol.LoginMsg.internal__static_protocol_LoginRsp__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<LoginRsp, LoginRsp.Builder> InternalFieldAccessors {
      get { return global::protocol.LoginMsg.internal__static_protocol_LoginRsp__FieldAccessorTable; }
    }
    
    public const int CodeFieldNumber = 1;
    private bool hasCode;
    private uint code_;
    public bool HasCode {
      get { return hasCode; }
    }
    [global::System.CLSCompliant(false)]
    public uint Code {
      get { return code_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasCode) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _loginRspFieldNames;
      if (hasCode) {
        output.WriteUInt32(1, field_names[0], Code);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        return CalcSerializedSize();
      }
    }
    
    private int CalcSerializedSize() {
      int size = memoizedSerializedSize;
      if (size != -1) return size;
      
      size = 0;
      if (hasCode) {
        size += pb::CodedOutputStream.ComputeUInt32Size(1, Code);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static LoginRsp ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static LoginRsp ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static LoginRsp ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static LoginRsp ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static LoginRsp ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static LoginRsp ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static LoginRsp ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static LoginRsp ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static LoginRsp ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static LoginRsp ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private LoginRsp MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(LoginRsp prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<LoginRsp, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(LoginRsp cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private LoginRsp result;
      
      private LoginRsp PrepareBuilder() {
        if (resultIsReadOnly) {
          LoginRsp original = result;
          result = new LoginRsp();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override LoginRsp MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::protocol.LoginRsp.Descriptor; }
      }
      
      public override LoginRsp DefaultInstanceForType {
        get { return global::protocol.LoginRsp.DefaultInstance; }
      }
      
      public override LoginRsp BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is LoginRsp) {
          return MergeFrom((LoginRsp) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(LoginRsp other) {
        if (other == global::protocol.LoginRsp.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasCode) {
          Code = other.Code;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_loginRspFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _loginRspFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              result.hasCode = input.ReadUInt32(ref result.code_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasCode {
        get { return result.hasCode; }
      }
      [global::System.CLSCompliant(false)]
      public uint Code {
        get { return result.Code; }
        set { SetCode(value); }
      }
      [global::System.CLSCompliant(false)]
      public Builder SetCode(uint value) {
        PrepareBuilder();
        result.hasCode = true;
        result.code_ = value;
        return this;
      }
      public Builder ClearCode() {
        PrepareBuilder();
        result.hasCode = false;
        result.code_ = 0;
        return this;
      }
    }
    static LoginRsp() {
      object.ReferenceEquals(global::protocol.LoginMsg.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
