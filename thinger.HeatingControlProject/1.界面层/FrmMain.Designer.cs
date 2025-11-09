namespace thinger.HeatingControlProject
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_UserManage = new System.Windows.Forms.Button();
            this.btn_History = new System.Windows.Forms.Button();
            this.btn_ParamSet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_TempOut = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lbl_PressuerBoiler = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.wave_LevelTank = new thinger.CommonControlLib.thingerWave();
            this.lbl_TempIn = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lbl_ValveCtl = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.toggle_AirPump = new thinger.CommonControlLib.thingerToggleAdvance();
            this.label25 = new System.Windows.Forms.Label();
            this.toggle_AddPump = new thinger.CommonControlLib.thingerToggleAdvance();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toggle_CirclePump = new thinger.CommonControlLib.thingerToggleAdvance();
            this.toggle_FeedPump = new thinger.CommonControlLib.thingerToggleAdvance();
            this.pump_AirState = new thinger.CommonControlLib.thingerPumpBasic();
            this.btn_SystemStop = new System.Windows.Forms.Button();
            this.btn_SystemStart = new System.Windows.Forms.Button();
            this.pump_AddState = new thinger.CommonControlLib.thingerPumpBasic();
            this.pump_FeedState = new thinger.CommonControlLib.thingerPumpBasic();
            this.thingerFlowControl6 = new thinger.CommonControlLib.thingerFlowControl();
            this.thingerFlowControl9 = new thinger.CommonControlLib.thingerFlowControl();
            this.thingerFlowControl7 = new thinger.CommonControlLib.thingerFlowControl();
            this.thingerFlowControl2 = new thinger.CommonControlLib.thingerFlowControl();
            this.thingerFlowControl5 = new thinger.CommonControlLib.thingerFlowControl();
            this.thingerFlowControl10 = new thinger.CommonControlLib.thingerFlowControl();
            this.thingerFlowControl13 = new thinger.CommonControlLib.thingerFlowControl();
            this.thingerFlowControl12 = new thinger.CommonControlLib.thingerFlowControl();
            this.thingerFlowControl11 = new thinger.CommonControlLib.thingerFlowControl();
            this.thingerFlowControl8 = new thinger.CommonControlLib.thingerFlowControl();
            this.thingerFlowControl4 = new thinger.CommonControlLib.thingerFlowControl();
            this.thingerFlowControl3 = new thinger.CommonControlLib.thingerFlowControl();
            this.thingerFlowControl1 = new thinger.CommonControlLib.thingerFlowControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl_PressuerBoiler2 = new System.Windows.Forms.Label();
            this.meter_PressureBoiler = new thinger.CommonControlLib.thingerAnalogMeter();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl_LevelBoiler = new System.Windows.Forms.Label();
            this.meter_LevelBoiler = new thinger.CommonControlLib.thingerAnalogMeter();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl_TempBoiler = new System.Windows.Forms.Label();
            this.meter_TempBoiler = new thinger.CommonControlLib.thingerAnalogMeter();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl_LevelTank = new System.Windows.Forms.Label();
            this.meter_LevelTank = new thinger.CommonControlLib.thingerAnalogMeter();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_PressureOut = new System.Windows.Forms.Label();
            this.lbl_TempOut2 = new System.Windows.Forms.Label();
            this.lbl_TempIn2 = new System.Windows.Forms.Label();
            this.meter_PressureOut = new thinger.CommonControlLib.thingerAnalogMeter();
            this.meter_TempOut = new thinger.CommonControlLib.thingerAnalogMeter();
            this.meter_TempIn = new thinger.CommonControlLib.thingerAnalogMeter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.led_SystemState = new thinger.CommonControlLib.thingerLED();
            this.label8 = new System.Windows.Forms.Label();
            this.led_PLCState = new thinger.CommonControlLib.thingerLED();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_PressureIn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.meter_PressureIn = new thinger.CommonControlLib.thingerAnalogMeter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pump_CircleState = new thinger.CommonControlLib.thingerPump();
            this.ReadTimer = new System.Windows.Forms.Timer(this.components);
            this.ct_boiler = new thinger.HeatingCustomControls.ThingerHCBoiler();
            this.valve_OutState = new thinger.HeatingCustomControls.ThingerHCValve();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::thinger.HeatingControlProject.Properties.Resources.TopPanel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCurrentAdmin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_UserManage);
            this.panel1.Controls.Add(this.btn_History);
            this.panel1.Controls.Add(this.btn_ParamSet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 93);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(477, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 53);
            this.label3.TabIndex = 3;
            this.label3.Text = "新歌清洁能源SCADA系统";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentAdmin
            // 
            this.lblCurrentAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.lblCurrentAdmin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentAdmin.ForeColor = System.Drawing.Color.White;
            this.lblCurrentAdmin.Location = new System.Drawing.Point(942, 67);
            this.lblCurrentAdmin.Name = "lblCurrentAdmin";
            this.lblCurrentAdmin.Size = new System.Drawing.Size(68, 23);
            this.lblCurrentAdmin.TabIndex = 3;
            this.lblCurrentAdmin.Text = "未登录";
            this.lblCurrentAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.label1.Image = global::thinger.HeatingControlProject.Properties.Resources.当前用户;
            this.label1.Location = new System.Drawing.Point(848, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 3;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = global::thinger.HeatingControlProject.Properties.Resources.NaviRight;
            this.btn_Exit.Location = new System.Drawing.Point(1158, 51);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(110, 36);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "退出系统";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_UserManage
            // 
            this.btn_UserManage.BackColor = System.Drawing.Color.Transparent;
            this.btn_UserManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UserManage.FlatAppearance.BorderSize = 0;
            this.btn_UserManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_UserManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_UserManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserManage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_UserManage.ForeColor = System.Drawing.Color.White;
            this.btn_UserManage.Image = global::thinger.HeatingControlProject.Properties.Resources.NaviRight;
            this.btn_UserManage.Location = new System.Drawing.Point(1016, 51);
            this.btn_UserManage.Name = "btn_UserManage";
            this.btn_UserManage.Size = new System.Drawing.Size(110, 36);
            this.btn_UserManage.TabIndex = 2;
            this.btn_UserManage.Text = "用户管理";
            this.btn_UserManage.UseVisualStyleBackColor = false;
            this.btn_UserManage.Click += new System.EventHandler(this.btn_UserManage_Click);
            // 
            // btn_History
            // 
            this.btn_History.BackColor = System.Drawing.Color.Transparent;
            this.btn_History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_History.FlatAppearance.BorderSize = 0;
            this.btn_History.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_History.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_History.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_History.ForeColor = System.Drawing.Color.White;
            this.btn_History.Image = global::thinger.HeatingControlProject.Properties.Resources.NaviLeft;
            this.btn_History.Location = new System.Drawing.Point(179, 51);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(110, 36);
            this.btn_History.TabIndex = 0;
            this.btn_History.Text = "历史查询";
            this.btn_History.UseVisualStyleBackColor = false;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_ParamSet
            // 
            this.btn_ParamSet.BackColor = System.Drawing.Color.Transparent;
            this.btn_ParamSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ParamSet.FlatAppearance.BorderSize = 0;
            this.btn_ParamSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ParamSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ParamSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ParamSet.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ParamSet.ForeColor = System.Drawing.Color.White;
            this.btn_ParamSet.Image = global::thinger.HeatingControlProject.Properties.Resources.NaviLeft;
            this.btn_ParamSet.Location = new System.Drawing.Point(37, 51);
            this.btn_ParamSet.Name = "btn_ParamSet";
            this.btn_ParamSet.Size = new System.Drawing.Size(110, 36);
            this.btn_ParamSet.TabIndex = 0;
            this.btn_ParamSet.Text = "参数设置";
            this.btn_ParamSet.UseVisualStyleBackColor = false;
            this.btn_ParamSet.Click += new System.EventHandler(this.btn_ParamSet_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.panel2.Controls.Add(this.lbl_TempOut);
            this.panel2.Controls.Add(this.label37);
            this.panel2.Controls.Add(this.label36);
            this.panel2.Controls.Add(this.label35);
            this.panel2.Controls.Add(this.lbl_PressuerBoiler);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.wave_LevelTank);
            this.panel2.Controls.Add(this.lbl_TempIn);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.label40);
            this.panel2.Controls.Add(this.label39);
            this.panel2.Controls.Add(this.lbl_ValveCtl);
            this.panel2.Controls.Add(this.label38);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.ct_boiler);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.toggle_CirclePump);
            this.panel2.Controls.Add(this.toggle_FeedPump);
            this.panel2.Controls.Add(this.pump_AirState);
            this.panel2.Controls.Add(this.btn_SystemStop);
            this.panel2.Controls.Add(this.btn_SystemStart);
            this.panel2.Controls.Add(this.pump_AddState);
            this.panel2.Controls.Add(this.pump_FeedState);
            this.panel2.Controls.Add(this.thingerFlowControl6);
            this.panel2.Controls.Add(this.thingerFlowControl9);
            this.panel2.Controls.Add(this.thingerFlowControl7);
            this.panel2.Controls.Add(this.thingerFlowControl2);
            this.panel2.Controls.Add(this.thingerFlowControl5);
            this.panel2.Controls.Add(this.thingerFlowControl10);
            this.panel2.Controls.Add(this.thingerFlowControl13);
            this.panel2.Controls.Add(this.thingerFlowControl12);
            this.panel2.Controls.Add(this.thingerFlowControl11);
            this.panel2.Controls.Add(this.thingerFlowControl8);
            this.panel2.Controls.Add(this.thingerFlowControl4);
            this.panel2.Controls.Add(this.thingerFlowControl3);
            this.panel2.Controls.Add(this.thingerFlowControl1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pump_CircleState);
            this.panel2.Controls.Add(this.valve_OutState);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 675);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lbl_TempOut
            // 
            this.lbl_TempOut.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TempOut.Font = new System.Drawing.Font("DigifaceWide", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TempOut.ForeColor = System.Drawing.Color.White;
            this.lbl_TempOut.Location = new System.Drawing.Point(260, 290);
            this.lbl_TempOut.Name = "lbl_TempOut";
            this.lbl_TempOut.Size = new System.Drawing.Size(87, 23);
            this.lbl_TempOut.TabIndex = 13;
            this.lbl_TempOut.Text = "00.0°C";
            this.lbl_TempOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.ForeColor = System.Drawing.Color.Lime;
            this.label37.Location = new System.Drawing.Point(339, 371);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(87, 23);
            this.label37.TabIndex = 14;
            this.label37.Text = "出水阀门";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.ForeColor = System.Drawing.Color.Lime;
            this.label36.Location = new System.Drawing.Point(260, 347);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(87, 23);
            this.label36.TabIndex = 14;
            this.label36.Text = "入户管网";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.ForeColor = System.Drawing.Color.Lime;
            this.label35.Location = new System.Drawing.Point(260, 260);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(87, 23);
            this.label35.TabIndex = 14;
            this.label35.Text = "出水温度";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PressuerBoiler
            // 
            this.lbl_PressuerBoiler.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PressuerBoiler.Font = new System.Drawing.Font("DigifaceWide", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PressuerBoiler.ForeColor = System.Drawing.Color.White;
            this.lbl_PressuerBoiler.Location = new System.Drawing.Point(667, 168);
            this.lbl_PressuerBoiler.Name = "lbl_PressuerBoiler";
            this.lbl_PressuerBoiler.Size = new System.Drawing.Size(87, 23);
            this.lbl_PressuerBoiler.TabIndex = 11;
            this.lbl_PressuerBoiler.Text = "00.0°C";
            this.lbl_PressuerBoiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.ForeColor = System.Drawing.Color.Lime;
            this.label31.Location = new System.Drawing.Point(667, 138);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(87, 23);
            this.label31.TabIndex = 12;
            this.label31.Text = "锅炉压力";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wave_LevelTank
            // 
            this.wave_LevelTank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.wave_LevelTank.ConerRadius = 10;
            this.wave_LevelTank.FillColor = System.Drawing.Color.Transparent;
            this.wave_LevelTank.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wave_LevelTank.ForeColor = System.Drawing.Color.Black;
            this.wave_LevelTank.IsRadius = true;
            this.wave_LevelTank.IsRectangle = true;
            this.wave_LevelTank.IsShowRect = false;
            this.wave_LevelTank.Location = new System.Drawing.Point(980, 300);
            this.wave_LevelTank.MaxValue = 100;
            this.wave_LevelTank.Name = "wave_LevelTank";
            this.wave_LevelTank.RectColor = System.Drawing.Color.White;
            this.wave_LevelTank.RectWidth = 4;
            this.wave_LevelTank.Size = new System.Drawing.Size(82, 124);
            this.wave_LevelTank.TabIndex = 7;
            this.wave_LevelTank.Value = 0;
            this.wave_LevelTank.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // lbl_TempIn
            // 
            this.lbl_TempIn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TempIn.Font = new System.Drawing.Font("DigifaceWide", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TempIn.ForeColor = System.Drawing.Color.White;
            this.lbl_TempIn.Location = new System.Drawing.Point(281, 145);
            this.lbl_TempIn.Name = "lbl_TempIn";
            this.lbl_TempIn.Size = new System.Drawing.Size(87, 23);
            this.lbl_TempIn.TabIndex = 3;
            this.lbl_TempIn.Text = "00.0°C";
            this.lbl_TempIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.ForeColor = System.Drawing.Color.Lime;
            this.label27.Location = new System.Drawing.Point(281, 115);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(87, 23);
            this.label27.TabIndex = 3;
            this.label27.Text = "进水温度";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.ForeColor = System.Drawing.Color.Lime;
            this.label33.Location = new System.Drawing.Point(972, 134);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(87, 23);
            this.label33.TabIndex = 3;
            this.label33.Text = "燃气泵";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.ForeColor = System.Drawing.Color.Lime;
            this.label32.Location = new System.Drawing.Point(972, 17);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(87, 23);
            this.label32.TabIndex = 3;
            this.label32.Text = "加水泵";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label40.ForeColor = System.Drawing.Color.Lime;
            this.label40.Location = new System.Drawing.Point(745, 274);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(69, 23);
            this.label40.TabIndex = 3;
            this.label40.Text = "储水罐";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label39.ForeColor = System.Drawing.Color.Lime;
            this.label39.Location = new System.Drawing.Point(640, 274);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(69, 23);
            this.label39.TabIndex = 3;
            this.label39.Text = "循环泵";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ValveCtl
            // 
            this.lbl_ValveCtl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_ValveCtl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ValveCtl.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ValveCtl.ForeColor = System.Drawing.Color.White;
            this.lbl_ValveCtl.Location = new System.Drawing.Point(365, 230);
            this.lbl_ValveCtl.Name = "lbl_ValveCtl";
            this.lbl_ValveCtl.Size = new System.Drawing.Size(54, 23);
            this.lbl_ValveCtl.TabIndex = 3;
            this.lbl_ValveCtl.Text = "已关闭";
            this.lbl_ValveCtl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ValveCtl.DoubleClick += new System.EventHandler(this.lbl_ValveCtl_DoubleClick);
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.ForeColor = System.Drawing.Color.Lime;
            this.label38.Location = new System.Drawing.Point(458, 250);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(87, 23);
            this.label38.TabIndex = 3;
            this.label38.Text = "出水过滤器";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.ForeColor = System.Drawing.Color.Lime;
            this.label29.Location = new System.Drawing.Point(577, 23);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(87, 23);
            this.label29.TabIndex = 3;
            this.label29.Text = "进水过滤器";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.ForeColor = System.Drawing.Color.Lime;
            this.label23.Location = new System.Drawing.Point(386, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 23);
            this.label23.TabIndex = 3;
            this.label23.Text = "进水泵";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::thinger.HeatingControlProject.Properties.Resources.PumpPanel;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.toggle_AirPump);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Controls.Add(this.toggle_AddPump);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Location = new System.Drawing.Point(1087, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(158, 167);
            this.panel6.TabIndex = 6;
            // 
            // toggle_AirPump
            // 
            this.toggle_AirPump.Checked = false;
            this.toggle_AirPump.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toggle_AirPump.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toggle_AirPump.Location = new System.Drawing.Point(34, 119);
            this.toggle_AirPump.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toggle_AirPump.Name = "toggle_AirPump";
            this.toggle_AirPump.Size = new System.Drawing.Size(73, 30);
            this.toggle_AirPump.SwitchType = thinger.CommonControlLib.SwitchType.Ellipse;
            this.toggle_AirPump.TabIndex = 6;
            this.toggle_AirPump.Texts = null;
            this.toggle_AirPump.TrueColor = System.Drawing.Color.Lime;
            this.toggle_AirPump.CheckedChanged += new System.EventHandler(this.toggle_AirPump_CheckedChanged);
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(20, 91);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 23);
            this.label25.TabIndex = 5;
            this.label25.Text = "燃气泵控制:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toggle_AddPump
            // 
            this.toggle_AddPump.Checked = false;
            this.toggle_AddPump.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toggle_AddPump.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toggle_AddPump.Location = new System.Drawing.Point(35, 51);
            this.toggle_AddPump.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toggle_AddPump.Name = "toggle_AddPump";
            this.toggle_AddPump.Size = new System.Drawing.Size(73, 30);
            this.toggle_AddPump.SwitchType = thinger.CommonControlLib.SwitchType.Ellipse;
            this.toggle_AddPump.TabIndex = 4;
            this.toggle_AddPump.Texts = null;
            this.toggle_AddPump.TrueColor = System.Drawing.Color.Lime;
            this.toggle_AddPump.CheckedChanged += new System.EventHandler(this.toggle_AddPump_CheckedChanged);
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(21, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 23);
            this.label24.TabIndex = 3;
            this.label24.Text = "加水泵控制:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.ForeColor = System.Drawing.Color.Lime;
            this.label26.Location = new System.Drawing.Point(972, 274);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 23);
            this.label26.TabIndex = 3;
            this.label26.Text = "储水罐液位";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::thinger.HeatingControlProject.Properties.Resources.Filter;
            this.pictureBox3.Location = new System.Drawing.Point(461, 281);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 98);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::thinger.HeatingControlProject.Properties.Resources.Filter;
            this.pictureBox1.Location = new System.Drawing.Point(588, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // toggle_CirclePump
            // 
            this.toggle_CirclePump.Checked = false;
            this.toggle_CirclePump.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toggle_CirclePump.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toggle_CirclePump.Location = new System.Drawing.Point(590, 365);
            this.toggle_CirclePump.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toggle_CirclePump.Name = "toggle_CirclePump";
            this.toggle_CirclePump.Size = new System.Drawing.Size(53, 28);
            this.toggle_CirclePump.SwitchType = thinger.CommonControlLib.SwitchType.Quadrilateral;
            this.toggle_CirclePump.TabIndex = 3;
            this.toggle_CirclePump.Texts = null;
            this.toggle_CirclePump.TrueColor = System.Drawing.Color.Lime;
            this.toggle_CirclePump.CheckedChanged += new System.EventHandler(this.toggle_CirclePump_CheckedChanged);
            // 
            // toggle_FeedPump
            // 
            this.toggle_FeedPump.Checked = false;
            this.toggle_FeedPump.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toggle_FeedPump.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toggle_FeedPump.Location = new System.Drawing.Point(404, 146);
            this.toggle_FeedPump.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toggle_FeedPump.Name = "toggle_FeedPump";
            this.toggle_FeedPump.Size = new System.Drawing.Size(53, 28);
            this.toggle_FeedPump.SwitchType = thinger.CommonControlLib.SwitchType.Quadrilateral;
            this.toggle_FeedPump.TabIndex = 3;
            this.toggle_FeedPump.Texts = null;
            this.toggle_FeedPump.TrueColor = System.Drawing.Color.Lime;
            this.toggle_FeedPump.CheckedChanged += new System.EventHandler(this.toggle_FeedPump_CheckedChanged);
            // 
            // pump_AirState
            // 
            this.pump_AirState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.pump_AirState.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pump_AirState.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pump_AirState.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pump_AirState.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.pump_AirState.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pump_AirState.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pump_AirState.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.pump_AirState.Entrance = 6;
            this.pump_AirState.Export = 1;
            this.pump_AirState.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pump_AirState.IsRun = false;
            this.pump_AirState.Location = new System.Drawing.Point(962, 138);
            this.pump_AirState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pump_AirState.MoveSpeed = 1F;
            this.pump_AirState.Name = "pump_AirState";
            this.pump_AirState.Size = new System.Drawing.Size(100, 100);
            this.pump_AirState.TabIndex = 2;
            this.pump_AirState.Text = "thingerPumpBasic1";
            // 
            // btn_SystemStop
            // 
            this.btn_SystemStop.BackColor = System.Drawing.Color.Transparent;
            this.btn_SystemStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SystemStop.Enabled = false;
            this.btn_SystemStop.FlatAppearance.BorderSize = 0;
            this.btn_SystemStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_SystemStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_SystemStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SystemStop.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SystemStop.ForeColor = System.Drawing.Color.Black;
            this.btn_SystemStop.Image = global::thinger.HeatingControlProject.Properties.Resources.Yellow;
            this.btn_SystemStop.Location = new System.Drawing.Point(1111, 378);
            this.btn_SystemStop.Name = "btn_SystemStop";
            this.btn_SystemStop.Size = new System.Drawing.Size(110, 46);
            this.btn_SystemStop.TabIndex = 0;
            this.btn_SystemStop.Text = "系统停止";
            this.btn_SystemStop.UseVisualStyleBackColor = false;
            this.btn_SystemStop.Click += new System.EventHandler(this.btn_SystemStop_Click);
            // 
            // btn_SystemStart
            // 
            this.btn_SystemStart.BackColor = System.Drawing.Color.Transparent;
            this.btn_SystemStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SystemStart.FlatAppearance.BorderSize = 0;
            this.btn_SystemStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_SystemStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_SystemStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SystemStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SystemStart.ForeColor = System.Drawing.Color.Black;
            this.btn_SystemStart.Image = global::thinger.HeatingControlProject.Properties.Resources.Green;
            this.btn_SystemStart.Location = new System.Drawing.Point(1110, 300);
            this.btn_SystemStart.Name = "btn_SystemStart";
            this.btn_SystemStart.Size = new System.Drawing.Size(110, 46);
            this.btn_SystemStart.TabIndex = 0;
            this.btn_SystemStart.Text = "系统启动";
            this.btn_SystemStart.UseVisualStyleBackColor = false;
            this.btn_SystemStart.Click += new System.EventHandler(this.btn_SystemStart_Click);
            // 
            // pump_AddState
            // 
            this.pump_AddState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.pump_AddState.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.pump_AddState.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(164)))), ((int)(((byte)(173)))));
            this.pump_AddState.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pump_AddState.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.pump_AddState.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.pump_AddState.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(160)))), ((int)(((byte)(169)))));
            this.pump_AddState.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.pump_AddState.Entrance = 6;
            this.pump_AddState.Export = 1;
            this.pump_AddState.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pump_AddState.IsRun = false;
            this.pump_AddState.Location = new System.Drawing.Point(962, 23);
            this.pump_AddState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pump_AddState.MoveSpeed = 1F;
            this.pump_AddState.Name = "pump_AddState";
            this.pump_AddState.Size = new System.Drawing.Size(100, 100);
            this.pump_AddState.TabIndex = 2;
            this.pump_AddState.Text = "thingerPumpBasic1";
            // 
            // pump_FeedState
            // 
            this.pump_FeedState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(85)))));
            this.pump_FeedState.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.pump_FeedState.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(164)))), ((int)(((byte)(173)))));
            this.pump_FeedState.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pump_FeedState.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.pump_FeedState.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.pump_FeedState.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(160)))), ((int)(((byte)(169)))));
            this.pump_FeedState.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.pump_FeedState.Entrance = 6;
            this.pump_FeedState.Export = 1;
            this.pump_FeedState.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pump_FeedState.IsRun = false;
            this.pump_FeedState.Location = new System.Drawing.Point(381, 36);
            this.pump_FeedState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pump_FeedState.MoveSpeed = -1F;
            this.pump_FeedState.Name = "pump_FeedState";
            this.pump_FeedState.Size = new System.Drawing.Size(100, 100);
            this.pump_FeedState.TabIndex = 2;
            this.pump_FeedState.Text = "thingerPumpBasic1";
            // 
            // thingerFlowControl6
            // 
            this.thingerFlowControl6.BackColor = System.Drawing.Color.Transparent;
            this.thingerFlowControl6.ColorPipeLineCenter = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.thingerFlowControl6.EdgeColor = System.Drawing.Color.DimGray;
            this.thingerFlowControl6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thingerFlowControl6.LineCenterColor = System.Drawing.Color.LightGray;
            this.thingerFlowControl6.Location = new System.Drawing.Point(876, 194);
            this.thingerFlowControl6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thingerFlowControl6.MoveSpeed = -1F;
            this.thingerFlowControl6.Name = "thingerFlowControl6";
            this.thingerFlowControl6.PipeLineActive = true;
            this.thingerFlowControl6.PipeLineGap = 5;
            this.thingerFlowControl6.PipeLineLength = 5;
            this.thingerFlowControl6.PipeLineStyle = thinger.CommonControlLib.DirectionStyle.Horizontal;
            this.thingerFlowControl6.PipeLineWidth = 5;
            this.thingerFlowControl6.PipeTurnLeft = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl6.PipeTurnRight = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl6.Size = new System.Drawing.Size(88, 22);
            this.thingerFlowControl6.TabIndex = 1;
            // 
            // thingerFlowControl9
            // 
            this.thingerFlowControl9.BackColor = System.Drawing.Color.Transparent;
            this.thingerFlowControl9.ColorPipeLineCenter = System.Drawing.Color.DodgerBlue;
            this.thingerFlowControl9.EdgeColor = System.Drawing.Color.DimGray;
            this.thingerFlowControl9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thingerFlowControl9.LineCenterColor = System.Drawing.Color.LightGray;
            this.thingerFlowControl9.Location = new System.Drawing.Point(696, 334);
            this.thingerFlowControl9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thingerFlowControl9.MoveSpeed = -1F;
            this.thingerFlowControl9.Name = "thingerFlowControl9";
            this.thingerFlowControl9.PipeLineActive = true;
            this.thingerFlowControl9.PipeLineGap = 5;
            this.thingerFlowControl9.PipeLineLength = 5;
            this.thingerFlowControl9.PipeLineStyle = thinger.CommonControlLib.DirectionStyle.Vertical;
            this.thingerFlowControl9.PipeLineWidth = 5;
            this.thingerFlowControl9.PipeTurnLeft = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl9.PipeTurnRight = thinger.CommonControlLib.PipeTurnDirection.Right;
            this.thingerFlowControl9.Size = new System.Drawing.Size(13, 85);
            this.thingerFlowControl9.TabIndex = 1;
            // 
            // thingerFlowControl7
            // 
            this.thingerFlowControl7.BackColor = System.Drawing.Color.Transparent;
            this.thingerFlowControl7.ColorPipeLineCenter = System.Drawing.Color.DodgerBlue;
            this.thingerFlowControl7.EdgeColor = System.Drawing.Color.DimGray;
            this.thingerFlowControl7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thingerFlowControl7.LineCenterColor = System.Drawing.Color.LightGray;
            this.thingerFlowControl7.Location = new System.Drawing.Point(844, 371);
            this.thingerFlowControl7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thingerFlowControl7.MoveSpeed = 1F;
            this.thingerFlowControl7.Name = "thingerFlowControl7";
            this.thingerFlowControl7.PipeLineActive = true;
            this.thingerFlowControl7.PipeLineGap = 5;
            this.thingerFlowControl7.PipeLineLength = 5;
            this.thingerFlowControl7.PipeLineStyle = thinger.CommonControlLib.DirectionStyle.Vertical;
            this.thingerFlowControl7.PipeLineWidth = 5;
            this.thingerFlowControl7.PipeTurnLeft = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl7.PipeTurnRight = thinger.CommonControlLib.PipeTurnDirection.Left;
            this.thingerFlowControl7.Size = new System.Drawing.Size(13, 47);
            this.thingerFlowControl7.TabIndex = 1;
            // 
            // thingerFlowControl2
            // 
            this.thingerFlowControl2.BackColor = System.Drawing.Color.Transparent;
            this.thingerFlowControl2.ColorPipeLineCenter = System.Drawing.Color.DodgerBlue;
            this.thingerFlowControl2.EdgeColor = System.Drawing.Color.DimGray;
            this.thingerFlowControl2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thingerFlowControl2.LineCenterColor = System.Drawing.Color.LightGray;
            this.thingerFlowControl2.Location = new System.Drawing.Point(831, 250);
            this.thingerFlowControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thingerFlowControl2.MoveSpeed = 1F;
            this.thingerFlowControl2.Name = "thingerFlowControl2";
            this.thingerFlowControl2.PipeLineActive = true;
            this.thingerFlowControl2.PipeLineGap = 5;
            this.thingerFlowControl2.PipeLineLength = 5;
            this.thingerFlowControl2.PipeLineStyle = thinger.CommonControlLib.DirectionStyle.Vertical;
            this.thingerFlowControl2.PipeLineWidth = 5;
            this.thingerFlowControl2.PipeTurnLeft = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl2.PipeTurnRight = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl2.Size = new System.Drawing.Size(11, 47);
            this.thingerFlowControl2.TabIndex = 1;
            // 
            // thingerFlowControl5
            // 
            this.thingerFlowControl5.BackColor = System.Drawing.Color.Transparent;
            this.thingerFlowControl5.ColorPipeLineCenter = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.thingerFlowControl5.EdgeColor = System.Drawing.Color.DimGray;
            this.thingerFlowControl5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thingerFlowControl5.LineCenterColor = System.Drawing.Color.LightGray;
            this.thingerFlowControl5.Location = new System.Drawing.Point(876, 79);
            this.thingerFlowControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thingerFlowControl5.MoveSpeed = -1F;
            this.thingerFlowControl5.Name = "thingerFlowControl5";
            this.thingerFlowControl5.PipeLineActive = true;
            this.thingerFlowControl5.PipeLineGap = 5;
            this.thingerFlowControl5.PipeLineLength = 5;
            this.thingerFlowControl5.PipeLineStyle = thinger.CommonControlLib.DirectionStyle.Horizontal;
            this.thingerFlowControl5.PipeLineWidth = 5;
            this.thingerFlowControl5.PipeTurnLeft = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl5.PipeTurnRight = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl5.Size = new System.Drawing.Size(88, 22);
            this.thingerFlowControl5.TabIndex = 1;
            // 
            // thingerFlowControl10
            // 
            this.thingerFlowControl10.BackColor = System.Drawing.Color.Transparent;
            this.thingerFlowControl10.ColorPipeLineCenter = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.thingerFlowControl10.EdgeColor = System.Drawing.Color.DimGray;
            this.thingerFlowControl10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thingerFlowControl10.LineCenterColor = System.Drawing.Color.LightGray;
            this.thingerFlowControl10.Location = new System.Drawing.Point(654, 321);
            this.thingerFlowControl10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thingerFlowControl10.MoveSpeed = -1F;
            this.thingerFlowControl10.Name = "thingerFlowControl10";
            this.thingerFlowControl10.PipeLineActive = true;
            this.thingerFlowControl10.PipeLineGap = 5;
            this.thingerFlowControl10.PipeLineLength = 5;
            this.thingerFlowControl10.PipeLineStyle = thinger.CommonControlLib.DirectionStyle.Horizontal;
            this.thingerFlowControl10.PipeLineWidth = 5;
            this.thingerFlowControl10.PipeTurnLeft = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl10.PipeTurnRight = thinger.CommonControlLib.PipeTurnDirection.Down;
            this.thingerFlowControl10.Size = new System.Drawing.Size(55, 13);
            this.thingerFlowControl10.TabIndex = 1;
            // 
            // thingerFlowControl13
            // 
            this.thingerFlowControl13.BackColor = System.Drawing.Color.Transparent;
            this.thingerFlowControl13.ColorPipeLineCenter = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.thingerFlowControl13.EdgeColor = System.Drawing.Color.DimGray;
            this.thingerFlowControl13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thingerFlowControl13.LineCenterColor = System.Drawing.Color.LightGray;
            this.thingerFlowControl13.Location = new System.Drawing.Point(272, 321);
            this.thingerFlowControl13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thingerFlowControl13.MoveSpeed = -1F;
            this.thingerFlowControl13.Name = "thingerFlowControl13";
            this.thingerFlowControl13.PipeLineActive = true;
            this.thingerFlowControl13.PipeLineGap = 5;
            this.thingerFlowControl13.PipeLineLength = 5;
            this.thingerFlowControl13.PipeLineStyle = thinger.CommonControlLib.DirectionStyle.Horizontal;
            this.thingerFlowControl13.PipeLineWidth = 5;
            this.thingerFlowControl13.PipeTurnLeft = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl13.PipeTurnRight = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl13.Size = new System.Drawing.Size(86, 13);
            this.thingerFlowControl13.TabIndex = 1;
            // 
            // thingerFlowControl12
            // 
            this.thingerFlowControl12.BackColor = System.Drawing.Color.Transparent;
            this.thingerFlowControl12.ColorPipeLineCenter = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.thingerFlowControl12.EdgeColor = System.Drawing.Color.DimGray;
            this.thingerFlowControl12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thingerFlowControl12.LineCenterColor = System.Drawing.Color.LightGray;
            this.thingerFlowControl12.Location = new System.Drawing.Point(404, 321);
            this.thingerFlowControl12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thingerFlowControl12.MoveSpeed = -1F;
            this.thingerFlowControl12.Name = "thingerFlowControl12";
            this.thingerFlowControl12.PipeLineActive = true;
            this.thingerFlowControl12.PipeLineGap = 5;
            this.thingerFlowControl12.PipeLineLength = 5;
            this.thingerFlowControl12.PipeLineStyle = thinger.CommonControlLib.DirectionStyle.Horizontal;
            this.thingerFlowControl12.PipeLineWidth = 5;
            this.thingerFlowControl12.PipeTurnLeft = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl12.PipeTurnRight = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl12.Size = new System.Drawing.Size(59, 13);
            this.thingerFlowControl12.TabIndex = 1;
            // 
            // thingerFlowControl11
            // 
            this.thingerFlowControl11.BackColor = System.Drawing.Color.Transparent;
            this.thingerFlowControl11.ColorPipeLineCenter = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.thingerFlowControl11.EdgeColor = System.Drawing.Color.DimGray;
            this.thingerFlowControl11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thingerFlowControl11.LineCenterColor = System.Drawing.Color.LightGray;
            this.thingerFlowControl11.Location = new System.Drawing.Point(527, 321);
            this.thingerFlowControl11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thingerFlowControl11.MoveSpeed = -1F;
            this.thingerFlowControl11.Name = "thingerFlowControl11";
            this.thingerFlowControl11.PipeLineActive = true;
            this.thingerFlowControl11.PipeLineGap = 5;
            this.thingerFlowControl11.PipeLineLength = 5;
            this.thingerFlowControl11.PipeLineStyle = thinger.CommonControlLib.DirectionStyle.Horizontal;
            this.thingerFlowControl11.PipeLineWidth = 5;
            this.thingerFlowControl11.PipeTurnLeft = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl11.PipeTurnRight = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl11.Size = new System.Drawing.Size(59, 13);
            this.thingerFlowControl11.TabIndex = 1;
            // 
            // thingerFlowControl8
            // 
            this.thingerFlowControl8.BackColor = System.Drawing.Color.Transparent;
            this.thingerFlowControl8.ColorPipeLineCenter = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.thingerFlowControl8.EdgeColor = System.Drawing.Color.DimGray;
            this.thingerFlowControl8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thingerFlowControl8.LineCenterColor = System.Drawing.Color.LightGray;
            this.thingerFlowControl8.Location = new System.Drawing.Point(709, 406);
            this.thingerFlowControl8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thingerFlowControl8.MoveSpeed = -1F;
            this.thingerFlowControl8.Name = "thingerFlowControl8";
            this.thingerFlowControl8.PipeLineActive = true;
            this.thingerFlowControl8.PipeLineGap = 5;
            this.thingerFlowControl8.PipeLineLength = 5;
            this.thingerFlowControl8.PipeLineStyle = thinger.CommonControlLib.DirectionStyle.Horizontal;
            this.thingerFlowControl8.PipeLineWidth = 5;
            this.thingerFlowControl8.PipeTurnLeft = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl8.PipeTurnRight = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl8.Size = new System.Drawing.Size(135, 13);
            this.thingerFlowControl8.TabIndex = 1;
            // 
            // thingerFlowControl4
            // 
            this.thingerFlowControl4.BackColor = System.Drawing.Color.Transparent;
            this.thingerFlowControl4.ColorPipeLineCenter = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.thingerFlowControl4.EdgeColor = System.Drawing.Color.DimGray;
            this.thingerFlowControl4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thingerFlowControl4.LineCenterColor = System.Drawing.Color.LightGray;
            this.thingerFlowControl4.Location = new System.Drawing.Point(656, 97);
            this.thingerFlowControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thingerFlowControl4.MoveSpeed = 1F;
            this.thingerFlowControl4.Name = "thingerFlowControl4";
            this.thingerFlowControl4.PipeLineActive = true;
            this.thingerFlowControl4.PipeLineGap = 5;
            this.thingerFlowControl4.PipeLineLength = 5;
            this.thingerFlowControl4.PipeLineStyle = thinger.CommonControlLib.DirectionStyle.Horizontal;
            this.thingerFlowControl4.PipeLineWidth = 5;
            this.thingerFlowControl4.PipeTurnLeft = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl4.PipeTurnRight = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl4.Size = new System.Drawing.Size(114, 13);
            this.thingerFlowControl4.TabIndex = 1;
            // 
            // thingerFlowControl3
            // 
            this.thingerFlowControl3.BackColor = System.Drawing.Color.Transparent;
            this.thingerFlowControl3.ColorPipeLineCenter = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.thingerFlowControl3.EdgeColor = System.Drawing.Color.DimGray;
            this.thingerFlowControl3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thingerFlowControl3.LineCenterColor = System.Drawing.Color.LightGray;
            this.thingerFlowControl3.Location = new System.Drawing.Point(475, 97);
            this.thingerFlowControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thingerFlowControl3.MoveSpeed = 1F;
            this.thingerFlowControl3.Name = "thingerFlowControl3";
            this.thingerFlowControl3.PipeLineActive = true;
            this.thingerFlowControl3.PipeLineGap = 5;
            this.thingerFlowControl3.PipeLineLength = 5;
            this.thingerFlowControl3.PipeLineStyle = thinger.CommonControlLib.DirectionStyle.Horizontal;
            this.thingerFlowControl3.PipeLineWidth = 5;
            this.thingerFlowControl3.PipeTurnLeft = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl3.PipeTurnRight = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl3.Size = new System.Drawing.Size(114, 13);
            this.thingerFlowControl3.TabIndex = 1;
            // 
            // thingerFlowControl1
            // 
            this.thingerFlowControl1.BackColor = System.Drawing.Color.Transparent;
            this.thingerFlowControl1.ColorPipeLineCenter = System.Drawing.Color.DodgerBlue;
            this.thingerFlowControl1.EdgeColor = System.Drawing.Color.DimGray;
            this.thingerFlowControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thingerFlowControl1.LineCenterColor = System.Drawing.Color.LightGray;
            this.thingerFlowControl1.Location = new System.Drawing.Point(284, 97);
            this.thingerFlowControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thingerFlowControl1.MoveSpeed = 1F;
            this.thingerFlowControl1.Name = "thingerFlowControl1";
            this.thingerFlowControl1.PipeLineActive = true;
            this.thingerFlowControl1.PipeLineGap = 5;
            this.thingerFlowControl1.PipeLineLength = 5;
            this.thingerFlowControl1.PipeLineStyle = thinger.CommonControlLib.DirectionStyle.Horizontal;
            this.thingerFlowControl1.PipeLineWidth = 5;
            this.thingerFlowControl1.PipeTurnLeft = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl1.PipeTurnRight = thinger.CommonControlLib.PipeTurnDirection.None;
            this.thingerFlowControl1.Size = new System.Drawing.Size(106, 13);
            this.thingerFlowControl1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::thinger.HeatingControlProject.Properties.Resources.DataPanel;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.lbl7);
            this.panel5.Controls.Add(this.lbl_PressuerBoiler2);
            this.panel5.Controls.Add(this.meter_PressureBoiler);
            this.panel5.Controls.Add(this.lbl6);
            this.panel5.Controls.Add(this.lbl_LevelBoiler);
            this.panel5.Controls.Add(this.meter_LevelBoiler);
            this.panel5.Controls.Add(this.lbl5);
            this.panel5.Controls.Add(this.lbl_TempBoiler);
            this.panel5.Controls.Add(this.meter_TempBoiler);
            this.panel5.Controls.Add(this.lbl4);
            this.panel5.Controls.Add(this.lbl_LevelTank);
            this.panel5.Controls.Add(this.meter_LevelTank);
            this.panel5.Controls.Add(this.lbl3);
            this.panel5.Controls.Add(this.lbl2);
            this.panel5.Controls.Add(this.lbl1);
            this.panel5.Controls.Add(this.lbl_PressureOut);
            this.panel5.Controls.Add(this.lbl_TempOut2);
            this.panel5.Controls.Add(this.lbl_TempIn2);
            this.panel5.Controls.Add(this.meter_PressureOut);
            this.panel5.Controls.Add(this.meter_TempOut);
            this.panel5.Controls.Add(this.meter_TempIn);
            this.panel5.Location = new System.Drawing.Point(12, 456);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1244, 212);
            this.panel5.TabIndex = 0;
            // 
            // lbl7
            // 
            this.lbl7.BackColor = System.Drawing.Color.Transparent;
            this.lbl7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl7.ForeColor = System.Drawing.Color.White;
            this.lbl7.Location = new System.Drawing.Point(1069, 170);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(87, 23);
            this.lbl7.TabIndex = 17;
            this.lbl7.Text = "锅炉压力";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PressuerBoiler2
            // 
            this.lbl_PressuerBoiler2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_PressuerBoiler2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PressuerBoiler2.ForeColor = System.Drawing.Color.White;
            this.lbl_PressuerBoiler2.Location = new System.Drawing.Point(1091, 134);
            this.lbl_PressuerBoiler2.Name = "lbl_PressuerBoiler2";
            this.lbl_PressuerBoiler2.Size = new System.Drawing.Size(64, 23);
            this.lbl_PressuerBoiler2.TabIndex = 16;
            this.lbl_PressuerBoiler2.Text = "0.00Bar";
            this.lbl_PressuerBoiler2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meter_PressureBoiler
            // 
            this.meter_PressureBoiler.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.meter_PressureBoiler.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meter_PressureBoiler.Location = new System.Drawing.Point(1046, 20);
            this.meter_PressureBoiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meter_PressureBoiler.MaxValue = 20D;
            this.meter_PressureBoiler.MinValue = 0D;
            this.meter_PressureBoiler.Name = "meter_PressureBoiler";
            this.meter_PressureBoiler.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.meter_PressureBoiler.Renderer = null;
            this.meter_PressureBoiler.ScaleColor = System.Drawing.Color.White;
            this.meter_PressureBoiler.ScaleDivisions = 10;
            this.meter_PressureBoiler.ScaleSubDivisions = 10;
            this.meter_PressureBoiler.Size = new System.Drawing.Size(150, 150);
            this.meter_PressureBoiler.TabIndex = 15;
            this.meter_PressureBoiler.Value = 0D;
            this.meter_PressureBoiler.ViewGlass = false;
            // 
            // lbl6
            // 
            this.lbl6.BackColor = System.Drawing.Color.Transparent;
            this.lbl6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl6.ForeColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(898, 170);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(87, 23);
            this.lbl6.TabIndex = 14;
            this.lbl6.Text = "锅炉水位";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LevelBoiler
            // 
            this.lbl_LevelBoiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_LevelBoiler.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_LevelBoiler.ForeColor = System.Drawing.Color.White;
            this.lbl_LevelBoiler.Location = new System.Drawing.Point(918, 134);
            this.lbl_LevelBoiler.Name = "lbl_LevelBoiler";
            this.lbl_LevelBoiler.Size = new System.Drawing.Size(64, 23);
            this.lbl_LevelBoiler.TabIndex = 13;
            this.lbl_LevelBoiler.Text = "0.00%";
            this.lbl_LevelBoiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meter_LevelBoiler
            // 
            this.meter_LevelBoiler.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.meter_LevelBoiler.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meter_LevelBoiler.Location = new System.Drawing.Point(874, 20);
            this.meter_LevelBoiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meter_LevelBoiler.MaxValue = 100D;
            this.meter_LevelBoiler.MinValue = 0D;
            this.meter_LevelBoiler.Name = "meter_LevelBoiler";
            this.meter_LevelBoiler.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.meter_LevelBoiler.Renderer = null;
            this.meter_LevelBoiler.ScaleColor = System.Drawing.Color.White;
            this.meter_LevelBoiler.ScaleDivisions = 10;
            this.meter_LevelBoiler.ScaleSubDivisions = 10;
            this.meter_LevelBoiler.Size = new System.Drawing.Size(150, 150);
            this.meter_LevelBoiler.TabIndex = 12;
            this.meter_LevelBoiler.Value = 0D;
            this.meter_LevelBoiler.ViewGlass = false;
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(727, 170);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(87, 23);
            this.lbl5.TabIndex = 11;
            this.lbl5.Text = "锅炉水温";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TempBoiler
            // 
            this.lbl_TempBoiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_TempBoiler.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_TempBoiler.ForeColor = System.Drawing.Color.White;
            this.lbl_TempBoiler.Location = new System.Drawing.Point(745, 134);
            this.lbl_TempBoiler.Name = "lbl_TempBoiler";
            this.lbl_TempBoiler.Size = new System.Drawing.Size(64, 23);
            this.lbl_TempBoiler.TabIndex = 10;
            this.lbl_TempBoiler.Text = "0.00℃";
            this.lbl_TempBoiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meter_TempBoiler
            // 
            this.meter_TempBoiler.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.meter_TempBoiler.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meter_TempBoiler.Location = new System.Drawing.Point(702, 20);
            this.meter_TempBoiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meter_TempBoiler.MaxValue = 100D;
            this.meter_TempBoiler.MinValue = 0D;
            this.meter_TempBoiler.Name = "meter_TempBoiler";
            this.meter_TempBoiler.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.meter_TempBoiler.Renderer = null;
            this.meter_TempBoiler.ScaleColor = System.Drawing.Color.White;
            this.meter_TempBoiler.ScaleDivisions = 10;
            this.meter_TempBoiler.ScaleSubDivisions = 10;
            this.meter_TempBoiler.Size = new System.Drawing.Size(150, 150);
            this.meter_TempBoiler.TabIndex = 9;
            this.meter_TempBoiler.Value = 0D;
            this.meter_TempBoiler.ViewGlass = false;
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(556, 170);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(87, 23);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "水罐水位";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LevelTank
            // 
            this.lbl_LevelTank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_LevelTank.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_LevelTank.ForeColor = System.Drawing.Color.White;
            this.lbl_LevelTank.Location = new System.Drawing.Point(572, 134);
            this.lbl_LevelTank.Name = "lbl_LevelTank";
            this.lbl_LevelTank.Size = new System.Drawing.Size(64, 23);
            this.lbl_LevelTank.TabIndex = 7;
            this.lbl_LevelTank.Text = "0.00%";
            this.lbl_LevelTank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meter_LevelTank
            // 
            this.meter_LevelTank.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.meter_LevelTank.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meter_LevelTank.Location = new System.Drawing.Point(530, 20);
            this.meter_LevelTank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meter_LevelTank.MaxValue = 100D;
            this.meter_LevelTank.MinValue = 0D;
            this.meter_LevelTank.Name = "meter_LevelTank";
            this.meter_LevelTank.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.meter_LevelTank.Renderer = null;
            this.meter_LevelTank.ScaleColor = System.Drawing.Color.White;
            this.meter_LevelTank.ScaleDivisions = 10;
            this.meter_LevelTank.ScaleSubDivisions = 10;
            this.meter_LevelTank.Size = new System.Drawing.Size(150, 150);
            this.meter_LevelTank.TabIndex = 6;
            this.meter_LevelTank.Value = 0D;
            this.meter_LevelTank.ViewGlass = false;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(385, 170);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(87, 23);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "出水压力";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(214, 170);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(87, 23);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "出水温度";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(43, 170);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(87, 23);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "进水温度";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PressureOut
            // 
            this.lbl_PressureOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_PressureOut.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PressureOut.ForeColor = System.Drawing.Color.White;
            this.lbl_PressureOut.Location = new System.Drawing.Point(399, 134);
            this.lbl_PressureOut.Name = "lbl_PressureOut";
            this.lbl_PressureOut.Size = new System.Drawing.Size(64, 23);
            this.lbl_PressureOut.TabIndex = 5;
            this.lbl_PressureOut.Text = "0.0Bar";
            this.lbl_PressureOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TempOut2
            // 
            this.lbl_TempOut2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_TempOut2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_TempOut2.ForeColor = System.Drawing.Color.White;
            this.lbl_TempOut2.Location = new System.Drawing.Point(226, 134);
            this.lbl_TempOut2.Name = "lbl_TempOut2";
            this.lbl_TempOut2.Size = new System.Drawing.Size(64, 23);
            this.lbl_TempOut2.TabIndex = 5;
            this.lbl_TempOut2.Text = "0.0℃";
            this.lbl_TempOut2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TempIn2
            // 
            this.lbl_TempIn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_TempIn2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_TempIn2.ForeColor = System.Drawing.Color.White;
            this.lbl_TempIn2.Location = new System.Drawing.Point(53, 134);
            this.lbl_TempIn2.Name = "lbl_TempIn2";
            this.lbl_TempIn2.Size = new System.Drawing.Size(64, 23);
            this.lbl_TempIn2.TabIndex = 5;
            this.lbl_TempIn2.Text = "0.0℃";
            this.lbl_TempIn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meter_PressureOut
            // 
            this.meter_PressureOut.BodyColor = System.Drawing.Color.Lime;
            this.meter_PressureOut.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meter_PressureOut.Location = new System.Drawing.Point(358, 20);
            this.meter_PressureOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meter_PressureOut.MaxValue = 20D;
            this.meter_PressureOut.MinValue = 0D;
            this.meter_PressureOut.Name = "meter_PressureOut";
            this.meter_PressureOut.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.meter_PressureOut.Renderer = null;
            this.meter_PressureOut.ScaleColor = System.Drawing.Color.White;
            this.meter_PressureOut.ScaleDivisions = 10;
            this.meter_PressureOut.ScaleSubDivisions = 10;
            this.meter_PressureOut.Size = new System.Drawing.Size(150, 150);
            this.meter_PressureOut.TabIndex = 4;
            this.meter_PressureOut.Value = 0D;
            this.meter_PressureOut.ViewGlass = false;
            // 
            // meter_TempOut
            // 
            this.meter_TempOut.BodyColor = System.Drawing.Color.Lime;
            this.meter_TempOut.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meter_TempOut.Location = new System.Drawing.Point(186, 20);
            this.meter_TempOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meter_TempOut.MaxValue = 100D;
            this.meter_TempOut.MinValue = 0D;
            this.meter_TempOut.Name = "meter_TempOut";
            this.meter_TempOut.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.meter_TempOut.Renderer = null;
            this.meter_TempOut.ScaleColor = System.Drawing.Color.White;
            this.meter_TempOut.ScaleDivisions = 10;
            this.meter_TempOut.ScaleSubDivisions = 10;
            this.meter_TempOut.Size = new System.Drawing.Size(150, 150);
            this.meter_TempOut.TabIndex = 4;
            this.meter_TempOut.Value = 0D;
            this.meter_TempOut.ViewGlass = false;
            // 
            // meter_TempIn
            // 
            this.meter_TempIn.BodyColor = System.Drawing.Color.Blue;
            this.meter_TempIn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meter_TempIn.Location = new System.Drawing.Point(14, 20);
            this.meter_TempIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meter_TempIn.MaxValue = 100D;
            this.meter_TempIn.MinValue = 0D;
            this.meter_TempIn.Name = "meter_TempIn";
            this.meter_TempIn.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.meter_TempIn.Renderer = null;
            this.meter_TempIn.ScaleColor = System.Drawing.Color.White;
            this.meter_TempIn.ScaleDivisions = 10;
            this.meter_TempIn.ScaleSubDivisions = 10;
            this.meter_TempIn.Size = new System.Drawing.Size(150, 150);
            this.meter_TempIn.TabIndex = 4;
            this.meter_TempIn.Value = 0D;
            this.meter_TempIn.ViewGlass = false;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::thinger.HeatingControlProject.Properties.Resources.ParamPanel;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.led_SystemState);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.led_PLCState);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(12, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 130);
            this.panel4.TabIndex = 0;
            // 
            // led_SystemState
            // 
            this.led_SystemState.BorderWidth = 5;
            this.led_SystemState.CenterColor = System.Drawing.Color.White;
            this.led_SystemState.ColorList = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))};
            this.led_SystemState.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.led_SystemState.GapWidth = 5;
            this.led_SystemState.IsBlink = false;
            this.led_SystemState.IsBorder = true;
            this.led_SystemState.IsHighLight = true;
            this.led_SystemState.LedState = 0;
            this.led_SystemState.Location = new System.Drawing.Point(138, 73);
            this.led_SystemState.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.led_SystemState.Name = "led_SystemState";
            this.led_SystemState.Size = new System.Drawing.Size(34, 34);
            this.led_SystemState.TabIndex = 6;
            this.led_SystemState.TwinkleSpeed = 200;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "SCADA状态:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // led_PLCState
            // 
            this.led_PLCState.BorderWidth = 5;
            this.led_PLCState.CenterColor = System.Drawing.Color.White;
            this.led_PLCState.ColorList = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))};
            this.led_PLCState.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.led_PLCState.GapWidth = 5;
            this.led_PLCState.IsBlink = false;
            this.led_PLCState.IsBorder = true;
            this.led_PLCState.IsHighLight = true;
            this.led_PLCState.LedState = 0;
            this.led_PLCState.Location = new System.Drawing.Point(138, 31);
            this.led_PLCState.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.led_PLCState.Name = "led_PLCState";
            this.led_PLCState.Size = new System.Drawing.Size(34, 34);
            this.led_PLCState.TabIndex = 4;
            this.led_PLCState.TwinkleSpeed = 200;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "PLC连接状态:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(11, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "系统状态";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::thinger.HeatingControlProject.Properties.Resources.ParamPanel;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lbl_PressureIn);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.meter_PressureIn);
            this.panel3.Location = new System.Drawing.Point(12, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 247);
            this.panel3.TabIndex = 0;
            // 
            // lbl_PressureIn
            // 
            this.lbl_PressureIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_PressureIn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PressureIn.ForeColor = System.Drawing.Color.White;
            this.lbl_PressureIn.Location = new System.Drawing.Point(64, 185);
            this.lbl_PressureIn.Name = "lbl_PressureIn";
            this.lbl_PressureIn.Size = new System.Drawing.Size(87, 23);
            this.lbl_PressureIn.TabIndex = 3;
            this.lbl_PressureIn.Text = "0.00Bar";
            this.lbl_PressureIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(11, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "进水压力";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meter_PressureIn
            // 
            this.meter_PressureIn.BodyColor = System.Drawing.Color.Blue;
            this.meter_PressureIn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meter_PressureIn.Location = new System.Drawing.Point(13, 36);
            this.meter_PressureIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meter_PressureIn.MaxValue = 18D;
            this.meter_PressureIn.MinValue = 0D;
            this.meter_PressureIn.Name = "meter_PressureIn";
            this.meter_PressureIn.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.meter_PressureIn.Renderer = null;
            this.meter_PressureIn.ScaleColor = System.Drawing.Color.White;
            this.meter_PressureIn.ScaleDivisions = 10;
            this.meter_PressureIn.ScaleSubDivisions = 10;
            this.meter_PressureIn.Size = new System.Drawing.Size(202, 187);
            this.meter_PressureIn.TabIndex = 0;
            this.meter_PressureIn.Value = 0D;
            this.meter_PressureIn.ViewGlass = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::thinger.HeatingControlProject.Properties.Resources.Tank;
            this.pictureBox2.Location = new System.Drawing.Point(737, 297);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pump_CircleState
            // 
            this.pump_CircleState.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.pump_CircleState.Location = new System.Drawing.Point(580, 230);
            this.pump_CircleState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pump_CircleState.Name = "pump_CircleState";
            this.pump_CircleState.PumpState = 0;
            this.pump_CircleState.Size = new System.Drawing.Size(77, 125);
            this.pump_CircleState.TabIndex = 9;
            // 
            // ReadTimer
            // 
            this.ReadTimer.Interval = 300;
            this.ReadTimer.Tick += new System.EventHandler(this.ReadTimer_Tick);
            // 
            // ct_boiler
            // 
            this.ct_boiler.BoilerLevel = 0F;
            this.ct_boiler.BoilerState = false;
            this.ct_boiler.Location = new System.Drawing.Point(770, 6);
            this.ct_boiler.Name = "ct_boiler";
            this.ct_boiler.Size = new System.Drawing.Size(112, 246);
            this.ct_boiler.TabIndex = 5;
            // 
            // valve_OutState
            // 
            this.valve_OutState.IsOpen = false;
            this.valve_OutState.Location = new System.Drawing.Point(353, 260);
            this.valve_OutState.Name = "valve_OutState";
            this.valve_OutState.Size = new System.Drawing.Size(66, 95);
            this.valve_OutState.TabIndex = 10;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCADA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_UserManage;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button btn_ParamSet;
        private System.Windows.Forms.Label lblCurrentAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private CommonControlLib.thingerAnalogMeter meter_PressureIn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_PressureOut;
        private System.Windows.Forms.Label lbl_TempOut2;
        private System.Windows.Forms.Label lbl_TempIn2;
        private CommonControlLib.thingerAnalogMeter meter_PressureOut;
        private CommonControlLib.thingerAnalogMeter meter_TempOut;
        private CommonControlLib.thingerAnalogMeter meter_TempIn;
        private System.Windows.Forms.Panel panel4;
        private CommonControlLib.thingerLED led_SystemState;
        private System.Windows.Forms.Label label8;
        private CommonControlLib.thingerLED led_PLCState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_PressureIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl_TempBoiler;
        private CommonControlLib.thingerAnalogMeter meter_TempBoiler;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl_LevelTank;
        private CommonControlLib.thingerAnalogMeter meter_LevelTank;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl_PressuerBoiler2;
        private CommonControlLib.thingerAnalogMeter meter_PressureBoiler;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl_LevelBoiler;
        private CommonControlLib.thingerAnalogMeter meter_LevelBoiler;
        private HeatingCustomControls.ThingerHCBoiler ct_boiler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CommonControlLib.thingerToggleAdvance toggle_FeedPump;
        private CommonControlLib.thingerPumpBasic pump_FeedState;
        private CommonControlLib.thingerFlowControl thingerFlowControl2;
        private CommonControlLib.thingerFlowControl thingerFlowControl5;
        private CommonControlLib.thingerFlowControl thingerFlowControl4;
        private CommonControlLib.thingerFlowControl thingerFlowControl3;
        private CommonControlLib.thingerFlowControl thingerFlowControl1;
        private System.Windows.Forms.Panel panel6;
        private CommonControlLib.thingerToggleAdvance toggle_AirPump;
        private System.Windows.Forms.Label label25;
        private CommonControlLib.thingerToggleAdvance toggle_AddPump;
        private System.Windows.Forms.Label label24;
        private CommonControlLib.thingerPumpBasic pump_AirState;
        private CommonControlLib.thingerPumpBasic pump_AddState;
        private CommonControlLib.thingerFlowControl thingerFlowControl6;
        private CommonControlLib.thingerWave wave_LevelTank;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btn_SystemStop;
        private System.Windows.Forms.Button btn_SystemStart;
        private CommonControlLib.thingerFlowControl thingerFlowControl9;
        private CommonControlLib.thingerFlowControl thingerFlowControl7;
        private CommonControlLib.thingerFlowControl thingerFlowControl10;
        private CommonControlLib.thingerFlowControl thingerFlowControl8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CommonControlLib.thingerPump pump_CircleState;
        private System.Windows.Forms.Label lbl_TempOut;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lbl_PressuerBoiler;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lbl_TempIn;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CommonControlLib.thingerToggleAdvance toggle_CirclePump;
        private CommonControlLib.thingerFlowControl thingerFlowControl13;
        private CommonControlLib.thingerFlowControl thingerFlowControl12;
        private CommonControlLib.thingerFlowControl thingerFlowControl11;
        private HeatingCustomControls.ThingerHCValve valve_OutState;
        private System.Windows.Forms.Label lbl_ValveCtl;
        private System.Windows.Forms.Timer ReadTimer;
    }
}

