namespace WpfLookupFilterOnTypingDemo.Models
{
    public class SampleModel : ObservableObject
    {
        private int _id;
        private string _name;
        private int _numberLookupId;

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
            }
        }

        public string CountName { get; private set; }
    }
}
