using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MonitorCtrlID.Src.ControlId.Model
{
  public partial class UserGroupsModel
  {
    //[DataMember(EmitDefaultValue = false)]
    //public Int64 user_id { get; set; }
    //[DataMember(EmitDefaultValue = false)]
    //public int group_id { get; set; }

    [JsonPropertyName("user_id")]
    public Int64 user_id { get; set; }

    [JsonPropertyName("group_id")]
    public int group_id { get; set; }
  }
}
