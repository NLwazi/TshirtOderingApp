using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using TshirtApp;

namespace TshirtApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void SaveButton_clicked(Object sender, System.EventArgs e)

            Order order = new Order()
            {
                Name = nameEntry.Text,
                Gender = genderEntry.Text,
                TshirtSize = sizeEntry.Text,
                TshirtColor = tshirtEntry.Text,
                DateOfOrder = dateEntry.Text,
                ShippingAddress = addressEntry.Text
            };
    }
    var db = new SQLiteConnection(dbPath);
    using (SQLiteConnection conn) = new SQLiteConnection(App.FilePas)
    {
         db.CreateTable<Order>();
    }
                
}

            
                


