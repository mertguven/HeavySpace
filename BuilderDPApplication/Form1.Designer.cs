namespace BuilderDPApplication
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.markaLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.boyutLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dboyutuLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tipLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.yuvaLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.markaTxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.boyutTxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.dBoyutuTXT = new Bunifu.Framework.BunifuCustomTextbox();
            this.tipTxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.yuvaTxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.heavySpaceLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.getirBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.zoomexRBtn = new System.Windows.Forms.RadioButton();
            this.bushmanRBtn = new System.Windows.Forms.RadioButton();
            this.modelTxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.modelLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.celestronRBtn = new System.Windows.Forms.RadioButton();
            this.nikonRBtn = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // markaLbl
            // 
            this.markaLbl.AutoSize = true;
            this.markaLbl.BackColor = System.Drawing.Color.Transparent;
            this.markaLbl.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markaLbl.ForeColor = System.Drawing.Color.White;
            this.markaLbl.Location = new System.Drawing.Point(162, 131);
            this.markaLbl.Name = "markaLbl";
            this.markaLbl.Size = new System.Drawing.Size(50, 17);
            this.markaLbl.TabIndex = 2;
            this.markaLbl.Text = "Marka:";
            // 
            // boyutLbl
            // 
            this.boyutLbl.AutoSize = true;
            this.boyutLbl.BackColor = System.Drawing.Color.Transparent;
            this.boyutLbl.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boyutLbl.ForeColor = System.Drawing.Color.White;
            this.boyutLbl.Location = new System.Drawing.Point(164, 192);
            this.boyutLbl.Name = "boyutLbl";
            this.boyutLbl.Size = new System.Drawing.Size(48, 17);
            this.boyutLbl.TabIndex = 3;
            this.boyutLbl.Text = "Boyut:";
            // 
            // dboyutuLbl
            // 
            this.dboyutuLbl.AutoSize = true;
            this.dboyutuLbl.BackColor = System.Drawing.Color.Transparent;
            this.dboyutuLbl.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dboyutuLbl.ForeColor = System.Drawing.Color.White;
            this.dboyutuLbl.Location = new System.Drawing.Point(95, 225);
            this.dboyutuLbl.Name = "dboyutuLbl";
            this.dboyutuLbl.Size = new System.Drawing.Size(117, 17);
            this.dboyutuLbl.TabIndex = 3;
            this.dboyutuLbl.Text = "Diyafram Boyutu:";
            // 
            // tipLbl
            // 
            this.tipLbl.AutoSize = true;
            this.tipLbl.BackColor = System.Drawing.Color.Transparent;
            this.tipLbl.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLbl.ForeColor = System.Drawing.Color.White;
            this.tipLbl.Location = new System.Drawing.Point(176, 257);
            this.tipLbl.Name = "tipLbl";
            this.tipLbl.Size = new System.Drawing.Size(36, 17);
            this.tipLbl.TabIndex = 4;
            this.tipLbl.Text = "Tipi:";
            // 
            // yuvaLbl
            // 
            this.yuvaLbl.AutoSize = true;
            this.yuvaLbl.BackColor = System.Drawing.Color.Transparent;
            this.yuvaLbl.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yuvaLbl.ForeColor = System.Drawing.Color.White;
            this.yuvaLbl.Location = new System.Drawing.Point(170, 289);
            this.yuvaLbl.Name = "yuvaLbl";
            this.yuvaLbl.Size = new System.Drawing.Size(42, 17);
            this.yuvaLbl.TabIndex = 5;
            this.yuvaLbl.Text = "Yuva:";
            // 
            // markaTxt
            // 
            this.markaTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.markaTxt.Enabled = false;
            this.markaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markaTxt.Location = new System.Drawing.Point(218, 129);
            this.markaTxt.Name = "markaTxt";
            this.markaTxt.Size = new System.Drawing.Size(111, 21);
            this.markaTxt.TabIndex = 6;
            this.markaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boyutTxt
            // 
            this.boyutTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.boyutTxt.Enabled = false;
            this.boyutTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boyutTxt.Location = new System.Drawing.Point(218, 191);
            this.boyutTxt.Name = "boyutTxt";
            this.boyutTxt.Size = new System.Drawing.Size(111, 21);
            this.boyutTxt.TabIndex = 7;
            this.boyutTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dBoyutuTXT
            // 
            this.dBoyutuTXT.BorderColor = System.Drawing.Color.SeaGreen;
            this.dBoyutuTXT.Enabled = false;
            this.dBoyutuTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dBoyutuTXT.Location = new System.Drawing.Point(218, 224);
            this.dBoyutuTXT.Name = "dBoyutuTXT";
            this.dBoyutuTXT.Size = new System.Drawing.Size(111, 21);
            this.dBoyutuTXT.TabIndex = 8;
            this.dBoyutuTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tipTxt
            // 
            this.tipTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.tipTxt.Enabled = false;
            this.tipTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tipTxt.Location = new System.Drawing.Point(218, 256);
            this.tipTxt.Name = "tipTxt";
            this.tipTxt.Size = new System.Drawing.Size(111, 21);
            this.tipTxt.TabIndex = 9;
            this.tipTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yuvaTxt
            // 
            this.yuvaTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.yuvaTxt.Enabled = false;
            this.yuvaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yuvaTxt.Location = new System.Drawing.Point(218, 289);
            this.yuvaTxt.Name = "yuvaTxt";
            this.yuvaTxt.Size = new System.Drawing.Size(111, 21);
            this.yuvaTxt.TabIndex = 10;
            this.yuvaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.heavySpaceLbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 40);
            this.panel1.TabIndex = 11;
            // 
            // heavySpaceLbl
            // 
            this.heavySpaceLbl.AutoSize = true;
            this.heavySpaceLbl.BackColor = System.Drawing.Color.Transparent;
            this.heavySpaceLbl.Font = new System.Drawing.Font("MV Boli", 15.75F);
            this.heavySpaceLbl.ForeColor = System.Drawing.Color.White;
            this.heavySpaceLbl.Location = new System.Drawing.Point(197, 6);
            this.heavySpaceLbl.Name = "heavySpaceLbl";
            this.heavySpaceLbl.Size = new System.Drawing.Size(132, 28);
            this.heavySpaceLbl.TabIndex = 20;
            this.heavySpaceLbl.Text = "Heavy Space";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BuilderDPApplication.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(466, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // getirBtn
            // 
            this.getirBtn.Active = false;
            this.getirBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.getirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.getirBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.getirBtn.BorderRadius = 7;
            this.getirBtn.ButtonText = "Ürün Getir";
            this.getirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getirBtn.DisabledColor = System.Drawing.Color.Gray;
            this.getirBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.getirBtn.Iconimage = global::BuilderDPApplication.Properties.Resources.bring;
            this.getirBtn.Iconimage_right = null;
            this.getirBtn.Iconimage_right_Selected = null;
            this.getirBtn.Iconimage_Selected = null;
            this.getirBtn.IconMarginLeft = 0;
            this.getirBtn.IconMarginRight = 0;
            this.getirBtn.IconRightVisible = true;
            this.getirBtn.IconRightZoom = 0D;
            this.getirBtn.IconVisible = true;
            this.getirBtn.IconZoom = 90D;
            this.getirBtn.IsTab = false;
            this.getirBtn.Location = new System.Drawing.Point(169, 377);
            this.getirBtn.Name = "getirBtn";
            this.getirBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.getirBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.getirBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.getirBtn.selected = false;
            this.getirBtn.Size = new System.Drawing.Size(162, 62);
            this.getirBtn.TabIndex = 12;
            this.getirBtn.Text = "Ürün Getir";
            this.getirBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.getirBtn.Textcolor = System.Drawing.Color.White;
            this.getirBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getirBtn.Click += new System.EventHandler(this.getirBtn_Click);
            // 
            // zoomexRBtn
            // 
            this.zoomexRBtn.AutoSize = true;
            this.zoomexRBtn.BackColor = System.Drawing.Color.Transparent;
            this.zoomexRBtn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.zoomexRBtn.ForeColor = System.Drawing.Color.White;
            this.zoomexRBtn.Location = new System.Drawing.Point(43, 337);
            this.zoomexRBtn.Name = "zoomexRBtn";
            this.zoomexRBtn.Size = new System.Drawing.Size(76, 21);
            this.zoomexRBtn.TabIndex = 13;
            this.zoomexRBtn.TabStop = true;
            this.zoomexRBtn.Text = "Zoomex";
            this.zoomexRBtn.UseVisualStyleBackColor = false;
            // 
            // bushmanRBtn
            // 
            this.bushmanRBtn.AutoSize = true;
            this.bushmanRBtn.BackColor = System.Drawing.Color.Transparent;
            this.bushmanRBtn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.bushmanRBtn.ForeColor = System.Drawing.Color.White;
            this.bushmanRBtn.Location = new System.Drawing.Point(150, 337);
            this.bushmanRBtn.Name = "bushmanRBtn";
            this.bushmanRBtn.Size = new System.Drawing.Size(83, 21);
            this.bushmanRBtn.TabIndex = 14;
            this.bushmanRBtn.TabStop = true;
            this.bushmanRBtn.Text = "Bushman";
            this.bushmanRBtn.UseVisualStyleBackColor = false;
            // 
            // modelTxt
            // 
            this.modelTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.modelTxt.Enabled = false;
            this.modelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modelTxt.Location = new System.Drawing.Point(218, 160);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(111, 21);
            this.modelTxt.TabIndex = 16;
            this.modelTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.BackColor = System.Drawing.Color.Transparent;
            this.modelLbl.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLbl.ForeColor = System.Drawing.Color.White;
            this.modelLbl.Location = new System.Drawing.Point(161, 161);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(51, 17);
            this.modelLbl.TabIndex = 15;
            this.modelLbl.Text = "Model:";
            // 
            // celestronRBtn
            // 
            this.celestronRBtn.AutoSize = true;
            this.celestronRBtn.BackColor = System.Drawing.Color.Transparent;
            this.celestronRBtn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.celestronRBtn.ForeColor = System.Drawing.Color.White;
            this.celestronRBtn.Location = new System.Drawing.Point(270, 337);
            this.celestronRBtn.Name = "celestronRBtn";
            this.celestronRBtn.Size = new System.Drawing.Size(88, 21);
            this.celestronRBtn.TabIndex = 17;
            this.celestronRBtn.TabStop = true;
            this.celestronRBtn.Text = "Celestron ";
            this.celestronRBtn.UseVisualStyleBackColor = false;
            // 
            // nikonRBtn
            // 
            this.nikonRBtn.AutoSize = true;
            this.nikonRBtn.BackColor = System.Drawing.Color.Transparent;
            this.nikonRBtn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.nikonRBtn.ForeColor = System.Drawing.Color.White;
            this.nikonRBtn.Location = new System.Drawing.Point(393, 337);
            this.nikonRBtn.Name = "nikonRBtn";
            this.nikonRBtn.Size = new System.Drawing.Size(63, 21);
            this.nikonRBtn.TabIndex = 18;
            this.nikonRBtn.TabStop = true;
            this.nikonRBtn.Text = "Nikon";
            this.nikonRBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BuilderDPApplication.Properties.Resources.teleskop;
            this.pictureBox2.Location = new System.Drawing.Point(141, 488);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 230);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.heavySpaceLbl;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(500, 750);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nikonRBtn);
            this.Controls.Add(this.celestronRBtn);
            this.Controls.Add(this.modelTxt);
            this.Controls.Add(this.modelLbl);
            this.Controls.Add(this.bushmanRBtn);
            this.Controls.Add(this.zoomexRBtn);
            this.Controls.Add(this.getirBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.yuvaTxt);
            this.Controls.Add(this.tipTxt);
            this.Controls.Add(this.dBoyutuTXT);
            this.Controls.Add(this.boyutTxt);
            this.Controls.Add(this.markaTxt);
            this.Controls.Add(this.yuvaLbl);
            this.Controls.Add(this.tipLbl);
            this.Controls.Add(this.dboyutuLbl);
            this.Controls.Add(this.boyutLbl);
            this.Controls.Add(this.markaLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel markaLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel boyutLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel dboyutuLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel tipLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel yuvaLbl;
        private Bunifu.Framework.BunifuCustomTextbox markaTxt;
        private Bunifu.Framework.BunifuCustomTextbox boyutTxt;
        private Bunifu.Framework.BunifuCustomTextbox dBoyutuTXT;
        private Bunifu.Framework.BunifuCustomTextbox tipTxt;
        private Bunifu.Framework.BunifuCustomTextbox yuvaTxt;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton getirBtn;
        private System.Windows.Forms.RadioButton zoomexRBtn;
        private System.Windows.Forms.RadioButton bushmanRBtn;
        private Bunifu.Framework.BunifuCustomTextbox modelTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel modelLbl;
        private System.Windows.Forms.RadioButton celestronRBtn;
        private System.Windows.Forms.RadioButton nikonRBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel heavySpaceLbl;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}

