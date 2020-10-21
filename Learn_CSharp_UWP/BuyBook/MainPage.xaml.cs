using BuyBook.Models;
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

namespace BuyBook
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        private ObservableCollection<Contact> Contacts;
        public MainPage()
        {
            this.InitializeComponent();

            Icons = new List<Icon>();
            Icons.Add(new Icon { IconPath = "Assets/1.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/2.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/3.jpeg" });
            Icons.Add(new Icon { IconPath = "Assets/4.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/5.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/6.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/7.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/8.png" });
            Icons.Add(new Icon { IconPath = "Assets/9.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/10.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/11.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/12.jpg" });

            Contacts = new ObservableCollection<Contact>();
            Contacts.Add(new Contact { Name = "Huy", Price = "12.000", Qty = "1", CoverImg = "Assets/1.jpg" });
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string coverimg = ((Icon)CoverImgComboBox.SelectedValue).IconPath;
            Contacts.Add(new Contact { Name=NameTextBox.Text,Price=PriceTextBox.Text,
            Qty=QtyTextBox.Text,CoverImg=coverimg});

            NameTextBox.Text = "";
            PriceTextBox.Text = "";
            QtyTextBox.Text = "";
            CoverImgComboBox.SelectedIndex= - 1;

            NameTextBox.Focus(FocusState.Programmatic);
        }
    }
}
