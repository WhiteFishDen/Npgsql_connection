namespace WindowsFormsApp3
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
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_go_query = new System.Windows.Forms.Button();
            this.label_query = new System.Windows.Forms.Label();
            this.textBox_query = new System.Windows.Forms.TextBox();
            this.comboBox_save_query = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_go_query
            // 
            this.button_go_query.Location = new System.Drawing.Point(210, 333);
            this.button_go_query.Name = "button_go_query";
            this.button_go_query.Size = new System.Drawing.Size(75, 23);
            this.button_go_query.TabIndex = 2;
            this.button_go_query.Text = "OK";
            this.button_go_query.UseVisualStyleBackColor = true;
            this.button_go_query.Click += new System.EventHandler(this.button_go_query_Click);
            // 
            // label_query
            // 
            this.label_query.AutoSize = true;
            this.label_query.Location = new System.Drawing.Point(51, 285);
            this.label_query.Name = "label_query";
            this.label_query.Size = new System.Drawing.Size(38, 13);
            this.label_query.TabIndex = 3;
            this.label_query.Text = "Query:";
            // 
            // textBox_query
            // 
            this.textBox_query.Location = new System.Drawing.Point(104, 286);
            this.textBox_query.Name = "textBox_query";
            this.textBox_query.Size = new System.Drawing.Size(302, 20);
            this.textBox_query.TabIndex = 4;
            // 
            // comboBox_save_query
            // 
            this.comboBox_save_query.FormattingEnabled = true;
            this.comboBox_save_query.Location = new System.Drawing.Point(447, 285);
            this.comboBox_save_query.Name = "comboBox_save_query";
            this.comboBox_save_query.Size = new System.Drawing.Size(341, 21);
            this.comboBox_save_query.TabIndex = 5;
            this.comboBox_save_query.SelectedIndexChanged += new System.EventHandler(this.comboBox_save_query_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_save_query);
            this.Controls.Add(this.textBox_query);
            this.Controls.Add(this.label_query);
            this.Controls.Add(this.button_go_query);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_go_query;
        private System.Windows.Forms.Label label_query;
        private System.Windows.Forms.TextBox textBox_query;
        private System.Windows.Forms.ComboBox comboBox_save_query;
    }
}

