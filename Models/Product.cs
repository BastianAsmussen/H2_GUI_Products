namespace Products.Models;

public class Product
{
    public Product(string name, string description, decimal salesPrice, decimal purchasePrice, float stock,
        StockUnit stockUnit, bool isHidden = false)
    {
        Name = name;
        Description = description;
        
        SalesPrice = salesPrice;
        PurchasePrice = purchasePrice;
        
        Stock = stock;
        StockUnit = stockUnit;
        
        IsHidden = isHidden;
    }
    
    public string Name { get; set; }
    public string Description { get; set; }

    public decimal SalesPrice { get; set; }
    public decimal PurchasePrice { get; set; }

    public float Stock { get; set; }
    public StockUnit StockUnit { get; set; }
    
    public bool IsHidden { get; set; }
}