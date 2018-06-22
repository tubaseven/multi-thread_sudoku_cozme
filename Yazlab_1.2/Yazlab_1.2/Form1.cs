using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazlab_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // temel nesnemiz:
        MSudoku msudoku;

        private void Form1_Load(object sender, EventArgs e)
        {
            // nesnemizin bir örneği oluşturuluyor:
            msudoku = new MSudoku();
        }
       
        private void sudokuYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // sudoku temel halde yükleniyor:
                msudoku.Load(openFileDialog1.FileName, panel_stage);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msudoku.Coz();
        }

        MSudoku sahteSudoku;
        private void button_animateSolution_Click(object sender, EventArgs e)
        {
            sahteSudoku = new MSudoku();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sahteSudoku.sudoku_textBoxlari[i, j].Text = "";
                    
                }
            }

            MessageBox.Show(sahteSudoku.sudoku_textBoxlari[5,5].Text);

            //timer1.Start();
        }

        int i = 0;
        int j = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           // sahteSudoku.sudoku_textBoxlari[i, j].Text = "" + sahteSudoku.cozum_adimlari.Where(w => w.i == i && w.j == j).FirstOrDefault().number;
            
            if (i == 8 && j == 8)
                timer1.Stop();

            if(j==8)
            {
                j = 0;
                i++;
            }
            else
            {
                j++;
            }
                
        }

    }
}
