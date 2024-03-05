using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Todolist
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> items;
        public MainPage()
        {
            InitializeComponent();
            items = new ObservableCollection<string>()
            {"Zakupy: chleb, masło, ser","Do zrobienia: obiad, umyć podłogi", "weekend: kino, spacer z psem"};
            lista.ItemsSource = items;
        }
      
        private void Button_Clicked(object sender, EventArgs e)
        {
            string text = tresc.Text;
            items.Add(text);
            tresc.Text = "";
        }
    }
}
