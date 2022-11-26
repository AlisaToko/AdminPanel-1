using AdminPanel.Interfaces;

namespace AdminPanel.Models
{
    public class Partners : AllTableInt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
