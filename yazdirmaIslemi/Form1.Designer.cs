
namespace yazdirmaIslemi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cmbBoxOperator = new System.Windows.Forms.ComboBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtLotNo = new System.Windows.Forms.TextBox();
            this.txtStokAdi = new System.Windows.Forms.TextBox();
            this.txtStokkodu = new System.Windows.Forms.TextBox();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblLotNo = new System.Windows.Forms.Label();
            this.lblStokAdi = new System.Windows.Forms.Label();
            this.lblStokKod = new System.Windows.Forms.Label();
            this.lblUrunAra = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxOperator
            // 
            this.cmbBoxOperator.FormattingEnabled = true;
            this.cmbBoxOperator.Items.AddRange(new object[] {
            "operatör 1",
            "operatör 2",
            "operatör 3"});
            this.cmbBoxOperator.Location = new System.Drawing.Point(988, 264);
            this.cmbBoxOperator.Name = "cmbBoxOperator";
            this.cmbBoxOperator.Size = new System.Drawing.Size(164, 24);
            this.cmbBoxOperator.TabIndex = 24;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(988, 229);
            this.txtAdet.Multiline = true;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(164, 29);
            this.txtAdet.TabIndex = 23;
            // 
            // txtLotNo
            // 
            this.txtLotNo.Location = new System.Drawing.Point(988, 194);
            this.txtLotNo.Multiline = true;
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.Size = new System.Drawing.Size(164, 29);
            this.txtLotNo.TabIndex = 22;
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(988, 159);
            this.txtStokAdi.Multiline = true;
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(164, 29);
            this.txtStokAdi.TabIndex = 21;
            // 
            // txtStokkodu
            // 
            this.txtStokkodu.Location = new System.Drawing.Point(988, 124);
            this.txtStokkodu.Multiline = true;
            this.txtStokkodu.Name = "txtStokkodu";
            this.txtStokkodu.Size = new System.Drawing.Size(164, 29);
            this.txtStokkodu.TabIndex = 20;
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Location = new System.Drawing.Point(988, 89);
            this.txtUrunAra.Multiline = true;
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(164, 29);
            this.txtUrunAra.TabIndex = 19;
            this.txtUrunAra.TextChanged += new System.EventHandler(this.txtUrunAra_TextChanged);
            // 
            // lblOperator
            // 
            this.lblOperator.Location = new System.Drawing.Point(891, 261);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(91, 35);
            this.lblOperator.TabIndex = 18;
            this.lblOperator.Text = "Operatör:";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAdet
            // 
            this.lblAdet.Location = new System.Drawing.Point(891, 223);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(91, 35);
            this.lblAdet.TabIndex = 17;
            this.lblAdet.Text = "Adet:";
            this.lblAdet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLotNo
            // 
            this.lblLotNo.Location = new System.Drawing.Point(891, 191);
            this.lblLotNo.Name = "lblLotNo";
            this.lblLotNo.Size = new System.Drawing.Size(91, 35);
            this.lblLotNo.TabIndex = 16;
            this.lblLotNo.Text = "Lot No:";
            this.lblLotNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStokAdi
            // 
            this.lblStokAdi.Location = new System.Drawing.Point(891, 156);
            this.lblStokAdi.Name = "lblStokAdi";
            this.lblStokAdi.Size = new System.Drawing.Size(91, 35);
            this.lblStokAdi.TabIndex = 15;
            this.lblStokAdi.Text = "Stok Adı:";
            this.lblStokAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStokKod
            // 
            this.lblStokKod.Location = new System.Drawing.Point(888, 121);
            this.lblStokKod.Name = "lblStokKod";
            this.lblStokKod.Size = new System.Drawing.Size(94, 35);
            this.lblStokKod.TabIndex = 14;
            this.lblStokKod.Text = "Stok Kodu:";
            this.lblStokKod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUrunAra
            // 
            this.lblUrunAra.Location = new System.Drawing.Point(901, 86);
            this.lblUrunAra.Name = "lblUrunAra";
            this.lblUrunAra.Size = new System.Drawing.Size(81, 35);
            this.lblUrunAra.TabIndex = 13;
            this.lblUrunAra.Text = "Ürün Ara:";
            this.lblUrunAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 590);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(1071, 294);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(81, 42);
            this.btnYazdir.TabIndex = 26;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(984, 355);
            this.txtBarkod.Multiline = true;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(164, 29);
            this.txtBarkod.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(984, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 42);
            this.button1.TabIndex = 29;
            this.button1.Text = "Liste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(904, 390);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 79);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(948, 484);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 663);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbBoxOperator);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtLotNo);
            this.Controls.Add(this.txtStokAdi);
            this.Controls.Add(this.txtStokkodu);
            this.Controls.Add(this.txtUrunAra);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblLotNo);
            this.Controls.Add(this.lblStokAdi);
            this.Controls.Add(this.lblStokKod);
            this.Controls.Add(this.lblUrunAra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxOperator;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtLotNo;
        private System.Windows.Forms.TextBox txtStokAdi;
        private System.Windows.Forms.TextBox txtStokkodu;
        private System.Windows.Forms.TextBox txtUrunAra;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblLotNo;
        private System.Windows.Forms.Label lblStokAdi;
        private System.Windows.Forms.Label lblStokKod;
        private System.Windows.Forms.Label lblUrunAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

