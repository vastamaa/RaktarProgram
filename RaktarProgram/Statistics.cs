using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace RaktarProgram
{
    public partial class Statistics : UserControl
    {
        //Oszlop/Cimke nevek
        readonly string[] colNames = { "name", "quantity" };
        readonly string[] headerNames = { "Termék", "Összmennyiség" };
        readonly DBConnect conn = new DBConnect();

        public Statistics()
        {
            InitializeComponent();
            CreateGrids();
            Query();
        }

        private void Query()
        {
            //Ürítés
            myDataGridView.Rows.Clear();
            myDataGridView.Refresh();

            try
            {
                //Lekérdezés, Grid feltöltés
                List<string>[] queryList = conn.Select("SELECT `name`, SUM(`quantity`) as quantity FROM `sold` GROUP BY `name`;", colNames[0], colNames[1]);
                for (int i = 0; i < queryList[0].Count; i++) myDataGridView.Rows.Add(queryList[0][i], queryList[1][i]);
            }
            catch (Exception ex) { Console.WriteLine($"Hiba történt: {ex}"); }
        }

        private void CreateGrids()
        {
            myDataGridView.Rows.Clear();
            myDataGridView.Refresh();
            for (int i = 0; i < 2; i++) myDataGridView.Columns.Add(colNames[i], headerNames[i]);

        }

        private void BtnPrint_MouseEnter(object sender, EventArgs e)
        {
            btnPrint.BackColor = Color.DarkGreen;
        }

        private void BtnPrint_MouseLeave(object sender, EventArgs e)
        {
            btnPrint.BackColor = Color.Black;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //Nyomtatás
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Raktár - Statisztika";
            printDialog.Document = printDoc;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            //Call ShowDialog  
            if (printDialog.ShowDialog() == DialogResult.OK) printDoc.Print();
        }
    }
}
