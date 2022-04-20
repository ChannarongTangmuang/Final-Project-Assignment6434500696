using System.Text;

namespace Final_Project_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                string readAllText = File.ReadAllText(openFileDialog.FileName);
                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string allDATARAW = readAllLine[i];
                    string[] allDATASplited = allDATARAW.Split(',');
                    this.dataGridView1.Rows.Add(allDATASplited[0], allDATASplited[1], allDATASplited[2], allDATASplited[3]);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string column = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                column += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += column;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(saveFileDialog.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

        private void buttonConfrim_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                string model1 = "รุ่น All Star สีขาว(ข้อสั้น) ";
                string price1 = "1900";
                textBoxAA.Text = model1;
                textBoxBB.Text = price1;
            }
            if (radioButton2.Checked == true)
            {
                string model2 = "รุ่น All Star สีแดง(ข้อสั้น)  ";
                string price2 = "2100";
                textBoxAA.Text = model2;
                textBoxBB.Text = price2;
            }
            if (radioButton3.Checked == true)
            {
                string model3 = "รุ่น All Star สีดำ(ข้อสั้น)  ";
                string price3 = "1900";
                textBoxAA.Text = model3;
                textBoxBB.Text = price3;
            }
            if (radioButton4.Checked == true)
            {
                string model4 = "รุ่น All Star สีเทา(ข้อสั้น)";
                string price4 = "1900";
                textBoxAA.Text = model4;
                textBoxBB.Text = price4;
            }
            if (radioButton5.Checked == true)
            {
                string model5 = "รุ่น All Star สีน้ำเงิน(ข้อสั้น)";
                string price5 = "2100";
                textBoxAA.Text = model5;
                textBoxBB.Text = price5;
            }
            if (radioButton6.Checked == true)
            {
                string model6 = "รุ่น All Star สีชมพู(หุ้มข้อ)";
                string price6 = "2300";
                textBoxAA.Text = model6;
                textBoxBB.Text = price6;
            }
            if (radioButton7.Checked == true)
            {
                string model7 = "รุ่น All Star สีเขียว(หุ้มข้อ)";
                string price7 = "2300";
                textBoxAA.Text = model7;
                textBoxBB.Text = price7;
            }
            if (radioButton8.Checked == true)
            {
                string model8 = "รุ่น All Star สีขาว(หุ้มข้อ)";
                string price8 = "2100";
                textBoxAA.Text = model8;
                textBoxBB.Text = price8;
            }
            if (radioButton9.Checked == true)
            {
                string model9 = "รุ่น All Star สีดำ(หุ้มข้อ)";
                string price9 = "2100";
                textBoxAA.Text = model9;
                textBoxBB.Text = price9;
            }
            if (radioButton10.Checked == true)
            {
                string model10 = "รุ่น All Star สีแดง(หุ้มข้อ)";
                string price10 = "2100";
                textBoxAA.Text = model10;
                textBoxBB.Text = price10;
            }
            if(radioButton11.Checked == true)
            {
                string model11 = "รุ่น One Star สีมัสตาร์ด";
                string price11 = "2200";
                textBoxAA.Text = model11;
                textBoxBB.Text = price11;
            }
            if (radioButton12.Checked == true)
            {
                string model12 = "รุ่น One Star สีดำ";
                string price12 = "2200";
                textBoxAA.Text = model12;
                textBoxBB.Text = price12;
            }
            if (radioButton13.Checked == true)
            {
                string model13 = "รุ่น One Star สีเขียวขี้ม้า";
                string price13 = "2000";
                textBoxAA.Text = model13;
                textBoxBB.Text = price13;
            }
            if (radioButton14.Checked == true)
            {
                string model14 = "รุ่น Jack Purcell สีกรม";
                string price14 = "1900";
                textBoxAA.Text = model14;
                textBoxBB.Text = price14;
            }
            if (radioButton15.Checked == true)
            {
                string model15 = "รุ่น Jack Purcell สีขาว";
                string price15 = "1900";
                textBoxAA.Text = model15;
                textBoxBB.Text = price15;
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            int Bank = Convert.ToInt32(textBoxDD.Text);
            int Bill = Convert.ToInt32(textBoxEE.Text);
            int sum = Bill - Bank;
            dataGridView1.Rows[n].Cells[5].Value = sum.ToString();

            string aa = textBoxAA.Text;
            string bb = textBoxBB.Text;
            string cc = textBoxCC.Text;
            string dd = textBoxDD.Text;
            string ee = textBoxEE.Text;           

            dataGridView1.Rows[n].Cells[0].Value = aa;
            dataGridView1.Rows[n].Cells[1].Value = bb;
            dataGridView1.Rows[n].Cells[2].Value = cc;
            dataGridView1.Rows[n].Cells[3].Value = dd;
            dataGridView1.Rows[n].Cells[4].Value = ee;

            textBoxAA.Text = "";
            textBoxBB.Text = "";
            textBoxCC.Text = "";
            textBoxDD.Text = "";
            textBoxEE.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBoxBB.Text);
            int change = Convert.ToInt32(textBoxCC.Text);
            int sum = price * change;
            textBoxDD.Text = sum.ToString();
        }
    }
}