using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace HealthHack
{
    public partial class UserControlSlideToggleSlidePanel : UserControl
    {
        public UserControlSlideToggleSlidePanel()
        {
            InitializeComponent();
        }

        private void UserControlSlideToggleSlidePanel_Load(object sender, EventArgs e)
        {
            
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;


            
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            PanelContent.Height -= 5;
        }
    }
}
