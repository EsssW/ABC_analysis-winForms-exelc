namespace sabina
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_loaddat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_sortDate = new System.Windows.Forms.Button();
            this.btn_sortByGrop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1156, 455);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_loaddat
            // 
            this.btn_loaddat.Location = new System.Drawing.Point(668, 522);
            this.btn_loaddat.Name = "btn_loaddat";
            this.btn_loaddat.Size = new System.Drawing.Size(158, 38);
            this.btn_loaddat.TabIndex = 1;
            this.btn_loaddat.Text = "Загрузить данные";
            this.btn_loaddat.UseVisualStyleBackColor = true;
            this.btn_loaddat.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фильтр";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 522);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Группа A",
            "Группа B",
            "Группа C"});
            this.comboBox1.Location = new System.Drawing.Point(355, 521);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(871, 522);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(158, 38);
            this.btn_calculate.TabIndex = 5;
            this.btn_calculate.Text = "Провести анализ";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(1067, 522);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(158, 38);
            this.btn_Print.TabIndex = 6;
            this.btn_Print.Text = "Печать Таблицы";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_sortDate
            // 
            this.btn_sortDate.Location = new System.Drawing.Point(33, 558);
            this.btn_sortDate.Name = "btn_sortDate";
            this.btn_sortDate.Size = new System.Drawing.Size(233, 29);
            this.btn_sortDate.TabIndex = 7;
            this.btn_sortDate.Text = "Применить фильтр по дате";
            this.btn_sortDate.UseVisualStyleBackColor = true;
            this.btn_sortDate.Click += new System.EventHandler(this.btn_sortDate_Click);
            // 
            // btn_sortByGrop
            // 
            this.btn_sortByGrop.Enabled = false;
            this.btn_sortByGrop.Location = new System.Drawing.Point(316, 558);
            this.btn_sortByGrop.Name = "btn_sortByGrop";
            this.btn_sortByGrop.Size = new System.Drawing.Size(241, 29);
            this.btn_sortByGrop.TabIndex = 8;
            this.btn_sortByGrop.Text = "Применить фильтр по группе";
            this.btn_sortByGrop.UseVisualStyleBackColor = true;
            this.btn_sortByGrop.Click += new System.EventHandler(this.btn_sortByGrop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 599);
            this.Controls.Add(this.btn_sortByGrop);
            this.Controls.Add(this.btn_sortDate);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_loaddat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "ABC-анализ товаров книжного магазина";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_loaddat;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button btn_calculate;
        private Button btn_Print;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_sortDate;
        private Button btn_sortByGrop;
    }
}