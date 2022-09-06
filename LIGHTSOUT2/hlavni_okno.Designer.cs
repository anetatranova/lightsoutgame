namespace LIGHTSOUT2
{
    partial class hlavni_okno
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
            this.btn_manual = new System.Windows.Forms.Button();
            this.btn_hrathru = new System.Windows.Forms.Button();
            this.lbl_vitej = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_manual
            // 
            this.btn_manual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_manual.Location = new System.Drawing.Point(294, 175);
            this.btn_manual.Name = "btn_manual";
            this.btn_manual.Size = new System.Drawing.Size(186, 72);
            this.btn_manual.TabIndex = 0;
            this.btn_manual.Text = "Manuál";
            this.btn_manual.UseVisualStyleBackColor = true;
            this.btn_manual.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // btn_hrathru
            // 
            this.btn_hrathru.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_hrathru.Location = new System.Drawing.Point(294, 285);
            this.btn_hrathru.Name = "btn_hrathru";
            this.btn_hrathru.Size = new System.Drawing.Size(186, 72);
            this.btn_hrathru.TabIndex = 1;
            this.btn_hrathru.Text = "Hrát hru";
            this.btn_hrathru.UseVisualStyleBackColor = true;
            this.btn_hrathru.Click += new System.EventHandler(this.btn_hrathru_Click);
            // 
            // lbl_vitej
            // 
            this.lbl_vitej.AutoSize = true;
            this.lbl_vitej.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_vitej.Location = new System.Drawing.Point(228, 70);
            this.lbl_vitej.Name = "lbl_vitej";
            this.lbl_vitej.Size = new System.Drawing.Size(345, 45);
            this.lbl_vitej.TabIndex = 2;
            this.lbl_vitej.Text = "Vítej ve hře Lights Out!";
            // 
            // hlavni_okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_vitej);
            this.Controls.Add(this.btn_hrathru);
            this.Controls.Add(this.btn_manual);
            this.Name = "hlavni_okno";
            this.Text = "Lights Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_manual;
        private Button btn_hrathru;
        private Label lbl_vitej;
    }
}