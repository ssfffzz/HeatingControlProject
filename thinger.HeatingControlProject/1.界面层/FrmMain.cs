using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using thinger.CommonControlLib;
using thinger.DataConvertLib;

namespace thinger.HeatingControlProject
{
    public partial class FrmMain : Form
    {
        #region 无边框拖动 
        private Point mPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion

        #region 窗体关闭提示
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否关闭窗体", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        #endregion

        public FrmMain()
        {
            InitializeComponent();
            this.lblCurrentAdmin.Text = Program.currentAdmin.LoginName;
        }


        private PLCDataService pLCDataService = new PLCDataService();
        Plc plc = null;
        private void btn_SystemStart_Click(object sender, EventArgs e)
        {
            try
            {
                pLCDataService.Connect(this.plcInfo);
                this.led_PLCState.LedState = 1;

                this.btn_SystemStart.Enabled = false;
                this.btn_SystemStop.Enabled = true;
                this.ReadTimer.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("系统启动失败！原因：" + ex.Message);
            }
        }

        private void btn_SystemStop_Click(object sender, EventArgs e)
        {
            ReadTimer.Stop();
            pLCDataService.DisConnect();
            this.led_PLCState.LedState = 0;

            this.btn_SystemStart.Enabled = true;
            this.btn_SystemStop.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.plcInfo = infoService.GetPlcInfoByPath(path);
                if (plcInfo == null)
                {
                    MessageBox.Show("请配置ini文件", "操作配置");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取配置文件失败" + ex.Message, "读取配置");
            }
        }

        private PlcInfo plcInfo = new PlcInfo();
        private PlcInfoService infoService = new PlcInfoService();
        private string path = Application.StartupPath + "//PLCInfo.ini";


        private void btn_ParamSet_Click(object sender, EventArgs e)
        {
            FrmParamSet frm = new FrmParamSet(plcInfo, path);
            frm.ShowDialog();
        }

        #region 更新界面实时参数
        public void UpdataUI(PLCData pLCData)
        {
            //各种泵和阀门状态
            this.pump_FeedState.IsRun = pLCData.FeedPumpState;//进水泵状态
            this.pump_AddState.IsRun = pLCData.AddPumpState;//加水泵状态
            this.pump_AirState.IsRun = pLCData.AirPumpState;//燃气泵状态
            this.pump_CircleState.PumpState = pLCData.CirclePumpState ? 1 : 0;//循环泵状态
            this.valve_OutState.IsOpen = pLCData.OutValveState;//出水阀状态
            if (pLCData.OutValveState)
            {
                this.lbl_ValveCtl.Text = "已打开";
                this.lbl_ValveCtl.BackColor = Color.DeepPink;
            }
            else
            {
                this.lbl_ValveCtl.Text = "已关闭";
                this.lbl_ValveCtl.BackColor = Color.OrangeRed;
            }
            this.led_SystemState.LedState = pLCData.SystemState ? 1 : 0;//系统状态
            //数据显示
            this.lbl_PressureIn.Text = pLCData.PressureIn.ToString("F1");//进水压力
            this.lbl_PressureOut.Text = pLCData.PressureOut.ToString("F1");//出水压力
            this.lbl_TempIn.Text = pLCData.TempIn.ToString("F1");//进水温度
            this.lbl_TempOut.Text = pLCData.TempOut.ToString("F1");//出水温度
            this.lbl_TempIn2.Text = pLCData.TempIn.ToString("F1");//进水温度2
            this.lbl_TempOut2.Text = pLCData.TempOut.ToString("F1");//出水温度2
            this.lbl_PressuerBoiler.Text = pLCData.PressureBoiler.ToString("F1");//锅炉压力
            this.lbl_PressuerBoiler2.Text = pLCData.PressureBoiler.ToString("F1");//锅炉压力2
            this.lbl_LevelBoiler.Text = pLCData.LevelBoiler.ToString("F1");//锅炉液位
            this.lbl_TempBoiler.Text = pLCData.TempBoiler.ToString("F1");//锅炉温度
            this.lbl_LevelTank.Text = pLCData.LevelTank.ToString("F1");//水罐液位
            //仪表显示
            this.meter_PressureIn.Value = pLCData.PressureIn;//进水压力
            this.meter_PressureOut.Value = pLCData.PressureOut;//出水压力
            this.meter_TempIn.Value = pLCData.TempIn;//进水温度
            this.meter_TempOut.Value = pLCData.TempOut;//出水温度      
            this.meter_PressureBoiler.Value = pLCData.PressureBoiler;//锅炉压力
            this.meter_LevelBoiler.Value = pLCData.LevelBoiler;//锅炉液位
            this.meter_TempBoiler.Value = pLCData.TempBoiler;//锅炉温度
            this.meter_LevelTank.Value = pLCData.LevelTank;//水罐液位
            //液位显示
            this.ct_boiler.BoilerLevel = pLCData.LevelBoiler;
            this.wave_LevelTank.Value = (int)pLCData.LevelTank;

        }
        #endregion

        private DateTime lastTime = DateTime.Now;
        private SqlDataService sqlDataService = new SqlDataService();

        private void ReadTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                PLCData pLCData = pLCDataService.GetPlcData();
                UpdataUI(pLCData);
                //计算一下时间间隔
                int timeSpan = DateTime.Now.Second - lastTime.Second;
                if (timeSpan== 1 || timeSpan == -59)
                {
                    sqlDataService.AddPlcData(pLCData);//保存到数据库
                }
                lastTime = DateTime.Now;//更新上一次记录时间

            }
            catch (Exception ex)
            {
                ReadTimer.Stop();
                MessageBox.Show("读取数据中断" + ex.Message);
            }
        }

        #region 水泵和阀门控制
        /// <summary>
        /// 进水泵控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toggle_FeedPump_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pLCDataService.FeedPumpControl(this.toggle_FeedPump.Checked);
            }
            catch (Exception ex)
            {
                //取消事件关联，用CheckedChanged的方法
                this.toggle_FeedPump.CheckedChanged -= toggle_FeedPump_CheckedChanged;
                //恢复按钮的初始状态
                this.toggle_FeedPump.Checked = !this.toggle_FeedPump.Checked;
                //再次关联事件
                this.toggle_FeedPump.CheckedChanged += toggle_FeedPump_CheckedChanged;
                MessageBox.Show("进水泵控制失败" + ex.Message, "错误提示");
            }
        }
        /// <summary>
        /// 加水泵控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toggle_AddPump_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pLCDataService.AddPumpControl(this.toggle_AddPump.Checked);
            }
            catch (Exception ex)
            {
                //取消事件关联，用CheckedChanged的方法
                this.toggle_AddPump.CheckedChanged -= toggle_AddPump_CheckedChanged;
                //恢复按钮的初始状态
                this.toggle_AddPump.Checked = !this.toggle_AddPump.Checked;
                //再次关联事件
                this.toggle_AddPump.CheckedChanged += toggle_AddPump_CheckedChanged;
                MessageBox.Show("加水泵控制失败" + ex.Message, "错误提示");
            }
        }
        /// <summary>
        /// 燃气泵控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toggle_AirPump_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pLCDataService.AirPumpControl(this.toggle_AirPump.Checked);
            }
            catch (Exception ex)
            {
                //取消事件关联，用CheckedChanged的方法
                this.toggle_AirPump.CheckedChanged -= toggle_AirPump_CheckedChanged;
                //恢复按钮的初始状态
                this.toggle_AirPump.Checked = !this.toggle_AirPump.Checked;
                //再次关联事件
                this.toggle_AirPump.CheckedChanged += toggle_AirPump_CheckedChanged;
                MessageBox.Show("燃气泵控制失败" + ex.Message, "错误提示");
            }
        }
        /// <summary>
        /// 循环泵控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toggle_CirclePump_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pLCDataService.CirclePumpControl(this.toggle_CirclePump.Checked);
            }
            catch (Exception ex)
            {
                //取消事件关联，用CheckedChanged的方法
                this.toggle_CirclePump.CheckedChanged -= toggle_CirclePump_CheckedChanged;
                //恢复按钮的初始状态
                this.toggle_CirclePump.Checked = !this.toggle_CirclePump.Checked;
                //再次关联事件
                this.toggle_CirclePump.CheckedChanged += toggle_CirclePump_CheckedChanged;
                MessageBox.Show("循环泵控制失败" + ex.Message, "错误提示");
            }
        }

        private void lbl_ValveCtl_DoubleClick(object sender, EventArgs e)
        {
            string msg = this.lbl_ValveCtl.Text == "已关闭" ? "打开" : "关闭";
            DialogResult result = MessageBox.Show("确定要【" + msg + "】出水阀吗", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    bool msg1 = this.lbl_ValveCtl.Text == "已关闭" ? true : false;
                    pLCDataService.OutValveControl(msg1);
                    if (this.lbl_ValveCtl.Text == "已关闭")
                    {
                        this.lbl_ValveCtl.Text = "已打开";
                        this.lbl_ValveCtl.BackColor = Color.DeepPink;
                    }
                    else
                    {
                        this.lbl_ValveCtl.Text = "已关闭";
                        this.lbl_ValveCtl.BackColor = Color.OrangeRed;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打开出水阀失败"+ex.Message);
                }
               
            }
          
        }
        #endregion

        private void btn_UserManage_Click(object sender, EventArgs e)
        {
            FrmUserManage frmUserManage = new FrmUserManage();
            frmUserManage.ShowDialog();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            FrmHistoryQuery frmHistoryQuery = new FrmHistoryQuery();
            frmHistoryQuery.ShowDialog();
        }
    }
}

