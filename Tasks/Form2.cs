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
namespace Tasks
{
    public partial class Form2 : Form
    {
        public int custId;
        public Form2(int custId)
        {
            InitializeComponent();
            adminAddButton.Visible = false;
            adminDeleteButton.Visible = false;
            adminAddButton.Enabled = false;
            adminDeleteButton.Enabled = false;
            this.custId = custId;
            using (var ctx = new MagazinContext())
            {
                foreach (Painting p in ctx.Paintings)
                {
                    comboBox1.Items.Add(p.Name);
                }
                foreach (Cart c in ctx.Carts.Where(c => c.CustomerID == custId))
                {
                    comboBox2.Items.Add(c.PaintingID);
                }
                foreach (Person p in ctx.People.Where(p => p.AccType == 1 && p.AccType == custId && custId == 1))
                {
                    adminAddButton.Visible = true;
                    adminDeleteButton.Visible = true;
                    adminAddButton.Enabled = true;
                    adminDeleteButton.Enabled = true;
                }
               // Data Source = DESKTOP - DC1RU1P\SQLEXPRESS; Initial Catalog = БД; Integrated Security = True
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            minusButton.Enabled = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new MagazinContext())
            {
                ctx.SaveChanges();
            }
                Application.Exit();
        }

        private void addingButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new MagazinContext())
            {
                int Amount = 0;
               foreach( Ware w in ctx.Wares.Where(w => w.WareID == Convert.ToInt32(comboBox2.SelectedItem))){ Amount = w.Amount; }
                if (Convert.ToInt32(numLabel.Text) <= Amount)
                {
                    var cartItem = new Cart() { Amount = Convert.ToInt32(numLabel.Text), CustomerID = custId, PaintingID = Convert.ToInt32(comboBox2.SelectedItem) };
                    ctx.Carts.Add(cartItem);
                    ctx.SaveChanges();
                }
                else { MessageBox.Show("You acceeded the the storage amount:" + Amount + ", please lower it."); }
            };
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numLabel.Text) == 8)
            {
                plusButton.Enabled = false;
            }
            else
            {
                
                minusButton.Enabled = true;  
            }
            numLabel.Text = (Convert.ToInt32(numLabel.Text) + 1).ToString();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numLabel.Text) == 2)
            {
                minusButton.Enabled = false;
            }
            else
            {
                plusButton.Enabled = true;
            }
            numLabel.Text = (Convert.ToInt32(numLabel.Text) - 1).ToString();

        }

        private void cartRemoveButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new MagazinContext())
            {
                foreach (Cart c in ctx.Carts.Where(c => c.PaintingID == Convert.ToInt32(comboBox2.SelectedItem))) { ctx.Carts.Attach(c);ctx.Carts.Remove(c); }         
                ctx.SaveChanges();
            };
        }

        private void buyButton_Click(object sender, EventArgs e)
        {

            using (var ctx = new MagazinContext())
            {
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    string value = comboBox2.GetItemText(comboBox2.Items[i]);
                    foreach (Cart c in ctx.Carts.Where(c => c.PaintingID == Convert.ToInt32(value)))
                    {
                        if (custId == c.CustomerID) {
                            foreach (Ware w in ctx.Wares.Where(w => w.WareID == Convert.ToInt32(comboBox2.SelectedItem))) { w.Amount -= Convert.ToInt32(numLabel.Text); }
                            ctx.Carts.Attach(c); ctx.Carts.Remove(c);
                        }
                    }
                }
                ctx.SaveChanges();
            };
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numLabel.Text = "1";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numLabel.Text = "1";
            using (MagazinContext ctx = new MagazinContext()) {
                foreach (Painting p in ctx.Paintings.Where(p => p.Name == comboBox1.Text))
                {
                   // wareIDLabel.Text = p.Ware.ToString();
                }
            }
        }

        private void adminAddButton_Click(object sender, EventArgs e)
        {
            string Name = Prompt.ShowDialog("Name:", "Name");
            string Desctiption = Prompt.ShowDialog("Description:", "Description");
            string Artist = Prompt.ShowDialog("Artist:", "Artist");
            string Price = Prompt.ShowDialog("Price:", "Price");
            using (MagazinContext ctx = new MagazinContext())
            {
                var newItem = new Painting { Name = Name, Artist = Artist, Description = Desctiption, Price = Convert.ToInt32(Price) };
                ctx.SaveChanges();
            }
        }

        private void adminDeleteButton_Click(object sender, EventArgs e)
        {
            using (MagazinContext ctx = new MagazinContext()) 
            {
                string ID = Prompt.ShowDialog("ID:", "ID");
               foreach(Painting p in ctx.Paintings.Where(p => p.PaintingID == Convert.ToInt32(ID))){
                    ctx.Paintings.Attach(p); ctx.Paintings.Remove(p);
                }
                ctx.SaveChanges();
            }

        }

        private void inspectButton_Click(object sender, EventArgs e)
        {
            using (MagazinContext ctx = new MagazinContext())
            {
                foreach (Painting p in ctx.Paintings.Where(p => p.Name == comboBox1.Text))
                {
                    Inspect i = new Inspect(p.PaintingID);
                    i.ShowDialog();
                }
            }
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////////https://stackoverflow.com/questions/5427020/prompt-dialog-in-windows-forms
    /// </summary>
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////////https://stackoverflow.com/questions/5427020/prompt-dialog-in-windows-forms
    /// </summary>
}

