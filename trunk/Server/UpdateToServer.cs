//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: client.proto
namespace Client
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateToServer")]
  public partial class UpdateToServer : global::ProtoBuf.IExtensible
  {
    public UpdateToServer() {}
    

    private Client.ThrustUpdate _Thrust = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Thrust", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Client.ThrustUpdate Thrust
    {
      get { return _Thrust; }
      set { _Thrust = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ThrustUpdate")]
  public partial class ThrustUpdate : global::ProtoBuf.IExtensible
  {
    public ThrustUpdate() {}
    
    private int _Angle;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Angle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Angle
    {
      get { return _Angle; }
      set { _Angle = value; }
    }
    private int _Distance;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Distance", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Distance
    {
      get { return _Distance; }
      set { _Distance = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}