namespace EAMS.Models
{
    public class CompanyModel
    {
            public int ID { get; set; }
            public string CompanyName { get; set; }
            public DateTime Foundation_Date { get; set; }
            public DateTime? CreateDate { get; set; }
            public DateTime? ModifiedDate { get; set; }
            public string CreateByUserID { get; set; }
            public string ModifiedByUserID { get; set; }
    }
}
