namespace AdminPanel.Models
{
    public class Picture
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public int NewsId { get; set; } //foreign key
        public News News { get; set; } //навигационное роле
        public string? Path { get; set; }
        public bool IsMain { get; set; }
    }
}
