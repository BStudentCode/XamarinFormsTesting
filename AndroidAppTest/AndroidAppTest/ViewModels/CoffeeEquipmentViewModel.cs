using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AndroidAppTest.ViewModels
{
    public class CoffeeEquipmentViewModel : BindableObject
    {
        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
        }

        public ICommand IncreaseCount { get; }

        int count = 0;
        string countDisplay = "Click Me!";

        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay)
                    return;

                countDisplay = value;
                OnPropertyChanged(); //calls an event saying that a property has changed and the xaml form looks for value and updates in UI
            }
        }

        void OnIncrease()
        {
            count++;
            CountDisplay = $"You clicked {count} times";
        }
    }
}
