namespace API.GraphQL.Types;

public class MovieReviewType : ObjectGraphType<Entities.MovieReview>
{
    public MovieReviewType()
    {
        Name = "MovieReview";
        Description = "A review for a movie.";
        Field(x => x.Id).Description("The unique identifier of the review.");
        Field(x => x.Rate).Description("The rating given to the movie.");
        Field(x => x.Comment).Description("The comment provided in the review.");
        Field(x => x.CreatedAt).Description("The date and time when the review was created.");
        Field(x => x.MovieId).Description("The unique identifier of the movie being reviewed.");
        ////Field<Entities.MovieType>("movie", resolve: context => context.Source.Movie);
    }
}

