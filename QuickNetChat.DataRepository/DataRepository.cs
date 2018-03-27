using System.Threading.Tasks;

namespace QuickNetChat.DataRepository
{
    public class DataRepository
    {
        public DataRepository()
        {
            new Task(async () => { await new DataContext().FirstInit(); }).Start();
        }

        public DataContext GetContext()
        {
            return new DataContext();
        }
    }
}