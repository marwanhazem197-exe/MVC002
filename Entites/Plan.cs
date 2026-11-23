namespace MVC002.Entites
{
    public class Plan : Base
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; }
        public int DurationDays { get; set; } = default!;
        public decimal Price { get; set; } = default!;
        public bool IsActive { get; set; } = default!;
        public ICollection<MemberPlan> MemberPlans { get; set; }
    }
}
