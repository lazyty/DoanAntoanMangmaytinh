namespace DoanAntoanMangmaytinh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EncyptButton = new Button();
            EraseAllButton1 = new Button();
            FileOpenButton1 = new Button();
            MoveDecryptButton = new Button();
            GenerateKeyButton = new Button();
            PTextbox = new TextBox();
            QTextBox = new TextBox();
            PubicKeyTextBox = new TextBox();
            PrivateKeyTextBox = new TextBox();
            DecryptButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            EraseKeyButton = new Button();
            MoveEncryptButton = new Button();
            EraseAllButton2 = new Button();
            EraseTextButton2 = new Button();
            EraseTextButton1 = new Button();
            E_DTab = new TabControl();
            EncryptTab = new TabPage();
            label7 = new Label();
            label6 = new Label();
            CypherTextBox1 = new TextBox();
            PlainTextBox1 = new TextBox();
            DecryptTab = new TabPage();
            label9 = new Label();
            label8 = new Label();
            CypherTextBox2 = new TextBox();
            FileOpenButton2 = new Button();
            PlainTextBox2 = new TextBox();
            label10 = new Label();
            DetailNumberBox = new ComboBox();
            InputButton = new Button();
            E_DTab.SuspendLayout();
            EncryptTab.SuspendLayout();
            DecryptTab.SuspendLayout();
            SuspendLayout();
            // 
            // EncyptButton
            // 
            EncyptButton.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EncyptButton.Location = new Point(609, 142);
            EncyptButton.Name = "EncyptButton";
            EncyptButton.Size = new Size(212, 34);
            EncyptButton.TabIndex = 0;
            EncyptButton.Text = "Mã Hóa";
            EncyptButton.UseVisualStyleBackColor = true;
            EncyptButton.Click += EncyptButton_Click;
            // 
            // EraseAllButton1
            // 
            EraseAllButton1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EraseAllButton1.Location = new Point(698, 218);
            EraseAllButton1.Name = "EraseAllButton1";
            EraseAllButton1.Size = new Size(212, 34);
            EraseAllButton1.TabIndex = 1;
            EraseAllButton1.Text = "Xóa hết";
            EraseAllButton1.UseVisualStyleBackColor = true;
            EraseAllButton1.Click += EraseAllButton1_Click;
            // 
            // FileOpenButton1
            // 
            FileOpenButton1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FileOpenButton1.Location = new Point(837, 34);
            FileOpenButton1.Name = "FileOpenButton1";
            FileOpenButton1.Size = new Size(212, 34);
            FileOpenButton1.TabIndex = 2;
            FileOpenButton1.Text = "Lấy từ File";
            FileOpenButton1.UseVisualStyleBackColor = true;
            FileOpenButton1.Click += FileOpenButton1_Click;
            // 
            // MoveDecryptButton
            // 
            MoveDecryptButton.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoveDecryptButton.Location = new Point(183, 219);
            MoveDecryptButton.Name = "MoveDecryptButton";
            MoveDecryptButton.Size = new Size(212, 40);
            MoveDecryptButton.TabIndex = 3;
            MoveDecryptButton.Text = "Chuyển qua giải mã";
            MoveDecryptButton.UseVisualStyleBackColor = true;
            MoveDecryptButton.Click += MoveDecryptButton_Click;
            // 
            // GenerateKeyButton
            // 
            GenerateKeyButton.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerateKeyButton.Location = new Point(881, 115);
            GenerateKeyButton.Name = "GenerateKeyButton";
            GenerateKeyButton.Size = new Size(146, 35);
            GenerateKeyButton.TabIndex = 4;
            GenerateKeyButton.Text = "Tự tạo khóa";
            GenerateKeyButton.UseVisualStyleBackColor = true;
            GenerateKeyButton.Click += GenerateKeyButton_Click;
            // 
            // PTextbox
            // 
            PTextbox.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PTextbox.Location = new Point(366, 116);
            PTextbox.Name = "PTextbox";
            PTextbox.ReadOnly = true;
            PTextbox.Size = new Size(211, 33);
            PTextbox.TabIndex = 6;
            // 
            // QTextBox
            // 
            QTextBox.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QTextBox.Location = new Point(657, 115);
            QTextBox.Name = "QTextBox";
            QTextBox.ReadOnly = true;
            QTextBox.Size = new Size(211, 33);
            QTextBox.TabIndex = 7;
            // 
            // PubicKeyTextBox
            // 
            PubicKeyTextBox.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PubicKeyTextBox.Location = new Point(470, 172);
            PubicKeyTextBox.Name = "PubicKeyTextBox";
            PubicKeyTextBox.ReadOnly = true;
            PubicKeyTextBox.Size = new Size(557, 33);
            PubicKeyTextBox.TabIndex = 8;
            PubicKeyTextBox.TextChanged += PubicKeyTextBox_TextChanged;
            // 
            // PrivateKeyTextBox
            // 
            PrivateKeyTextBox.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrivateKeyTextBox.Location = new Point(470, 226);
            PrivateKeyTextBox.Name = "PrivateKeyTextBox";
            PrivateKeyTextBox.ReadOnly = true;
            PrivateKeyTextBox.Size = new Size(557, 33);
            PrivateKeyTextBox.TabIndex = 9;
            // 
            // DecryptButton
            // 
            DecryptButton.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DecryptButton.Location = new Point(609, 142);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(212, 34);
            DecryptButton.TabIndex = 11;
            DecryptButton.Text = "Giải Mã";
            DecryptButton.UseVisualStyleBackColor = true;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 121);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 12;
            label1.Text = "Số P";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(594, 121);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 13;
            label2.Text = "Số Q";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(307, 180);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 14;
            label3.Text = "Khóa Công Khai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(307, 234);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 15;
            label4.Text = "Khóa Bí Mật";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(232, 48);
            label5.Name = "label5";
            label5.Size = new Size(769, 45);
            label5.TabIndex = 16;
            label5.Text = "WINFORM THUẬT TOÁN MÃ HÓA RSA";
            // 
            // EraseKeyButton
            // 
            EraseKeyButton.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EraseKeyButton.Location = new Point(1044, 115);
            EraseKeyButton.Name = "EraseKeyButton";
            EraseKeyButton.Size = new Size(94, 144);
            EraseKeyButton.TabIndex = 17;
            EraseKeyButton.Text = "Xóa thông tin khóa";
            EraseKeyButton.UseVisualStyleBackColor = true;
            EraseKeyButton.Click += EraseKeyButton_Click;
            // 
            // MoveEncryptButton
            // 
            MoveEncryptButton.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoveEncryptButton.Location = new Point(183, 219);
            MoveEncryptButton.Name = "MoveEncryptButton";
            MoveEncryptButton.Size = new Size(216, 34);
            MoveEncryptButton.TabIndex = 18;
            MoveEncryptButton.Text = "Chuyển qua mã hóa";
            MoveEncryptButton.UseVisualStyleBackColor = true;
            MoveEncryptButton.Click += MoveEncryptButton_Click;
            // 
            // EraseAllButton2
            // 
            EraseAllButton2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EraseAllButton2.Location = new Point(698, 218);
            EraseAllButton2.Name = "EraseAllButton2";
            EraseAllButton2.Size = new Size(212, 40);
            EraseAllButton2.TabIndex = 19;
            EraseAllButton2.Text = "Xóa hết";
            EraseAllButton2.UseVisualStyleBackColor = true;
            EraseAllButton2.Click += EraseAllButton2_Click;
            // 
            // EraseTextButton2
            // 
            EraseTextButton2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EraseTextButton2.Location = new Point(443, 218);
            EraseTextButton2.Name = "EraseTextButton2";
            EraseTextButton2.Size = new Size(214, 40);
            EraseTextButton2.TabIndex = 20;
            EraseTextButton2.Text = "Xóa text";
            EraseTextButton2.UseVisualStyleBackColor = true;
            EraseTextButton2.Click += EraseTextButton2_Click;
            // 
            // EraseTextButton1
            // 
            EraseTextButton1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EraseTextButton1.Location = new Point(443, 218);
            EraseTextButton1.Name = "EraseTextButton1";
            EraseTextButton1.Size = new Size(212, 34);
            EraseTextButton1.TabIndex = 21;
            EraseTextButton1.Text = "Xóa text";
            EraseTextButton1.UseVisualStyleBackColor = true;
            EraseTextButton1.Click += EraseTextButton1_Click;
            // 
            // E_DTab
            // 
            E_DTab.Controls.Add(EncryptTab);
            E_DTab.Controls.Add(DecryptTab);
            E_DTab.Location = new Point(70, 297);
            E_DTab.Name = "E_DTab";
            E_DTab.SelectedIndex = 0;
            E_DTab.Size = new Size(1072, 327);
            E_DTab.TabIndex = 22;
            // 
            // EncryptTab
            // 
            EncryptTab.BackColor = SystemColors.GradientInactiveCaption;
            EncryptTab.Controls.Add(label7);
            EncryptTab.Controls.Add(label6);
            EncryptTab.Controls.Add(CypherTextBox1);
            EncryptTab.Controls.Add(PlainTextBox1);
            EncryptTab.Controls.Add(FileOpenButton1);
            EncryptTab.Controls.Add(EraseAllButton2);
            EncryptTab.Controls.Add(EraseTextButton2);
            EncryptTab.Controls.Add(EncyptButton);
            EncryptTab.Controls.Add(MoveDecryptButton);
            EncryptTab.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EncryptTab.Location = new Point(4, 34);
            EncryptTab.Name = "EncryptTab";
            EncryptTab.Padding = new Padding(3);
            EncryptTab.Size = new Size(1064, 289);
            EncryptTab.TabIndex = 0;
            EncryptTab.Text = "Encrypt Text Mode";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 96);
            label7.Name = "label7";
            label7.Size = new Size(168, 27);
            label7.TabIndex = 22;
            label7.Text = "Văn bản mã hóa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 37);
            label6.Name = "label6";
            label6.Size = new Size(132, 27);
            label6.TabIndex = 21;
            label6.Text = "Văn bản gốc";
            // 
            // CypherTextBox1
            // 
            CypherTextBox1.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CypherTextBox1.Location = new Point(204, 92);
            CypherTextBox1.Multiline = true;
            CypherTextBox1.Name = "CypherTextBox1";
            CypherTextBox1.Size = new Size(617, 33);
            CypherTextBox1.TabIndex = 10;
            // 
            // PlainTextBox1
            // 
            PlainTextBox1.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlainTextBox1.Location = new Point(204, 37);
            PlainTextBox1.Multiline = true;
            PlainTextBox1.Name = "PlainTextBox1";
            PlainTextBox1.Size = new Size(617, 33);
            PlainTextBox1.TabIndex = 9;
            // 
            // DecryptTab
            // 
            DecryptTab.BackColor = SystemColors.GradientInactiveCaption;
            DecryptTab.Controls.Add(label9);
            DecryptTab.Controls.Add(label8);
            DecryptTab.Controls.Add(CypherTextBox2);
            DecryptTab.Controls.Add(FileOpenButton2);
            DecryptTab.Controls.Add(PlainTextBox2);
            DecryptTab.Controls.Add(EraseTextButton1);
            DecryptTab.Controls.Add(MoveEncryptButton);
            DecryptTab.Controls.Add(DecryptButton);
            DecryptTab.Controls.Add(EraseAllButton1);
            DecryptTab.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            DecryptTab.Location = new Point(4, 34);
            DecryptTab.Name = "DecryptTab";
            DecryptTab.Padding = new Padding(3);
            DecryptTab.Size = new Size(1064, 289);
            DecryptTab.TabIndex = 1;
            DecryptTab.Text = "Decrypt Text Mode";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(23, 96);
            label9.Name = "label9";
            label9.Size = new Size(168, 27);
            label9.TabIndex = 26;
            label9.Text = "Văn bản mã hóa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 39);
            label8.Name = "label8";
            label8.Size = new Size(132, 27);
            label8.TabIndex = 25;
            label8.Text = "Văn bản gốc";
            label8.Click += label8_Click;
            // 
            // CypherTextBox2
            // 
            CypherTextBox2.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CypherTextBox2.Location = new Point(207, 91);
            CypherTextBox2.Name = "CypherTextBox2";
            CypherTextBox2.Size = new Size(617, 33);
            CypherTextBox2.TabIndex = 24;
            // 
            // FileOpenButton2
            // 
            FileOpenButton2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FileOpenButton2.Location = new Point(837, 34);
            FileOpenButton2.Name = "FileOpenButton2";
            FileOpenButton2.Size = new Size(214, 33);
            FileOpenButton2.TabIndex = 12;
            FileOpenButton2.Text = "Lấy từ File";
            FileOpenButton2.UseVisualStyleBackColor = true;
            FileOpenButton2.Click += FileOpenButton2_Click;
            // 
            // PlainTextBox2
            // 
            PlainTextBox2.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlainTextBox2.Location = new Point(207, 33);
            PlainTextBox2.Multiline = true;
            PlainTextBox2.Name = "PlainTextBox2";
            PlainTextBox2.Size = new Size(617, 33);
            PlainTextBox2.TabIndex = 23;
            PlainTextBox2.TextChanged += PlainTextBox2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(90, 180);
            label10.Name = "label10";
            label10.Size = new Size(175, 27);
            label10.TabIndex = 23;
            label10.Text = "Chọn cơ sở nhập";
            label10.Click += label10_Click;
            // 
            // DetailNumberBox
            // 
            DetailNumberBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DetailNumberBox.Enabled = false;
            DetailNumberBox.FormattingEnabled = true;
            DetailNumberBox.Items.AddRange(new object[] { "Thập phân", "Nhị phân", "Thập lục phân" });
            DetailNumberBox.Location = new Point(77, 223);
            DetailNumberBox.Name = "DetailNumberBox";
            DetailNumberBox.Size = new Size(198, 33);
            DetailNumberBox.TabIndex = 24;
            // 
            // InputButton
            // 
            InputButton.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InputButton.Location = new Point(77, 121);
            InputButton.Name = "InputButton";
            InputButton.Size = new Size(198, 35);
            InputButton.TabIndex = 25;
            InputButton.Text = "Nhập thủ công";
            InputButton.UseVisualStyleBackColor = true;
            InputButton.Click += InputButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1214, 671);
            Controls.Add(InputButton);
            Controls.Add(DetailNumberBox);
            Controls.Add(label10);
            Controls.Add(E_DTab);
            Controls.Add(EraseKeyButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PrivateKeyTextBox);
            Controls.Add(PubicKeyTextBox);
            Controls.Add(QTextBox);
            Controls.Add(PTextbox);
            Controls.Add(GenerateKeyButton);
            Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "RSA Form";
            E_DTab.ResumeLayout(false);
            EncryptTab.ResumeLayout(false);
            EncryptTab.PerformLayout();
            DecryptTab.ResumeLayout(false);
            DecryptTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EncyptButton;
        private Button EraseAllButton1;
        private Button FileOpenButton1;
        private Button MoveDecryptButton;
        private Button GenerateKeyButton;
        private TextBox PTextbox;
        private TextBox QTextBox;
        private TextBox PubicKeyTextBox;
        private TextBox PrivateKeyTextBox;
        private Button DecryptButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button EraseKeyButton;
        private Button MoveEncryptButton;
        private Button EraseAllButton2;
        private Button EraseTextButton2;
        private Button EraseTextButton1;
        private TabControl E_DTab;
        private TabPage EncryptTab;
        private TabPage DecryptTab;
        private TextBox CypherTextBox1;
        private TextBox PlainTextBox1;
        private Button FileOpenButton2;
        private TextBox PlainTextBox2;
        private TextBox CypherTextBox2;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label10;
        private ComboBox DetailNumberBox;
        private Button InputButton;
    }
}
