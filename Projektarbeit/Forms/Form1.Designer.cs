﻿namespace Projektarbeit
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Laden = new System.Windows.Forms.PictureBox();
            this.lbl_TalerGesamt = new System.Windows.Forms.TextBox();
            this.lbl_TalerPerClick = new System.Windows.Forms.TextBox();
            this.tmr_autoclicker = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Laden)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kaffee Pro Click";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 39);
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
            // lbl_TalerGesamt
            // 
            this.lbl_TalerGesamt.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_TalerGesamt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_TalerGesamt.Enabled = false;
            this.lbl_TalerGesamt.Location = new System.Drawing.Point(91, 67);
            this.lbl_TalerGesamt.Name = "lbl_TalerGesamt";
            this.lbl_TalerGesamt.Size = new System.Drawing.Size(100, 13);
            this.lbl_TalerGesamt.TabIndex = 7;
            this.lbl_TalerGesamt.Text = "0";
            this.lbl_TalerGesamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_TalerPerClick
            // 
            this.lbl_TalerPerClick.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_TalerPerClick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_TalerPerClick.Enabled = false;
            this.lbl_TalerPerClick.Location = new System.Drawing.Point(91, 106);
            this.lbl_TalerPerClick.Name = "lbl_TalerPerClick";
            this.lbl_TalerPerClick.Size = new System.Drawing.Size(100, 13);
            this.lbl_TalerPerClick.TabIndex = 8;
            this.lbl_TalerPerClick.Text = "0";
            this.lbl_TalerPerClick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmr_autoclicker
            // 
            this.tmr_autoclicker.Interval = 6000;
            this.tmr_autoclicker.Tick += new System.EventHandler(this.tmr_autoclicker_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Projektarbeit.Properties.Resources.KaffeeKanne;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(46, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 162);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Hauptklicker_Click);
            // 
            // Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_TalerPerClick);
            this.Controls.Add(this.lbl_TalerGesamt);
            this.Controls.Add(this.btn_Laden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KaffeeClicker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Clicker_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clicker_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Laden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_Laden;
        private System.Windows.Forms.TextBox lbl_TalerGesamt;
        private System.Windows.Forms.TextBox lbl_TalerPerClick;
        public System.Windows.Forms.Timer tmr_autoclicker;
        private System.Windows.Forms.Button button1;
    }
}

