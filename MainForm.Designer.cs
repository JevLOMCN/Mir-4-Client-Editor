namespace Mir_4_Client_Editor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainMenu = new MenuStrip();
            ExportToolStripMenuItem = new ToolStripMenuItem();
            EditExportToolStripMenuItem = new ToolStripMenuItem();
            rePakToolStripMenuItem = new ToolStripMenuItem();
            MainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.Dock = DockStyle.None;
            MainMenu.Items.AddRange(new ToolStripItem[] { ExportToolStripMenuItem, EditExportToolStripMenuItem, rePakToolStripMenuItem });
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(188, 24);
            MainMenu.Stretch = false;
            MainMenu.TabIndex = 0;
            MainMenu.Text = "Main Menu";
            // 
            // ExportToolStripMenuItem
            // 
            ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            ExportToolStripMenuItem.Size = new Size(53, 20);
            ExportToolStripMenuItem.Text = "Export";
            ExportToolStripMenuItem.Click += ExportToolStripMenuItem_Click;
            // 
            // EditExportToolStripMenuItem
            // 
            EditExportToolStripMenuItem.Name = "EditExportToolStripMenuItem";
            EditExportToolStripMenuItem.Size = new Size(76, 20);
            EditExportToolStripMenuItem.Text = "Edit Export";
            EditExportToolStripMenuItem.Click += EditExportToolStripMenuItem_Click;
            // 
            // rePakToolStripMenuItem
            // 
            rePakToolStripMenuItem.Name = "rePakToolStripMenuItem";
            rePakToolStripMenuItem.Size = new Size(51, 20);
            rePakToolStripMenuItem.Text = "RePak";
            rePakToolStripMenuItem.Click += rePakToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 373);
            Controls.Add(MainMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MainMenu;
            Name = "MainForm";
            Text = "Mir 4 Client Editor";
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenu;
        private ToolStripMenuItem ExportToolStripMenuItem;
        private ToolStripMenuItem EditExportToolStripMenuItem;
        private ToolStripMenuItem rePakToolStripMenuItem;
    }
}
