namespace GUI
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paluse = new System.Windows.Forms.Panel();
            this.panmenu = new System.Windows.Forms.Panel();
            //this.fl_help = new GUI.ComponentForm.Flat_Button();
            //this.flat_thoat = new GUI.ComponentForm.Flat_Button();
            //this.flat_sach = new GUI.ComponentForm.Flat_Button();
            //this.flat_thongke = new GUI.ComponentForm.Flat_Button();
            //this.flat_timkiem = new GUI.ComponentForm.Flat_Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.panmenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paluse
            // 
            this.paluse.Location = new System.Drawing.Point(207, 1);
            this.paluse.Name = "paluse";
            this.paluse.Size = new System.Drawing.Size(817, 503);
            this.paluse.TabIndex = 1;
            // 
            // panmenu
            // 
            this.panmenu.BackgroundImage = global::GUI.Properties.Resources.menu_clipart_dT8orjETe;
            this.panmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //this.panmenu.Controls.Add(this.fl_help);
            //this.panmenu.Controls.Add(this.flat_thoat);
            //this.panmenu.Controls.Add(this.flat_sach);
            //this.panmenu.Controls.Add(this.flat_thongke);
            //this.panmenu.Controls.Add(this.flat_timkiem);
            this.panmenu.Controls.Add(this.menuStrip1);
            this.panmenu.Location = new System.Drawing.Point(1, 1);
            this.panmenu.Name = "panmenu";
            this.panmenu.Size = new System.Drawing.Size(207, 518);
            this.panmenu.TabIndex = 0;
            this.panmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panmenu_Paint);
            this.panmenu.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panmenu_PreviewKeyDown);
            // 
            // fl_help
            // 
           
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(207, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // help
            // 
            this.help.Name = "help";
            this.help.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.help.Size = new System.Drawing.Size(44, 20);
            this.help.Text = "Help";
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 517);
            this.Controls.Add(this.paluse);
            this.Controls.Add(this.panmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panmenu.ResumeLayout(false);
            this.panmenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panmenu;
        private System.Windows.Forms.Panel paluse;
        //private ComponentForm.Flat_Button flat_sach;
        //private ComponentForm.Flat_Button flat_thongke;
        //private ComponentForm.Flat_Button flat_timkiem;
        //private ComponentForm.Flat_Button flat_thoat;
        //private ComponentForm.Flat_Button fl_help;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem help;
    }
}