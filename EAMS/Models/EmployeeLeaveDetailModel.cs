namespace EAMS.Models
{
    public class EmployeeLeaveDetailModel
    {
            public int ID { get; set; }
            public int? EmpID { get; set; }
            public int? TotalLeave { get; set; }
            public int? ApprovedRequestedLeaved { get; set; }
            public int? BalancedLeaves { get; set; }
            public DateTime? CreatedDate { get; set; }
            public DateTime? ModifiedDate { get; set; }
            public int? LastYearCarryFwdLeaves { get; set; }
    }
}
