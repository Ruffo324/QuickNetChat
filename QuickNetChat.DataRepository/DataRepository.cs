using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickNetChat.DataRepository
{
    public class DataRepository
    {
        public DataRepository()
        {
            new DataContext().FirstInit();
        }

        public static DataContext GetContext()
        {
            return new DataContext();
        }
    }
}