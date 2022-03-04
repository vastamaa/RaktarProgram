using System;
using System.Drawing;
using System.Windows.Forms;

namespace RaktarProgram
{
    public partial class Storage : Form
    {
        public Storage()
        {
            InitializeComponent();
            Login();
        }

        private void Login()
        {
            myPanel.Controls.Clear();
            Login login = new Login
            {
                Location = new Point(75, 0)
            };
            myPanel.Controls.Add(login);
        }

        private void TermékekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aktuális menüelem letiltása
            eladásToolStripMenuItem.Enabled = true;
            statisztikaToolStripMenuItem.Enabled = true;
            termékekToolStripMenuItem.Enabled = false;

            //UserControl csere
            myPanel.Controls.Clear();
            Products products = new Products()
            {
                Location = new Point(40, 0)
            };
            myPanel.Controls.Add(products);
        }

        private void EladásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            termékekToolStripMenuItem.Enabled = true;
            statisztikaToolStripMenuItem.Enabled = true;
            eladásToolStripMenuItem.Enabled = false;

            myPanel.Controls.Clear();
            Sold sold = new Sold
            {
                Location = new Point(70, 0)
            };
            myPanel.Controls.Add(sold);
        }

        private void StatisztikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            termékekToolStripMenuItem.Enabled = true;
            eladásToolStripMenuItem.Enabled = true;
            statisztikaToolStripMenuItem.Enabled = false;

            myPanel.Controls.Clear();
            Statistics stats = new Statistics
            {
                Location = new Point(70, 0)
            };
            myPanel.Controls.Add(stats);
        }

        public void ShowItems()
        {
            //Menü megjelenítés
            termékekToolStripMenuItem.Visible = true;
            eladásToolStripMenuItem.Visible = true;
            statisztikaToolStripMenuItem.Visible = true;
        }
    }
}
