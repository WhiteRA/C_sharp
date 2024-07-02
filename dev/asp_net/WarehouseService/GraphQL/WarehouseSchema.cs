using GraphQL;
using GraphQL.Types;

namespace WarehouseService.GraphQL
{
    public class WarehouseSchema : Schema
    {
        public WarehouseSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<WarehouseQuery>();
        }
    }
}
