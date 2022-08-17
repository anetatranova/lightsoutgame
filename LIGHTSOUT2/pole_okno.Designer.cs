namespace LIGHTSOUT2
{
    partial class pole_okno
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
            this.btn_3x3 = new System.Windows.Forms.Button();
            this.btn_5x5 = new System.Windows.Forms.Button();
            this.btn_7x7 = new System.Windows.Forms.Button();
            this.lbl_pole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_3x3
            // 
            this.btn_3x3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_3x3.Location = new System.Drawing.Point(289, 132);
            this.btn_3x3.Name = "btn_3x3";
            this.btn_3x3.Size = new System.Drawing.Size(201, 71);
            this.btn_3x3.TabIndex = 0;
            this.btn_3x3.Text = "3x3";
            this.btn_3x3.UseVisualStyleBackColor = true;
            this.btn_3x3.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_5x5
            // 
            this.btn_5x5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_5x5.Location = new System.Drawing.Point(289, 225);
            this.btn_5x5.Name = "btn_5x5";
            this.btn_5x5.Size = new System.Drawing.Size(201, 71);
            this.btn_5x5.TabIndex = 1;
            this.btn_5x5.Text = "5x5";
            this.btn_5x5.UseVisualStyleBackColor = true;
            this.btn_5x5.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_7x7
            // 
            this.btn_7x7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_7x7.Location = new System.Drawing.Point(289, 320);
            this.btn_7x7.Name = "btn_7x7";
            this.btn_7x7.Size = new System.Drawing.Size(201, 71);
            this.btn_7x7.TabIndex = 2;
            this.btn_7x7.Text = "7x7";
            this.btn_7x7.UseVisualStyleBackColor = true;
            this.btn_7x7.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_pole
            // 
            this.lbl_pole.AutoSize = true;
            this.lbl_pole.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pole.Location = new System.Drawing.Point(185, 58);
            this.lbl_pole.Name = "lbl_pole";
            this.lbl_pole.Size = new System.Drawing.Size(443, 45);
            this.lbl_pole.TabIndex = 3;
            this.lbl_pole.Text = "Vyber si velikost hracího pole:";
            // 
            // pole_okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_pole);
            this.Controls.Add(this.btn_7x7);
            this.Controls.Add(this.btn_5x5);
            this.Controls.Add(this.btn_3x3);
            this.Name = "pole_okno";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_3x3;
        private Button btn_5x5;
        private Button btn_7x7;
        private Label lbl_pole;
    }
}