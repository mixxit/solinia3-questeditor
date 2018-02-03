namespace SoliniaQuestEditor
{
    partial class frmQuestEditor
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
            this.setPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.lblQuestName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbRequiresQuestFlag = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAwardsQuestFlag = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAwardsRandomisedGear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTeleportResponse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tbNewTriggerData = new System.Windows.Forms.TextBox();
            this.cbNPCIdList = new System.Windows.Forms.ComboBox();
            this.txtQuestName = new System.Windows.Forms.TextBox();
            this.tbAwardsItem = new System.Windows.Forms.TextBox();
            this.tbNPCId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRequiresQuest = new System.Windows.Forms.TextBox();
            this.tbChatResponse = new System.Windows.Forms.TextBox();
            this.tbQuestId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTriggerData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAwardsQuest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInteractionType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelQuestStep = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelQuest = new System.Windows.Forms.Panel();
            this.tvTree = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.panelQuestStep.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelQuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(383, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(858, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPathToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // setPathToolStripMenuItem
            // 
            this.setPathToolStripMenuItem.Name = "setPathToolStripMenuItem";
            this.setPathToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.setPathToolStripMenuItem.Text = "Set Path";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create Quest Step";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblQuestName
            // 
            this.lblQuestName.AutoSize = true;
            this.lblQuestName.Location = new System.Drawing.Point(19, 53);
            this.lblQuestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestName.Name = "lblQuestName";
            this.lblQuestName.Size = new System.Drawing.Size(87, 17);
            this.lblQuestName.TabIndex = 3;
            this.lblQuestName.Text = "Quest Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 260);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 61;
            this.label11.Text = "requiresQuestFlag";
            // 
            // tbRequiresQuestFlag
            // 
            this.tbRequiresQuestFlag.Location = new System.Drawing.Point(203, 251);
            this.tbRequiresQuestFlag.Margin = new System.Windows.Forms.Padding(4);
            this.tbRequiresQuestFlag.Name = "tbRequiresQuestFlag";
            this.tbRequiresQuestFlag.Size = new System.Drawing.Size(204, 22);
            this.tbRequiresQuestFlag.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 324);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 59;
            this.label10.Text = "awardsQuestFlag";
            // 
            // tbAwardsQuestFlag
            // 
            this.tbAwardsQuestFlag.Location = new System.Drawing.Point(203, 315);
            this.tbAwardsQuestFlag.Margin = new System.Windows.Forms.Padding(4);
            this.tbAwardsQuestFlag.Name = "tbAwardsQuestFlag";
            this.tbAwardsQuestFlag.Size = new System.Drawing.Size(204, 22);
            this.tbAwardsQuestFlag.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 409);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 57;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 450);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "awardsRandomisedGear";
            // 
            // tbAwardsRandomisedGear
            // 
            this.tbAwardsRandomisedGear.Location = new System.Drawing.Point(203, 442);
            this.tbAwardsRandomisedGear.Margin = new System.Windows.Forms.Padding(4);
            this.tbAwardsRandomisedGear.Name = "tbAwardsRandomisedGear";
            this.tbAwardsRandomisedGear.Size = new System.Drawing.Size(204, 22);
            this.tbAwardsRandomisedGear.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 418);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "teleportResponse";
            // 
            // tbTeleportResponse
            // 
            this.tbTeleportResponse.Location = new System.Drawing.Point(203, 410);
            this.tbTeleportResponse.Margin = new System.Windows.Forms.Padding(4);
            this.tbTeleportResponse.Name = "tbTeleportResponse";
            this.tbTeleportResponse.Size = new System.Drawing.Size(204, 22);
            this.tbTeleportResponse.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 386);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "awardsItem";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 84);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "Raw";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbNewTriggerData
            // 
            this.tbNewTriggerData.Location = new System.Drawing.Point(81, 86);
            this.tbNewTriggerData.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewTriggerData.Name = "tbNewTriggerData";
            this.tbNewTriggerData.Size = new System.Drawing.Size(132, 22);
            this.tbNewTriggerData.TabIndex = 6;
            // 
            // cbNPCIdList
            // 
            this.cbNPCIdList.FormattingEnabled = true;
            this.cbNPCIdList.Location = new System.Drawing.Point(223, 86);
            this.cbNPCIdList.Margin = new System.Windows.Forms.Padding(4);
            this.cbNPCIdList.Name = "cbNPCIdList";
            this.cbNPCIdList.Size = new System.Drawing.Size(160, 24);
            this.cbNPCIdList.TabIndex = 5;
            // 
            // txtQuestName
            // 
            this.txtQuestName.Location = new System.Drawing.Point(115, 49);
            this.txtQuestName.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuestName.Name = "txtQuestName";
            this.txtQuestName.Size = new System.Drawing.Size(533, 22);
            this.txtQuestName.TabIndex = 2;
            // 
            // tbAwardsItem
            // 
            this.tbAwardsItem.Location = new System.Drawing.Point(203, 378);
            this.tbAwardsItem.Margin = new System.Windows.Forms.Padding(4);
            this.tbAwardsItem.Name = "tbAwardsItem";
            this.tbAwardsItem.Size = new System.Drawing.Size(204, 22);
            this.tbAwardsItem.TabIndex = 51;
            // 
            // tbNPCId
            // 
            this.tbNPCId.Location = new System.Drawing.Point(203, 346);
            this.tbNPCId.Margin = new System.Windows.Forms.Padding(4);
            this.tbNPCId.Name = "tbNPCId";
            this.tbNPCId.Size = new System.Drawing.Size(204, 22);
            this.tbNPCId.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "requiresQuest";
            // 
            // tbRequiresQuest
            // 
            this.tbRequiresQuest.Location = new System.Drawing.Point(203, 222);
            this.tbRequiresQuest.Margin = new System.Windows.Forms.Padding(4);
            this.tbRequiresQuest.Name = "tbRequiresQuest";
            this.tbRequiresQuest.Size = new System.Drawing.Size(204, 22);
            this.tbRequiresQuest.TabIndex = 48;
            // 
            // tbChatResponse
            // 
            this.tbChatResponse.Location = new System.Drawing.Point(203, 87);
            this.tbChatResponse.Margin = new System.Windows.Forms.Padding(4);
            this.tbChatResponse.Multiline = true;
            this.tbChatResponse.Name = "tbChatResponse";
            this.tbChatResponse.Size = new System.Drawing.Size(519, 126);
            this.tbChatResponse.TabIndex = 46;
            // 
            // tbQuestId
            // 
            this.tbQuestId.Location = new System.Drawing.Point(115, 17);
            this.tbQuestId.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuestId.Name = "tbQuestId";
            this.tbQuestId.Size = new System.Drawing.Size(132, 22);
            this.tbQuestId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "chatresponse";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(383, 669);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(858, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "triggerdata";
            // 
            // tbTriggerData
            // 
            this.tbTriggerData.Location = new System.Drawing.Point(203, 55);
            this.tbTriggerData.Margin = new System.Windows.Forms.Padding(4);
            this.tbTriggerData.Name = "tbTriggerData";
            this.tbTriggerData.Size = new System.Drawing.Size(204, 22);
            this.tbTriggerData.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "awardsQuest";
            // 
            // tbAwardsQuest
            // 
            this.tbAwardsQuest.Location = new System.Drawing.Point(203, 283);
            this.tbAwardsQuest.Margin = new System.Windows.Forms.Padding(4);
            this.tbAwardsQuest.Name = "tbAwardsQuest";
            this.tbAwardsQuest.Size = new System.Drawing.Size(204, 22);
            this.tbAwardsQuest.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Interaction Type";
            // 
            // tbInteractionType
            // 
            this.tbInteractionType.Location = new System.Drawing.Point(203, 23);
            this.tbInteractionType.Margin = new System.Windows.Forms.Padding(4);
            this.tbInteractionType.Name = "tbInteractionType";
            this.tbInteractionType.Size = new System.Drawing.Size(204, 22);
            this.tbInteractionType.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "npcId";
            // 
            // panelQuestStep
            // 
            this.panelQuestStep.Controls.Add(this.label11);
            this.panelQuestStep.Controls.Add(this.tbRequiresQuestFlag);
            this.panelQuestStep.Controls.Add(this.label10);
            this.panelQuestStep.Controls.Add(this.tbAwardsQuestFlag);
            this.panelQuestStep.Controls.Add(this.button2);
            this.panelQuestStep.Controls.Add(this.label9);
            this.panelQuestStep.Controls.Add(this.tbAwardsRandomisedGear);
            this.panelQuestStep.Controls.Add(this.label8);
            this.panelQuestStep.Controls.Add(this.tbTeleportResponse);
            this.panelQuestStep.Controls.Add(this.label7);
            this.panelQuestStep.Controls.Add(this.tbAwardsItem);
            this.panelQuestStep.Controls.Add(this.tbNPCId);
            this.panelQuestStep.Controls.Add(this.label5);
            this.panelQuestStep.Controls.Add(this.tbRequiresQuest);
            this.panelQuestStep.Controls.Add(this.label4);
            this.panelQuestStep.Controls.Add(this.tbChatResponse);
            this.panelQuestStep.Controls.Add(this.label3);
            this.panelQuestStep.Controls.Add(this.tbTriggerData);
            this.panelQuestStep.Controls.Add(this.label2);
            this.panelQuestStep.Controls.Add(this.tbAwardsQuest);
            this.panelQuestStep.Controls.Add(this.label1);
            this.panelQuestStep.Controls.Add(this.tbInteractionType);
            this.panelQuestStep.Controls.Add(this.label6);
            this.panelQuestStep.Location = new System.Drawing.Point(36, 181);
            this.panelQuestStep.Margin = new System.Windows.Forms.Padding(4);
            this.panelQuestStep.Name = "panelQuestStep";
            this.panelQuestStep.Size = new System.Drawing.Size(769, 486);
            this.panelQuestStep.TabIndex = 1;
            this.panelQuestStep.Visible = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelQuestStep);
            this.panelMain.Controls.Add(this.panelQuest);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(383, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(858, 691);
            this.panelMain.TabIndex = 5;
            // 
            // panelQuest
            // 
            this.panelQuest.Controls.Add(this.button3);
            this.panelQuest.Controls.Add(this.tbQuestId);
            this.panelQuest.Controls.Add(this.tbNewTriggerData);
            this.panelQuest.Controls.Add(this.cbNPCIdList);
            this.panelQuest.Controls.Add(this.button1);
            this.panelQuest.Controls.Add(this.lblQuestName);
            this.panelQuest.Controls.Add(this.txtQuestName);
            this.panelQuest.Location = new System.Drawing.Point(36, 33);
            this.panelQuest.Margin = new System.Windows.Forms.Padding(4);
            this.panelQuest.Name = "panelQuest";
            this.panelQuest.Size = new System.Drawing.Size(769, 123);
            this.panelQuest.TabIndex = 0;
            this.panelQuest.Visible = false;
            // 
            // tvTree
            // 
            this.tvTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvTree.Location = new System.Drawing.Point(0, 0);
            this.tvTree.Margin = new System.Windows.Forms.Padding(4);
            this.tvTree.Name = "tvTree";
            this.tvTree.Size = new System.Drawing.Size(383, 691);
            this.tvTree.TabIndex = 4;
            this.tvTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTree_AfterSelect);
            // 
            // frmQuestEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 691);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.tvTree);
            this.Name = "frmQuestEditor";
            this.Text = "frmQuestEditor";
            this.Load += new System.EventHandler(this.frmQuestEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelQuestStep.ResumeLayout(false);
            this.panelQuestStep.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelQuest.ResumeLayout(false);
            this.panelQuest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblQuestName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbRequiresQuestFlag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAwardsQuestFlag;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAwardsRandomisedGear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTeleportResponse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbNewTriggerData;
        private System.Windows.Forms.ComboBox cbNPCIdList;
        private System.Windows.Forms.TextBox txtQuestName;
        private System.Windows.Forms.TextBox tbAwardsItem;
        private System.Windows.Forms.TextBox tbNPCId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRequiresQuest;
        private System.Windows.Forms.TextBox tbChatResponse;
        private System.Windows.Forms.TextBox tbQuestId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTriggerData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAwardsQuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInteractionType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelQuestStep;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelQuest;
        private System.Windows.Forms.TreeView tvTree;
    }
}