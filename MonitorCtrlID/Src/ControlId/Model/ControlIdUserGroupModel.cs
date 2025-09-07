using System.Runtime.Serialization;

namespace MonitorCtrlID.Src.ControlId.Model
{
  public partial class ControlIdUserGroupModel
  {
    [DataMember(EmitDefaultValue = false)]
    public long User_id { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public long Group_id { get; set; }
  }
}