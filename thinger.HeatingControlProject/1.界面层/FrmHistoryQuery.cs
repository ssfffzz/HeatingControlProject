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
    public partial class FrmHistoryQuery : Form
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

        public FrmHistoryQuery()
        {
            InitializeComponent();
            //禁止自动生成列
            this.dgv_DataList.AutoGenerateColumns = false;
            //初始化时间控件
            this.dpt_Start.Value = DateTime.Now.AddHours(-2.0);
            this.dpt_Stop.Value = DateTime.Now;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewHelper.DgvRowPostPaint(dgv_DataList, e);  //显示行号
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHistoryQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否关闭历史查询窗口", "关闭提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private SqlDataService sqlDataService = new SqlDataService();

        //查询数据
        private void btn_Query_Click(object sender, EventArgs e)
        {
            //判断一下选择的开始和结束时间
            TimeSpan timeSpan = this.dpt_Stop.Value - this.dpt_Start.Value;
            if (timeSpan.TotalSeconds < 0)
            {
                MessageBox.Show("选择的时间错误，请重新选择", "错误提示");
                return;
            }
            try
            {
                DataSet ds = sqlDataService.GetActualDataByTime(this.dpt_Start.Value, this.dpt_Stop.Value);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    this.dgv_DataList.DataSource = null;

                    this.dgv_DataList.DataSource = ds.Tables[0];
                }
                else
                    MessageBox.Show("在这个时间段内没有查询导数据", "查询提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据查询错误，原因" + ex.Message, "错误提示");
            }

        }






        //dataGridView控件设置步骤
        //界面设置1.设置背景颜色2.设置页眉文本3.去掉对钩4.编辑列设置列宽5.视觉样式enableheadervisual改为false  6.girdcolor 边框颜色
        //
        //
        //
        //
        //
        //
        //

    }
}
