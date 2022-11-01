
namespace Character_Generator
{
    partial class MainForm
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
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createdByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lukaAirassalo2022ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxMainForm = new System.Windows.Forms.GroupBox();
            this.IntroText = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonCreationMode = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.testDatabaseToolStripMenuItem,
            this.createDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createdByToolStripMenuItem,
            this.versionToolStripMenuItem,
            this.sourcesToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // createdByToolStripMenuItem
            // 
            this.createdByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lukaAirassalo2022ToolStripMenuItem});
            this.createdByToolStripMenuItem.Name = "createdByToolStripMenuItem";
            this.createdByToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.createdByToolStripMenuItem.Text = "Created by";
            // 
            // lukaAirassalo2022ToolStripMenuItem
            // 
            this.lukaAirassalo2022ToolStripMenuItem.Name = "lukaAirassalo2022ToolStripMenuItem";
            this.lukaAirassalo2022ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.lukaAirassalo2022ToolStripMenuItem.Text = "Luka Airassalo, 2022";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItem2.Text = "1.0.0";
            // 
            // sourcesToolStripMenuItem
            // 
            this.sourcesToolStripMenuItem.Name = "sourcesToolStripMenuItem";
            this.sourcesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.sourcesToolStripMenuItem.Text = "Sources";
            // 
            // testDatabaseToolStripMenuItem
            // 
            this.testDatabaseToolStripMenuItem.Name = "testDatabaseToolStripMenuItem";
            this.testDatabaseToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.testDatabaseToolStripMenuItem.Text = "Test Database";
            this.testDatabaseToolStripMenuItem.Click += new System.EventHandler(this.testDatabaseToolStripMenuItem_Click);
            // 
            // createDatabaseToolStripMenuItem
            // 
            this.createDatabaseToolStripMenuItem.Name = "createDatabaseToolStripMenuItem";
            this.createDatabaseToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.createDatabaseToolStripMenuItem.Text = "Database missing?";
            this.createDatabaseToolStripMenuItem.Click += new System.EventHandler(this.createDatabaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBoxMainForm
            // 
            this.groupBoxMainForm.Controls.Add(this.IntroText);
            this.groupBoxMainForm.Controls.Add(this.buttonInfo);
            this.groupBoxMainForm.Controls.Add(this.buttonView);
            this.groupBoxMainForm.Controls.Add(this.buttonCreationMode);
            this.groupBoxMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMainForm.Location = new System.Drawing.Point(0, 24);
            this.groupBoxMainForm.Name = "groupBoxMainForm";
            this.groupBoxMainForm.Size = new System.Drawing.Size(472, 462);
            this.groupBoxMainForm.TabIndex = 1;
            this.groupBoxMainForm.TabStop = false;
            this.groupBoxMainForm.UseWaitCursor = true;
            // 
            // IntroText
            // 
            this.IntroText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntroText.AutoSize = true;
            this.IntroText.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroText.Location = new System.Drawing.Point(86, 42);
            this.IntroText.Name = "IntroText";
            this.IntroText.Size = new System.Drawing.Size(318, 18);
            this.IntroText.TabIndex = 3;
            this.IntroText.Text = "Welcome to creating characters!";
            this.IntroText.UseWaitCursor = true;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.Location = new System.Drawing.Point(116, 292);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(240, 60);
            this.buttonInfo.TabIndex = 2;
            this.buttonInfo.Text = "Instructions And Ideas";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.UseWaitCursor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonView
            // 
            this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonView.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.Location = new System.Drawing.Point(116, 201);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(240, 60);
            this.buttonView.TabIndex = 1;
            this.buttonView.Text = "View Saved Characters";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.UseWaitCursor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonCreationMode
            // 
            this.buttonCreationMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreationMode.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreationMode.Location = new System.Drawing.Point(116, 117);
            this.buttonCreationMode.Name = "buttonCreationMode";
            this.buttonCreationMode.Size = new System.Drawing.Size(240, 60);
            this.buttonCreationMode.TabIndex = 0;
            this.buttonCreationMode.Text = "Make A New Character";
            this.buttonCreationMode.UseVisualStyleBackColor = true;
            this.buttonCreationMode.UseWaitCursor = true;
            this.buttonCreationMode.Click += new System.EventHandler(this.buttonCreationMode_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(472, 486);
            this.Controls.Add(this.groupBoxMainForm);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxMainForm.ResumeLayout(false);
            this.groupBoxMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createdByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lukaAirassalo2022ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourcesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxMainForm;
        private System.Windows.Forms.Label IntroText;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonCreationMode;
        private System.Windows.Forms.ToolStripMenuItem testDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem createDatabaseToolStripMenuItem;
    }
}

