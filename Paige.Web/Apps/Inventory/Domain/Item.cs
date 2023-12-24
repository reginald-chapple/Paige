using Paige.Web.Domain;

namespace Paige.Web.Apps.Inventory.Domain;

public class Item : Entity
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int QuantityInStock { get; set; }

    public string Category { get; set; } = string.Empty;

    public virtual ICollection<StockChange> Changes { get; set; } =  new List<StockChange>();
}