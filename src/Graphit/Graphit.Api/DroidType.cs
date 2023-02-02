using GraphQL.Types;

namespace Graphit.Api;

public class DroidType : ObjectGraphType<Droid>
{
    public DroidType()
    {
        Field(x => x.Id).Description("The Id of the Droid.");
        Field(x => x.Name).Description("The name of the Droid.");
    }
}