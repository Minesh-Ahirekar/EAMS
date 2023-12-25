namespace EAMS.Models
{
    public class LeaveRequestTableModel
    {
            public int Id { get; set; }
            public int? EmpID { get; set; }
            public int? ReasonID { get; set; }
            public DateTime? CreatedDate { get; set; }
            public DateTime? ModifiedDate { get; set; }
            public int? IsApproved { get; set; }
            public int? ApproveByEmp { get; set; }
            public int? NoOfDaysLeave { get; set; }
            public DateTime? LeaveFrom { get; set; }
            public DateTime? LeaveTO { get; set; }
    }
}
