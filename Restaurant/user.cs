using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class user : Form
    {
       LoginForm loginForm;
        public user(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            this.FormClosing +=userFormClosing;
            InitializeComponent();
        }

        private void userFormClosing(object sender, FormClosingEventArgs e)
        {
            //loginForm.Show();
            Application.Exit();

        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
