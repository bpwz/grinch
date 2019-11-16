namespace hackathon
{
    partial class goronca7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(goronca7));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSprawdz = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.btnPodajCene = new System.Windows.Forms.TextBox();
            this.txtKoniec = new System.Windows.Forms.TextBox();
            this.txtpyt = new System.Windows.Forms.TextBox();
            this.txtOdp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMailpyt = new System.Windows.Forms.TextBox();
            this.txtMailOdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 469);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSprawdz
            // 
            this.btnSprawdz.Location = new System.Drawing.Point(563, 558);
            this.btnSprawdz.Name = "btnSprawdz";
            this.btnSprawdz.Size = new System.Drawing.Size(111, 80);
            this.btnSprawdz.TabIndex = 2;
            this.btnSprawdz.Text = "sprawdz";
            this.btnSprawdz.UseVisualStyleBackColor = true;
            this.btnSprawdz.Click += new System.EventHandler(this.btnSprawdz_Click);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(432, 560);
            this.txtCena.Multiline = true;
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(113, 78);
            this.txtCena.TabIndex = 3;
            // 
            // btnPodajCene
            // 
            this.btnPodajCene.Location = new System.Drawing.Point(301, 560);
            this.btnPodajCene.Multiline = true;
            this.btnPodajCene.Name = "btnPodajCene";
            this.btnPodajCene.Size = new System.Drawing.Size(113, 78);
            this.btnPodajCene.TabIndex = 5;
            this.btnPodajCene.Text = "Podaj cenę za jaką jesteś w stanie zapłacić";
            // 
            // txtKoniec
            // 
            this.txtKoniec.Location = new System.Drawing.Point(700, 560);
            this.txtKoniec.Multiline = true;
            this.txtKoniec.Name = "txtKoniec";
            this.txtKoniec.Size = new System.Drawing.Size(113, 78);
            this.txtKoniec.TabIndex = 6;
            // 
            // txtpyt
            // 
            this.txtpyt.Location = new System.Drawing.Point(1041, 481);
            this.txtpyt.Multiline = true;
            this.txtpyt.Name = "txtpyt";
            this.txtpyt.Size = new System.Drawing.Size(100, 93);
            this.txtpyt.TabIndex = 7;
            this.txtpyt.Text = "Jeżeli chcesz potwierdzenie zakupu kliknij T a jak nie to N";
            this.txtpyt.TextChanged += new System.EventHandler(this.txtpyt_TextChanged);
            // 
            // txtOdp
            // 
            this.txtOdp.Location = new System.Drawing.Point(1041, 599);
            this.txtOdp.Name = "txtOdp";
            this.txtOdp.Size = new System.Drawing.Size(100, 20);
            this.txtOdp.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(992, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "wyslij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMailpyt
            // 
            this.txtMailpyt.Location = new System.Drawing.Point(924, 481);
            this.txtMailpyt.Multiline = true;
            this.txtMailpyt.Name = "txtMailpyt";
            this.txtMailpyt.Size = new System.Drawing.Size(100, 93);
            this.txtMailpyt.TabIndex = 10;
            this.txtMailpyt.Text = "podaj nazwe maila na jakiego wyslac potwierdzenie";
            // 
            // txtMailOdp
            // 
            this.txtMailOdp.Location = new System.Drawing.Point(914, 599);
            this.txtMailOdp.Name = "txtMailOdp";
            this.txtMailOdp.Size = new System.Drawing.Size(100, 20);
            this.txtMailOdp.TabIndex = 11;
            this.txtMailOdp.TextChanged += new System.EventHandler(this.txtMailOdp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(839, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mac Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(839, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rodzaj : Komputer ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(839, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Matryca : 13\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(860, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(839, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(424, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "System Operacyjny : MasOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(839, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Pamięć : 256 gb ssd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(839, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 37);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ram : 8GB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(839, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 37);
            this.label8.TabIndex = 19;
            this.label8.Text = "Procesor Intel Core i5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(839, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 37);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sprzedawca : Apple";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1283, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "cofnij zakładkę";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // goronca7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMailOdp);
            this.Controls.Add(this.txtMailpyt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOdp);
            this.Controls.Add(this.txtpyt);
            this.Controls.Add(this.txtKoniec);
            this.Controls.Add(this.btnPodajCene);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.btnSprawdz);
            this.Controls.Add(this.pictureBox1);
            this.Name = "goronca7";
            this.Text = "goronca7";
            this.Load += new System.EventHandler(this.goronca7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSprawdz;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox btnPodajCene;
        private System.Windows.Forms.TextBox txtKoniec;
        private System.Windows.Forms.TextBox txtpyt;
        private System.Windows.Forms.TextBox txtOdp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMailpyt;
        private System.Windows.Forms.TextBox txtMailOdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
    }
}