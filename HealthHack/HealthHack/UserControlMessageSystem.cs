using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthHack
{
    public partial class UserControlMessageSystem : UserControl
    {
        public string Message = "";
        public UserControlMessageSystem()
        {
            InitializeComponent();
        }

        private void UserControlMessage_Load(object sender, EventArgs e)
        {
            int morestr = Message.Length - 25;
            if (morestr > 0)
            {
                morestr = morestr / 25;
                LableMessage.Height = LableMessage.Height + (morestr * 30);
                this.Height = this.Height + (morestr * 30);
            }
            LableMessage.Text = Message;

        }
    }
}
