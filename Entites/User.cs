namespace MVC002.Entites
{
    public class User : Base
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public DateOnly DOB { get; set; } 
        public Gender Gender { get; set; } 
        public Address Address { get; set; } = default!;

    }
}
