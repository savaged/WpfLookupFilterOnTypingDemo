using System.Collections.Generic;
using WpfLookupFilterOnTypingDemo.Models;
using WpfLookupFilterOnTypingDemo.Services;

namespace WpfLookupFilterOnTypingDemo.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private readonly ISampleModelService _modelService;
        private SampleModel _selectedModel;

        public MainViewModel(
            ISampleModelService modelService,
            ILookupService lookupService)
        {
            _modelService = modelService;

            NumbersLookup = lookupService
                .GetLookup(nameof(NumbersLookup));

            SelectedModel = _modelService.Show(1);
        }

        public IDictionary<int, string> NumbersLookup { get; }        

        public SampleModel SelectedModel
        {
            get => _selectedModel;
            set
            {
                _selectedModel = value;
                RaisePropertyChanged();
            }
        }
    }
}
