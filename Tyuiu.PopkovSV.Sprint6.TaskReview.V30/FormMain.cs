using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PopkovSV.Sprint6.TaskReview.V30.Lib;

namespace Tyuiu.PopkovSV.Sprint6.TaskReview.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Random rn = new Random();
        DataService ds = new DataService();
        private void buttonHelp_PSV_Click(object sender, EventArgs e)
        {
            FormAbout_PSV formAbout = new FormAbout_PSV();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        

        private void buttonDone_PSV_Click(object sender, EventArgs e)
        {
            int stroke = Convert.ToInt32(textBoxStroke_PSV.Text);
            int columns = Convert.ToInt32(textBoxColumns_PSV.Text);

            int StartStep = Convert.ToInt32(textBoxStart_PSV.Text);
            int StopStep = Convert.ToInt32(textBoxEnd_PSV.Text);


            dataGridViewMatrix_PSV.RowCount = stroke;
            dataGridViewMatrix_PSV.ColumnCount = columns;

            int[,] mtrx = new int[dataGridViewMatrix_PSV.RowCount, dataGridViewMatrix_PSV.ColumnCount];
            int[] array = new int[] { };
            for (int i = 0; i < dataGridViewMatrix_PSV.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewMatrix_PSV.ColumnCount; j++)
                {
                    int r = rn.Next(StartStep, StopStep);
                    mtrx[j, i] = r;
                }
            }

            for (int r = 0; r < mtrx.GetLength(0); r++)
            {
                for (int i = 0; i < mtrx.GetLength(1); i++)
                {
                    for (int j = i + 1; j < mtrx.GetLength(1); j++)
                    {
                        if (mtrx[r, i] < mtrx[r, j])
                        {
                            int tmp = mtrx[r, i];
                            mtrx[r, i] = mtrx[r, j];
                            mtrx[r, j] = tmp;
                        }
                    }
                }
            }

            int w = mtrx.GetLength(0);
            int h = mtrx.GetLength(1);

            int[,] mtrxT = new int[h, w];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    mtrxT[j, i] = mtrx[i, j];
                }
            }


            try
            {


                for (int i = 0; i < stroke; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMatrix_PSV.Rows[j].Cells[i].Value = Convert.ToString(mtrxT[j, i]);
                    }
                }

                int StrokeNum = Convert.ToInt32(textBoxChooseStroke_PSV.Text);
                int FirstCol = Convert.ToInt32(textBoxStartColumn_PSV.Text);
                int LastCol = Convert.ToInt32(textBoxEndColumn_PSV.Text);

                textBoxOutPut_PSV.Text = Convert.ToString(ds.GetMatrix(mtrxT, StrokeNum, FirstCol, LastCol));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        
    }
    

}
