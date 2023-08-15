using System;
using Products.Models;

namespace Products.ViewModels;

public class ProductDetailViewModel : ViewModelBase
{
    public static StockUnit[] StockUnits { get; } = Enum.GetValues<StockUnit>();

    public static Product? Product { get; set; }
    
    public static bool IsValidProduct(Product product)
    {
        return !string.IsNullOrWhiteSpace(product.Name) &&
               !string.IsNullOrWhiteSpace(product.Description) &&
               product.SalesPrice > 0 &&
               product.PurchasePrice > 0 &&
               product.Stock > 0;
    }
}