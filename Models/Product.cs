using Avalonia;

namespace Products.Models;

public class Product : AvaloniaObject
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

    public string Name
    {
        get => GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }

    public string Description
    {
        get => GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }

    public decimal SalesPrice
    {
        get => GetValue(SalesPriceProperty);
        set => SetValue(SalesPriceProperty, value);
    }

    public decimal PurchasePrice
    {
        get => GetValue(PurchasePriceProperty);
        set => SetValue(PurchasePriceProperty, value);
    }

    public float Stock
    {
        get => GetValue(StockProperty);
        set => SetValue(StockProperty, value);
    }

    public StockUnit StockUnit
    {
        get => GetValue(StockUnitProperty);
        set => SetValue(StockUnitProperty, value);
    }

    public bool IsHidden
    {
        get => GetValue(IsHiddenProperty);
        set => SetValue(IsHiddenProperty, value);
    }

    public static readonly StyledProperty<string> NameProperty =
        AvaloniaProperty.Register<Product, string>(nameof(Name));

    public static readonly StyledProperty<string> DescriptionProperty =
        AvaloniaProperty.Register<Product, string>(nameof(Description));

    public static readonly StyledProperty<decimal> SalesPriceProperty =
        AvaloniaProperty.Register<Product, decimal>(nameof(SalesPrice));

    public static readonly StyledProperty<decimal> PurchasePriceProperty =
        AvaloniaProperty.Register<Product, decimal>(nameof(PurchasePrice));

    public static readonly StyledProperty<float> StockProperty =
        AvaloniaProperty.Register<Product, float>(nameof(Stock));

    public static readonly StyledProperty<StockUnit> StockUnitProperty =
        AvaloniaProperty.Register<Product, StockUnit>(nameof(StockUnit));

    public static readonly StyledProperty<bool> IsHiddenProperty =
        AvaloniaProperty.Register<Product, bool>(nameof(IsHidden));
}