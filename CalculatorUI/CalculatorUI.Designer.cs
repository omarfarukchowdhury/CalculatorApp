namespace CalculatorUI
{
    partial class CalculatorUI
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
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secoundNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(303, 57);
            this.firstNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(180, 29);
            this.firstNumberTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Secound Number";
            // 
            // secoundNumberTextBox
            // 
            this.secoundNumberTextBox.Location = new System.Drawing.Point(303, 113);
            this.secoundNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.secoundNumberTextBox.Name = "secoundNumberTextBox";
            this.secoundNumberTextBox.Size = new System.Drawing.Size(180, 29);
            this.secoundNumberTextBox.TabIndex = 1;
            //this.secoundNumberTextBox.TextChanged += new System.EventHandler(this.secoundNumberTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Result";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(303, 176);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(180, 29);
            this.resultTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(56, 268);
            this.addButton.Margin = new System.Windows.Forms.Padding(6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(138, 42);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(279, 268);
            this.subtractButton.Margin = new System.Windows.Forms.Padding(6);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(138, 42);
            this.subtractButton.TabIndex = 2;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(56, 352);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(6);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(138, 42);
            this.multiplyButton.TabIndex = 2;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(279, 352);
            this.divideButton.Margin = new System.Windows.Forms.Padding(6);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(138, 42);
            this.divideButton.TabIndex = 2;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            // 
            // CalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 836);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.secoundNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CalculatorUI";
            this.Text = "Calculator";
           // this.Load += new System.EventHandler(this.CalculatorUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secoundNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
    }
}

