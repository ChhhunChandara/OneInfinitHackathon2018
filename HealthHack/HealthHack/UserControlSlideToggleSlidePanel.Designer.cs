namespace HealthHack
{
    partial class UserControlSlideToggleSlidePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(87, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 52);
            this.panel1.TabIndex = 0;
            // 
            // PanelContent
            // 
            this.PanelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelContent.Location = new System.Drawing.Point(87, 80);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(774, 279);
            this.PanelContent.TabIndex = 1;
            // 
            // UserControlSlideToggleSlidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlSlideToggleSlidePanel";
            this.Size = new System.Drawing.Size(1077, 411);
            this.Load += new System.EventHandler(this.UserControlSlideToggleSlidePanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelContent;
    }
}
