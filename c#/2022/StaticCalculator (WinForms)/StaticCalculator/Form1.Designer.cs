namespace StaticCalculator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.compileButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.modaLabel = new System.Windows.Forms.Label();
            this.medianaLabel = new System.Windows.Forms.Label();
            this.avgLabel = new System.Windows.Forms.Label();
            this.avgGeomLabel = new System.Windows.Forms.Label();
            this.standDevLabel = new System.Windows.Forms.Label();
            this.dispertionLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.maxlabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sortedListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xi,
            this.ni});
            this.dataGridView1.Location = new System.Drawing.Point(286, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(248, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // xi
            // 
            this.xi.HeaderText = "xi";
            this.xi.Name = "xi";
            this.xi.ReadOnly = true;
            // 
            // ni
            // 
            this.ni.HeaderText = "ni";
            this.ni.Name = "ni";
            this.ni.ReadOnly = true;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(15, 33);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(234, 20);
            this.filePathTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь к файлу с рядом распределения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "*Пример содержимого файла: 1;2 3;4 5;6";
            // 
            // compileButton
            // 
            this.compileButton.Location = new System.Drawing.Point(15, 80);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(234, 23);
            this.compileButton.TabIndex = 4;
            this.compileButton.Text = "Выполнить";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);
            // 
            // chart1
            // 
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            this.chart1.Location = new System.Drawing.Point(572, 12);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Name = "Series1";
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(438, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(731, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Полигон частот";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Среднее арифметическое:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Стандартное отклонение:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дисперсия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Мода:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Медиана:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Сумма:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Наибольшее:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Наименьшее:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Среднее геометрическое:";
            // 
            // modaLabel
            // 
            this.modaLabel.AutoSize = true;
            this.modaLabel.Location = new System.Drawing.Point(55, 124);
            this.modaLabel.Name = "modaLabel";
            this.modaLabel.Size = new System.Drawing.Size(0, 13);
            this.modaLabel.TabIndex = 16;
            // 
            // medianaLabel
            // 
            this.medianaLabel.AutoSize = true;
            this.medianaLabel.Location = new System.Drawing.Point(73, 150);
            this.medianaLabel.Name = "medianaLabel";
            this.medianaLabel.Size = new System.Drawing.Size(0, 13);
            this.medianaLabel.TabIndex = 17;
            // 
            // avgLabel
            // 
            this.avgLabel.AutoSize = true;
            this.avgLabel.Location = new System.Drawing.Point(160, 175);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(0, 13);
            this.avgLabel.TabIndex = 18;
            // 
            // avgGeomLabel
            // 
            this.avgGeomLabel.AutoSize = true;
            this.avgGeomLabel.Location = new System.Drawing.Point(160, 201);
            this.avgGeomLabel.Name = "avgGeomLabel";
            this.avgGeomLabel.Size = new System.Drawing.Size(0, 13);
            this.avgGeomLabel.TabIndex = 19;
            // 
            // standDevLabel
            // 
            this.standDevLabel.AutoSize = true;
            this.standDevLabel.Location = new System.Drawing.Point(160, 227);
            this.standDevLabel.Name = "standDevLabel";
            this.standDevLabel.Size = new System.Drawing.Size(0, 13);
            this.standDevLabel.TabIndex = 20;
            // 
            // dispertionLabel
            // 
            this.dispertionLabel.AutoSize = true;
            this.dispertionLabel.Location = new System.Drawing.Point(85, 253);
            this.dispertionLabel.Name = "dispertionLabel";
            this.dispertionLabel.Size = new System.Drawing.Size(0, 13);
            this.dispertionLabel.TabIndex = 21;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(62, 278);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(0, 13);
            this.sumLabel.TabIndex = 22;
            // 
            // maxlabel
            // 
            this.maxlabel.AutoSize = true;
            this.maxlabel.Location = new System.Drawing.Point(94, 302);
            this.maxlabel.Name = "maxlabel";
            this.maxlabel.Size = new System.Drawing.Size(0, 13);
            this.maxlabel.TabIndex = 23;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(94, 328);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(0, 13);
            this.minLabel.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Сортированные данные:";
            // 
            // sortedListLabel
            // 
            this.sortedListLabel.AutoSize = true;
            this.sortedListLabel.Location = new System.Drawing.Point(149, 358);
            this.sortedListLabel.Name = "sortedListLabel";
            this.sortedListLabel.Size = new System.Drawing.Size(0, 13);
            this.sortedListLabel.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 410);
            this.Controls.Add(this.sortedListLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxlabel);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.dispertionLabel);
            this.Controls.Add(this.standDevLabel);
            this.Controls.Add(this.avgGeomLabel);
            this.Controls.Add(this.avgLabel);
            this.Controls.Add(this.medianaLabel);
            this.Controls.Add(this.modaLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Статический калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ni;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label modaLabel;
        private System.Windows.Forms.Label medianaLabel;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Label avgGeomLabel;
        private System.Windows.Forms.Label standDevLabel;
        private System.Windows.Forms.Label dispertionLabel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label maxlabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label sortedListLabel;
    }
}

