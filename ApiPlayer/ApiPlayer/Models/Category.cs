using System.ComponentModel.DataAnnotations;

namespace ApiPlayer.Models
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }
        public string NameCategory { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
