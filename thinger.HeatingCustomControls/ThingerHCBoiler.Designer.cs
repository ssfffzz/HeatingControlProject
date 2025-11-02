namespace thinger.HeatingCustomControls
{
    partial class ThingerHCBoiler
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
            this.pic_Boiler = new System.Windows.Forms.PictureBox();
            this.thingerWave1 = new thinger.CommonControlLib.thingerWave();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Boiler)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Boiler
            // 
            this.pic_Boiler.BackgroundImage = global::thinger.HeatingCustomControls.Properties.Resources.锅炉Stop;
            this.pic_Boiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Boiler.Location = new System.Drawing.Point(0, 0);
            this.pic_Boiler.Name = "pic_Boiler";
            this.pic_Boiler.Size = new System.Drawing.Size(112, 246);
            this.pic_Boiler.TabIndex = 0;
            this.pic_Boiler.TabStop = false;
            // 
            // thingerWave1
            // 
            this.thingerWave1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.thingerWave1.ConerRadius = 10;
            this.thingerWave1.FillColor = System.Drawing.Color.Transparent;
            this.thingerWave1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thingerWave1.ForeColor = System.Drawing.Color.White;
            this.thingerWave1.IsRadius = true;
            this.thingerWave1.IsRectangle = true;
            this.thingerWave1.IsShowRect = false;
            this.thingerWave1.Location = new System.Drawing.Point(23, 82);
            this.thingerWave1.MaxValue = 100;
            this.thingerWave1.Name = "thingerWave1";
            this.thingerWave1.RectColor = System.Drawing.Color.White;
            this.thingerWave1.RectWidth = 4;
            this.thingerWave1.Size = new System.Drawing.Size(67, 128);
            this.thingerWave1.TabIndex = 1;
            this.thingerWave1.Value = 0;
            this.thingerWave1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "水位计";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThingerHCBoiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thingerWave1);
            this.Controls.Add(this.pic_Boiler);
            this.Name = "ThingerHCBoiler";
            this.Size = new System.Drawing.Size(112, 246);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Boiler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Boiler;
        private CommonControlLib.thingerWave thingerWave1;
        private System.Windows.Forms.Label label1;
    }
}
