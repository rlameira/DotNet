using System.Runtime.Serialization;

namespace MonitorCtrlID.Src.ControlId.Model
{
  public partial class ControlIdUserModel
  {
    
//{"users":[{"id":871,"registration":"","name":"ADELCIO PEREIRA DOS SANTOS","password":"","salt":"","expires":0,"user_type_id":0,"begin_time":1735689600,"end_time":2082758340,"image_timestamp":1756069013,"last_access":0}]}
//public int Id { get; set; }
//public string Name { get; set; }
//public string Registration { get; set; } = "";
//public string password { get; set; } = "";
// Atenção no iDAccess todos os numeros são sempre long (64bits)
    [DataMember(EmitDefaultValue = false)]
    public long Id { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string Name { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string Registration { get; set; } = "";
    [DataMember(EmitDefaultValue = false)]
    public string Password { get; set; } = "";
    [DataMember(EmitDefaultValue = false)]
    public string Salt { get; set; } = "";

    public long User_type_id { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public long begin_time { get; set; } = 1735689600;
    [DataMember(EmitDefaultValue = false)]
    public long end_time { get; set; } = 2082758340;
    [DataMember(EmitDefaultValue = false)]
    public long last_access { get; set; }
      
    //[DataMember(EmitDefaultValue = false)]
    //public long id; 
    //[DataMember(EmitDefaultValue = false)]
    //public string name;
    //[DataMember(EmitDefaultValue = false)]
    //public string registration;

  }
}
