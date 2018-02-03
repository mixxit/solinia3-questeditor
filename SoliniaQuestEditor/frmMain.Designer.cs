namespace SoliniaQuestEditor
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWorldFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createQuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchQuestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questVIsualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchNPCsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchItemsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1333, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadWorldFolderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadWorldFolderToolStripMenuItem
            // 
            this.loadWorldFolderToolStripMenuItem.Name = "loadWorldFolderToolStripMenuItem";
            this.loadWorldFolderToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.loadWorldFolderToolStripMenuItem.Text = "Load World Folder";
            this.loadWorldFolderToolStripMenuItem.Click += new System.EventHandler(this.loadWorldFolderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editorsToolStripMenuItem
            // 
            this.editorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemEditorToolStripMenuItem,
            this.questToolStripMenuItem,
            this.nPCToolStripMenuItem,
            this.spellToolStripMenuItem});
            this.editorsToolStripMenuItem.Name = "editorsToolStripMenuItem";
            this.editorsToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.editorsToolStripMenuItem.Text = "Editors";
            // 
            // itemEditorToolStripMenuItem
            // 
            this.itemEditorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createItemToolStripMenuItem,
            this.searchItemsToolStripMenuItem});
            this.itemEditorToolStripMenuItem.Name = "itemEditorToolStripMenuItem";
            this.itemEditorToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.itemEditorToolStripMenuItem.Text = "Item";
            // 
            // createItemToolStripMenuItem
            // 
            this.createItemToolStripMenuItem.Name = "createItemToolStripMenuItem";
            this.createItemToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.createItemToolStripMenuItem.Text = "Create Item";
            this.createItemToolStripMenuItem.Click += new System.EventHandler(this.createItemToolStripMenuItem_Click);
            // 
            // searchItemsToolStripMenuItem
            // 
            this.searchItemsToolStripMenuItem.Name = "searchItemsToolStripMenuItem";
            this.searchItemsToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.searchItemsToolStripMenuItem.Text = "Search Items";
            this.searchItemsToolStripMenuItem.Click += new System.EventHandler(this.searchItemsToolStripMenuItem_Click);
            // 
            // questToolStripMenuItem
            // 
            this.questToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createQuestToolStripMenuItem,
            this.searchQuestsToolStripMenuItem,
            this.questVIsualiserToolStripMenuItem});
            this.questToolStripMenuItem.Name = "questToolStripMenuItem";
            this.questToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.questToolStripMenuItem.Text = "Quest";
            // 
            // createQuestToolStripMenuItem
            // 
            this.createQuestToolStripMenuItem.Name = "createQuestToolStripMenuItem";
            this.createQuestToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.createQuestToolStripMenuItem.Text = "Create Quest";
            this.createQuestToolStripMenuItem.Click += new System.EventHandler(this.createQuestToolStripMenuItem_Click);
            // 
            // searchQuestsToolStripMenuItem
            // 
            this.searchQuestsToolStripMenuItem.Name = "searchQuestsToolStripMenuItem";
            this.searchQuestsToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.searchQuestsToolStripMenuItem.Text = "Search Quests";
            this.searchQuestsToolStripMenuItem.Click += new System.EventHandler(this.searchQuestsToolStripMenuItem_Click);
            // 
            // questVIsualiserToolStripMenuItem
            // 
            this.questVIsualiserToolStripMenuItem.Name = "questVIsualiserToolStripMenuItem";
            this.questVIsualiserToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.questVIsualiserToolStripMenuItem.Text = "Quest Visualiser";
            this.questVIsualiserToolStripMenuItem.Click += new System.EventHandler(this.questVIsualiserToolStripMenuItem_Click);
            // 
            // nPCToolStripMenuItem
            // 
            this.nPCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNPCToolStripMenuItem,
            this.searchNPCsToolStripMenuItem});
            this.nPCToolStripMenuItem.Name = "nPCToolStripMenuItem";
            this.nPCToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.nPCToolStripMenuItem.Text = "NPC";
            // 
            // createNPCToolStripMenuItem
            // 
            this.createNPCToolStripMenuItem.Name = "createNPCToolStripMenuItem";
            this.createNPCToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.createNPCToolStripMenuItem.Text = "Create NPC";
            this.createNPCToolStripMenuItem.Click += new System.EventHandler(this.createNPCToolStripMenuItem_Click);
            // 
            // searchNPCsToolStripMenuItem
            // 
            this.searchNPCsToolStripMenuItem.Name = "searchNPCsToolStripMenuItem";
            this.searchNPCsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.searchNPCsToolStripMenuItem.Text = "Search NPCs";
            this.searchNPCsToolStripMenuItem.Click += new System.EventHandler(this.searchNPCsToolStripMenuItem_Click);
            // 
            // spellToolStripMenuItem
            // 
            this.spellToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createItemToolStripMenuItem1,
            this.searchItemsToolStripMenuItem1});
            this.spellToolStripMenuItem.Name = "spellToolStripMenuItem";
            this.spellToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.spellToolStripMenuItem.Text = "Spell";
            // 
            // createItemToolStripMenuItem1
            // 
            this.createItemToolStripMenuItem1.Name = "createItemToolStripMenuItem1";
            this.createItemToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.createItemToolStripMenuItem1.Text = "Create Spell";
            this.createItemToolStripMenuItem1.Click += new System.EventHandler(this.createItemToolStripMenuItem1_Click);
            // 
            // searchItemsToolStripMenuItem1
            // 
            this.searchItemsToolStripMenuItem1.Name = "searchItemsToolStripMenuItem1";
            this.searchItemsToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.searchItemsToolStripMenuItem1.Text = "Search Spells";
            this.searchItemsToolStripMenuItem1.Click += new System.EventHandler(this.searchItemsToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 720);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1333, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 742);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Solinia Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWorldFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createQuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchQuestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchNPCsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createItemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchItemsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questVIsualiserToolStripMenuItem;
    }
}

