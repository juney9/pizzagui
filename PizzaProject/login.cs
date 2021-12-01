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
        List<string> userList = new List<string>();
        List<string> userPass = new List<string>();
        public login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("userinfo.txt");
            string line;
            bool loginSuccess=false;
            while ((line = sr.ReadLine()) != null)
            {
                var components = line.Split(',');
                if (textBox1.Text == components[0] && textBox2.Text == components[1])
                {
                    loginSuccess= true;
                    break;
                }
            }
            if (loginSuccess==true)
            {
                this.Hide();
                pizzaOrder.pizzaOrderForm.ShowDialog();
            }
            else
                MessageBox.Show("The UserID and/or password is incorrect");
        }
        
    }
}
