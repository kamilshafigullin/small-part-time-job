namespace WinFormsWordsSum
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
            this.WordsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.WordsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WordsListBox
            // 
            this.WordsListBox.FormattingEnabled = true;
            this.WordsListBox.Location = new System.Drawing.Point(229, 76);
            this.WordsListBox.Name = "WordsListBox";
            this.WordsListBox.Size = new System.Drawing.Size(120, 95);
            this.WordsListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходный массив:";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(82, 102);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(131, 23);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Добавить в массив";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // WordsTextBox
            // 
            this.WordsTextBox.Location = new System.Drawing.Point(82, 76);
            this.WordsTextBox.Name = "WordsTextBox";
            this.WordsTextBox.Size = new System.Drawing.Size(131, 20);
            this.WordsTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(82, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(150, 159);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(13, 13);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите число:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 246);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WordsTextBox);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WordsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WordsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox WordsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label3;
    }
}

