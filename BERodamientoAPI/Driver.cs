using System.ComponentModel.DataAnnotations;

namespace BERodamientoAPI
{
    public class Driver
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string Country { get; set; } = string.Empty;

        [StringLength(50)]
        public string Team { get; set; } = string.Empty;

        [Range(1,99)]
        public int Number { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
