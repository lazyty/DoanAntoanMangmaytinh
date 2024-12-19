using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanAntoanMangmaytinh
{
    public partial class Playfair : Form
    {

        private char[,] playfairMatrix;
        private int MatrixSize = 5;


        public Playfair()
        {
            InitializeComponent();
        }

        //tạo ma trận 
        private void TaoMaTran(string key)
        {
            string alphabet = MatrixSize == 5 ? "ABCDEFGHIKLMNOPQRSTUVWXYZ" : "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string TachKituKey = string.Concat(key.ToUpper().Distinct().Where(char.IsLetterOrDigit)) + alphabet;
            TachKituKey = string.Concat(TachKituKey.Distinct());

            playfairMatrix = new char[MatrixSize, MatrixSize];
            for (int i = 0; i < MatrixSize * MatrixSize; i++)
            {
                playfairMatrix[i / MatrixSize, i % MatrixSize] = TachKituKey[i];
            }

            //
            HienThiLenTable();
        }

        private void HienThiLenTable()
        {
            datagridMatrix.Rows.Clear();
            datagridMatrix.Columns.Clear();

            //Tao cot
            for (int i = 0; i < MatrixSize; i++)
            {
                datagridMatrix.Columns.Add(i.ToString(), "");
                datagridMatrix.Columns[i].Width = 50;
            }

            for (int i = 0; i < MatrixSize; i++)
            {
                datagridMatrix.Rows.Add();
                for (int j = 0; j < MatrixSize; j++)
                {
                    datagridMatrix.Rows[i].Cells[j].Value = playfairMatrix[i, j];
                }
            }
        }

        private string DieuChinhVanban(string text)
        {
            text = text.ToUpper().Replace("J", "I").Replace(" ", " ");
            for (int i = 0; i < text.Length - 1; i += 2)
            {
                if (text[i] == text[i + 1])
                {
                    text = text.Insert(i + 1, "X");
                }
            }
            if (text.Length % 2 != 0)
            {
                text += "X";
            }
            return text;
        }

        private (int, int) TimViTriKiTu(char c)
        {
            try
            {

                for (int row = 0; row < MatrixSize; row++)
                {
                    for (int col = 0; col < MatrixSize; col++)
                    {
                        if (playfairMatrix[row, col] == c)
                            return (row, col);
                    }
                }
                return (-1, -1);
            }
            catch (Exception e)
            {
                return (-1, -1);
                
            }
        }

        private string Encrypt(string plaintext)
        {
            string ciphertext = "";
            plaintext = DieuChinhVanban(plaintext);
            for (int i = 0; i < plaintext.Length; i += 2)
            {
                var vitri1 = TimViTriKiTu(plaintext[i]);
                var vitri2 = TimViTriKiTu(plaintext[i + 1]);

                
                if (vitri1.Item1 == vitri2.Item1) // cung mot dong
                {
                    ciphertext += playfairMatrix[vitri1.Item1, (vitri1.Item2 + 1) % MatrixSize];
                    ciphertext += playfairMatrix[vitri2.Item1, (vitri2.Item2 + 1) % MatrixSize];

                }
                else if (vitri1.Item2 == vitri2.Item2) // cung cot
                {
                    ciphertext += playfairMatrix[(vitri1.Item1 + 1) % MatrixSize, vitri1.Item2];
                    ciphertext += playfairMatrix[(vitri2.Item1 + 1) % MatrixSize, vitri2.Item2];
                }
                else
                {
                    ciphertext += playfairMatrix[vitri1.Item1, vitri2.Item2];
                    ciphertext += playfairMatrix[vitri2.Item1, vitri1.Item2];
                }

            }

            return ciphertext;
        }

        private string Decrypt(string ciphertext)
        {
            string plaintext = "";
            for (int i = 0; i < ciphertext.Length; i += 2)
            {
                var vitri1 = TimViTriKiTu(ciphertext[i]);
                var vitri2 = TimViTriKiTu(ciphertext[i + 1]);



                if (vitri1.Item1 == vitri2.Item1) // cung dong
                {
                    plaintext += playfairMatrix[vitri1.Item1, (vitri1.Item2 + MatrixSize - 1) % MatrixSize];
                    plaintext += playfairMatrix[vitri2.Item1, (vitri2.Item2 + MatrixSize - 1) % MatrixSize];
                }
                else if (vitri1.Item2 == vitri2.Item2)
                {
                    plaintext += playfairMatrix[(vitri1.Item1 + MatrixSize - 1) % MatrixSize, vitri1.Item2];
                    plaintext += playfairMatrix[(vitri2.Item1 + MatrixSize - 1) % MatrixSize, vitri2.Item2];
                }
                else
                {
                    plaintext += playfairMatrix[vitri1.Item1, vitri2.Item2];
                    plaintext += playfairMatrix[vitri2.Item1, vitri1.Item2];
                }

            }
            return plaintext;
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_RandomKey_Click(object sender, EventArgs e)
        {

        }

        private void Playfair_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoMaTran_Click(object sender, EventArgs e)
        {
            TaoMaTran(tb_key.Text.Trim());
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            rtb_DauRa.Text = Encrypt(rtb_DauVao.Text);
        }

        private void btn_GiaMa_Click(object sender, EventArgs e)
        {
            rtb_DauRa.Text = Decrypt(rtb_DauVao.Text);
        }

        private void btn_DichNguoc_Click(object sender, EventArgs e)
        {
            rtb_DauVao.Text = Decrypt(rtb_DauRa.Text);
        }
    }
}
