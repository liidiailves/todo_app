using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Todo_app.Data
{
    public class TodoItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "See väli on kohustuslik")]
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ItemDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "See väli on kohustuslik")]
        [Column(TypeName = "datetime2")]
        public DateTime ItemDueDate { get; set; }
    }
}
