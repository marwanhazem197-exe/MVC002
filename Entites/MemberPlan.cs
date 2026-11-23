namespace MVC002.Entites
{
    public class MemberPlan : Base
    {
        public int MemberId { get; set; }
        public int PlanId { get; set; }
        public Member Member { get; set; }
        public Plan Plan { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Status => StartDate > DateTime.Now ? "Upcoming"
                                : EndDate > DateTime.Now ? "Active"
                                : "Expired";

    }
}
