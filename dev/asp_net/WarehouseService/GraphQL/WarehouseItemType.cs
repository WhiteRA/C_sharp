using WarehouseService.Models;

namespace WarehouseService.GraphQL
{
    public class WarehouseItemType : ObjectGraphType<WarehouseItem>
    {
        public WarehouseItemType()
        {
            Field(x => x.Id).Description("Item ID");
            Field(x => x.Name).Description("Item name");
            Field(x => x.Quantity).Description("Item quantity");
        }
    }
}
