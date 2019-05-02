using System.Data;

namespace WpfLookupFilterOnTypingDemo.Data
{
    public class SampleDatabase
    {
        static SampleDatabase()
        {
            Default = new SampleDatabase();
        }

        public static SampleDatabase Default
        { get; private set; }

        private SampleDatabase()
        {
            var t = new DataTable();
            t.Columns.Add("Id", typeof(int));
            t.Columns.Add("Name", typeof(string));
            t.Columns.Add("CountId", typeof(int));
            t.Rows.Add(new object[] { 1, "Apple", 2 });
            t.Rows.Add(new object[] { 2, "Pear", 2 });
            t.Rows.Add(new object[] { 3, "Orange", 2 });
            SampleTable = t;

            t = new DataTable();
            t.Columns.Add("Id", typeof(int));
            t.Columns.Add("Name", typeof(string));
            t.Rows.Add(new object[] { 1, "One" });
            t.Rows.Add(new object[] { 2, "Two" });
            t.Rows.Add(new object[] { 3, "Three" });
            t.Rows.Add(new object[] { 4, "Four" });
            t.Rows.Add(new object[] { 5, "Five" });
            t.Rows.Add(new object[] { 6, "Six" });
            LookupTable = t;
        }

        public DataTable SampleTable { get; }

        public DataTable LookupTable { get; }
    }
}
