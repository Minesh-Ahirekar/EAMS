namespace EAMS.Models
{
    public class LeaveReasonModel
    {
            public int Id { get; set; }
            public string Reason { get; set; }
            public DateTime? CreatedDate { get; set; }
            public DateTime? ModifiedDate { get; set; }
    }
}
