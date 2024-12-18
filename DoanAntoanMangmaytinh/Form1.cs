using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private bool IsJustNumberAndSpace(string content)
        {
            foreach (char c in content)
            {
                if (!char.IsDigit(c) && c != ' ')
                {
                    return false;
                }
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
                if (one % 2 == 0)
                    one++;
            } while (!IsPrime(one));
            return one;
        }
        private void Find_D_and_E()
        {
            Random r = new Random();
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
                num_p = GeneratePrime(random, 8);
                num_q = GeneratePrime(random, 8);
            }
            while (num_p == num_q);
            Find_D_and_E();

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
            StringBuilder plainTextBuilder = new StringBuilder();

            for (int i = 0; i < parts.Length; i++)
            {
                BigInteger cipherValue = BigInteger.Parse(parts[i]);
                BigInteger decryptedValue = BigInteger.ModPow(cipherValue, num_d, num_n);


                plainTextBuilder.Append((char)(decryptedValue));
            }

            return plainTextBuilder.ToString();
        }
        private bool IsBinary(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsHexadecimal(string input)
        {
            foreach (char c in input)
            {
                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
                {
                    return false;
                }
            }
            return true;
        }
        private BigInteger ParseBinary(string binaryText)
        {
            return BigInteger.Parse(binaryText, System.Globalization.NumberStyles.AllowLeadingWhite | System.Globalization.NumberStyles.AllowTrailingWhite, System.Globalization.CultureInfo.InvariantCulture);
        }

        private BigInteger ParseHexadecimal(string hexText)
        {
            return BigInteger.Parse(hexText, System.Globalization.NumberStyles.HexNumber);
        }
        private bool IsValueAccepted()
        {
            string selectedInputType = DetailNumberBox.SelectedItem?.ToString() ?? "Không";
            string pText = PTextbox.Text;
            string qText = QTextBox.Text;

            if (string.IsNullOrWhiteSpace(pText) && string.IsNullOrWhiteSpace(qText))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu để tiếp tục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            BigInteger p, q;
            try
            {
                switch (selectedInputType)
                {
                    case "Thập phân":
                        p = BigInteger.Parse(pText);
                        q = BigInteger.Parse(qText);
                        break;

                    case "Nhị phân":
                        if (!IsBinary(pText) || !IsBinary(qText))
                        {
                            MessageBox.Show("P và Q phải là số nhị phân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        p = ParseBinary(pText);
                        q = ParseBinary(qText);
                        break;

                    case "Thập lục phân":
                        if (!IsHexadecimal(pText) || !IsHexadecimal(qText))
                        {
                            MessageBox.Show("P và Q phải là số thập lục phân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        p = ParseHexadecimal(pText);
                        q = ParseHexadecimal(qText);
                        break;

                    default:
                        MessageBox.Show("Vui lòng chọn loại đầu vào hợp lệ từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsPrime(p) || !IsPrime(q))
            {
                MessageBox.Show("P và Q phải là số nguyên tố!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (p == q)
            {
                MessageBox.Show("P và Q phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (p * q < 128)
            {
                MessageBox.Show("Nhập lại P và Q do tích của cả hai phải hơn 128", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            num_p = p;
            num_q = q;

            Find_D_and_E();

            PublicKeyTextBox.Text = $"e = {num_e}, n = {num_n}";
            PrivateKeyTextBox.Text = $"d = {num_d}, n = {num_n}";
            return true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateKeyButton_Click(object sender, EventArgs e)
        {
            PTextbox.Enabled = true;
            QTextBox.Enabled = true;
            PTextbox.ReadOnly = true;
            QTextBox.ReadOnly = true;
            DetailNumberBox.SelectedIndex = 0;
            DetailNumberBox.Enabled = false;
            GenerateKeyPair();
            PTextbox.Text = $"{num_p}";
            QTextBox.Text = $"{num_q}";
            PublicKeyTextBox.Text = $"e = {num_e}, n = {num_n}";
            PrivateKeyTextBox.Text = $"d = {num_d}, n = {num_n}";
        }

        private void EraseKeyButton_Click(object sender, EventArgs e)
        {
            PTextbox.Text = "";
            QTextBox.Text = "";
            PublicKeyTextBox.Text = "";
            PrivateKeyTextBox.Text = "";

        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            PTextbox.Enabled = true;
            QTextBox.Enabled = true;
            DetailNumberBox.Enabled = true;
            PTextbox.Text = "";
            QTextBox.Text = "";
            PublicKeyTextBox.Text = "";
            PrivateKeyTextBox.Text = "";
        }

        private void EncyptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PlainTextBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập thông điệp cần mã hóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ciphertext = Encrypt(PlainTextBox1.Text);
            CypherTextBox1.Text = ciphertext;

        }

        private void FileOpenButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileContent = System.IO.File.ReadAllText(openFileDialog.FileName);
                    PlainTextBox1.Text = fileContent;
                    MessageBox.Show("Dữ liệu đã được tải lên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(CypherTextBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập bản mã cần giải mã.");
                return;
            }
            string plaintext = Decrypt(CypherTextBox2.Text);
            PlainTextBox2.Text = plaintext;
        }

        private void FileOpenButton2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileContent = System.IO.File.ReadAllText(openFileDialog.FileName);
                    if (IsJustNumberAndSpace(fileContent))
                    {
                        CypherTextBox2.Text = fileContent;
                        MessageBox.Show("Dữ liệu đã được tải lên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu chứa ký tự không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void MoveEncryptButton_Click(object sender, EventArgs e)
        {
            E_DTab.SelectedIndex = 0;
            PlainTextBox2.Text = PlainTextBox1.Text;

        }

        private void EraseTextButton1_Click(object sender, EventArgs e)
        {
            CypherTextBox2.Text = "";
            PlainTextBox2.Text = "";

        }

        private void EraseAllButton1_Click(object sender, EventArgs e)
        {
            CypherTextBox2.Text = "";
            PlainTextBox2.Text = "";
            PTextbox.Text = "";
            QTextBox.Text = "";
            PublicKeyTextBox.Text = "";
            PrivateKeyTextBox.Text = "";

        }

        private void MoveDecryptButton_Click(object sender, EventArgs e)
        {
            E_DTab.SelectedIndex = 1;
            CypherTextBox2.Text = CypherTextBox1.Text;

        }

        private void EraseTextButton2_Click(object sender, EventArgs e)
        {
            PlainTextBox1.Text = "";
            CypherTextBox1.Text = "";
        }

        private void EraseAllButton2_Click(object sender, EventArgs e)
        {
            PlainTextBox1.Text = "";
            CypherTextBox1.Text = "";
            PTextbox.Text = "";
            QTextBox.Text = "";
            PublicKeyTextBox.Text = "";
            PrivateKeyTextBox.Text = "";
        }

        private void PTextbox_Leave(object sender, EventArgs e)
        {
            IsValueAccepted();
        }

        private void QTextBox_Leave(object sender, EventArgs e)
        {
            IsValueAccepted();
        }

        private void DropDownClosed(object sender, EventArgs e)
        {
            PTextbox.ReadOnly = false;
            QTextBox.ReadOnly = false;
        }
    }
}
