using System.Collections.ObjectModel;
using System.Linq;
using Products.Models;

namespace Products.ViewModels;

public class ProductListViewModel : ViewModelBase
{
    public static ObservableCollection<Product> Products => new()
    {
        new Product("Apple", "A red apple", 1.99m, 0.99m, 10, StockUnit.Piece),
        new Product("Banana", "A yellow banana", 2.99m, 1.99m, 5, StockUnit.Piece),
        new Product("Orange", "A orange orange", 3.99m, 2.99m, 3, StockUnit.Piece),
        new Product("Pineapple", "A yellow pineapple", 4.99m, 3.99m, 1, StockUnit.Piece),
        new Product("Strawberry", "A red strawberry", 5.99m, 4.99m, 0.5f, StockUnit.Kilograms),
        new Product("Blueberry", "A blue blueberry", 6.99m, 5.99m, 0.5f, StockUnit.Kilograms),
        new Product("Raspberry", "A red raspberry", 7.99m, 6.99m, 0.5f, StockUnit.Kilograms),
        new Product("Blackberry", "A black blackberry", 8.99m, 7.99m, 0.5f, StockUnit.Kilograms),
        new Product("Cherry", "A red cherry", 9.99m, 8.99m, 0.5f, StockUnit.Kilograms),
        new Product("Grape", "A purple grape", 10.99m, 9.99m, 0.5f, StockUnit.Kilograms),
        new Product("Watermelon", "A green watermelon", 11.99m, 10.99m, 0.5f, StockUnit.Kilograms),
        new Product("Melon", "A yellow melon", 12.99m, 11.99m, 0.5f, StockUnit.Kilograms),
        new Product("Peach", "A yellow peach", 13.99m, 12.99m, 0.5f, StockUnit.Kilograms),
        new Product("Pear", "A yellow pear", 14.99m, 13.99m, 0.5f, StockUnit.Kilograms),
    };

    private Product[] _filteredProducts => Products.Where(p => !p.IsHidden).ToArray();
    public Product[] FilteredProducts => _filteredProducts;
}