using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicer
{
    public partial class InputData4Invoice : Form
    {
        public InputData4Invoice()
        {
            InitializeComponent();
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public Image IssuerImage { get; set; }
        public DataGridView TableOfContents { get; set; }
        public string total { get; set; }
        public string totalVAT { get; set; }

        private void UploadImage()
        {
            try
            {
                openFileDialog1.Filter = "JPG FILES(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.jfif)|*.jfif| PNG FILES(*.png)|*.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxImage.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! {ex.Message}","Error...",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InputData4Invoice_Load(object sender, EventArgs e)
        {
            pictureBoxImage.Image = Properties.Resources._1653291622486;//Loads the Hicom logo as a default
            InputValuesInTableButton.Enabled= false;
            
        }
        private void DataInsert()
        {
            Name=NameInputBox.Text;
            Address=AddressInputBox.Text;
            IssuerImage=pictureBoxImage.Image;
            TableOfContents = dataGridView1;
            total = textBox1.Text;
            totalVAT = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UploadImage();
        }

        

        private void GenerateInvoiceButton_Click(object sender, EventArgs e)
        {
            DataInsert();
            Invoice invoice = new Invoice(IssuerImage,TableOfContents,Name,Address,total,totalVAT);

            invoice.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InputValuesInTableButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(DescriptionInputBox.Text, QuantityInputBox.Value, ValueInputBox.Value);
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                dataGridView1.Rows[i].Cells[3].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            textBox1.Text = sum.ToString();
            DescriptionInputBox.Text = null; QuantityInputBox.Value = 1; ValueInputBox.Value = 0;
            double totalVal = sum + (0.2 * sum);
            textBox2.Text =totalVal.ToString();
            dataGridView1.ClearSelection();//clears the row selection of the datagrid

        }

        private void DescriptionInputBox_TextChanged(object sender, EventArgs e)
        {
            if (DescriptionInputBox.Text != null && ValueInputBox.Value>=1)
            {
                InputValuesInTableButton.Enabled = true;
            }
            else
            {
                InputValuesInTableButton.Enabled=false;
            }
        }

        private void ValueInputBox_ValueChanged(object sender, EventArgs e)
        {
            if (ValueInputBox.Value >= 1 && DescriptionInputBox.Text != null)
            {
                InputValuesInTableButton.Enabled = true;
            }
            else
            {
                InputValuesInTableButton.Enabled = false;
            }
        }

        private void ValueInputBox_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void ValueInputBox_Enter(object sender, EventArgs e)
        {
            label9.Text = "Press ENTER when done writing.";
        }

        private void ValueInputBox_Leave(object sender, EventArgs e)
        {
            label9.Text = "";
        }
    }
}
