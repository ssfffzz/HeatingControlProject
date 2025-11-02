namespace thinger.HeatingControlProject
{
    partial class FrmHistoryQuery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_DataList = new System.Windows.Forms.DataGridView();
            this.btn_Query = new System.Windows.Forms.Button();
            this.dpt_Stop = new System.Windows.Forms.DateTimePicker();
            this.dpt_Start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InsertTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PressureIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PressureOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelTank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempBoiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelBoiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PressureBoiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 86);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btn_Close
            // 
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(930, 23);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(62, 41);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "×";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "历史查询";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::thinger.HeatingControlProject.Properties.Resources.device;
            this.pictureBox1.Location = new System.Drawing.Point(68, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.panel2.Controls.Add(this.dgv_DataList);
            this.panel2.Controls.Add(this.btn_Query);
            this.panel2.Controls.Add(this.dpt_Stop);
            this.panel2.Controls.Add(this.dpt_Start);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 648);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // dgv_DataList
            // 
            this.dgv_DataList.AllowUserToAddRows = false;
            this.dgv_DataList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_DataList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DataList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DataList.ColumnHeadersHeight = 35;
            this.dgv_DataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InsertTime,
            this.PressureIn,
            this.PressureOut,
            this.TempIn,
            this.TempOut,
            this.LevelTank,
            this.TempBoiler,
            this.LevelBoiler,
            this.PressureBoiler});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DataList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DataList.EnableHeadersVisualStyles = false;
            this.dgv_DataList.GridColor = System.Drawing.Color.Silver;
            this.dgv_DataList.Location = new System.Drawing.Point(68, 105);
            this.dgv_DataList.Name = "dgv_DataList";
            this.dgv_DataList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DataList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgv_DataList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DataList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_DataList.RowTemplate.Height = 23;
            this.dgv_DataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DataList.Size = new System.Drawing.Size(924, 501);
            this.dgv_DataList.TabIndex = 16;
            this.dgv_DataList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // btn_Query
            // 
            this.btn_Query.BackColor = System.Drawing.Color.Transparent;
            this.btn_Query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Query.FlatAppearance.BorderSize = 0;
            this.btn_Query.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Query.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Query.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Query.ForeColor = System.Drawing.Color.Black;
            this.btn_Query.Image = global::thinger.HeatingControlProject.Properties.Resources.Green;
            this.btn_Query.Location = new System.Drawing.Point(866, 26);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(126, 46);
            this.btn_Query.TabIndex = 15;
            this.btn_Query.Text = "查询数据";
            this.btn_Query.UseVisualStyleBackColor = false;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // dpt_Stop
            // 
            this.dpt_Stop.CalendarFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpt_Stop.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dpt_Stop.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpt_Stop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpt_Stop.Location = new System.Drawing.Point(575, 39);
            this.dpt_Stop.Name = "dpt_Stop";
            this.dpt_Stop.Size = new System.Drawing.Size(252, 26);
            this.dpt_Stop.TabIndex = 10;
            // 
            // dpt_Start
            // 
            this.dpt_Start.CalendarFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpt_Start.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dpt_Start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpt_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpt_Start.Location = new System.Drawing.Point(177, 39);
            this.dpt_Start.Name = "dpt_Start";
            this.dpt_Start.Size = new System.Drawing.Size(252, 26);
            this.dpt_Start.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(463, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "结束时间:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(64, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "开始时间:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InsertTime
            // 
            this.InsertTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InsertTime.DataPropertyName = "InsertTime";
            this.InsertTime.HeaderText = "时间日期";
            this.InsertTime.Name = "InsertTime";
            this.InsertTime.ReadOnly = true;
            // 
            // PressureIn
            // 
            this.PressureIn.DataPropertyName = "PressureIn";
            this.PressureIn.HeaderText = "进口压力";
            this.PressureIn.Name = "PressureIn";
            this.PressureIn.ReadOnly = true;
            this.PressureIn.Width = 90;
            // 
            // PressureOut
            // 
            this.PressureOut.DataPropertyName = "PressureOut";
            this.PressureOut.HeaderText = "出口压力";
            this.PressureOut.Name = "PressureOut";
            this.PressureOut.ReadOnly = true;
            this.PressureOut.Width = 90;
            // 
            // TempIn
            // 
            this.TempIn.DataPropertyName = "TempIn";
            this.TempIn.HeaderText = "进口温度";
            this.TempIn.Name = "TempIn";
            this.TempIn.ReadOnly = true;
            this.TempIn.Width = 90;
            // 
            // TempOut
            // 
            this.TempOut.DataPropertyName = "TempOut";
            this.TempOut.HeaderText = "出口温度";
            this.TempOut.Name = "TempOut";
            this.TempOut.ReadOnly = true;
            this.TempOut.Width = 90;
            // 
            // LevelTank
            // 
            this.LevelTank.DataPropertyName = "LevelTank";
            this.LevelTank.HeaderText = "水罐液位";
            this.LevelTank.Name = "LevelTank";
            this.LevelTank.ReadOnly = true;
            this.LevelTank.Width = 90;
            // 
            // TempBoiler
            // 
            this.TempBoiler.DataPropertyName = "TempBoiler";
            this.TempBoiler.HeaderText = "锅炉温度";
            this.TempBoiler.Name = "TempBoiler";
            this.TempBoiler.ReadOnly = true;
            this.TempBoiler.Width = 90;
            // 
            // LevelBoiler
            // 
            this.LevelBoiler.DataPropertyName = "LevelBoiler";
            this.LevelBoiler.HeaderText = "锅炉液位";
            this.LevelBoiler.Name = "LevelBoiler";
            this.LevelBoiler.ReadOnly = true;
            this.LevelBoiler.Width = 90;
            // 
            // PressureBoiler
            // 
            this.PressureBoiler.DataPropertyName = "PressureBoiler";
            this.PressureBoiler.HeaderText = "锅炉压力";
            this.PressureBoiler.Name = "PressureBoiler";
            this.PressureBoiler.ReadOnly = true;
            this.PressureBoiler.Width = 90;
            // 
            // FrmHistoryQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 740);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistoryQuery";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "历史查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHistoryQuery_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dpt_Stop;
        private System.Windows.Forms.DateTimePicker dpt_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.DataGridView dgv_DataList;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressureIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressureOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelTank;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempBoiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelBoiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressureBoiler;
    }
}