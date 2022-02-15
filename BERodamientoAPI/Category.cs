using System.ComponentModel.DataAnnotations;

namespace BERodamientoAPI
{
    public class Category
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string CategoryName { get; set; } = string.Empty;
    }
}
