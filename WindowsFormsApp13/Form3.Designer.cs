namespace WindowsFormsApp13
{
    partial class Formdataa
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
            this.labelnamaaa = new System.Windows.Forms.Label();
            this.labeltelp = new System.Windows.Forms.Label();
            this.labelalamattt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonkembali = new System.Windows.Forms.Button();
            this.buttonnextdata = new System.Windows.Forms.Button();
            this.buttonprevdata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelnamaaa
            // 
            this.labelnamaaa.AutoSize = true;
            this.labelnamaaa.Location = new System.Drawing.Point(60, 55);
            this.labelnamaaa.Name = "labelnamaaa";
            this.labelnamaaa.Size = new System.Drawing.Size(49, 20);
            this.labelnamaaa.TabIndex = 0;
            this.labelnamaaa.Text = "nama";
            // 
            // labeltelp
            // 
            this.labeltelp.AutoSize = true;
            this.labeltelp.Location = new System.Drawing.Point(60, 152);
            this.labeltelp.Name = "labeltelp";
            this.labeltelp.Size = new System.Drawing.Size(57, 20);
            this.labeltelp.TabIndex = 1;
            this.labeltelp.Text = "no.telp";
            // 
            // labelalamattt
            // 
            this.labelalamattt.AutoSize = true;
            this.labelalamattt.Location = new System.Drawing.Point(60, 100);
            this.labelalamattt.Name = "labelalamattt";
            this.labelalamattt.Size = new System.Drawing.Size(57, 20);
            this.labelalamattt.TabIndex = 2;
            this.labelalamattt.Text = "alamat";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(175, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 5;
            // 
            // buttonkembali
            // 
            this.buttonkembali.Location = new System.Drawing.Point(36, 211);
            this.buttonkembali.Name = "buttonkembali";
            this.buttonkembali.Size = new System.Drawing.Size(89, 32);
            this.buttonkembali.TabIndex = 6;
            this.buttonkembali.Text = "kembali";
            this.buttonkembali.UseVisualStyleBackColor = true;
            // 
            // buttonnextdata
            // 
            this.buttonnextdata.Location = new System.Drawing.Point(312, 211);
            this.buttonnextdata.Name = "buttonnextdata";
            this.buttonnextdata.Size = new System.Drawing.Size(91, 38);
            this.buttonnextdata.TabIndex = 7;
            this.buttonnextdata.Text = "next data";
            this.buttonnextdata.UseVisualStyleBackColor = true;
            // 
            // buttonprevdata
            // 
            this.buttonprevdata.Location = new System.Drawing.Point(175, 211);
            this.buttonprevdata.Name = "buttonprevdata";
            this.buttonprevdata.Size = new System.Drawing.Size(91, 32);
            this.buttonprevdata.TabIndex = 8;
            this.buttonprevdata.Text = "prev data";
            this.buttonprevdata.UseVisualStyleBackColor = true;
            // 
            // Formdataa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonprevdata);
            this.Controls.Add(this.buttonnextdata);
            this.Controls.Add(this.buttonkembali);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelalamattt);
            this.Controls.Add(this.labeltelp);
            this.Controls.Add(this.labelnamaaa);
            this.Name = "Formdataa";
            this.Text = "Form Tampilan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnamaaa;
        private System.Windows.Forms.Label labeltelp;
        private System.Windows.Forms.Label labelalamattt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonkembali;
        private System.Windows.Forms.Button buttonnextdata;
        private System.Windows.Forms.Button buttonprevdata;
    }
}