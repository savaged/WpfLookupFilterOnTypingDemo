namespace WpfLookupFilterOnTypingDemo.Models
{
    public class SampleModel : ObservableObject
    {
        private readonly ILookupItem _countLookup;
        private int _id;
        private string _name;
        private int _numberLookupId;

        public SampleModel(
            int id, 
            string name, 
            int countId,
            ILookupItem countLookup)
        {
            _countLookup = countLookup;
            Id = id;
            Name = name;
            CountId = countId;
        }

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged();
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        public int CountId
        {
            get => _numberLookupId;
            set
            {
                _numberLookupId = value;
                RaisePropertyChanged();
                CountName = _countLookup.GetValueByKey(value);
                RaisePropertyChanged(nameof(CountName));
            }
        }

        public string CountName { get; private set; }
    }
}
