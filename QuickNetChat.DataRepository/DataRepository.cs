namespace QuickNetChat.DataRepository
{
    public class DataRepository
    {
        public DataRepository()
        {
            new DataContext().FirstInit();
        }

        public DataContext GetContext()
        {
            return new DataContext();
        }
    }
}