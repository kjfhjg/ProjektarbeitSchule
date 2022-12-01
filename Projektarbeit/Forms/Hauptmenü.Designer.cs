namespace Projektarbeit
{
    partial class Hauptmenü
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
            this.btn_NeuesSpiel = new System.Windows.Forms.Button();
            this.btn_SpielLaden = new System.Windows.Forms.Button();
            this.btn_Einstellungen = new System.Windows.Forms.Button();
            this.btn_Verlassen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NeuesSpiel
            // 
            this.btn_NeuesSpiel.Location = new System.Drawing.Point(134, 23);
            this.btn_NeuesSpiel.Name = "btn_NeuesSpiel";
            this.btn_NeuesSpiel.Size = new System.Drawing.Size(150, 50);
            this.btn_NeuesSpiel.TabIndex = 0;
            this.btn_NeuesSpiel.Text = "Neues Spiel";
            this.btn_NeuesSpiel.UseVisualStyleBackColor = true;
            this.btn_NeuesSpiel.Click += new System.EventHandler(this.btn_NeuesSpiel_Click);
            // 
            // btn_SpielLaden
            // 
            this.btn_SpielLaden.Location = new System.Drawing.Point(134, 79);
            this.btn_SpielLaden.Name = "btn_SpielLaden";
            this.btn_SpielLaden.Size = new System.Drawing.Size(150, 50);
            this.btn_SpielLaden.TabIndex = 1;
            this.btn_SpielLaden.Text = "Spiel Laden";
            this.btn_SpielLaden.UseVisualStyleBackColor = true;
            this.btn_SpielLaden.Click += new System.EventHandler(this.btn_SpielLaden_Click);
            // 
            // btn_Einstellungen
            // 
            this.btn_Einstellungen.Location = new System.Drawing.Point(134, 135);
            this.btn_Einstellungen.Name = "btn_Einstellungen";
            this.btn_Einstellungen.Size = new System.Drawing.Size(150, 50);
            this.btn_Einstellungen.TabIndex = 2;
            this.btn_Einstellungen.Text = "Einstellungen";
            this.btn_Einstellungen.UseVisualStyleBackColor = true;
            this.btn_Einstellungen.Click += new System.EventHandler(this.btn_Einstellungen_Click);
            // 
            // btn_Verlassen
            // 
            this.btn_Verlassen.Location = new System.Drawing.Point(134, 191);
            this.btn_Verlassen.Name = "btn_Verlassen";
            this.btn_Verlassen.Size = new System.Drawing.Size(150, 50);
            this.btn_Verlassen.TabIndex = 3;
            this.btn_Verlassen.Text = "Verlassen";
            this.btn_Verlassen.UseVisualStyleBackColor = true;
            this.btn_Verlassen.Click += new System.EventHandler(this.btn_Verlassen_Click);
            // 
            // Hauptmenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 263);
            this.Controls.Add(this.btn_Verlassen);
            this.Controls.Add(this.btn_Einstellungen);
            this.Controls.Add(this.btn_SpielLaden);
            this.Controls.Add(this.btn_NeuesSpiel);
            this.Name = "Hauptmenü";
            this.Text = "KaffeeClicker";
            this.Load += new System.EventHandler(this.Hauptmenü_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NeuesSpiel;
        private System.Windows.Forms.Button btn_SpielLaden;
        private System.Windows.Forms.Button btn_Einstellungen;
        private System.Windows.Forms.Button btn_Verlassen;
    }
}