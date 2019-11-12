namespace Betoltes_Mentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Szuletesi_Datum = new System.Windows.Forms.DateTimePicker();
            this.radioButton_ferfi = new System.Windows.Forms.RadioButton();
            this.radioButton_no = new System.Windows.Forms.RadioButton();
            this.listBox_Hobbik = new System.Windows.Forms.ListBox();
            this.textBox_Ujhobbi = new System.Windows.Forms.TextBox();
            this.button_Hobbit_hozzaad = new System.Windows.Forms.Button();
            this.button_Mentes = new System.Windows.Forms.Button();
            this.button_Betoltes = new System.Windows.Forms.Button();
            this.checkBox_feliratkozom = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hobbik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Feliratkozom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Születési dátum";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(196, 52);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(204, 29);
            this.textBox_nev.TabIndex = 6;
            this.textBox_nev.TextChanged += new System.EventHandler(this.Csak_betuket_enged);
            // 
            // dateTimePicker_Szuletesi_Datum
            // 
            this.dateTimePicker_Szuletesi_Datum.Location = new System.Drawing.Point(196, 115);
            this.dateTimePicker_Szuletesi_Datum.Name = "dateTimePicker_Szuletesi_Datum";
            this.dateTimePicker_Szuletesi_Datum.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker_Szuletesi_Datum.TabIndex = 7;
            // 
            // radioButton_ferfi
            // 
            this.radioButton_ferfi.AutoSize = true;
            this.radioButton_ferfi.Location = new System.Drawing.Point(196, 181);
            this.radioButton_ferfi.Name = "radioButton_ferfi";
            this.radioButton_ferfi.Size = new System.Drawing.Size(40, 28);
            this.radioButton_ferfi.TabIndex = 8;
            this.radioButton_ferfi.TabStop = true;
            this.radioButton_ferfi.Text = "F";
            this.radioButton_ferfi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButton_ferfi.UseVisualStyleBackColor = true;
            // 
            // radioButton_no
            // 
            this.radioButton_no.AutoSize = true;
            this.radioButton_no.Location = new System.Drawing.Point(291, 181);
            this.radioButton_no.Name = "radioButton_no";
            this.radioButton_no.Size = new System.Drawing.Size(42, 28);
            this.radioButton_no.TabIndex = 9;
            this.radioButton_no.TabStop = true;
            this.radioButton_no.Text = "N";
            this.radioButton_no.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButton_no.UseVisualStyleBackColor = true;
            // 
            // listBox_Hobbik
            // 
            this.listBox_Hobbik.FormattingEnabled = true;
            this.listBox_Hobbik.ItemHeight = 24;
            this.listBox_Hobbik.Location = new System.Drawing.Point(447, 56);
            this.listBox_Hobbik.Name = "listBox_Hobbik";
            this.listBox_Hobbik.Size = new System.Drawing.Size(197, 196);
            this.listBox_Hobbik.TabIndex = 10;
            // 
            // textBox_Ujhobbi
            // 
            this.textBox_Ujhobbi.Location = new System.Drawing.Point(447, 259);
            this.textBox_Ujhobbi.Name = "textBox_Ujhobbi";
            this.textBox_Ujhobbi.Size = new System.Drawing.Size(197, 29);
            this.textBox_Ujhobbi.TabIndex = 11;
            // 
            // button_Hobbit_hozzaad
            // 
            this.button_Hobbit_hozzaad.Location = new System.Drawing.Point(447, 303);
            this.button_Hobbit_hozzaad.Name = "button_Hobbit_hozzaad";
            this.button_Hobbit_hozzaad.Size = new System.Drawing.Size(197, 34);
            this.button_Hobbit_hozzaad.TabIndex = 12;
            this.button_Hobbit_hozzaad.Text = "Hozzáad";
            this.button_Hobbit_hozzaad.UseVisualStyleBackColor = true;
            this.button_Hobbit_hozzaad.Click += new System.EventHandler(this.button_Hobbit_hozzaad_Click);
            // 
            // button_Mentes
            // 
            this.button_Mentes.Location = new System.Drawing.Point(95, 389);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(184, 42);
            this.button_Mentes.TabIndex = 13;
            this.button_Mentes.Text = "Mentés";
            this.button_Mentes.UseVisualStyleBackColor = true;
            this.button_Mentes.Click += new System.EventHandler(this.button_Mentes_Click);
            // 
            // button1
            // 
            this.button_Betoltes.Location = new System.Drawing.Point(386, 389);
            this.button_Betoltes.Name = "button1";
            this.button_Betoltes.Size = new System.Drawing.Size(184, 42);
            this.button_Betoltes.TabIndex = 14;
            this.button_Betoltes.Text = "Betöltés";
            this.button_Betoltes.UseVisualStyleBackColor = true;
            this.button_Betoltes.Click += new System.EventHandler(this.button_Betoltes_Click);
            // 
            // checkBox_feliratkozom
            // 
            this.checkBox_feliratkozom.AutoSize = true;
            this.checkBox_feliratkozom.Location = new System.Drawing.Point(196, 241);
            this.checkBox_feliratkozom.Name = "checkBox_feliratkozom";
            this.checkBox_feliratkozom.Size = new System.Drawing.Size(15, 14);
            this.checkBox_feliratkozom.TabIndex = 15;
            this.checkBox_feliratkozom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBox_feliratkozom.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 456);
            this.Controls.Add(this.checkBox_feliratkozom);
            this.Controls.Add(this.button_Betoltes);
            this.Controls.Add(this.button_Mentes);
            this.Controls.Add(this.button_Hobbit_hozzaad);
            this.Controls.Add(this.textBox_Ujhobbi);
            this.Controls.Add(this.listBox_Hobbik);
            this.Controls.Add(this.radioButton_no);
            this.Controls.Add(this.radioButton_ferfi);
            this.Controls.Add(this.dateTimePicker_Szuletesi_Datum);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Betöltés és mentés gyakorlás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Szuletesi_Datum;
        private System.Windows.Forms.RadioButton radioButton_ferfi;
        private System.Windows.Forms.RadioButton radioButton_no;
        private System.Windows.Forms.ListBox listBox_Hobbik;
        private System.Windows.Forms.TextBox textBox_Ujhobbi;
        private System.Windows.Forms.Button button_Hobbit_hozzaad;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.Button button_Betoltes;
        private System.Windows.Forms.CheckBox checkBox_feliratkozom;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

