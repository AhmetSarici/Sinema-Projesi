namespace sineweb.webui.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsLoad { get; set; }
    }
}