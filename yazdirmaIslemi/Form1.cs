using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Drawing.Printing;
using PrintDialog = System.Windows.Controls.PrintDialog;

namespace yazdirmaIslemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-VI2PUI8\\SQLEXPRESS;Initial Catalog=DbMuhafaza;Integrated Security=True");
        void Listele()
        {
            SqlCommand komut = new SqlCommand("select * from tbl_muhafaza", bag);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;


            //seydaservis.WebService1 servis = new seydaservis.WebService1();
            //DataSet ds = new DataSet();
            //ds = servis.Listele();
            //dataGridView1.DataSource = ds.Tables[0];

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Listele();
           
        }
        DbMuhafazaEntities5 db = new DbMuhafazaEntities5();
        PrintDialog prd = new PrintDialog();

       

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtStokkodu.Text;
            var query = from item in db.Tbl_Muhafaza
                        where item.StokNo.Contains(aranan)
                        select item;
            dataGridView1.DataSource = query.ToList();
        }


        private void btnYazdir_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument kagit = new System.Drawing.Printing.PrintDocument();
            DialogResult yazdirmaIslemi;
            yazdirmaIslemi = prd.ShowDialog();
        
        

            




        }

        private void myPrintDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap myBitmap1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(myBitmap1, new Rectangle(0, 0, pictureBox1.Width, 79));
            e.Graphics.DrawImage(myBitmap1, 120, 380,249,40);
            myBitmap1.Dispose();


        }

   

        private void Kagit_PrintPage(object sender, PrintPageEventArgs e)
        {

            string kod = "Stok No: " + txtStokkodu.Text;
            
            string ad = "\nStok Adı: " + txtStokAdi.Text;
            string bol = ad.Substring(0, 28);
            string bol2 = ad.Substring( 28);

            string lot ="\nLot No: " + txtLotNo.Text;
            string vardiya = "\nVardiya: " + cmbBoxOperator.Text;
            string adet ="\nAdet: " + txtAdet.Text;
            string barkod = "\nBarkod: " + txtBarkod.Text;


            



            Font fontStokNo = new Font("Arial",20,GraphicsUnit.Point);
            Font fontStokAdLot = new Font("Arial",20,GraphicsUnit.Point);
            
            SolidBrush kalem = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);
            StringFormat drawFormat = new StringFormat();


            Rectangle kapla = new Rectangle(40, 20, 360, 410);
            

            e.Graphics.DrawRectangle(myPen, kapla);

            

            e.Graphics.DrawLine(myPen, 40, 20, 400, 20);
            e.Graphics.DrawString(kod, fontStokNo, kalem, 40,50);
            e.Graphics.DrawLine(myPen, 40,80, 400, 80);
            e.Graphics.DrawString(bol, fontStokAdLot, kalem, 40, 70);
            e.Graphics.DrawString(bol2, fontStokAdLot, kalem, 40, 130);
            e.Graphics.DrawLine(myPen, 40, 180, 400, 180);
            e.Graphics.DrawString(lot, fontStokAdLot, kalem, 40, 160);
            e.Graphics.DrawLine(myPen, 40, 230, 400, 230);
            e.Graphics.DrawString(vardiya, fontStokAdLot, kalem, 40, 210);
            e.Graphics.DrawLine(myPen, 40, 280, 400, 280);
            e.Graphics.DrawString(adet, fontStokNo, kalem, 40, 260);
            e.Graphics.DrawLine(myPen, 40, 330, 400, 330);
            e.Graphics.DrawString(barkod, fontStokNo, kalem, 40, 310);
            

        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtStokkodu.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtStokAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtBarkod.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            
            Zen.Barcode.Code11BarcodeDraw brc = Zen.Barcode.BarcodeDrawFactory.Code11WithChecksum;
            pictureBox1.Image = brc.Draw(txtBarkod.Text, 249);
            
            
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
            ServisReferansı.WebService1 webServis = new ServisReferansı.WebService1();
            DataSet ds = webServis.Lİstele();
            dataGridView1.DataSource = ds.Tables[0];
        }


    }
}
