namespace Projektarbeit
{
    partial class uc_Einstellungen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ShopÖffnen = new System.Windows.Forms.TextBox();
            this.txt_ShopSchließen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Einstellungen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shop öffnen";
            // 
            // txt_ShopÖffnen
            // 
            this.txt_ShopÖffnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ShopÖffnen.Location = new System.Drawing.Point(136, 53);
            this.txt_ShopÖffnen.Name = "txt_ShopÖffnen";
            this.txt_ShopÖffnen.Size = new System.Drawing.Size(100, 20);
            this.txt_ShopÖffnen.TabIndex = 2;
            this.txt_ShopÖffnen.Text = "I";
            this.txt_ShopÖffnen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ShopSchließen
            // 
            this.txt_ShopSchließen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ShopSchließen.Location = new System.Drawing.Point(136, 83);
            this.txt_ShopSchließen.Name = "txt_ShopSchließen";
            this.txt_ShopSchließen.Size = new System.Drawing.Size(100, 20);
            this.txt_ShopSchließen.TabIndex = 4;
            this.txt_ShopSchließen.Text = "ESC";
            this.txt_ShopSchließen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shop schließen";
            // 
            // uc_Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_ShopSchließen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ShopÖffnen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uc_Einstellungen";
            this.Size = new System.Drawing.Size(276, 133);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ShopÖffnen;
        private System.Windows.Forms.TextBox txt_ShopSchließen;
        private System.Windows.Forms.Label label3;
    }
}
