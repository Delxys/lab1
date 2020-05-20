namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btt = new System.Windows.Forms.Button();
            this.Bts = new System.Windows.Forms.Button();
            this.tbt = new System.Windows.Forms.TextBox();
            this.tbs = new System.Windows.Forms.TextBox();
            this.tbn = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.pbf = new System.Windows.Forms.PictureBox();
            this.Btf = new System.Windows.Forms.Button();
            this.tba = new System.Windows.Forms.TextBox();
            this.tbb = new System.Windows.Forms.TextBox();
            this.lblBorders = new System.Windows.Forms.Label();
            this.Bttp = new System.Windows.Forms.Button();
            this.Btsp = new System.Windows.Forms.Button();
            this.lblposl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbtpar = new System.Windows.Forms.TextBox();
            this.tbtposl = new System.Windows.Forms.TextBox();
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbf)).BeginInit();
            this.SuspendLayout();
            // 
            // Btt
            // 
            this.Btt.Location = new System.Drawing.Point(44, 99);
            this.Btt.Name = "Btt";
            this.Btt.Size = new System.Drawing.Size(134, 23);
            this.Btt.TabIndex = 0;
            this.Btt.Text = "Метод трапеций";
            this.Btt.UseVisualStyleBackColor = true;
            this.Btt.Click += new System.EventHandler(this.Btt_Click);
            // 
            // Bts
            // 
            this.Bts.Location = new System.Drawing.Point(44, 168);
            this.Bts.Name = "Bts";
            this.Bts.Size = new System.Drawing.Size(134, 23);
            this.Bts.TabIndex = 1;
            this.Bts.Text = "Метод Симпсона";
            this.Bts.UseVisualStyleBackColor = true;
            this.Bts.Click += new System.EventHandler(this.Bts_Click);
            // 
            // tbt
            // 
            this.tbt.Location = new System.Drawing.Point(290, 99);
            this.tbt.Name = "tbt";
            this.tbt.Size = new System.Drawing.Size(100, 20);
            this.tbt.TabIndex = 2;
            // 
            // tbs
            // 
            this.tbs.Location = new System.Drawing.Point(290, 139);
            this.tbs.Name = "tbs";
            this.tbs.Size = new System.Drawing.Size(100, 20);
            this.tbs.TabIndex = 3;
            // 
            // tbn
            // 
            this.tbn.Location = new System.Drawing.Point(186, 38);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(100, 20);
            this.tbn.TabIndex = 4;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(99, 38);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(81, 13);
            this.lblN.TabIndex = 5;
            this.lblN.Text = "Число точек N";
            // 
            // pbf
            // 
            this.pbf.Location = new System.Drawing.Point(147, 306);
            this.pbf.Name = "pbf";
            this.pbf.Size = new System.Drawing.Size(243, 283);
            this.pbf.TabIndex = 6;
            this.pbf.TabStop = false;
            // 
            // Btf
            // 
            this.Btf.Location = new System.Drawing.Point(44, 291);
            this.Btf.Name = "Btf";
            this.Btf.Size = new System.Drawing.Size(75, 23);
            this.Btf.TabIndex = 7;
            this.Btf.Text = "Жабстер";
            this.Btf.UseVisualStyleBackColor = true;
            this.Btf.Click += new System.EventHandler(this.Btf_Click);
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(186, 65);
            this.tba.Name = "tba";
            this.tba.Size = new System.Drawing.Size(41, 20);
            this.tba.TabIndex = 8;
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(245, 65);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(41, 20);
            this.tbb.TabIndex = 8;
            // 
            // lblBorders
            // 
            this.lblBorders.AutoSize = true;
            this.lblBorders.Location = new System.Drawing.Point(41, 68);
            this.lblBorders.Name = "lblBorders";
            this.lblBorders.Size = new System.Drawing.Size(136, 13);
            this.lblBorders.TabIndex = 9;
            this.lblBorders.Text = "Границы интегрирования";
            // 
            // Bttp
            // 
            this.Bttp.Location = new System.Drawing.Point(43, 128);
            this.Bttp.Name = "Bttp";
            this.Bttp.Size = new System.Drawing.Size(134, 34);
            this.Bttp.TabIndex = 0;
            this.Bttp.Text = "Метод трапеций параллельный";
            this.Bttp.UseVisualStyleBackColor = true;
            this.Bttp.Click += new System.EventHandler(this.Bttp_Click);
            // 
            // Btsp
            // 
            this.Btsp.Location = new System.Drawing.Point(44, 197);
            this.Btsp.Name = "Btsp";
            this.Btsp.Size = new System.Drawing.Size(134, 34);
            this.Btsp.TabIndex = 1;
            this.Btsp.Text = "Метод Симпсона параллельный";
            this.Btsp.UseVisualStyleBackColor = true;
            this.Btsp.Click += new System.EventHandler(this.Btsp_Click);
            // 
            // lblposl
            // 
            this.lblposl.AutoSize = true;
            this.lblposl.Location = new System.Drawing.Point(436, 72);
            this.lblposl.Name = "lblposl";
            this.lblposl.Size = new System.Drawing.Size(137, 13);
            this.lblposl.TabIndex = 10;
            this.lblposl.Text = "время последовательной";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "время параллельной";
            // 
            // tbtpar
            // 
            this.tbtpar.Location = new System.Drawing.Point(448, 139);
            this.tbtpar.Name = "tbtpar";
            this.tbtpar.Size = new System.Drawing.Size(100, 20);
            this.tbtpar.TabIndex = 11;
            // 
            // tbtposl
            // 
            this.tbtposl.Location = new System.Drawing.Point(448, 99);
            this.tbtposl.Name = "tbtposl";
            this.tbtposl.Size = new System.Drawing.Size(100, 20);
            this.tbtposl.TabIndex = 11;
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(130, 257);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(311, 23);
            this.pgb.TabIndex = 12;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(199, 139);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 13;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 668);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.pgb);
            this.Controls.Add(this.tbtposl);
            this.Controls.Add(this.tbtpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblposl);
            this.Controls.Add(this.lblBorders);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.tba);
            this.Controls.Add(this.Btf);
            this.Controls.Add(this.pbf);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.tbn);
            this.Controls.Add(this.tbs);
            this.Controls.Add(this.tbt);
            this.Controls.Add(this.Btsp);
            this.Controls.Add(this.Bts);
            this.Controls.Add(this.Bttp);
            this.Controls.Add(this.Btt);
            this.Name = "Form1";
            this.Text = "Куприянов В.А. 3-46";
            ((System.ComponentModel.ISupportInitialize)(this.pbf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btt;
        private System.Windows.Forms.Button Bts;
        private System.Windows.Forms.TextBox tbt;
        private System.Windows.Forms.TextBox tbs;
        private System.Windows.Forms.TextBox tbn;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Button Btf;
        protected internal System.Windows.Forms.PictureBox pbf;
        private System.Windows.Forms.TextBox tba;
        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.Label lblBorders;
        private System.Windows.Forms.Button Bttp;
        private System.Windows.Forms.Button Btsp;
        private System.Windows.Forms.Label lblposl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbtpar;
        private System.Windows.Forms.TextBox tbtposl;
        private System.Windows.Forms.ProgressBar pgb;
        private System.Windows.Forms.Button btCancel;
    }
}

