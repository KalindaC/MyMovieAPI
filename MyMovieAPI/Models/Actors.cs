namespace MyMovieAPI.Models
{
    public class Actors
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string[] Movies { get; set; } = new string[0];
        
       // public Actors() { }
    }
}
