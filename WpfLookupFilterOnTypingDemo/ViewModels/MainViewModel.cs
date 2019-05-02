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
            NumbersLookup = new List<LookupItem>
            {
                new LookupItem(1, "One"),
                new LookupItem(2, "Two"),
                new LookupItem(3, "Three"),
                new LookupItem(4, "Four"),
                new LookupItem(5, "Five")
            };
            NumberLookupSelected = new LookupItem();
        }

        public IList<LookupItem> NumbersLookup { get; }

        public int NumberSelection
        {
            get => _numberSelection;
            set
            {
                _numberSelection = value;
                RaisePropertyChanged();

                NumberLookupSelected = 
                    NumbersLookup.SingleOrDefault(l => l.Key == value);
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
