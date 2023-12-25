namespace EAMS.Models
{
    public class EmployeeUserRolesModel
    {
            public int ID { get; set; }
            public string RoleName { get; set; }
            public DateTime? CreatedDate { get; set; }
            public DateTime? ModifiedDate { get; set; }
            public string CreateByUserID { get; set; }
            public string ModifiedByUserID { get; set; }
    }
}
