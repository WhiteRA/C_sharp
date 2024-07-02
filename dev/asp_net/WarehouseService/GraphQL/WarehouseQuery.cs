using GraphQL.Types;
using WarehouseService.Repositories;

namespace WarehouseService.GraphQL
{
    public class WarehouseQuery : ObjectGraphType
    {
        public WarehouseQuery(IWarehouseRepository repository)
        {
            Field<ListGraphType<WarehouseItemType>>(
                "items",
                resolve: context => repository.GetAllItems()
            );

            Field<WarehouseItemType>(
                "item",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }),
                resolve: context => repository.GetItemById(context.GetArgument<int>("id"))
            );
        }
    }
}
