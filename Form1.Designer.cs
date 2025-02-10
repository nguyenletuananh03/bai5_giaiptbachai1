namespace bai5_giaiptbachai1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnGiaiPT = new System.Windows.Forms.Button();
            this.tbB = new System.Windows.Forms.TrackBar();
            this.tbC = new System.Windows.Forms.TrackBar();
            this.tbA = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải PT Bậc 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "nhập a";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(90, 49);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "nhập b";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "nhập c";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(35, 225);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(44, 13);
            this.lblKQ.TabIndex = 0;
            this.lblKQ.Text = "Kết quả";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(89, 97);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(89, 148);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 1;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // btnGiaiPT
            // 
            this.btnGiaiPT.Location = new System.Drawing.Point(114, 202);
            this.btnGiaiPT.Name = "btnGiaiPT";
            this.btnGiaiPT.Size = new System.Drawing.Size(75, 21);
            this.btnGiaiPT.TabIndex = 2;
            this.btnGiaiPT.Text = "Giải PT";
            this.btnGiaiPT.UseVisualStyleBackColor = true;
            this.btnGiaiPT.Click += new System.EventHandler(this.btnGiaiPT_Click);
            // 
            // tbB
            // 
            this.tbB.LargeChange = 2;
            this.tbB.Location = new System.Drawing.Point(220, 97);
            this.tbB.Maximum = 50;
            this.tbB.Minimum = -50;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(159, 45);
            this.tbB.TabIndex = 3;
            this.tbB.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // tbC
            // 
            this.tbC.LargeChange = 2;
            this.tbC.Location = new System.Drawing.Point(220, 148);
            this.tbC.Maximum = 50;
            this.tbC.Minimum = -50;
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(159, 45);
            this.tbC.TabIndex = 3;
            this.tbC.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // tbA
            // 
            this.tbA.LargeChange = 2;
            this.tbA.Location = new System.Drawing.Point(220, 49);
            this.tbA.Maximum = 50;
            this.tbA.Minimum = -50;
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(159, 45);
            this.tbA.TabIndex = 3;
            this.tbA.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.btnGiaiPT);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnGiaiPT;
        private System.Windows.Forms.TrackBar tbB;
        private System.Windows.Forms.TrackBar tbC;
        private System.Windows.Forms.TrackBar tbA;
    }
}

