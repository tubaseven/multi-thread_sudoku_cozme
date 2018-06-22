using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazlab_1._2
{
    class MSudoku
    {
        int[,] matris = new int[9, 9];
        int[,] copy_matris = new int[9, 9];

        Stack<MStep> stac = new Stack<MStep>();

        public TextBox[,] sudoku_textBoxlari = new TextBox[9, 9];

        public enum Result
        {
            OK,
            NumErr,
            ColErr,
            RowErr,
            SquErr
        }

        // yapıcı metot.
        public MSudoku()
        {
            // bütün sudoku değerlerine -1 başlangıç değeri atanıyor
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matris[i, j] = -1;
                }
            }


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TextBox textbox = new TextBox();
                    textbox.TextAlign = HorizontalAlignment.Center;
                    textbox.Size = new Size(30, 30);
                    textbox.Location = new Point(j * 30 + 2, i * 30 + 2);

                    sudoku_textBoxlari[i, j] = textbox;
                }
            }


            // sahte adımlar oluşturuluyor:
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int random_number = j;
                    //AddStep(i, j, random_number);
                }
            }
        }

        private void ReadSudokuFromFile(string p_filename)
        {
            StreamReader dosya_oku = new StreamReader(p_filename);
            for (int i = 0; i < 9; i++)
            {
                string satir = dosya_oku.ReadLine();
                for (int j = 0; j < 9; j++)
                {
                    string okunan_karakter = "" + satir[j];
                    if (okunan_karakter != "*")
                    {
                        int sayi = Convert.ToInt32(okunan_karakter);
                        matris[i, j] = sayi;
                        copy_matris[i, j] = sayi;
                    }
                }
            }
        }


        private void LocateAndLoadTextBoxes(Panel p_panel)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TextBox textbox = sudoku_textBoxlari[i, j];
                    textbox.Text = "" + matris[i, j];
                    p_panel.Controls.Add(textbox);
                }
            }
        }

        public void Load(string p_filename, Panel p_panel)
        {
            //  önce dosya bir matrise yazılıyor
            ReadSudokuFromFile(p_filename);

            // sonra verilen panel üzerine matris'deki verileri içeren
            // textBox'lardan bir şekil elde ediliyor
            LocateAndLoadTextBoxes(p_panel);
        }

        public void ShowResult()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku_textBoxlari[i, j].Text = "" + matris[i, j];
                }
            }
        }


        public void Coz()
        {

            ThreadStart ts = new ThreadStart(Cozz);
            Thread th = new Thread(ts);
            th.Start();
        }


        public void Cozz()
        {
            int point_i = 0;
            int point_j = 0;


            while (!isEnd())
            {
                point_i = point_j = -1;

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (matris[i, j] == -1)
                        {
                            point_i = i;
                            point_j = j;

                            break;
                        }
                    }

                    if (point_i != -1)
                        break;
                }

                bool flag = false;
                for (int i = 1; i < 10; i++)
                {
                    if (isCorrect(point_i, point_j, i) == Result.OK)
                    {
                        flag = true;
                        matris[point_i, point_j] = i;
                        stac.Push(new MStep() { i = point_i, j = point_j, number = i });
                        //Cizdir();
                        break;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine("Conflict...");

                    int num = 0;
                    do
                    {


                        if (point_j > 0)
                        {
                            point_j--;
                            Console.WriteLine("J-AZALDI");
                        }
                        else if (point_j == 0 && point_i > 0)
                        {
                            point_i--;
                            point_j = 8;
                            Console.WriteLine("I-AZALDI");
                        }
                        else
                        {
                            Console.WriteLine("DEADLOCK:" + point_i + " - " + point_j);
                            continue;
                        }


                        // verilen rakamlara dokunulmuyor
                        if (copy_matris[point_i, point_j] != -1)
                        {
                            num = -1;
                            continue;
                        }


                        num = matris[point_i, point_j];

                        bool flag2 = false;
                        for (num = num + 1; num < 10; num++)
                        {
                            if (isCorrect(point_i, point_j, num) == Result.OK)
                            {
                                flag2 = true;
                                matris[point_i, point_j] = num;
                                stac.Push(new MStep() { i = point_i, j = point_j, number = num });
                                Console.WriteLine("Duzeltme-- " + point_i + " - " + point_j + " : " + num);
                                //Cizdir();
                                break;
                            }
                        }
                        if (flag2)
                        {
                            break;
                        }
                        else if (!flag2)
                        {
                            stac.Pop();
                            matris[point_i, point_j] = -1;
                            Console.WriteLine("Bulunamadı:Geri" + point_i + " - " + point_j + " : " + num);
                            //Cizdir();
                            continue;
                        }

                    } while (isCorrect(point_i, point_j, num) != Result.OK);
                }
            }





            /// sonuç adımlarının dosyaya yazılması:
            if (File.Exists("sonuc.txt"))
                File.Delete("sonuc.txt");

            StreamWriter yaz = new StreamWriter("sonuc.txt");
            for (int i = 0; i < stac.Count; i++)
            {
                MStep stp = stac.ElementAt(i);
                yaz.WriteLine("" + stp.i + "-" + stp.j + ":" + stp.number);
            }
            yaz.Close();

        }








        public bool isEnd()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (matris[i, j] == -1)
                        return false;
                }
            }

            return true;
        }


        public Result isCorrect(int pi, int pj, int pnumber)
        {
            if (pnumber == -1 || pnumber == 10)
                return Result.NumErr;

            for (int i = 0; i < 9; i++)
            {
                if (matris[pi, i] == pnumber)
                    return Result.RowErr;
            }

            for (int i = 0; i < 9; i++)
            {
                if (matris[i, pj] == pnumber)
                    return Result.ColErr;
            }

            int ii = pi / 3;
            int jj = pj / 3;

            for (int i = ii * 3; i < ii * 3 + 3; i++)
            {
                for (int j = jj * 3; j < jj * 3 + 3; j++)
                {
                    if (matris[i, j] == pnumber)
                        return Result.SquErr;
                }
            }


            return Result.OK;
        }


    }
}
