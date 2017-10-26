using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Symbol
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
