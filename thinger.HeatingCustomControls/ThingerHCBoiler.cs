using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thinger.HeatingCustomControls
{
    public partial class ThingerHCBoiler : UserControl
    {
        public ThingerHCBoiler()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 锅炉状态
        /// </summary>
        private bool boilerState;
        [Category("自定义属性"), Description("获取或设置锅炉的状态")]
        public bool BoilerState
        {
            get { return boilerState; }
            set
            {
                if (boilerState != value)
                {
                    boilerState = value;
                    this.pic_Boiler.Image = value ? Properties.Resources.锅炉Run : Properties.Resources.锅炉Stop;
                }
            }
        }
        /// <summary>
        /// 锅炉液位
        /// </summary>
        private float boilerLevel = 0.0f;
        [Category("自定义属性"), Description("获取或设置锅炉的液位")]
        public float BoilerLevel
        {
            get { return boilerLevel; }
            set
            {
                if (boilerLevel != value)
                {
                    boilerLevel = value;
                    this.thingerWave1.Value = Convert.ToInt32(value);
                }

            }
        }
    }
}
