using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symplex_method
{
    public partial class Form1 : Form
    {
        int it = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(3);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView2.Rows.Add(3);
            dataGridView1.RowTemplate.Height = 30;
            iterativeTable.Rows.Add(3);
            dataGridView4.Rows.Add();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            dataGridView5.Rows.Add();
            dataGridView5.Rows[0].HeaderCell.Value = "F=";
        }

        bool validate()
        {
            for (int j = 0; j < 4; ++j)
            {
                dynamic val = dataGridView5[j, 0].Value;
                if (val == null || val.ToString().Length == 0)
                {
                    return false;
                }
            }

            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    dynamic val = dataGridView1[j, i].Value;
                    if (val == null || val.ToString().Length == 0)
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < 3; ++i)
            {
                dynamic val = dataGridView2[0, i].Value;
                if (val == null || val.ToString().Length == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public void initTable()
        {
            for (int i = 0; i < dataGridView5.ColumnCount; i++)
            {
                dataGridView4.Rows[0].Cells[i + 1].Value = -Convert.ToInt32(dataGridView5.Rows[0].Cells[i].Value);
            }

            iterativeTable["x5", 0].Value = 1;
            iterativeTable["x6", 1].Value = 1;
            iterativeTable["x7", 2].Value = 1;

            iterativeTable["x5", 1].Value = 0;
            iterativeTable["x5", 2].Value = 0;

            iterativeTable["x6", 0].Value = 0;
            iterativeTable["x6", 2].Value = 0;

            iterativeTable["x7", 0].Value = 0;
            iterativeTable["x7", 1].Value = 0;

            iterativeTable["basis", 0].Value = "x5";
            iterativeTable["basis", 1].Value = "x6";
            iterativeTable["basis", 2].Value = "x7";

            iterativeTable["CBasis", 0].Value = 0;
            iterativeTable["CBasis", 1].Value = 0;
            iterativeTable["CBasis", 2].Value = 0;

            iterativeTable["freeColumn", 0].Value = dataGridView2[0, 0].Value;
            iterativeTable["freeColumn", 1].Value = dataGridView2[0, 1].Value;
            iterativeTable["freeColumn", 2].Value = dataGridView2[0, 2].Value;

            for (int i = 0; i < 3; i++) { 
                for (int j = 1; j <= 4; j++)
                {
                    iterativeTable["x" + j.ToString(), i].Value = dataGridView1["matrixX" + j.ToString(), i].Value;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (it == 0)
            {
                if (validate())
                {
                    initTable();
                }
                else
                {
                    MessageBox.Show("Не всі поля заповнені");
                    return;
                }
                
            }



            ++this.it;
        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
