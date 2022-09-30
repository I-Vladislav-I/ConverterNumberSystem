namespace ConverterBinaryCode
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.output1 = new System.Windows.Forms.TextBox();
            this.output2 = new System.Windows.Forms.TextBox();
            this.output3 = new System.Windows.Forms.TextBox();
            this.numberSystemSelector = new System.Windows.Forms.ComboBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(91, 12);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(353, 23);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputBox_KeyPress);
            // 
            // output1
            // 
            this.output1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output1.Location = new System.Drawing.Point(91, 50);
            this.output1.Name = "output1";
            this.output1.ReadOnly = true;
            this.output1.Size = new System.Drawing.Size(482, 23);
            this.output1.TabIndex = 1;
            // 
            // output2
            // 
            this.output2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output2.Location = new System.Drawing.Point(91, 88);
            this.output2.Name = "output2";
            this.output2.ReadOnly = true;
            this.output2.Size = new System.Drawing.Size(482, 23);
            this.output2.TabIndex = 2;
            // 
            // output3
            // 
            this.output3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output3.Location = new System.Drawing.Point(91, 128);
            this.output3.Name = "output3";
            this.output3.ReadOnly = true;
            this.output3.Size = new System.Drawing.Size(482, 23);
            this.output3.TabIndex = 3;
            // 
            // numberSystemSelector
            // 
            this.numberSystemSelector.FormattingEnabled = true;
            this.numberSystemSelector.Items.AddRange(new object[] {
            "Binary",
            "Octal",
            "Decimal",
            "Hex"});
            this.numberSystemSelector.Location = new System.Drawing.Point(454, 13);
            this.numberSystemSelector.Name = "numberSystemSelector";
            this.numberSystemSelector.Size = new System.Drawing.Size(119, 21);
            this.numberSystemSelector.TabIndex = 4;
            this.numberSystemSelector.SelectedIndexChanged += new System.EventHandler(this.numberSystemSelector_SelectedIndexChanged);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLabel.Location = new System.Drawing.Point(21, 12);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(46, 20);
            this.inputLabel.TabIndex = 5;
            this.inputLabel.Text = "Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 163);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.numberSystemSelector);
            this.Controls.Add(this.output3);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.inputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox output1;
        private System.Windows.Forms.TextBox output2;
        private System.Windows.Forms.TextBox output3;
        private System.Windows.Forms.ComboBox numberSystemSelector;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

