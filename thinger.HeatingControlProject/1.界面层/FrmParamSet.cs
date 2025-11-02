using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thinger.HeatingControlProject
{
    public partial class FrmParamSet : Form
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

        private string path = string.Empty;
        private PlcInfo plcInfo = null;
        private PlcInfoService infoService = new PlcInfoService();
        public FrmParamSet(PlcInfo plcInfo, string path)
        {
            InitializeComponent();//这行代码一定要写在最前面

            this.cmb_CPUType.DataSource = Enum.GetNames(typeof(CpuType));
            this.plcInfo = plcInfo;
            this.path = path;
            if (plcInfo != null)
            {
                this.txt_IPAddress.Text = this.plcInfo.IPAdress;
                this.cmb_CPUType.Text = this.plcInfo.CpuType.ToString();
                this.txt_Rack.Text = this.plcInfo.Rack.ToString();
                this.txt_Slot.Text = this.plcInfo.Slot.ToString();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (plcInfo == null)
            {
                plcInfo = new PlcInfo();
            }
            this.plcInfo.IPAdress = this.txt_IPAddress.Text;
            this.plcInfo.CpuType = (CpuType)Enum.Parse(typeof(CpuType), this.cmb_CPUType.Text);
            this.plcInfo.Rack = Convert.ToInt16(this.txt_Rack.Text);
            this.plcInfo.Slot = Convert.ToInt16(this.txt_Slot.Text);
            try
            {
                infoService.SetPlcInfoToPath(plcInfo, path);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("PLC参数写入成功", "保存提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PLC参数写入失败" + ex.Message, "错误提示");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
