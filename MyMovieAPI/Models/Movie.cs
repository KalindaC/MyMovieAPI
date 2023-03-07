namespace MyMovieAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate{ get; set;}

        public DateTime UpdatedDate { get; set;}
        public int ActorId { get; set; }

    }
}
