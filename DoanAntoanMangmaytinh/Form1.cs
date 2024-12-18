using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DoanAntoanMangmaytinh
{
    public partial class Form1 : Form
    {
        private BigInteger num_p = 0, num_q = 0, num_n = 0, phi = 0, num_e = 0, num_d = 0;

        private bool IsPrime(BigInteger n)
        {
            if (n < 2) return false;
            for (BigInteger i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        private BigInteger GCD(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m, x0 = 0, x1 = 1;
            if (m == 1)
                return 0;

            while (a > 1)
            {
                BigInteger q = a / m;
                BigInteger temp = m;

                m = a % m;
                a = temp;
                temp = x0;

                x0 = x1 - q * x0;
                x1 = temp;
            }

            if (x1 < 0)
                x1 += m0;

            return x1;
        }
        private BigInteger GenerateRandomNumber(Random random, int bits)
        {
            byte[] bytes = new byte[(bits + 7) / 8];
            random.NextBytes(bytes);
            bytes[bytes.Length - 1] &= 0x7F;
            BigInteger number = new BigInteger(bytes);
            return number | (BigInteger.One << (bits - 1));
        }
        private BigInteger GeneratePrime(Random r, int bits)
        {
            BigInteger one;
            do
            {
                one = GenerateRandomNumber(r, bits);
            } while (!IsPrime(one));
            return one;
        }
        private void Find_D_and_E(Random r)
        {
            num_n = num_p * num_q;
            phi = (num_p - 1) * (num_q - 1);

            do
            {
                num_e = r.Next(2, (int)phi);
            } while (GCD(num_e, phi) != 1);

            num_d = ModInverse(num_e, phi);
        }
        private void GenerateKeyPair()
        {
            Random random = new Random();
            do
            {
                num_p = GeneratePrime(random, 1024);
                num_q = GeneratePrime(random, 1024);
            }
            while (num_p == num_q);
            Find_D_and_E(random);
        }
        private string Encrypt(string plaintext)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(plaintext);
            BigInteger[] cipherBytes = new BigInteger[bytes.Length];

            for (int i = 0; i < bytes.Length; i++)
            {
                cipherBytes[i] = BigInteger.ModPow(bytes[i], num_e, num_n);
            }

            return string.Join(" ", cipherBytes);
        }

        private string Decrypt(string ciphertext)
        {
            string[] parts = ciphertext.Split(' ');
            byte[] plainBytes = new byte[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                BigInteger cipherValue = BigInteger.Parse(parts[i]);
                plainBytes[i] = (byte)BigInteger.ModPow(cipherValue, num_d, num_n);
            }

            return Encoding.UTF8.GetString(plainBytes);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void PubicKeyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlainTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void GenerateKeyButton_Click(object sender, EventArgs e)
        {
            PTextbox.ReadOnly = true;
            QTextBox.ReadOnly = true;
            DetailNumberBox.SelectedIndex = 0;
            DetailNumberBox.Enabled = false;
        }

        private void EraseKeyButton_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            PTextbox.ReadOnly = false;
            QTextBox.ReadOnly = false;
            DetailNumberBox.Enabled = true;
        }

        private void EncyptButton_Click(object sender, EventArgs e)
        {

        }

        private void FileOpenButton1_Click(object sender, EventArgs e)
        {

        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {

        }

        private void FileOpenButton2_Click(object sender, EventArgs e)
        {

        }

        private void MoveEncryptButton_Click(object sender, EventArgs e)
        {

        }

        private void EraseTextButton1_Click(object sender, EventArgs e)
        {

        }

        private void EraseAllButton1_Click(object sender, EventArgs e)
        {

        }

        private void MoveDecryptButton_Click(object sender, EventArgs e)
        {

        }

        private void EraseTextButton2_Click(object sender, EventArgs e)
        {

        }

        private void EraseAllButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
