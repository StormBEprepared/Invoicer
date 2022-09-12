namespace Invoicer
{
    partial class InputData4Invoice
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameInputBox = new System.Windows.Forms.TextBox();
            this.AddressInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GenerateInvoiceButton = new System.Windows.Forms.Button();
            this.DescriptionInputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InputValuesInTableButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.QuantityInputBox = new System.Windows.Forms.NumericUpDown();
            this.ValueInputBox = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueInputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1259, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Description";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 600;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Value/1pc";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TotalValue/Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // NameInputBox
            // 
            this.NameInputBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameInputBox.Location = new System.Drawing.Point(144, 28);
            this.NameInputBox.Name = "NameInputBox";
            this.NameInputBox.Size = new System.Drawing.Size(228, 27);
            this.NameInputBox.TabIndex = 1;
            // 
            // AddressInputBox
            // 
            this.AddressInputBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddressInputBox.Location = new System.Drawing.Point(144, 74);
            this.AddressInputBox.Name = "AddressInputBox";
            this.AddressInputBox.Size = new System.Drawing.Size(595, 27);
            this.AddressInputBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address:";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxImage.BackColor = System.Drawing.Color.White;
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImage.Location = new System.Drawing.Point(1092, 12);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(228, 199);
            this.pictureBoxImage.TabIndex = 5;
            this.pictureBoxImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(992, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Upload Issuer logo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GenerateInvoiceButton
            // 
            this.GenerateInvoiceButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GenerateInvoiceButton.Location = new System.Drawing.Point(583, 769);
            this.GenerateInvoiceButton.Name = "GenerateInvoiceButton";
            this.GenerateInvoiceButton.Size = new System.Drawing.Size(215, 29);
            this.GenerateInvoiceButton.TabIndex = 7;
            this.GenerateInvoiceButton.Text = "Generate Invoice";
            this.GenerateInvoiceButton.UseVisualStyleBackColor = true;
            this.GenerateInvoiceButton.Click += new System.EventHandler(this.GenerateInvoiceButton_Click);
            // 
            // DescriptionInputBox
            // 
            this.DescriptionInputBox.Location = new System.Drawing.Point(73, 249);
            this.DescriptionInputBox.Name = "DescriptionInputBox";
            this.DescriptionInputBox.Size = new System.Drawing.Size(556, 27);
            this.DescriptionInputBox.TabIndex = 8;
            this.DescriptionInputBox.TextChanged += new System.EventHandler(this.DescriptionInputBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(862, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Value";
            // 
            // InputValuesInTableButton
            // 
            this.InputValuesInTableButton.Location = new System.Drawing.Point(1077, 247);
            this.InputValuesInTableButton.Name = "InputValuesInTableButton";
            this.InputValuesInTableButton.Size = new System.Drawing.Size(94, 29);
            this.InputValuesInTableButton.TabIndex = 12;
            this.InputValuesInTableButton.Text = "Add";
            this.InputValuesInTableButton.UseVisualStyleBackColor = true;
            this.InputValuesInTableButton.Click += new System.EventHandler(this.InputValuesInTableButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1002, 728);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1197, 769);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "With VAT 20%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1197, 728);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Without VAT 20%";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1066, 725);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1066, 766);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 17;
            // 
            // QuantityInputBox
            // 
            this.QuantityInputBox.Location = new System.Drawing.Point(664, 254);
            this.QuantityInputBox.Name = "QuantityInputBox";
            this.QuantityInputBox.Size = new System.Drawing.Size(150, 27);
            this.QuantityInputBox.TabIndex = 18;
            this.QuantityInputBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ValueInputBox
            // 
            this.ValueInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueInputBox.Location = new System.Drawing.Point(862, 254);
            this.ValueInputBox.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.ValueInputBox.Name = "ValueInputBox";
            this.ValueInputBox.Size = new System.Drawing.Size(150, 27);
            this.ValueInputBox.TabIndex = 19;
            this.ValueInputBox.ValueChanged += new System.EventHandler(this.ValueInputBox_ValueChanged);
            this.ValueInputBox.Enter += new System.EventHandler(this.ValueInputBox_Enter);
            this.ValueInputBox.Leave += new System.EventHandler(this.ValueInputBox_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(863, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 20;
            // 
            // InputData4Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1353, 844);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ValueInputBox);
            this.Controls.Add(this.QuantityInputBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InputValuesInTableButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescriptionInputBox);
            this.Controls.Add(this.GenerateInvoiceButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressInputBox);
            this.Controls.Add(this.NameInputBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InputData4Invoice";
            this.Text = "InputData4Invoice";
            this.Load += new System.EventHandler(this.InputData4Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueInputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox NameInputBox;
        private TextBox AddressInputBox;
        private Label label1;
        private Label label2;
        private PictureBox pictureBoxImage;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Button GenerateInvoiceButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox DescriptionInputBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button InputValuesInTableButton;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown QuantityInputBox;
        public DataGridView dataGridView1;
        private NumericUpDown ValueInputBox;
        private Label label9;
    }
}