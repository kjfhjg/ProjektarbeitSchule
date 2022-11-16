namespace Projektarbeit
{
    partial class uc_NeuesSpiel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_Kaffe = new System.Windows.Forms.PictureBox();
            this.panelKaffe = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Starten = new System.Windows.Forms.Button();
            this.btn_Zurück = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Kaffe)).BeginInit();
            this.panelKaffe.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Kaffe
            // 
            this.pb_Kaffe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_Kaffe.Location = new System.Drawing.Point(21, 20);
            this.pb_Kaffe.Name = "pb_Kaffe";
            this.pb_Kaffe.Size = new System.Drawing.Size(200, 200);
            this.pb_Kaffe.TabIndex = 0;
            this.pb_Kaffe.TabStop = false;
            this.pb_Kaffe.Click += new System.EventHandler(this.pb_Kaffe_Click);
            // 
            // panelKaffe
            // 
            this.panelKaffe.Controls.Add(this.pb_Kaffe);
            this.panelKaffe.Location = new System.Drawing.Point(290, 286);
            this.panelKaffe.Name = "panelKaffe";
            this.panelKaffe.Size = new System.Drawing.Size(240, 240);
            this.panelKaffe.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(546, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 240);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(801, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 240);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(21, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Starten
            // 
            this.btn_Starten.Location = new System.Drawing.Point(1087, 623);
            this.btn_Starten.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btn_Starten.Name = "btn_Starten";
            this.btn_Starten.Size = new System.Drawing.Size(200, 100);
            this.btn_Starten.TabIndex = 1;
            this.btn_Starten.Text = "Starten";
            this.btn_Starten.UseVisualStyleBackColor = true;
            this.btn_Starten.Click += new System.EventHandler(this.btn_Starten_Click);
            // 
            // btn_Zurück
            // 
            this.btn_Zurück.Location = new System.Drawing.Point(20, 623);
            this.btn_Zurück.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btn_Zurück.Name = "btn_Zurück";
            this.btn_Zurück.Size = new System.Drawing.Size(200, 100);
            this.btn_Zurück.TabIndex = 6;
            this.btn_Zurück.Text = "Zurück";
            this.btn_Zurück.UseVisualStyleBackColor = true;
            this.btn_Zurück.Click += new System.EventHandler(this.btn_Zurück_Click);
            // 
            // uc_NeuesSpiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Zurück);
            this.Controls.Add(this.btn_Starten);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelKaffe);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "uc_NeuesSpiel";
            this.Size = new System.Drawing.Size(1341, 851);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Kaffe)).EndInit();
            this.panelKaffe.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Kaffe;
        private System.Windows.Forms.Panel panelKaffe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Starten;
        private System.Windows.Forms.Button btn_Zurück;
    }
}
