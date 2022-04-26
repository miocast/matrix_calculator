using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace matrix_calculator
{


        public partial class Form1 : Form
        {
        public Form1()
        {
            InitializeComponent();
        }

        private void size1_Click(object sender, EventArgs e)
        {

        }

       
        //матрица А
        private void createA_Click(object sender, EventArgs e)
        {
            int n;
            int.TryParse(sizeA.Text, out n);
            matrixA.RowCount = n;
            matrixA.ColumnCount = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixA.Columns[j].Width = 60;
                }
            }
        }

        //матрица В
        private void createB_Click(object sender, EventArgs e)
        {
            int n;
            int.TryParse(sizeB.Text, out n);
            matrixB.RowCount = n;
            matrixB.ColumnCount = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixB.Columns[j].Width = 60;
                }
            }
        }

        //сумма матриц
        private void plus_Click(object sender, EventArgs e)
        {
            try
            {
                if (sizeA.Text == sizeB.Text)
                {
                    int n;
                    int.TryParse(sizeB.Text, out n);
                    omatrix.RowCount = n;
                    omatrix.ColumnCount = n;
                    int[,] a = new int[n, n];
                    int[,] b = new int[n, n];
                    int[,] c = new int[n, n];
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            a[i, j] = Convert.ToInt32(matrixA[i, j].Value);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            b[i, j] = Convert.ToInt32(matrixB[i, j].Value);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                        {
                            c[i, j] = a[i, j] + b[i, j];
                            omatrix[i, j].Value = c[i, j];
                        }
                }
                else
                    MessageBox.Show("Складывать можно только матрицы одинакового размера");
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }
        }

        //вычитание матриц 
        private void minus_Click(object sender, EventArgs e)
        {
            try
            {
                if (sizeA.Text == sizeB.Text)
                {
                    int n;
                    int.TryParse(sizeB.Text, out n);
                    omatrix.RowCount = n;
                    omatrix.ColumnCount = n;
                    int[,] a = new int[n, n];
                    int[,] b = new int[n, n];
                    int[,] c = new int[n, n];
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            a[i, j] = Convert.ToInt32(matrixA[i, j].Value);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            b[i, j] = Convert.ToInt32(matrixB[i, j].Value);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                        {
                            c[i, j] = a[i, j] - b[i, j];
                            omatrix[i, j].Value = c[i, j];
                        }
                }
                else
                    MessageBox.Show("Ошибка", "Вычитать можно только матрицы одинакового размера");
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }

        }

        //умножние матриц
        private void multiply_Click(object sender, EventArgs e)
        {
            try
            {
                if (sizeA.Text == sizeB.Text)
                {
                    int n, v;
                    int.TryParse(sizeB.Text, out n);
                    omatrix.RowCount = n;
                    omatrix.ColumnCount = n;
                    int[,] a = new int[n, n];
                    int[,] b = new int[n, n];
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            a[j, i] = Convert.ToInt32(matrixA[i, j].Value);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            b[j, i] = Convert.ToInt32(matrixB[i, j].Value);

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            v = 0;
                            for (int r = 0; r < n; r++)
                                v += a[i, r] * b[r, j];
                            omatrix[i, j].Value = v;

                        }
                    }
                }

                else
                    MessageBox.Show("Ошибка", "Умножать матрицы можно только когда количество столбцов первой матрицы равно количеству строк второй матрицы");
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }
        }

        //транспонирование матрицы А
        private void trans1_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int.TryParse(sizeA.Text, out n);

                omatrix.RowCount = n;
                omatrix.ColumnCount = n;
                int[,] a = new int[n, n];
                int[,] c = new int[n, n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        a[i, j] = Convert.ToInt32(matrixA[i, j].Value);
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        c[i, j] = a[j, i];
                        omatrix[i, j].Value = c[i, j];
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Матрица введена некорректно");
            }
        }

        //транспонирование матрицы В
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int n;
                int.TryParse(sizeB.Text, out n);

                omatrix.RowCount = n;
                omatrix.ColumnCount = n;
                int[,] a = new int[n, n];
                int[,] c = new int[n, n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        a[i, j] = Convert.ToInt32(matrixB[i, j].Value);
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        c[i, j] = a[j, i];
                        omatrix[i, j].Value = c[i, j];
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Матрица введена некорректно");
            }
        }

        //возведение в степень матрицы А
        private void powA_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int.TryParse(sizeA.Text, out n);
                omatrix.RowCount = n;
                omatrix.ColumnCount = n;
                int[,] c = new int[n, n];
                int[,] b = new int[n, n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        c[j, i] = Convert.ToInt32(matrixA[i, j].Value);
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        b[j, i] = Convert.ToInt32(matrixA[i, j].Value);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        double z = 0;
                        for (int r = 0; r < n; r++)
                            z += b[j, r] * c[r, i];
                        omatrix[i, j].Value = z;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }
        }

        //возведение в степень матрицы В
        private void powB_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int.TryParse(sizeA.Text, out n);
                omatrix.RowCount = n;
                omatrix.ColumnCount = n;
                int[,] c = new int[n, n];
                int[,] b = new int[n, n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        c[j, i] = Convert.ToInt32(matrixB[i, j].Value);
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        b[j, i] = Convert.ToInt32(matrixB[i, j].Value);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        double z = 0;
                        for (int r = 0; r < n; r++)
                            z += b[j, r] * c[r, i];
                        omatrix[i, j].Value = z;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }
        }

        //нахождение минимального эдемента матрицы А
        private void minA_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int.TryParse(sizeA.Text, out n);
                int[,] a = new int[n, n];
                int min = a[0, 0];
          
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        a[i, j] = Convert.ToInt32(matrixA[i, j].Value);

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if (min > a[i, j])
                            min = a[i, j];
                    }
                
                answer.Text = Convert.ToString(min);

            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }
        }

        //нахождение минимального элемента матрицы А
        private void minB_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int.TryParse(sizeB.Text, out n);
                int[,] a = new int[n, n];
                int min = a[0, 0];

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        a[i, j] = Convert.ToInt32(matrixB[i, j].Value);

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if (min > a[i, j])
                            min = a[i, j];
                    }

                answer.Text = Convert.ToString(min);

            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }
        }

        //нахождение максимального элемента матрицы А
        private void maxA_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int.TryParse(sizeA.Text, out n);
                int[,] a = new int[n, n];
                int max = a[0, 0];

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        a[i, j] = Convert.ToInt32(matrixA[i, j].Value);

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if (max < a[i, j])
                            max = a[i, j];
                    }
                
                answer.Text = Convert.ToString(max);

            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }
        }

        //нахождение максимального элемента матрицы В
        private void maxB_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int.TryParse(sizeB.Text, out n);
                int[,] a = new int[n, n];
                int max = a[0, 0];

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        a[i, j] = Convert.ToInt32(matrixB[i, j].Value);

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if (max < a[i, j])
                            max = a[i, j];
                    }

                answer.Text = Convert.ToString(max);

            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }
        }

        private void sumnum_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int.TryParse(sizeA.Text, out n);
                omatrix.RowCount = n;
                omatrix.ColumnCount = n;

                int[,] b = new int[n, n];

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        b[j, i] = Convert.ToInt32(matrixA[i, j].Value);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        double z = 0;

                        z += b[i, j] * Convert.ToInt32(number.Text);
                        omatrix[j, i].Value = z;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }

            
        }

        private void mulnumB_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int.TryParse(sizeB.Text, out n);
                omatrix.RowCount = n;
                omatrix.ColumnCount = n;

                int[,] b = new int[n, n];

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        b[j, i] = Convert.ToInt32(matrixB[i, j].Value);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        double z = 0;

                        z += b[i, j] * Convert.ToInt32(number.Text);
                        omatrix[j, i].Value = z;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            matrixA.Rows.Clear();
            matrixB.Rows.Clear();
        }

        private void omatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void matrixA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
