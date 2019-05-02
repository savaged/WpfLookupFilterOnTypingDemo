using System.Collections.Generic;

namespace WpfLookupFilterOnTypingDemo.Models
{
    public class LookupItem : ObservableObject
    {
        private readonly IDictionary<int, string> _lookup;
        private int _key;
        private string _value;

        public LookupItem()
            : this(0, null)
        { }

        public LookupItem(
            int key,
            IDictionary<int, string> lookup)
        {
            _lookup = lookup;
            Key = key;
        }

        public int Key
        {
            get => _key;
            set
            {
                _key = value;
                RaisePropertyChanged();

                Value = _lookup?[_key] ?? string.Empty;
            }
        }

        public string Value
        {
            get => _value;
            set
            {
                _value = value;
                RaisePropertyChanged();
            }
        }
    }
}
