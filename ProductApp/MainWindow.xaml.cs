using System.Collections.Generic;
using System.Windows;

namespace ProductApp
{
    public partial class MainWindow : Window
    {
        Product cProduct = new Product();

        /// <summary>
        /// Initialises the main window wpf
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            // File path to the CSV file
            string filePath = "products.csv";

            // Load the products using ProductDataLoader
            List<Product> products = ProductDataLoader.LoadProducts(filePath);

            // Set the DataContext of the DataGrid to the list of products
            ProductDataGrid.ItemsSource = products;
        }

        private void ProductDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Get the selected product
            if (ProductDataGrid.SelectedItem is Product selectedProduct)
            {
                // Display the selected product details in a message box
                MessageBox.Show($"Selected Product:\nID: {selectedProduct.ProductId}\n" +
                                $"Name: {selectedProduct.ProductName}\n" +
                                $"Price: {selectedProduct.ProductPrice}\n" +
                                $"CalcCode: {selectedProduct.ProductCalcCode}");

                cProduct = selectedProduct;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Selected Product:\nID: {cProduct.ProductId}\n" +
                $"Name: {cProduct.ProductName}\n" +
                $"Price: {cProduct.ProductPrice}\n" +
                $"CalcCode: {cProduct.ProductCalcCode}");
        }
    }
}
