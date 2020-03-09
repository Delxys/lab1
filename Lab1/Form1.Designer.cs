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
            this.btt.Click += new System.EventHandler(this.button1_Click);
            // 
            // bts
            // 
            this.bts.Location = new System.Drawing.Point(44, 137);
            this.bts.Name = "bts";
            this.bts.Size = new System.Drawing.Size(134, 23);
            this.bts.TabIndex = 1;
            this.bts.Text = "Метод Симпсона";
            this.bts.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbs);
            this.Controls.Add(this.tbt);
            this.Controls.Add(this.bts);
            this.Controls.Add(this.btt);
            this.Name = "Form1";
            this.Text = "Куприянов В.А. 3-46";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt;
        private System.Windows.Forms.Button bts;
        private System.Windows.Forms.TextBox tbt;
        private System.Windows.Forms.TextBox tbs;
    }
}

