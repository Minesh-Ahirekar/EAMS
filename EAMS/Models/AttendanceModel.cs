using System.Data;

namespace EAMS.Models
{
    public class AttendanceModel
    {
            public int ID { get; set; }
            public int EmployeeID { get; set; }
            public DateTime? PunchIn { get; set; }
            public DateTime? PunchOut { get; set; }
            public int LoginType { get; set; }
            public string SelfieImage { get; set; }
            public string EmployeeLocation { get; set; }
            public string Latitute { get; set; }
            public bool? OnLeave { get; set; }
            public int? LeaveType { get; set; }
    }
}
