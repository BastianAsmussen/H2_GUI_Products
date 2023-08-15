using System;
using Avalonia.Controls;
using Products.Models;
using Products.ViewModels;

namespace Products.Views;

public partial class ProductListView : UserControl
{
    public ProductListView()
    {
        InitializeComponent();
    }

    private void OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        var mainWindow = (MainWindow) VisualRoot!;
        
        // Get the selected product.
        var selection = (Product) e.AddedItems[0]!;
        // Set the product as the Product property of the ProductDetailViewModel.
        ProductDetailViewModel.Product = selection;
        
        // Create a new instance of the ProductDetailViewModel and set it as the DataContext of the detail view.
        mainWindow.ProductDetailView.DataContext = new ProductDetailViewModel();
        // Show the detail view.
        mainWindow.ProductDetailView.IsVisible = true;
        
    }
}