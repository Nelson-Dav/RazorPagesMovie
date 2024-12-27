using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Todos
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Status { get; set; }
    }
}
