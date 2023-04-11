namespace F1Karte.UI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.txtTribina = new System.Windows.Forms.TextBox();
            this.txtBrDana = new System.Windows.Forms.TextBox();
            this.txtxCenaKarte = new System.Windows.Forms.TextBox();
            this.txtStaza = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFilterCena = new System.Windows.Forms.CheckBox();
            this.cbFilterGrad = new System.Windows.Forms.CheckBox();
            this.txtFilterCena = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtFilterGrad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(540, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(656, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtDrzava
            // 
            this.txtDrzava.Location = new System.Drawing.Point(161, 24);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(224, 23);
            this.txtDrzava.TabIndex = 1;
            // 
            // txtTribina
            // 
            this.txtTribina.Location = new System.Drawing.Point(161, 198);
            this.txtTribina.Name = "txtTribina";
            this.txtTribina.Size = new System.Drawing.Size(224, 23);
            this.txtTribina.TabIndex = 2;
            // 
            // txtBrDana
            // 
            this.txtBrDana.Location = new System.Drawing.Point(161, 169);
            this.txtBrDana.Name = "txtBrDana";
            this.txtBrDana.Size = new System.Drawing.Size(224, 23);
            this.txtBrDana.TabIndex = 3;
            // 
            // txtxCenaKarte
            // 
            this.txtxCenaKarte.Location = new System.Drawing.Point(161, 140);
            this.txtxCenaKarte.Name = "txtxCenaKarte";
            this.txtxCenaKarte.Size = new System.Drawing.Size(224, 23);
            this.txtxCenaKarte.TabIndex = 4;
            // 
            // txtStaza
            // 
            this.txtStaza.Location = new System.Drawing.Point(161, 111);
            this.txtStaza.Name = "txtStaza";
            this.txtStaza.Size = new System.Drawing.Size(224, 23);
            this.txtStaza.TabIndex = 5;
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(161, 53);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(224, 23);
            this.txtGrad.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Drzava";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tribina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Broj dana vazenja karte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cena karte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Naziv staze";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Grad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Datum";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(161, 83);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(223, 23);
            this.date.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(568, 322);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(219, 23);
            this.txtID.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(793, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = "Obrisi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Filtriraj po:";
            // 
            // cbFilterCena
            // 
            this.cbFilterCena.AutoSize = true;
            this.cbFilterCena.Location = new System.Drawing.Point(8, 284);
            this.cbFilterCena.Name = "cbFilterCena";
            this.cbFilterCena.Size = new System.Drawing.Size(50, 19);
            this.cbFilterCena.TabIndex = 21;
            this.cbFilterCena.Text = "Ceni";
            this.cbFilterCena.UseVisualStyleBackColor = true;
            this.cbFilterCena.CheckedChanged += new System.EventHandler(this.cbFilterCena_CheckedChanged);
            // 
            // cbFilterGrad
            // 
            this.cbFilterGrad.AutoSize = true;
            this.cbFilterGrad.Location = new System.Drawing.Point(144, 284);
            this.cbFilterGrad.Name = "cbFilterGrad";
            this.cbFilterGrad.Size = new System.Drawing.Size(58, 19);
            this.cbFilterGrad.TabIndex = 22;
            this.cbFilterGrad.Text = "Gradu";
            this.cbFilterGrad.UseVisualStyleBackColor = true;
            this.cbFilterGrad.CheckedChanged += new System.EventHandler(this.cbFilterGrad_CheckedChanged);
            // 
            // txtFilterCena
            // 
            this.txtFilterCena.Location = new System.Drawing.Point(8, 309);
            this.txtFilterCena.Name = "txtFilterCena";
            this.txtFilterCena.Size = new System.Drawing.Size(124, 23);
            this.txtFilterCena.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 25);
            this.button3.TabIndex = 25;
            this.button3.Text = "Filtriraj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtFilterGrad
            // 
            this.txtFilterGrad.Location = new System.Drawing.Point(144, 309);
            this.txtFilterGrad.Name = "txtFilterGrad";
            this.txtFilterGrad.Size = new System.Drawing.Size(124, 23);
            this.txtFilterGrad.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 382);
            this.Controls.Add(this.txtFilterGrad);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtFilterCena);
            this.Controls.Add(this.cbFilterGrad);
            this.Controls.Add(this.cbFilterCena);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.date);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.txtStaza);
            this.Controls.Add(this.txtxCenaKarte);
            this.Controls.Add(this.txtBrDana);
            this.Controls.Add(this.txtTribina);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtDrzava;
        private TextBox txtTribina;
        private TextBox txtBrDana;
        private TextBox txtxCenaKarte;
        private TextBox txtStaza;
        private TextBox txtGrad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private DateTimePicker date;
        private Label label8;
        private TextBox txtID;
        private Button button2;
        private Label label9;
        private CheckBox cbFilterCena;
        private CheckBox cbFilterGrad;
        private TextBox txtFilterCena;
        private Button button3;
        private TextBox txtFilterGrad;
    }
}