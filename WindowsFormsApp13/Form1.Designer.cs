namespace WindowsFormsApp13
{
    partial class Formdata
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
            this.labelnama = new System.Windows.Forms.Label();
            this.labeltelpon = new System.Windows.Forms.Label();
            this.labelalamat = new System.Windows.Forms.Label();
            this.textboxalamat = new System.Windows.Forms.TextBox();
            this.textboxtelpon = new System.Windows.Forms.TextBox();
            this.textboxnama = new System.Windows.Forms.TextBox();
            this.buttonsimpan = new System.Windows.Forms.Button();
            this.buttonlihatdata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Location = new System.Drawing.Point(41, 40);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(51, 20);
            this.labelnama.TabIndex = 0;
            this.labelnama.Text = "Nama";
            // 
            // labeltelpon
            // 
            this.labeltelpon.AutoSize = true;
            this.labeltelpon.Location = new System.Drawing.Point(41, 149);
            this.labeltelpon.Name = "labeltelpon";
            this.labeltelpon.Size = new System.Drawing.Size(86, 20);
            this.labeltelpon.TabIndex = 1;
            this.labeltelpon.Text = "No.telepon";
            // 
            // labelalamat
            // 
            this.labelalamat.AutoSize = true;
            this.labelalamat.Location = new System.Drawing.Point(41, 93);
            this.labelalamat.Name = "labelalamat";
            this.labelalamat.Size = new System.Drawing.Size(59, 20);
            this.labelalamat.TabIndex = 2;
            this.labelalamat.Text = "Alamat";
            // 
            // textboxalamat
            // 
            this.textboxalamat.Location = new System.Drawing.Point(149, 93);
            this.textboxalamat.Name = "textboxalamat";
            this.textboxalamat.Size = new System.Drawing.Size(321, 26);
            this.textboxalamat.TabIndex = 3;
            // 
            // textboxtelpon
            // 
            this.textboxtelpon.Location = new System.Drawing.Point(149, 149);
            this.textboxtelpon.Name = "textboxtelpon";
            this.textboxtelpon.Size = new System.Drawing.Size(254, 26);
            this.textboxtelpon.TabIndex = 4;
            // 
            // textboxnama
            // 
            this.textboxnama.Location = new System.Drawing.Point(149, 40);
            this.textboxnama.Name = "textboxnama";
            this.textboxnama.Size = new System.Drawing.Size(254, 26);
            this.textboxnama.TabIndex = 5;
            // 
            // buttonsimpan
            // 
            this.buttonsimpan.Location = new System.Drawing.Point(45, 196);
            this.buttonsimpan.Name = "buttonsimpan";
            this.buttonsimpan.Size = new System.Drawing.Size(104, 38);
            this.buttonsimpan.TabIndex = 6;
            this.buttonsimpan.Text = "simpandata";
            this.buttonsimpan.UseVisualStyleBackColor = true;
            // 
            // buttonlihatdata
            // 
            this.buttonlihatdata.Location = new System.Drawing.Point(174, 196);
            this.buttonlihatdata.Name = "buttonlihatdata";
            this.buttonlihatdata.Size = new System.Drawing.Size(97, 38);
            this.buttonlihatdata.TabIndex = 7;
            this.buttonlihatdata.Text = "lihat data";
            this.buttonlihatdata.UseVisualStyleBackColor = true;
            this.buttonlihatdata.Click += new System.EventHandler(this.buttonlihatdata_Click);
            // 
            // Formdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonlihatdata);
            this.Controls.Add(this.buttonsimpan);
            this.Controls.Add(this.textboxnama);
            this.Controls.Add(this.textboxtelpon);
            this.Controls.Add(this.textboxalamat);
            this.Controls.Add(this.labelalamat);
            this.Controls.Add(this.labeltelpon);
            this.Controls.Add(this.labelnama);
            this.Name = "Formdata";
            this.Text = "Form Penambahan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.Label labeltelpon;
        private System.Windows.Forms.Label labelalamat;
        private System.Windows.Forms.TextBox textboxalamat;
        private System.Windows.Forms.TextBox textboxtelpon;
        private System.Windows.Forms.TextBox textboxnama;
        private System.Windows.Forms.Button buttonsimpan;
        private System.Windows.Forms.Button buttonlihatdata;
    }
}

