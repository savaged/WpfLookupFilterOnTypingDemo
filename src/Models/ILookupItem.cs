namespace WpfLookupFilterOnTypingDemo.Models
{
    public interface ILookupItem
    {
        int Key { get; set; }
        string Value { get; set; }

        string GetValueByKey(int key);
    }
}