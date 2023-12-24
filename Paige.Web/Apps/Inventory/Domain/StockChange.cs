using Paige.Web.Domain;

namespace Paige.Web.Apps.Inventory.Domain;

public class StockChange : Entity
{
    public long Id { get; set; }

    public DateTime TransactionDate { get; set; }

    public virtual Item? Item { get; set; }

    public int QuantityChange { get; set; }

    public string TransactionType { get; set; } = ""; // e.g., "Purchase", "Sale", "Adjustment"
    
    public string Notes { get; set; } = string.Empty;
}