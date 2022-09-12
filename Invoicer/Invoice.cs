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
    public partial class Invoice : Form
    {
        public Image IssuerLogo { get; set; }
        public DataGridView invoiceTable { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public string total { get; set; }
        public string totalVAT { get; set; }

        public Invoice(Image logo, DataGridView table, string name, string address, string Total, string TotalVAT)
        {
            InitializeComponent();
            IssuerLogo = logo;
            invoiceTable = table;
            CustName=name;
            CustAddress=address;
            total = Total;
            totalVAT=TotalVAT;
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = table.Rows[n].Cells[0].Value.ToString();
                dataGridView1.Rows[n].Cells[1].Value = table.Rows[n].Cells[1].Value.ToString();
                dataGridView1.Rows[n].Cells[2].Value = table.Rows[n].Cells[2].Value.ToString();
                dataGridView1.Rows[n].Cells[3].Value = table.Rows[n].Cells[3].Value.ToString();
            }
        }
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width,pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0,0,pnl.Width,pnl.Height));
        }
        private void Invoice_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();//clears the row selection of the datagrid
            DateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
            PaymentTermLabel.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yyy");
            NameLabel.Text = CustName;
            AddressLabel.Text = CustAddress;
            pictureBox1.Image = IssuerLogo;
            textboxTotal.Text = total+ " GBP";
            textBoxTotalVAT.Text = totalVAT + " GBP";
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg,(pagearea.Width/2)-(this.panelPrint.Width/2),this.panelPrint.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void panelPrint_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
