using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RaktarProgram
{
    public partial class Products : UserControl
    {
        readonly string[] colNames = { "id", "name", "cost" };
        readonly string[] headerNames = { "Cikkszám", "Név", "Ár" };
        readonly DBConnect conn = new DBConnect();

        public Products()
        {
            InitializeComponent();
            CreateGrids();
        }

        private void Query()
        {
            myDataGridView.Rows.Clear();
            myDataGridView.Refresh();

            try
            {
                List<string>[] queryList = conn.Select("SELECT * FROM products", colNames[0], colNames[1], colNames[2]);
                for (int i = 0; i < queryList[0].Count; i++) myDataGridView.Rows.Add(queryList[0][i], queryList[1][i], queryList[2][i] + " Ft");
            }
            catch (Exception ex) { Console.WriteLine($"Hiba történt: {ex}"); }
        }

        private void CreateGrids()
        {
            myDataGridView.Rows.Clear();
            myDataGridView.Refresh();
            for (int i = 0; i < 3; i++) myDataGridView.Columns.Add(colNames[i], headerNames[i]);
        }

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.DarkGreen;
        }

        private void BtnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Black;
        }

        private void BtnDel_MouseEnter(object sender, EventArgs e)
        {
            btnDel.BackColor = Color.DarkGreen;
        }

        private void BtnDel_MouseLeave(object sender, EventArgs e)
        {
            btnDel.BackColor = Color.Black;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            List<string>[] queryList = conn.Select("SELECT `id`, `name`  FROM products", colNames[0], colNames[1]);

            try
            {
                //Ha egyik mező se üres, és nincs az adatbázisban x nevű, y azonosítójú elem, akkor hozzáadja.
                if (tbAddNumber.Text.Length != 0 && tbAddCost.Text.Length != 0 && tbAddProduct.Text.Length != 0 && !queryList[0].Contains(tbAddNumber.Text) && !queryList[1].Contains(tbAddProduct.Text))
                {
                    conn.Insert(int.Parse(tbAddNumber.Text), tbAddProduct.Text, int.Parse(tbAddCost.Text));
                    Console.WriteLine("Beillesztve!");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void NumberChecker(KeyPressEventArgs e)
        {
            //Csak szám
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void StringChecker(KeyPressEventArgs e)
        {
            //Csak str
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }

        private void BtnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.DarkGreen;
        }

        private void BtnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.Black;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            //Ha nagyobb a szám 0-nál, del
            if (int.Parse(tbDelNumber.Text) > 0) conn.Delete(int.Parse(tbDelNumber.Text));
        }

        private void TbAddNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberChecker(e);
        }

        private void TbAddCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberChecker(e);
        }

        private void TbAddProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            StringChecker(e);
        }

        private void TbDelNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberChecker(e);
        }
    }
}
