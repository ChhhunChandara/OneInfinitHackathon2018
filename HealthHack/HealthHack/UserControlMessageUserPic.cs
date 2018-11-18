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
    public partial class UserControlMessageUserPic : UserControl
    {
        public string Path = "";
        
        public UserControlMessageUserPic()
        {
            InitializeComponent();
        }

        private void UserControlMessageUserPic_Load(object sender, EventArgs e)
        {
            PicUser.BackgroundImageLayout = ImageLayout.Zoom;
            PicUser.BackgroundImage = Image.FromFile(Path);
            
        }
    }
}
