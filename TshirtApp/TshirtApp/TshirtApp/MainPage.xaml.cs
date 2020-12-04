using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace TshirtApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void SaveButton_clicked(Object sender, System.EventArgs e)

            Name name = new Name()
            {
                Name = nameEntry.Text,
                Gender = genderEntry.Text,
                TshirtSize = sizeEntry.Text,
                DateOfOrder = dateEntry.Text,
                TshirtColor = tshirtEntry.Text,
                DateOfOrder = dateEntry.Text,
                ShippingAddress = addressEntry.Text
            };
    }       using(SQLiteConnection conn= new SQLiteConnection(App.FilePath))
            {
        
            }
}
