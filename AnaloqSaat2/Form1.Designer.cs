namespace AnaloqSaat2
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pDot = new System.Windows.Forms.PictureBox();
            this.pSecond = new System.Windows.Forms.PictureBox();
            this.pMinut = new System.Windows.Forms.PictureBox();
            this.pHour = new System.Windows.Forms.PictureBox();
            this.pBack = new System.Windows.Forms.PictureBox();
            this.bIreli = new System.Windows.Forms.Button();
            this.bArxa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMinut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBack)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pDot
            // 
            this.pDot.BackColor = System.Drawing.Color.Transparent;
            this.pDot.Location = new System.Drawing.Point(155, 112);
            this.pDot.Name = "pDot";
            this.pDot.Size = new System.Drawing.Size(300, 300);
            this.pDot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pDot.TabIndex = 10;
            this.pDot.TabStop = false;
            // 
            // pSecond
            // 
            this.pSecond.BackColor = System.Drawing.Color.Transparent;
            this.pSecond.Location = new System.Drawing.Point(123, 94);
            this.pSecond.Name = "pSecond";
            this.pSecond.Size = new System.Drawing.Size(300, 300);
            this.pSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pSecond.TabIndex = 9;
            this.pSecond.TabStop = false;
            // 
            // pMinut
            // 
            this.pMinut.BackColor = System.Drawing.Color.Transparent;
            this.pMinut.Location = new System.Drawing.Point(87, 72);
            this.pMinut.Name = "pMinut";
            this.pMinut.Size = new System.Drawing.Size(300, 300);
            this.pMinut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pMinut.TabIndex = 8;
            this.pMinut.TabStop = false;
            // 
            // pHour
            // 
            this.pHour.BackColor = System.Drawing.Color.Transparent;
            this.pHour.Location = new System.Drawing.Point(77, 55);
            this.pHour.Name = "pHour";
            this.pHour.Size = new System.Drawing.Size(300, 300);
            this.pHour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pHour.TabIndex = 7;
            this.pHour.TabStop = false;
            // 
            // pBack
            // 
            this.pBack.BackColor = System.Drawing.Color.Transparent;
            this.pBack.Location = new System.Drawing.Point(77, 25);
            this.pBack.Name = "pBack";
            this.pBack.Size = new System.Drawing.Size(300, 300);
            this.pBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBack.TabIndex = 6;
            this.pBack.TabStop = false;
            // 
            // bIreli
            // 
            this.bIreli.Location = new System.Drawing.Point(383, 25);
            this.bIreli.Name = "bIreli";
            this.bIreli.Size = new System.Drawing.Size(46, 33);
            this.bIreli.TabIndex = 11;
            this.bIreli.Text = ">>";
            this.bIreli.UseVisualStyleBackColor = true;
            this.bIreli.Click += new System.EventHandler(this.bIreli_Click);
            // 
            // bArxa
            // 
            this.bArxa.Location = new System.Drawing.Point(12, 25);
            this.bArxa.Name = "bArxa";
            this.bArxa.Size = new System.Drawing.Size(46, 33);
            this.bArxa.TabIndex = 12;
            this.bArxa.Text = "<<";
            this.bArxa.UseVisualStyleBackColor = true;
            this.bArxa.Click += new System.EventHandler(this.bArxa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "22:22";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(177, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "08";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(237, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 46);
            this.label3.TabIndex = 15;
            this.label3.Text = "15/09/2019";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bArxa);
            this.Controls.Add(this.bIreli);
            this.Controls.Add(this.pDot);
            this.Controls.Add(this.pSecond);
            this.Controls.Add(this.pMinut);
            this.Controls.Add(this.pHour);
            this.Controls.Add(this.pBack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMinut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pBack;
        private System.Windows.Forms.PictureBox pHour;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pMinut;
        private System.Windows.Forms.PictureBox pSecond;
        private System.Windows.Forms.PictureBox pDot;
        private System.Windows.Forms.Button bIreli;
        private System.Windows.Forms.Button bArxa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

