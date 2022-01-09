using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public partial class Inspect : Form
    {
        public Inspect(int pID)
        {
            InitializeComponent();
            using (MagazinContext ctx = new MagazinContext()) {
                foreach (Painting p in ctx.Paintings.Where(p => pID == p.PaintingID))
                {
                    nameLabel.Text = p.Name;
                    artistLabel.Text = p.Artist;
                    DesctriptLabel.Text = p.Description;
                    priceLabel.Text = p.Price.ToString();
                    idLabel.Text = p.PaintingID.ToString();
                }
            }
        }

        private void Inspect_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
