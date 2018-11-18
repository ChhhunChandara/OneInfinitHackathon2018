using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthHack
{
    public partial class FormHome : Form
    {
        int MessageOrder = 0;
        string profile_path = "";
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControlMessageSystem userControlMessageSystem = new UserControlMessageSystem();
            userControlMessageSystem.Message = Resource.SystemMessage[MessageOrder];
            MessageOrder++;
            PanelRegisterChatPanel.Controls.Add(userControlMessageSystem);
        }

        private void PanelRegisterTxtChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanelRegisterTxtChat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                UserControlMessageUser userControlMessageUser = new UserControlMessageUser();
                userControlMessageUser.Message = PanelRegisterTxtChat.Text;
                userControlMessageUser.PicProfile = profile_path;

                int ptop = 0;
                foreach(Control con in PanelRegisterChatPanel.Controls)
                {
                    if(con.Top + con.Height > ptop)
                    {
                        ptop = con.Top + con.Height;
                    }
                }
                userControlMessageUser.Top = ptop;
                PanelRegisterChatPanel.Controls.Add(userControlMessageUser);

                if (MessageOrder == Resource.SystemMessage.Count())
                {
                    PanelBMI.BringToFront();
                    
                }
                else
                {
                    UserControlMessageSystem userControlMessageSystem = new UserControlMessageSystem();
                    userControlMessageSystem.Message = Resource.SystemMessage[MessageOrder];
                    userControlMessageSystem.Top = ptop + userControlMessageUser.Height;
                    PanelRegisterChatPanel.Controls.Add(userControlMessageSystem);
                    MessageOrder++;
                    PanelRegisterTxtChat.Text = "";
                    PanelRegisterChatPanel.VerticalScroll.Maximum = 100;
                }

                
            }
        }

        private void FormHome_Load_1(object sender, EventArgs e)
        {
            PanelSettingGoalEatingWell01.Enabled = false;
            PanelSettingGoalEatingWell02.Enabled = false;
            PanelSettingGoalEatingWell03.Enabled = false;
            PanelSettingGoalFirmBody01.Enabled = false;
            PanelSettingGoalFirmBody02.Enabled = false;
            PanelSettingGoalFirmBody03.Enabled = false;
        }

        private void PanelRegisterAttachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an image file.";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                UserControlMessageUserPic userControlUserMessagePic = new UserControlMessageUserPic();
                userControlUserMessagePic.Path = dialog.FileName;

                int ptop = 0;
                foreach (Control con in PanelRegisterChatPanel.Controls)
                {
                    if (con.Top + con.Height > ptop)
                    {
                        ptop = con.Top + con.Height;
                    }
                }
                userControlUserMessagePic.Top = ptop;
                PanelRegisterChatPanel.Controls.Add(userControlUserMessagePic);
                profile_path = dialog.FileName;
                PanelRegisterTxtChat.Text = "";

                UserControlMessageSystem userControlMessageSystem = new UserControlMessageSystem();
                userControlMessageSystem.Message = Resource.SystemMessage[MessageOrder];
                userControlMessageSystem.Top = ptop + userControlUserMessagePic.Height;
                PanelRegisterChatPanel.Controls.Add(userControlMessageSystem);
                MessageOrder++;

                if (MessageOrder == Resource.SystemMessage.Count())
                {
                    PanelBMI.BringToFront();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserControlMessageSystem userControlMessageSystem = new UserControlMessageSystem();
            userControlMessageSystem.Message = Resource.SystemMessage[MessageOrder];
            MessageOrder++;
            PanelRegisterChatPanel.Controls.Add(userControlMessageSystem);
            PanelRegister.BringToFront();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (PanelSettingGoalFirmBody.Checked)
            {
                PanelSettingGoalFirmBody01.Enabled = true;
                PanelSettingGoalFirmBody02.Enabled = true;
                PanelSettingGoalFirmBody03.Enabled = true;
                comboBox1.Enabled = true;
            }
            else
            {
                PanelSettingGoalFirmBody01.Enabled = false;
                PanelSettingGoalFirmBody02.Enabled = false;
                PanelSettingGoalFirmBody03.Enabled = false;
                comboBox1.Enabled = false;

                PanelSettingGoalFirmBody01.Checked = false;
                PanelSettingGoalFirmBody02.Checked = false;
                PanelSettingGoalFirmBody03.Checked = false;
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanelSettingGoalEatingWell_CheckedChanged(object sender, EventArgs e)
        {
            if (PanelSettingGoalEatingWell.Checked)
            {
                PanelSettingGoalEatingWell01.Enabled = true;
                PanelSettingGoalEatingWell02.Enabled = true;
                PanelSettingGoalEatingWell03.Enabled = true;
                comboBox1.Enabled = false;
            }
            else
            {
                PanelSettingGoalEatingWell01.Enabled = false;
                PanelSettingGoalEatingWell02.Enabled = false;
                PanelSettingGoalEatingWell03.Enabled = false;

                PanelSettingGoalEatingWell01.Checked = false;
                PanelSettingGoalEatingWell02.Checked = false;
                PanelSettingGoalEatingWell03.Checked = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelBMIBody_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelKnownleadgeBtnPersonal_Click(object sender, EventArgs e)
        {
            PanelKnownleadgePanelPersonal.BringToFront();
            PanelKnownleadgeIndicator.Left =PanelKnownleadgeBtnPersonal.Left;
        }

        private void PanelKnownleadgeBtnArticle_Click(object sender, EventArgs e)
        {
            PanelKnownleadgePanelFullStory.BringToFront();
            PanelKnownleadgeIndicator.Left = PanelKnownleadgeBtnArticle.Left;

        }

        private void PanelPeerBtnFriend_Click(object sender, EventArgs e)
        {
            PanelPeerPanelFriend.BringToFront();
            PanelPeerIndicator.Left = PanelPeerBtnFriend.Left;

        }

        private void PanelPeerBtnGlobal_Click(object sender, EventArgs e)
        {
            PanelPeerPanelGlobal.BringToFront();
            PanelPeerIndicator.Left = PanelPeerBtnGlobal.Left;
        }

        private void PanelPeerPanelGlobal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.aia.com.kh");
        }

        private void PanelHomeBtnHome_Click(object sender, EventArgs e)
        {
            PanelHome.BringToFront();

        }

        private void PanelHomeBtnKnowleadge_Click(object sender, EventArgs e)
        {
            PanelKnownleadge.BringToFront();
        }

        private void PanelHomeBtnPeer_Click(object sender, EventArgs e)
        {
            PanelPeer.BringToFront();
        }

        private void PanelHomeBtnPlace_Click(object sender, EventArgs e)
        {
            PanelPlace.BringToFront();
        }

        private void PanelHomeBtnNotification_Click(object sender, EventArgs e)
        {
            PanelNotification.BringToFront();
        }

        private void PanelKnowleadgeBntKnowleadge_Click(object sender, EventArgs e)
        {
            PanelKnownleadge.BringToFront();
        }

        private void PanelKnowleadgeBtnPeer_Click(object sender, EventArgs e)
        {
            PanelPeer.BringToFront();
        }

        private void PanelKnowleadgeBtnHome_Click(object sender, EventArgs e)
        {
            PanelHome.BringToFront();
        }

        private void PanelKnowleadgeBtnPlace_Click(object sender, EventArgs e)
        {
            PanelPlace.BringToFront();
        }

        private void PanelKnowleadgeBtnNotification_Click(object sender, EventArgs e)
        {
            PanelNotification.BringToFront();
        }

        private void PanelPeerBntKnowleadge_Click(object sender, EventArgs e)
        {
            PanelKnownleadge.BringToFront();
        }

        private void PanelPeerBtnPeer_Click(object sender, EventArgs e)
        {
            PanelPeer.BringToFront();
        }

        private void PanelPeereBtnHome_Click(object sender, EventArgs e)
        {
            PanelHome.BringToFront();
        }

        private void PanelPeerBtnPlace_Click(object sender, EventArgs e)
        {
            PanelPlace.BringToFront();
        }

        private void PanelPeerBtnNotification_Click(object sender, EventArgs e)
        {
            PanelNotification.BringToFront();
        }

        private void PanelPlaceBntKnowleadge_Click(object sender, EventArgs e)
        {
            PanelKnownleadge.BringToFront();
        }

        private void PanelPlaceBtnPeer_Click(object sender, EventArgs e)
        {
            PanelPeer.BringToFront();
        }

        private void PanelPlaceBtnHome_Click(object sender, EventArgs e)
        {
            PanelHome.BringToFront();
        }

        private void PanelPlacePlace_Click(object sender, EventArgs e)
        {
            PanelPlace.BringToFront();
        }

        private void PanelPlaceBtnNotification_Click(object sender, EventArgs e)
        {
            PanelNotification.BringToFront();
        }

        private void PanelNotificationBntKnowleadge_Click(object sender, EventArgs e)
        {
            PanelKnownleadge.BringToFront();
        }

        private void PanelNotificationBtnPeer_Click(object sender, EventArgs e)
        {
            PanelPeer.BringToFront();
        }

        private void PanelNotificationBtnHome_Click(object sender, EventArgs e)
        {
            PanelHome.BringToFront();
        }

        private void PanelNotificationPlace_Click(object sender, EventArgs e)
        {
            PanelPlace.BringToFront();
        }

        private void PanelNotificationBtnNotification_Click(object sender, EventArgs e)
        {
            PanelNotification.BringToFront();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            PanelHome.BringToFront();
        }

        private void PanelHomeDetail_Click(object sender, EventArgs e)
        {
            PanelHomeDetail01.BringToFront();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.aia.com.kh");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void PanelBMIBtnOK_Click(object sender, EventArgs e)
        {
            PanelSettingGoal.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelHome.BringToFront();
        }

        private void PanelRegisterMic_Click(object sender, EventArgs e)
        {
            if (PanelRegisterMic.BackColor == Color.Green)
            {
                PanelRegisterMic.BackColor = Color.FromArgb(238, 28, 36);
                PanelRegisterTxtChat.Text = Resource.SystemMessageAnswer[MessageOrder - 1];
                UserControlMessageUser userControlMessageUser = new UserControlMessageUser();
                userControlMessageUser.Message = PanelRegisterTxtChat.Text;
                userControlMessageUser.PicProfile = profile_path;

                int ptop = 0;
                foreach (Control con in PanelRegisterChatPanel.Controls)
                {
                    if (con.Top + con.Height > ptop)
                    {
                        ptop = con.Top + con.Height;
                    }
                }
                userControlMessageUser.Top = ptop;
                PanelRegisterChatPanel.Controls.Add(userControlMessageUser);

                UserControlMessageSystem userControlMessageSystem = new UserControlMessageSystem();
                userControlMessageSystem.Message = Resource.SystemMessage[MessageOrder];
                userControlMessageSystem.Top = ptop + userControlMessageUser.Height;
                PanelRegisterChatPanel.Controls.Add(userControlMessageSystem);
                MessageOrder++;
                PanelRegisterTxtChat.Text = "";
                PanelRegisterChatPanel.VerticalScroll.Maximum = 100;

                if (MessageOrder == Resource.SystemMessage.Count())
                {
                    PanelBMI.BringToFront();
                }
            }
            else{

                PanelRegisterMic.BackColor = Color.Green;
            }
            
        }

        private void PanelRegisterChatPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelRegisterChatPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            PanelRegisterChatPanel.ScrollControlIntoView(e.Control);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            PanelGetStarted.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PanelRegister.BringToFront();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PanelBMI.BringToFront();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            PanelNotification.BringToFront();
        }
    }
}
