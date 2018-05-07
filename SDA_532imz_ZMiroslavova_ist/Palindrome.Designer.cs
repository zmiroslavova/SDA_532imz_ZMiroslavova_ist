namespace SDA_532imz_ZMiroslavova_ist
{
    partial class Palindrome
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
            this.label_InputNumber = new System.Windows.Forms.Label();
            this.textBox_inputNimber = new System.Windows.Forms.TextBox();
            this.button_Result = new System.Windows.Forms.Button();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_InputNumber
            // 
            this.label_InputNumber.AutoSize = true;
            this.label_InputNumber.Location = new System.Drawing.Point(13, 9);
            this.label_InputNumber.Name = "label_InputNumber";
            this.label_InputNumber.Size = new System.Drawing.Size(79, 13);
            this.label_InputNumber.TabIndex = 0;
            this.label_InputNumber.Text = "Enter a number";
            // 
            // textBox_inputNimber
            // 
            this.textBox_inputNimber.Location = new System.Drawing.Point(98, 2);
            this.textBox_inputNimber.Name = "textBox_inputNimber";
            this.textBox_inputNimber.Size = new System.Drawing.Size(167, 20);
            this.textBox_inputNimber.TabIndex = 1;
            // 
            // button_Result
            // 
            this.button_Result.Location = new System.Drawing.Point(97, 34);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(167, 34);
            this.button_Result.TabIndex = 2;
            this.button_Result.Text = "Result";
            this.button_Result.UseVisualStyleBackColor = true;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.Location = new System.Drawing.Point(12, 79);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.ReadOnly = true;
            this.richTextBox_Result.Size = new System.Drawing.Size(252, 84);
            this.richTextBox_Result.TabIndex = 3;
            this.richTextBox_Result.Text = "";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(97, 177);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(167, 34);
            this.button_Clear.TabIndex = 4;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Palindrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 220);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.richTextBox_Result);
            this.Controls.Add(this.button_Result);
            this.Controls.Add(this.textBox_inputNimber);
            this.Controls.Add(this.label_InputNumber);
            this.Name = "Palindrome";
            this.Text = "Palindrome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InputNumber;
        private System.Windows.Forms.TextBox textBox_inputNimber;
        private System.Windows.Forms.Button button_Result;
        private System.Windows.Forms.RichTextBox richTextBox_Result;
        private System.Windows.Forms.Button button_Clear;
    }
}

