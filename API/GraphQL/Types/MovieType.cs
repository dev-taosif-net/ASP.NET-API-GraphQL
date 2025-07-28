using API.GraphQL.Types.Enum;

namespace API.GraphQL.Types;

public class MovieType : ObjectGraphType<Entities.Movie>
{
    public MovieType()
    {
        Name = "Movie";
        Description = "A movie entity";
        Field(x => x.Id).Description("The unique identifier of the movie.");
        Field(x => x.Name).Description("The name of the movie.");
        Field(x => x.Description).Description("A brief description of the movie.");
        Field(x => x.LaunchDate).Description("The release date of the movie.");
        Field<MovieGenreType>("genre");
        Field<MovieReviewType>("review");
        //Field<ListGraphType<MovieReviewType>>(
        //    "reviews",
        //    resolve: context => context.Source.Reviews
        //);
    }
}

