using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnlineStore.Models

{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage ="You're fucking dumb")]
        public int DisplayOrder { get; set; }
    }
}
