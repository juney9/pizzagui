using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PizzaProject
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        List<string> users = new List<string>();
        List<string> pass = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (users.Contains(textBox1.Text) && pass.Contains(textBox2.Text) && Array.IndexOf(users.ToArray(), textBox1.Text) == Array.IndexOf(pass.ToArray(), textBox2.Text))
            {
                this.Hide();
                pizzaOrder.pizzaOrderForm.ShowDialog();
            }
            else
                MessageBox.Show("The UserID and/or password is incorrect");
        }
            private void login_Load (object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("userinfo.txt");
            string line = "";
            while ((line==sr.ReadLine()) != null)
            {
                string [] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                pass.Add(components[1]);
            }
        }
        }
    }
