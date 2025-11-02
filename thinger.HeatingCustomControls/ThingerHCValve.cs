using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thinger.HeatingCustomControls
{
    public partial class ThingerHCValve : UserControl
    {
        public ThingerHCValve()
        {
            InitializeComponent();
        }

        private bool isOpen = false;
        [Category("自定义属性"),Description("获取或设置阀门的状态值")]
        public bool IsOpen
        {
            get { return isOpen; }
            set
            {
                if (isOpen != value)
                {
                    isOpen = value;
                    if (isOpen)
                    {
                        this.pic_Valve.Image = Properties.Resources.阀门Open;
                    }
                    else
                    {
                        this.pic_Valve.Image = Properties.Resources.阀门Close;
                    }
                }

            }




        }


    }
}

