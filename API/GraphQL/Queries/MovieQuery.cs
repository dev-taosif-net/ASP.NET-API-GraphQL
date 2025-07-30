
using API.Entities;
using API.GraphQL.Types;
using GraphQL;
using Microsoft.EntityFrameworkCore;

namespace API.GraphQL.Queries;

public class MovieQuery : ObjectGraphType
{
    public MovieQuery(ApplicationDbContext db)
    {
        Field<ListGraphType<MovieType>>("movies")  
            .Description("Gets all movies")
            .ResolveAsync(async context => await db.Movies.ToListAsync());

        Field<MovieType>("movie")
            .Arguments(new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>>() { Name = "id" }))
            .ResolveAsync(async context =>
            {
                var id = context.GetArgument<int>("id");
                return await db.Movies.SingleAsync(a => a.Id == id);
            });
    }

}




