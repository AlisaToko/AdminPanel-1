using AdminPanel.Interfaces;

namespace AdminPanel.Models
{
    public class News : AllTableInt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Picture> Pictures { get; set; }
         public News()
        {
            Pictures = new List<Picture>(); 
        }

    }
}
