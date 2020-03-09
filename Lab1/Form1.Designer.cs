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
            this.btt = new System.Windows.Forms.Button();
            this.bts = new System.Windows.Forms.Button();
            this.tbt = new System.Windows.Forms.TextBox();
            this.tbs = new System.Windows.Forms.TextBox();
            this.tbn = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.pbf = new System.Windows.Forms.PictureBox();
            this.btf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbf)).BeginInit();
            this.SuspendLayout();
            // 
            // btt
            // 
            this.btt.Location = new System.Drawing.Point(44, 83);
            this.btt.Name = "btt";
            this.btt.Size = new System.Drawing.Size(134, 23);
            this.btt.TabIndex = 0;
            this.btt.Text = "Метод трапеций";
            this.btt.UseVisualStyleBackColor = true;
            this.btt.Click += new System.EventHandler(this.btt_Click);
            // 
            // bts
            // 
            this.bts.Location = new System.Drawing.Point(44, 137);
            this.bts.Name = "bts";
            this.bts.Size = new System.Drawing.Size(134, 23);
            this.bts.TabIndex = 1;
            this.bts.Text = "Метод Симпсона";
            this.bts.UseVisualStyleBackColor = true;
            this.bts.Click += new System.EventHandler(this.bts_Click);
            // 
            // tbt
            // 
            this.tbt.Location = new System.Drawing.Point(291, 83);
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
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(193, 22);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(81, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Число точек N";
            // 
            // pbf
            // 
            this.pbf.Location = new System.Drawing.Point(147, 174);
            this.pbf.Name = "pbf";
            this.pbf.Size = new System.Drawing.Size(243, 337);
            this.pbf.TabIndex = 6;
            this.pbf.TabStop = false;
            // 
            // btf
            // 
            this.btf.Location = new System.Drawing.Point(44, 174);
            this.btf.Name = "btf";
            this.btf.Size = new System.Drawing.Size(75, 23);
            this.btf.TabIndex = 7;
            this.btf.Text = "Жабстер";
            this.btf.UseVisualStyleBackColor = true;
            this.btf.Click += new System.EventHandler(this.btf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 552);
            this.Controls.Add(this.btf);
            this.Controls.Add(this.pbf);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.tbn);
            this.Controls.Add(this.tbs);
            this.Controls.Add(this.tbt);
            this.Controls.Add(this.bts);
            this.Controls.Add(this.btt);
            this.Name = "Form1";
            this.Text = "Куприянов В.А. 3-46";
            ((System.ComponentModel.ISupportInitialize)(this.pbf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt;
        private System.Windows.Forms.Button bts;
        private System.Windows.Forms.TextBox tbt;
        private System.Windows.Forms.TextBox tbs;
        private System.Windows.Forms.TextBox tbn;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btf;
        protected internal System.Windows.Forms.PictureBox pbf;
    }
}

