using GraphQL.Types;

namespace Graphit.Api;

public class StarWarsQuery : ObjectGraphType
{
    public StarWarsQuery()
    {
        Field<DroidType>("hero")
            .Resolve(context => new Droid { Id = "1", Name = "R2-D2" });
    }
}