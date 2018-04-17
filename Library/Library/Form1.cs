using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        LibraryContext context;

        public Form1()
        {
            InitializeComponent();
            context = new LibraryContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRepository repo = new UserRepository(context);
            User user = new User("test", "123");
            try
            {
                repo.InsertObject(user);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            repo.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //context.Users.Find();
            UserRepository repo = new UserRepository(context);
            List<User> users = repo.GetObjects().ToList();
            foreach (User user in users)
            {
                richTextBox1.AppendText(user.UserID.ToString() + " " + user.Login + " " + user.Password);
            }
        }
    }
}
