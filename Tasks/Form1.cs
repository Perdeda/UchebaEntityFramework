using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace Tasks
{
    public partial class Form1 : Form
    {
        string id = "0";
        public static int idd;
       
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            PasswordBox.PasswordChar = '*';
            new_login.Visible = false;
            new_password.Visible = false;
            email.Visible = false;
            new_account.Visible = false;
            back.Visible = false;
            new_password.PasswordChar = '*';

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool clear = false;
            if(LoginBox.Text != "" && PasswordBox.Text != "") {
                using (MagazinContext ctx = new MagazinContext())
                {
                    foreach (Person p in ctx.People.Where(p => p.Login == LoginBox.Text && p.Password == PasswordBox.Text))
                    {

                        clear = true;
                        Form2 f = new Form2(p.PersonID);
                        this.Close();

                    }
                    if (clear == false)
                    {
                        PasswordBox.Text = "";
                        label1.Text = "Неверное имя пользователя или пароль.";
                    }
                }
            }
        }

        private void registration_Click(object sender, EventArgs e)
        {
            new_login.Visible = true;
            new_password.Visible = true;
            email.Visible = true;
            new_account.Visible = true;
            back.Visible = true;
            button1.Visible = false;
            LoginBox.Visible = false;
            PasswordBox.Visible = false;
            registration.Visible = false;
            label2.Text = "Sign up";
            label3.Visible = true;
            label4.Text = "Password";
            label5.Text = "E-mail";
        }

        private void back_Click(object sender, EventArgs e)
        {
            new_login.Visible = false;
            new_password.Visible = false;
            email.Visible = false;
            new_account.Visible = false;
            back.Visible = false;
            button1.Visible = true;
            LoginBox.Visible = true;
            PasswordBox.Visible = true;
            registration.Visible = true;
            label2.Text = "Sign in";
            label3.Visible = false;
            label4.Text = "Login";
            label5.Text = "Password";
        }
    

        private void new_account_Click(object sender, EventArgs e)
        {
            using (MagazinContext ctx = new MagazinContext())
            {
                Person p = new Person() { AccType = 0, FIO = LoginBox.Text, Login = LoginBox.Text, Password = PasswordBox.Text, PhoneNumber = 85553535 };
                ctx.People.Add(p);
                ctx.SaveChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

