using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickNetChat.DataRepository.Entitys;

namespace QuickNetChat.Client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var Context = Program.DataRepository.GetContext())
            {

                User user1 = new User() { Name = "user1" };
                //new DataRepository.Entitys.User() { Name = "TQN", Mail = "test@web.de" }
                Context.Users.Add(user1);
                // Program.DataRepository.GetContext().Users.Add(new User() { Name = "TQN", Mail = "test@web.de" });
                Context.SaveChanges();
            }
        }
    }
}
