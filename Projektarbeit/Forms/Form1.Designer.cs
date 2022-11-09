namespace Projektarbeit
{
    partial class Clicker
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_TalerGesamt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TalerPerSecond = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Laden = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Laden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TalerGesamt
            // 
            this.lbl_TalerGesamt.AutoSize = true;
            this.lbl_TalerGesamt.Location = new System.Drawing.Point(130, 66);
            this.lbl_TalerGesamt.Name = "lbl_TalerGesamt";
            this.lbl_TalerGesamt.Size = new System.Drawing.Size(13, 13);
            this.lbl_TalerGesamt.TabIndex = 2;
            this.lbl_TalerGesamt.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kaffee Pro Sekunde";
            // 
            // lbl_TalerPerSecond
            // 
            this.lbl_TalerPerSecond.AutoSize = true;
            this.lbl_TalerPerSecond.Location = new System.Drawing.Point(130, 112);
            this.lbl_TalerPerSecond.Name = "lbl_TalerPerSecond";
            this.lbl_TalerPerSecond.Size = new System.Drawing.Size(13, 13);
            this.lbl_TalerPerSecond.TabIndex = 4;
            this.lbl_TalerPerSecond.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Taler";
            // 
            // btn_Laden
            // 
            this.btn_Laden.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Laden.BackgroundImage = global::Projektarbeit.Properties.Resources.shop;
            this.btn_Laden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Laden.Location = new System.Drawing.Point(244, 12);
            this.btn_Laden.Name = "btn_Laden";
            this.btn_Laden.Size = new System.Drawing.Size(38, 30);
            this.btn_Laden.TabIndex = 6;
            this.btn_Laden.TabStop = false;
            this.btn_Laden.Click += new System.EventHandler(this.btn_Laden_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(48, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 162);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Hauptklicker_Click);
            // 
            // Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 391);
            this.Controls.Add(this.btn_Laden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_TalerPerSecond);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_TalerGesamt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Clicker";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Laden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_TalerGesamt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TalerPerSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_Laden;
    }
}

