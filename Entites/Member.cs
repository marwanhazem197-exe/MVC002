namespace MVC002.Entites
{
    public class Member : User
    {
        public string Photo { get; set; } = default!;
        public ICollection<MemberPlan> MemberPlans { get; set; }
    }
}
