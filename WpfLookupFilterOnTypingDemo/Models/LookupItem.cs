namespace WpfLookupFilterOnTypingDemo.Models
{
    public class LookupItem : ObservableObject
    {
        private int _key;

        public LookupItem()
            : this(0, "")
        { }

        public LookupItem(
            int key, 
            string value)
        {
            _key = key;
            Value = value;
        }

        public int Key
        {
            get => _key;
            set
            {
                _key = value;
                RaisePropertyChanged();
            }
        }

        public string Value { get; }
    }
}
