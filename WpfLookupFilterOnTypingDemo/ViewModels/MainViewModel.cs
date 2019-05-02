using System.Collections.Generic;
using System.Linq;
using WpfLookupFilterOnTypingDemo.Models;

namespace WpfLookupFilterOnTypingDemo.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private int _numberSelection;
        private LookupItem _numberLookupSelected;

        public MainViewModel()
        {
            NumbersLookup = new Dictionary<int, string>
            {
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" },
                { 4, "Four" },
                { 5, "Five" },
                { 6, "Six" }
            };
            NumberLookupSelected = new LookupItem();
        }

        public IDictionary<int, string> NumbersLookup { get; }

        public int NumberSelection
        {
            get => _numberSelection;
            set
            {
                _numberSelection = value;
                RaisePropertyChanged();

                NumberLookupSelected = 
                    new LookupItem(value, NumbersLookup);
            }
        }

        public LookupItem NumberLookupSelected
        {
            get => _numberLookupSelected;
            set
            {
                _numberLookupSelected = value;
                RaisePropertyChanged();
            }
        }
    }
}
