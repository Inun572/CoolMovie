using System.Text.Json.Serialization;
using Application.Movies.DTO;

namespace Application.Profile.DTO;

public class ProfileDTO
{
    [JsonIgnore]
    public string Id { get; set; }
    
    public string DisplayName { get; set; } = string.Empty;
    public string UserName { get; set; }
    public string Bio { get; set; } = string.Empty;
    public ICollection<MovieDTO> FavoriteMovies { get; set; }
}
