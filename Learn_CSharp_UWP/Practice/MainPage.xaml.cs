using Practice.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Practice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        private ObservableCollection<Product> Products;
        public MainPage()
        {
            this.InitializeComponent();

            Icons = new List<Icon>();
            Icons.Add(new Icon { IconPath = "Assets/13.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/14.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/15.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/16.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/9.jpg" });

            Products = new ObservableCollection<Product>();
            Products.Add(new Product { ProductName = "Thuoc Ke", Description = "abcd", Image = "Assets/16.jpg" });
        }

        private void NewProductButton_Click(object sender, RoutedEventArgs e)
        {
            string image = ((Icon)ImageComboBox.SelectedValue).IconPath;
            Products.Add(new Product
            {
                ProductName = ProductTextBox.Text,
                Description = DescriptionTextBox.Text,
                Image = image
            });

            ProductTextBox.Text = "";
            DescriptionTextBox.Text = "";
            ImageComboBox.SelectedIndex = -1;

            ProductTextBox.Focus(FocusState.Programmatic);
        }
    }
}
