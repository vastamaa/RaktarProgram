using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;

namespace RaktarProgram
{
    public partial class Sold : UserControl
    {
        readonly string[] colNames = { "name" };
        readonly DBConnect conn = new DBConnect();

        public Sold()
        {

            InitializeComponent();
            Query();
        }

        private void Query()
        {
            try
            {
                List<string> queryList = conn.Select("SELECT `name` FROM products", colNames[0]);
                foreach (string item in queryList) cbProduct.Items.Add(item);

                //Alapértelmezett beállítása
                dateTimePicker1.Value = DateTime.Now;
                cbProduct.SelectedIndex = 1;
                nudQuantity.Value = 1;
            }
            catch (Exception ex) { Console.WriteLine(ex); }

        }

        private void BtnSold_MouseEnter(object sender, EventArgs e)
        {
            btnSold.BackColor = Color.DarkGreen;
        }

        private void BtnSold_MouseLeave(object sender, EventArgs e)
        {
            btnSold.BackColor = Color.Black;
        }

        private void BtnSold_Click(object sender, EventArgs e)
        {
            //Eladás, ha mennyiség nagyobb mint 0
            if ((int)nudQuantity.Value > 0) conn.Insert(cbProduct.SelectedItem.ToString(), dateTimePicker1.Value.Date.ToString("yyyyMMdd"), (int)nudQuantity.Value);
        }
    }
}
