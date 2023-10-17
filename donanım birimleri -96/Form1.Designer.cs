namespace donanım_birimleri__96
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
            this.lbDonanim = new System.Windows.Forms.ListBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDonanim
            // 
            this.lbDonanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDonanim.FormattingEnabled = true;
            this.lbDonanim.ItemHeight = 25;
            this.lbDonanim.Items.AddRange(new object[] {
            "Mouse",
            "Yazıcı",
            "Klavye",
            "Hoparlör",
            "Kamera",
            "Tarayıcı",
            "Projeksiyon"});
            this.lbDonanim.Location = new System.Drawing.Point(30, 63);
            this.lbDonanim.Name = "lbDonanim";
            this.lbDonanim.Size = new System.Drawing.Size(160, 204);
            this.lbDonanim.TabIndex = 0;
            // 
            // btnKontrol
            // 
            this.btnKontrol.BackColor = System.Drawing.Color.Yellow;
            this.btnKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrol.Location = new System.Drawing.Point(30, 289);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(160, 36);
            this.btnKontrol.TabIndex = 1;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = false;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Donanım Birimleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(228, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.lbDonanim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDonanim;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Label label1;
    }
}

