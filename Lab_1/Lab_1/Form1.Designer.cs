
namespace Lab_1
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
            this.get_result = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.num_label = new System.Windows.Forms.Label();
            this.pow_label = new System.Windows.Forms.Label();
            this.res_textbox = new System.Windows.Forms.TextBox();
            this.num_textbox = new System.Windows.Forms.TextBox();
            this.pow_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // get_result
            // 
            this.get_result.Location = new System.Drawing.Point(98, 111);
            this.get_result.Name = "get_result";
            this.get_result.Size = new System.Drawing.Size(75, 23);
            this.get_result.TabIndex = 0;
            this.get_result.Text = "Рассчитать";
            this.get_result.UseVisualStyleBackColor = true;
            this.get_result.Click += new System.EventHandler(this.get_result_Click);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(105, 156);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(58, 13);
            this.result_label.TabIndex = 1;
            this.result_label.Text = "результат";
            // 
            // num_label
            // 
            this.num_label.AutoSize = true;
            this.num_label.Location = new System.Drawing.Point(29, 27);
            this.num_label.Name = "num_label";
            this.num_label.Size = new System.Drawing.Size(80, 13);
            this.num_label.TabIndex = 2;
            this.num_label.Text = "введите число";
            // 
            // pow_label
            // 
            this.pow_label.AutoSize = true;
            this.pow_label.Location = new System.Drawing.Point(160, 27);
            this.pow_label.Name = "pow_label";
            this.pow_label.Size = new System.Drawing.Size(92, 13);
            this.pow_label.TabIndex = 3;
            this.pow_label.Text = "введите степень";
            // 
            // res_textbox
            // 
            this.res_textbox.Location = new System.Drawing.Point(86, 181);
            this.res_textbox.Name = "res_textbox";
            this.res_textbox.Size = new System.Drawing.Size(100, 20);
            this.res_textbox.TabIndex = 4;
            // 
            // num_textbox
            // 
            this.num_textbox.Location = new System.Drawing.Point(12, 56);
            this.num_textbox.Name = "num_textbox";
            this.num_textbox.Size = new System.Drawing.Size(100, 20);
            this.num_textbox.TabIndex = 5;
            // 
            // pow_textbox
            // 
            this.pow_textbox.Location = new System.Drawing.Point(152, 56);
            this.pow_textbox.Name = "pow_textbox";
            this.pow_textbox.Size = new System.Drawing.Size(100, 20);
            this.pow_textbox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 241);
            this.Controls.Add(this.pow_textbox);
            this.Controls.Add(this.num_textbox);
            this.Controls.Add(this.res_textbox);
            this.Controls.Add(this.pow_label);
            this.Controls.Add(this.num_label);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.get_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button get_result;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Label num_label;
        private System.Windows.Forms.Label pow_label;
        private System.Windows.Forms.TextBox res_textbox;
        private System.Windows.Forms.TextBox num_textbox;
        private System.Windows.Forms.TextBox pow_textbox;
    }
}

