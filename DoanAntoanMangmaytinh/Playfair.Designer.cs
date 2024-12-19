namespace DoanAntoanMangmaytinh
{
    partial class Playfair
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            gb_Khoa = new GroupBox();
            btnTaoMaTran = new Button();
            datagridMatrix = new DataGridView();
            lbl_Matrix = new Label();
            ChonMaTrix5x5 = new RadioButton();
            radioButton1 = new RadioButton();
            btn_RandomKey = new Button();
            tb_key = new TextBox();
            lbl_input = new Label();
            gbKetQua = new GroupBox();
            btnExportText = new Button();
            btn_InputText = new Button();
            btn_DichNguoc = new Button();
            btn_GiaMa = new Button();
            btnMaHoa = new Button();
            rtb_DauRa = new RichTextBox();
            lblGiaiMa = new Label();
            rtb_DauVao = new RichTextBox();
            lblTextInput = new Label();
            gb_Khoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridMatrix).BeginInit();
            gbKetQua.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 15.8571434F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(-29, 52);
            label5.Name = "label5";
            label5.Size = new Size(1269, 53);
            label5.TabIndex = 17;
            label5.Text = "Mô phỏng Mã Hóa và Giải Mã theo phương pháp Playfair ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // gb_Khoa
            // 
            gb_Khoa.Controls.Add(btnTaoMaTran);
            gb_Khoa.Controls.Add(datagridMatrix);
            gb_Khoa.Controls.Add(lbl_Matrix);
            gb_Khoa.Controls.Add(ChonMaTrix5x5);
            gb_Khoa.Controls.Add(radioButton1);
            gb_Khoa.Controls.Add(btn_RandomKey);
            gb_Khoa.Controls.Add(tb_key);
            gb_Khoa.Controls.Add(lbl_input);
            gb_Khoa.Location = new Point(74, 135);
            gb_Khoa.Name = "gb_Khoa";
            gb_Khoa.Size = new Size(1033, 369);
            gb_Khoa.TabIndex = 18;
            gb_Khoa.TabStop = false;
            gb_Khoa.Text = "Khóa";
            // 
            // btnTaoMaTran
            // 
            btnTaoMaTran.FlatStyle = FlatStyle.Flat;
            btnTaoMaTran.Location = new Point(580, 126);
            btnTaoMaTran.Name = "btnTaoMaTran";
            btnTaoMaTran.Size = new Size(430, 57);
            btnTaoMaTran.TabIndex = 6;
            btnTaoMaTran.Text = "Tạo Ma Trận";
            btnTaoMaTran.UseVisualStyleBackColor = true;
            btnTaoMaTran.Click += btnTaoMaTran_Click;
            // 
            // datagridMatrix
            // 
            datagridMatrix.AllowUserToAddRows = false;
            datagridMatrix.AllowUserToDeleteRows = false;
            datagridMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridMatrix.Location = new Point(16, 150);
            datagridMatrix.Name = "datagridMatrix";
            datagridMatrix.ReadOnly = true;
            datagridMatrix.RowHeadersWidth = 72;
            datagridMatrix.Size = new Size(505, 200);
            datagridMatrix.TabIndex = 5;
            // 
            // lbl_Matrix
            // 
            lbl_Matrix.AutoSize = true;
            lbl_Matrix.Location = new Point(22, 61);
            lbl_Matrix.Name = "lbl_Matrix";
            lbl_Matrix.Size = new Size(97, 30);
            lbl_Matrix.TabIndex = 4;
            lbl_Matrix.Text = "Ma trận: ";
            // 
            // ChonMaTrix5x5
            // 
            ChonMaTrix5x5.AutoSize = true;
            ChonMaTrix5x5.Location = new Point(134, 34);
            ChonMaTrix5x5.Name = "ChonMaTrix5x5";
            ChonMaTrix5x5.Size = new Size(151, 34);
            ChonMaTrix5x5.TabIndex = 3;
            ChonMaTrix5x5.TabStop = true;
            ChonMaTrix5x5.Text = "Ma Trận 5x5";
            ChonMaTrix5x5.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(134, 84);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(149, 34);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ma trận 6x6";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn_RandomKey
            // 
            btn_RandomKey.FlatStyle = FlatStyle.Flat;
            btn_RandomKey.Location = new Point(580, 201);
            btn_RandomKey.Name = "btn_RandomKey";
            btn_RandomKey.Size = new Size(430, 57);
            btn_RandomKey.TabIndex = 2;
            btn_RandomKey.Text = "Tạo khóa ngẫu nhiên";
            btn_RandomKey.UseVisualStyleBackColor = true;
            btn_RandomKey.Click += btn_RandomKey_Click;
            // 
            // tb_key
            // 
            tb_key.BorderStyle = BorderStyle.FixedSingle;
            tb_key.Cursor = Cursors.IBeam;
            tb_key.Location = new Point(581, 73);
            tb_key.Name = "tb_key";
            tb_key.Size = new Size(429, 35);
            tb_key.TabIndex = 1;
            // 
            // lbl_input
            // 
            lbl_input.AutoSize = true;
            lbl_input.Location = new Point(581, 31);
            lbl_input.Name = "lbl_input";
            lbl_input.Size = new Size(126, 30);
            lbl_input.TabIndex = 0;
            lbl_input.Text = "Nhập khóa: ";
            // 
            // gbKetQua
            // 
            gbKetQua.Controls.Add(btnExportText);
            gbKetQua.Controls.Add(btn_InputText);
            gbKetQua.Controls.Add(btn_DichNguoc);
            gbKetQua.Controls.Add(btn_GiaMa);
            gbKetQua.Controls.Add(btnMaHoa);
            gbKetQua.Controls.Add(rtb_DauRa);
            gbKetQua.Controls.Add(lblGiaiMa);
            gbKetQua.Controls.Add(rtb_DauVao);
            gbKetQua.Controls.Add(lblTextInput);
            gbKetQua.Location = new Point(74, 540);
            gbKetQua.Name = "gbKetQua";
            gbKetQua.Size = new Size(1033, 522);
            gbKetQua.TabIndex = 18;
            gbKetQua.TabStop = false;
            gbKetQua.Text = "Mã hóa, Giải mã";
            // 
            // btnExportText
            // 
            btnExportText.FlatStyle = FlatStyle.Flat;
            btnExportText.Location = new Point(653, 425);
            btnExportText.Name = "btnExportText";
            btnExportText.Size = new Size(306, 57);
            btnExportText.TabIndex = 11;
            btnExportText.Text = "Xuất file ra bên ngoài";
            btnExportText.UseVisualStyleBackColor = true;
            // 
            // btn_InputText
            // 
            btn_InputText.FlatStyle = FlatStyle.Flat;
            btn_InputText.Location = new Point(74, 425);
            btn_InputText.Name = "btn_InputText";
            btn_InputText.Size = new Size(306, 57);
            btn_InputText.TabIndex = 10;
            btn_InputText.Text = "Nhập file từ bên ngoài";
            btn_InputText.UseVisualStyleBackColor = true;
            // 
            // btn_DichNguoc
            // 
            btn_DichNguoc.FlatStyle = FlatStyle.Flat;
            btn_DichNguoc.Location = new Point(422, 302);
            btn_DichNguoc.Name = "btn_DichNguoc";
            btn_DichNguoc.Size = new Size(196, 57);
            btn_DichNguoc.TabIndex = 9;
            btn_DichNguoc.Text = "<<";
            btn_DichNguoc.UseVisualStyleBackColor = true;
            btn_DichNguoc.Click += btn_DichNguoc_Click;
            // 
            // btn_GiaMa
            // 
            btn_GiaMa.FlatStyle = FlatStyle.Flat;
            btn_GiaMa.Location = new Point(422, 213);
            btn_GiaMa.Name = "btn_GiaMa";
            btn_GiaMa.Size = new Size(196, 57);
            btn_GiaMa.TabIndex = 8;
            btn_GiaMa.Text = "Giải Mã";
            btn_GiaMa.UseVisualStyleBackColor = true;
            btn_GiaMa.Click += btn_GiaMa_Click;
            // 
            // btnMaHoa
            // 
            btnMaHoa.FlatStyle = FlatStyle.Flat;
            btnMaHoa.Location = new Point(422, 124);
            btnMaHoa.Name = "btnMaHoa";
            btnMaHoa.Size = new Size(196, 57);
            btnMaHoa.TabIndex = 7;
            btnMaHoa.Text = "Mã Hóa";
            btnMaHoa.UseVisualStyleBackColor = true;
            btnMaHoa.Click += btnMaHoa_Click;
            // 
            // rtb_DauRa
            // 
            rtb_DauRa.Location = new Point(653, 76);
            rtb_DauRa.Name = "rtb_DauRa";
            rtb_DauRa.Size = new Size(357, 328);
            rtb_DauRa.TabIndex = 3;
            rtb_DauRa.Text = "";
            // 
            // lblGiaiMa
            // 
            lblGiaiMa.AutoSize = true;
            lblGiaiMa.Location = new Point(658, 35);
            lblGiaiMa.Name = "lblGiaiMa";
            lblGiaiMa.Size = new Size(158, 30);
            lblGiaiMa.TabIndex = 0;
            lblGiaiMa.Text = "Văn bản đầu ra:";
            // 
            // rtb_DauVao
            // 
            rtb_DauVao.Location = new Point(23, 76);
            rtb_DauVao.Name = "rtb_DauVao";
            rtb_DauVao.Size = new Size(357, 328);
            rtb_DauVao.TabIndex = 3;
            rtb_DauVao.Text = "";
            // 
            // lblTextInput
            // 
            lblTextInput.AutoSize = true;
            lblTextInput.Location = new Point(28, 37);
            lblTextInput.Name = "lblTextInput";
            lblTextInput.Size = new Size(179, 30);
            lblTextInput.TabIndex = 0;
            lblTextInput.Text = "Văn bản đầu vào: ";
            // 
            // Playfair
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1214, 1074);
            Controls.Add(gbKetQua);
            Controls.Add(gb_Khoa);
            Controls.Add(label5);
            Name = "Playfair";
            Text = "Playfair";
            Load += Playfair_Load;
            gb_Khoa.ResumeLayout(false);
            gb_Khoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridMatrix).EndInit();
            gbKetQua.ResumeLayout(false);
            gbKetQua.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private GroupBox gb_Khoa;
        private TextBox tb_key;
        private Label lbl_input;
        private GroupBox gbKetQua;
        private Label lbl_Matrix;
        private RadioButton ChonMaTrix5x5;
        private RadioButton radioButton1;
        private Button btn_RandomKey;
        private Label lblTextInput;
        private RichTextBox rtb_DauVao;
        private RichTextBox rtb_DauRa;
        private Label lblGiaiMa;
        private DataGridView datagridMatrix;
        private Button btnTaoMaTran;
        private Button btnExportText;
        private Button btn_InputText;
        private Button btn_DichNguoc;
        private Button btn_GiaMa;
        private Button btnMaHoa;
    }
}