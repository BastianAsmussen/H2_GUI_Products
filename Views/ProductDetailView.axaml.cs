using Avalonia.Controls;
using Avalonia.Interactivity;
using Products.ViewModels;

namespace Products.Views;

public partial class ProductDetailView : UserControl
{
    public ProductDetailView()
    {
        InitializeComponent();
    }

    private void OnSaveButtonClick(object? sender, RoutedEventArgs e)
    {
        // Get the product from the ProductDetailViewModel.
        var product = ProductDetailViewModel.Product;
        if (product is null) return;
        
        if (!ProductDetailViewModel.IsValidProduct(product))
        {
            SaveButton.IsEnabled = false;
            
            return;
        }
        
        // Override the product in the ProductListViewModel if it already exists, otherwise add it.
        if (ProductListViewModel.Products.Contains(product))
        {
            var index = ProductListViewModel.Products.IndexOf(product);
            
            ProductListViewModel.Products[index] = product;
        }
        else
        {
            ProductListViewModel.Products.Add(product);
        }
        
        // Hide the detail view.
        var mainWindow = (MainWindow) VisualRoot!;
        mainWindow.ProductDetailView.IsVisible = false;
        
        // Reset the DataContext of the detail view.
        mainWindow.ProductDetailView.DataContext = new ProductDetailViewModel();
    }

    private void OnCancelButtonClick(object? sender, RoutedEventArgs e)
    {
        // Hide the detail view.
        var mainWindow = (MainWindow) VisualRoot!;
        mainWindow.ProductDetailView.IsVisible = false;
        
        // Reset the DataContext of the detail view.
        mainWindow.ProductDetailView.DataContext = new ProductDetailViewModel();
    }
}