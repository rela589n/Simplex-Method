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
        int baseCol = -1;
        int baseRow = -1;
        Dictionary<String, double> baseCoefs = new Dictionary<string, double>();

        bool found = false;
        bool success = true;
        public Form1()
        {
            InitializeComponent();
        }

        void initBaseCoefs()
        {
            for (int i = 1; i <= 4; ++i)
            {
                this.baseCoefs.Add("x" + i, double.Parse(dataGridView5["startX" + i, 0].Value.ToString()));
            }
            for (int i = 5; i <= 7; ++i)
            {
                this.baseCoefs.Add("x" + i, 0.0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(3);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView2.Rows.Add(3);
            dataGridView1.RowTemplate.Height = 30;
            iterativeTable.Rows.Add(3);
            dzTable.Rows.Add();

            /*
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            */
            dataGridView5.Rows.Add();
            dataGridView5.Rows[0].HeaderCell.Value = "F=";

            dataGridView1.Rows[0].Cells[0].Value = 2;
            dataGridView1.Rows[1].Cells[0].Value = 0;
            dataGridView1.Rows[2].Cells[0].Value = 2;

            dataGridView1.Rows[0].Cells[1].Value = 2;
            dataGridView1.Rows[1].Cells[1].Value = 1;
            dataGridView1.Rows[2].Cells[1].Value = 1;

            dataGridView1.Rows[0].Cells[2].Value = 4;
            dataGridView1.Rows[1].Cells[2].Value = 2;
            dataGridView1.Rows[2].Cells[2].Value = 0;

            dataGridView1.Rows[0].Cells[3].Value = 5;
            dataGridView1.Rows[1].Cells[3].Value = 2;
            dataGridView1.Rows[2].Cells[3].Value = 6;

            dataGridView5.Rows[0].Cells[0].Value = 2;
            dataGridView5.Rows[0].Cells[1].Value = 4;
            dataGridView5.Rows[0].Cells[2].Value = 6;
            dataGridView5.Rows[0].Cells[3].Value = 1;

            dataGridView2.Rows[0].Cells[0].Value = 28;
            dataGridView2.Rows[1].Cells[0].Value = 10;
            dataGridView2.Rows[2].Cells[0].Value = 14;
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

        int calculateBaseCol()
        {
            int baseCol = -1;

            double minVal = double.PositiveInfinity;
            for (int j = 1; j <= 7; ++j)
            {
                double val = double.Parse(dzTable["dzX" + j.ToString(), 0].Value.ToString());

                if (minVal > val)
                {
                    baseCol = j;
                    minVal = val;
                }
            }

            return (minVal < 0) ? baseCol : -1;
        }

        int calculateBaseRow()
        {
            int row = -1;
            double minVal = double.PositiveInfinity;

            for (int i = 0; i < 3; ++i)
            {
                double v;
                if (double.TryParse(iterativeTable["teta", i].Value.ToString(), out v))
                {
                    if (minVal > v)
                    {
                        minVal = v;
                        row = i;
                    }
                }
            }

            return row;
        }

        bool calculateTeta(int baseRow)
        {
            bool set = false;
            for (int i = 0; i < 3; ++i)
            {
                double a = double.Parse(iterativeTable["freeColumn", i].Value.ToString());
                double x = double.Parse(iterativeTable["x" + baseRow, i].Value.ToString());

                if (x == 0 || a / x < 0)
                {
                    iterativeTable["teta", i].Value = float.NaN;
                }
                else
                {
                    set = true;
                    iterativeTable["teta", i].Value = Math.Round(a / x, 8);
                }
            }

            return set;
        }


        public void initTable()
        {
            for (int i = 0; i < dataGridView5.ColumnCount; i++)
            {
                dzTable.Rows[0].Cells[i + 1].Value = -Convert.ToInt32(dataGridView5.Rows[0].Cells[i].Value);
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

            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    iterativeTable["x" + j.ToString(), i].Value = dataGridView1["matrixX" + j.ToString(), i].Value;
                }
            }

            dzTable[0, 0].Value = 0;
            for (int j = 5; j <= 7; ++j)
            {
                dzTable["dzX" + j.ToString(), 0].Value = 0;
            }

            this.baseCol = calculateBaseCol();
            if (baseCol == -1)
            {
                this.found = true;
                showResult();
            }
            else if (!calculateTeta(baseCol))
            {
                MessageBox.Show("Задача не має розв'язку!");
            }
            else
            {
                this.baseRow = calculateBaseRow();
            }
        }

        double calulateRectangle(int row, int col)
        {
            if (row == baseRow)
            {
                if (col == baseCol)
                {
                    return 1;
                }

                return double.Parse(iterativeTable[col + 2, row].Value.ToString()) /
                    double.Parse(iterativeTable[baseCol + 2, baseRow].Value.ToString());

            }
            if (baseCol == col)
            {
                return 0;
            }

            double baseEl = double.Parse(iterativeTable[baseCol + 2, baseRow].Value.ToString());
            double first = double.Parse(iterativeTable[col + 2, baseRow].Value.ToString());
            double currentEl;
            double second;

            if (row < 3)
            {
                currentEl = double.Parse(iterativeTable[col + 2, row].Value.ToString());
                second = double.Parse(iterativeTable[baseCol + 2, row].Value.ToString());
            }
            else
            {
                row = 0;
                currentEl = double.Parse(dzTable[col, row].Value.ToString());
                second = double.Parse(dzTable[baseCol, row].Value.ToString());
            }

            return (currentEl * baseEl - first * second) / baseEl;
        }

        void changeBaseVar()
        {
            String columnName = iterativeTable.Columns[baseCol + 2].Name;
            iterativeTable[0, baseRow].Value = columnName;
            iterativeTable[1, baseRow].Value = baseCoefs[columnName];
        }

        void showResult()
        {
            List<String> resultVars = new List<String>();

            for (int i = 0; i < 3; ++i)
            {
                resultVars.Add(iterativeTable["basis", i].Value.ToString());
            }

            StringBuilder ans = new StringBuilder("(");

            for (int i = 1; i <= 4; ++i)
            {
                String app;
                int indx = resultVars.FindIndex(x => x == "x" + i);
                if (indx != -1)
                {
                    app = iterativeTable["freeColumn", indx].Value.ToString();
                }
                else
                {
                    app = "0";
                }

                ans.Append(app);

                if (i != 4)
                {
                    ans.Append(", ");
                }
                else
                {
                    ans.Append(")");
                }
            }
            MessageBox.Show(ans.ToString());
            textBoxResult.Text = ans.ToString();
            textBoxMax.Text = dzTable[0, 0].Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (it == 0)
            {
                if (validate()) //////////////////////////////////////
                {
                    initBaseCoefs();
                    initTable();
                }
                else
                {
                    MessageBox.Show("Не всі поля заповнені");
                    return;
                }

            }
            else
            {
                if (this.found)
                {
                    MessageBox.Show("Відповідь вже знайдена!");
                    return;
                }
                else if (!this.success)
                {
                    MessageBox.Show("Задача не має відповіді!");
                    return;
                }
                changeBaseVar();

                Dictionary<String, double>[] dict = new Dictionary<String, double>[4];

                for (int i = 0; i < 4; ++i)
                {
                    dict[i] = new Dictionary<string, double>();

                    dict[i].Add("freeColumn", calulateRectangle(i, 0));
                    for (int j = 1; j <= 7; ++j)
                    {
                        dict[i].Add("x" + j, calulateRectangle(i, j));
                    }
                }

                for (int i = 0; i < 3; ++i)
                {
                    foreach (var el in dict[i])
                    {
                        iterativeTable[el.Key, i].Value = Math.Round(el.Value, 8);
                    }
                }

                foreach (var el in dict[3])
                {
                    dzTable["dz" + el.Key.ToUpper(), 0].Value = Math.Round(el.Value, 8);
                }

                this.baseCol = calculateBaseCol();
                if (baseCol == -1)
                {
                    this.found = true;
                    showResult();
                }
                else if (!calculateTeta(baseCol))
                {
                    MessageBox.Show("Задача не має розв'язку!");
                }
                else
                {
                    this.baseRow = calculateBaseRow();
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

        private void Button3_Click(object sender, EventArgs e)
        {
            do
            {
                button2_Click(sender, e);
            }
            while (this.success && !this.found);
        }
    }
}
