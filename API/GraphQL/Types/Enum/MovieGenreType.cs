namespace API.GraphQL.Types.Enum;

public class MovieGenreType : EnumerationGraphType<Entities.Enums.MovieGenre>
{
    public MovieGenreType()
    {
        Name = "Movie Genre";
        Description = "The genre of the movie.";
    }
}
