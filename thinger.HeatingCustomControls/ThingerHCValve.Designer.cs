namespace thinger.HeatingCustomControls
{
    partial class ThingerHCValve
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_Valve = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Valve)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Valve
            // 
            this.pic_Valve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Valve.Image = global::thinger.HeatingCustomControls.Properties.Resources.阀门Close;
            this.pic_Valve.Location = new System.Drawing.Point(0, 0);
            this.pic_Valve.Name = "pic_Valve";
            this.pic_Valve.Size = new System.Drawing.Size(209, 299);
            this.pic_Valve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Valve.TabIndex = 0;
            this.pic_Valve.TabStop = false;
            // 
            // ThingerHCValve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_Valve);
            this.Name = "ThingerHCValve";
            this.Size = new System.Drawing.Size(209, 299);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Valve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Valve;
    }
}
