using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndroidAppTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipmentPage : ContentPage
    {
        public CoffeeEquipmentPage()
        {
            InitializeComponent();

            LabelCount.Text = "You clicked 0 times";
            //ButtonClick.Clicked += ButtonClick_Clicked; <--can be called from c# codebehind or xaml itself, useful to call in xaml as you know what event each element is pointing to
        }

        int count = 0;

        private void ButtonClick_Clicked(object sender, EventArgs e)
        {
            //can check which button triggered method with var button = sender as Button   button?.
            count++;
            LabelCount.Text = $"You clicked {count} times";
        }
    }
}