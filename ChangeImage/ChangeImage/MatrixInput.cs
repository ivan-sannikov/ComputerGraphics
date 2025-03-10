using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChangeImage
{
    public partial class MatrixInput : Form
    {
        public int[,] Matrix { get; private set; }

        public MatrixInput()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(RowsTextBox.Text, out int n))
            {
                if (n > 0)
                {
                    MatrixInputContainer.Controls.Clear();
                    MatrixInputContainer.RowStyles.Clear();
                    MatrixInputContainer.ColumnStyles.Clear();
                    MatrixInputContainer.RowCount = n;
                    MatrixInputContainer.ColumnCount = n;
                    for (int i = 0; i < n; i++)
                    {
                        MatrixInputContainer.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    }
                    for (int j = 0; j < n; j++)
                    {
                        MatrixInputContainer.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    }
                    for (int i = 0; i < n; i++)
                    {
                        MatrixInputContainer.RowCount++;
                        MatrixInputContainer.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        for (int j = 0; j < n; j++)
                        {
                            TextBox textBox = new TextBox
                            {
                                Width = 50,
                                Margin = new Padding(5),
                                Tag = new Tuple<int, int>(i, j), 
                                Text = "1"
                            };
                            MatrixInputContainer.Controls.Add(textBox, j, i);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Rows and columns must be greater than 0.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid input for rows or columns.", "Error");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(RowsTextBox.Text, out int n))
            {
                Matrix = new int[n, n];
                foreach (Control control in MatrixInputContainer.Controls)
                {
                    if (control is TextBox textBox && textBox.Tag is Tuple<int, int> coords)
                    {
                        int i = coords.Item1;
                        int j = coords.Item2;
                        if (int.TryParse(textBox.Text, out int value))
                        {
                            Matrix[i, j] = value;
                        }
                        else
                        {
                            MessageBox.Show("Invalid input in matrix.", "Error");
                            return;
                        }
                    }
                }
                DialogResult = DialogResult.OK; 
                Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}