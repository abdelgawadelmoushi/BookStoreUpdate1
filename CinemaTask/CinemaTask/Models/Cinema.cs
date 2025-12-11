using System.ComponentModel.DataAnnotations;

namespace CinemaTask.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Img { get; set; } = "defaultMovie.png";
        public string? Description { get; set; }

        public bool Status { get; set; } = true;
        public int CinemaId { get; internal set; }
    }
}
