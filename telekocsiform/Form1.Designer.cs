namespace telekocsiform
{
    partial class FrmFo
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
            this.BtnBeolvasas = new System.Windows.Forms.Button();
            this.lbKimenet = new System.Windows.Forms.ListBox();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnThird = new System.Windows.Forms.Button();
            this.btnFourth = new System.Windows.Forms.Button();
            this.btnFith = new System.Windows.Forms.Button();
            this.btnSixth = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBeolvasas
            // 
            this.BtnBeolvasas.Location = new System.Drawing.Point(12, 26);
            this.BtnBeolvasas.Name = "BtnBeolvasas";
            this.BtnBeolvasas.Size = new System.Drawing.Size(95, 46);
            this.BtnBeolvasas.TabIndex = 0;
            this.BtnBeolvasas.Text = "Beolvasás";
            this.BtnBeolvasas.UseVisualStyleBackColor = true;
            this.BtnBeolvasas.Click += new System.EventHandler(this.BtnBeolvasas_Click);
            // 
            // lbKimenet
            // 
            this.lbKimenet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKimenet.FormattingEnabled = true;
            this.lbKimenet.ItemHeight = 16;
            this.lbKimenet.Location = new System.Drawing.Point(141, 52);
            this.lbKimenet.Name = "lbKimenet";
            this.lbKimenet.Size = new System.Drawing.Size(368, 212);
            this.lbKimenet.TabIndex = 1;
            // 
            // btnSecond
            // 
            this.btnSecond.Enabled = false;
            this.btnSecond.Location = new System.Drawing.Point(12, 78);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(95, 39);
            this.btnSecond.TabIndex = 2;
            this.btnSecond.Text = "2. feladat";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // btnThird
            // 
            this.btnThird.Enabled = false;
            this.btnThird.Location = new System.Drawing.Point(12, 123);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(95, 26);
            this.btnThird.TabIndex = 3;
            this.btnThird.Text = "3. feladat";
            this.btnThird.UseVisualStyleBackColor = true;
            this.btnThird.Click += new System.EventHandler(this.btnThird_Click);
            // 
            // btnFourth
            // 
            this.btnFourth.Enabled = false;
            this.btnFourth.Location = new System.Drawing.Point(12, 155);
            this.btnFourth.Name = "btnFourth";
            this.btnFourth.Size = new System.Drawing.Size(95, 30);
            this.btnFourth.TabIndex = 4;
            this.btnFourth.Text = "4.feladat";
            this.btnFourth.UseVisualStyleBackColor = true;
            this.btnFourth.Click += new System.EventHandler(this.btnFourth_Click);
            // 
            // btnFith
            // 
            this.btnFith.Enabled = false;
            this.btnFith.Location = new System.Drawing.Point(12, 191);
            this.btnFith.Name = "btnFith";
            this.btnFith.Size = new System.Drawing.Size(95, 33);
            this.btnFith.TabIndex = 5;
            this.btnFith.Text = "5. feladat";
            this.btnFith.UseVisualStyleBackColor = true;
            this.btnFith.Click += new System.EventHandler(this.btnFith_Click);
            // 
            // btnSixth
            // 
            this.btnSixth.Enabled = false;
            this.btnSixth.Location = new System.Drawing.Point(12, 230);
            this.btnSixth.Name = "btnSixth";
            this.btnSixth.Size = new System.Drawing.Size(95, 34);
            this.btnSixth.TabIndex = 6;
            this.btnSixth.Text = "6. feladat";
            this.btnSixth.UseVisualStyleBackColor = true;
            this.btnSixth.Click += new System.EventHandler(this.btnSixth_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(261, 304);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(75, 36);
            this.btnKilepes.TabIndex = 7;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "A feladatok kimenete";
            // 
            // FrmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnSixth);
            this.Controls.Add(this.btnFith);
            this.Controls.Add(this.btnFourth);
            this.Controls.Add(this.btnThird);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.lbKimenet);
            this.Controls.Add(this.BtnBeolvasas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telekocsi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBeolvasas;
        private System.Windows.Forms.ListBox lbKimenet;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnThird;
        private System.Windows.Forms.Button btnFourth;
        private System.Windows.Forms.Button btnFith;
        private System.Windows.Forms.Button btnSixth;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Label label1;
    }
}

