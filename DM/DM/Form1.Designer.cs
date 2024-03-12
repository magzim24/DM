namespace DM
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.leftBoundary = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RightBoundary = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Inaccuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			chartArea5.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea5);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
			legend5.Name = "Legend1";
			this.chart1.Legends.Add(legend5);
			this.chart1.Location = new System.Drawing.Point(0, 0);
			this.chart1.Name = "chart1";
			series5.ChartArea = "ChartArea1";
			series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series5.Legend = "Legend1";
			series5.Name = "Series1";
			this.chart1.Series.Add(series5);
			this.chart1.Size = new System.Drawing.Size(795, 391);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 397);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(139, 397);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 21);
			this.button1.TabIndex = 2;
			this.button1.Text = "Рассчитать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leftBoundary,
            this.RightBoundary,
            this.Inaccuracy});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 424);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(795, 77);
			this.dataGridView1.TabIndex = 3;
			// 
			// leftBoundary
			// 
			this.leftBoundary.HeaderText = "leftBoundary";
			this.leftBoundary.Name = "leftBoundary";
			// 
			// RightBoundary
			// 
			this.RightBoundary.HeaderText = "RightBoundary";
			this.RightBoundary.Name = "RightBoundary";
			// 
			// Inaccuracy
			// 
			this.Inaccuracy.HeaderText = "Column1";
			this.Inaccuracy.Name = "Inaccuracy";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(262, 398);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(109, 20);
			this.textBox1.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 501);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.chart1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn leftBoundary;
		private System.Windows.Forms.DataGridViewTextBoxColumn RightBoundary;
		private System.Windows.Forms.DataGridViewTextBoxColumn Inaccuracy;
		private System.Windows.Forms.TextBox textBox1;
	}
}

