namespace MVC002.Entites
{
    public class Session : Base
    {
        public string Description { get; set; } = default!;
        public int Capacity { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TrainerId { get; set; } 
        public Trainer Trainer { get; set; } = default!;
    }
}
