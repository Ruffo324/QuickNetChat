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
        private void button3_Click(object sender, EventArgs e)
        {
            using (var Context = Program.DataRepository.GetContext())

            {
                //lumber-Expression:  // Filter-Condition
                User user1 = Context.Users.FirstOrDefault((usr) => usr.Id == 5);

                List<DataRepository.Entitys.Message> messages =
                    Context.Messages.Where((msg) => msg.Text.Contains("Nguyen") && msg.Channel.Id == 5).ToList();
                foreach (DataRepository.Entitys.Message msg in messages)
                {
                    //msg.Text
                }
                //messages.Count


                if (user1 != null)
                {
                    button3.Text = user1.Name;
                    user1.Name = $"{DateTime.Now}";
                    Context.SaveChanges();
                    //int x = int.Parse();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Task(() =>
            {
                int i = 0;
                label1.Text = "";
                while (true)
                {
                    i++;
                    label1.Text = i.ToString();
                    Application.DoEvents();
                }
            }).RunSynchronously();
        }
    }
}
