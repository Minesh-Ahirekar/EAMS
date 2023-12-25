namespace EAMS.Models
{
    public class EmployeeModel
    {
            public int Id { get; set; }
            public string EmpName { get; set; }
            public int? EmpID { get; set; }
            public int? Age { get; set; }
            public int? Sex { get; set; }
            public string MobileNumber { get; set; }
            public string PersonalEmailId { get; set; }
            public string OfficialEmailId { get; set; }
            public int? DeptId { get; set; }
            public int? CompanyID { get; set; }
            public int? EmpUserRoleID { get; set; }
            public string UserName { get; set; }
            public byte[] Password { get; set; }
            public string EmployeeImage { get; set; }
            public DateTime? EmpDOB { get; set; }
            public DateTime? EmpJoiningDate { get; set; }
            public DateTime? EmpLastDate { get; set; }
            public DateTime? CreatedDate { get; set; }
            public DateTime? ModifiedDate { get; set; }
            public DateTime? IsActive { get; set; }
            public string CreateByUserID { get; set; }
            public string ModifiedByUserID { get; set; }
    }
}
