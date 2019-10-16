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
            dataGridView3.Rows.Add(3);
            dataGridView4.Rows.Add();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            dataGridView5.Rows.Add();
            dataGridView5.Rows[0].HeaderCell.Value = "F=";
        }

        public void zap_simp_tab()
        {
            for (int i = 0; i < dataGridView5.ColumnCount; i++)
            {
                dataGridView4.Rows[0].Cells[i + 1].Value = -Convert.ToInt32(dataGridView5.Rows[0].Cells[i].Value);
            }
            for (int i = 0; i < 4; i++) { 
                for (int j = 0; j < 3; j++)
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zap_simp_tab();
        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
