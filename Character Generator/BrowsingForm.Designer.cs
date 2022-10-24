
namespace Character_Generator
{
    partial class BrowsingForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGetRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLifePhase = new System.Windows.Forms.TextBox();
            this.textBoxTrait = new System.Windows.Forms.TextBox();
            this.textBoxStrength = new System.Windows.Forms.TextBox();
            this.textBoxFlaw = new System.Windows.Forms.TextBox();
            this.textBoxGoal = new System.Windows.Forms.TextBox();
            this.textBoxSecret = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxCharacterId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(146, 434);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(185, 32);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Back To Main Menu";
            this.buttonClose.UseMnemonic = false;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonGetRandom
            // 
            this.buttonGetRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetRandom.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetRandom.Location = new System.Drawing.Point(146, 40);
            this.buttonGetRandom.Name = "buttonGetRandom";
            this.buttonGetRandom.Size = new System.Drawing.Size(185, 45);
            this.buttonGetRandom.TabIndex = 1;
            this.buttonGetRandom.Text = "Show A Random Character";
            this.buttonGetRandom.UseVisualStyleBackColor = true;
            this.buttonGetRandom.Click += new System.EventHandler(this.buttonGetRandom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "This character is a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "People describe them as";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "What most helps them succeed is their";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Their biggest shortcoming is their";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Their main goal is to";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "They hide from the world their";
            // 
            // textBoxLifePhase
            // 
            this.textBoxLifePhase.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLifePhase.Location = new System.Drawing.Point(170, 142);
            this.textBoxLifePhase.Name = "textBoxLifePhase";
            this.textBoxLifePhase.ReadOnly = true;
            this.textBoxLifePhase.Size = new System.Drawing.Size(279, 22);
            this.textBoxLifePhase.TabIndex = 8;
            // 
            // textBoxTrait
            // 
            this.textBoxTrait.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrait.Location = new System.Drawing.Point(197, 172);
            this.textBoxTrait.Name = "textBoxTrait";
            this.textBoxTrait.ReadOnly = true;
            this.textBoxTrait.Size = new System.Drawing.Size(252, 22);
            this.textBoxTrait.TabIndex = 9;
            // 
            // textBoxStrength
            // 
            this.textBoxStrength.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStrength.Location = new System.Drawing.Point(295, 202);
            this.textBoxStrength.Name = "textBoxStrength";
            this.textBoxStrength.ReadOnly = true;
            this.textBoxStrength.Size = new System.Drawing.Size(154, 22);
            this.textBoxStrength.TabIndex = 10;
            // 
            // textBoxFlaw
            // 
            this.textBoxFlaw.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFlaw.Location = new System.Drawing.Point(274, 232);
            this.textBoxFlaw.Name = "textBoxFlaw";
            this.textBoxFlaw.ReadOnly = true;
            this.textBoxFlaw.Size = new System.Drawing.Size(175, 22);
            this.textBoxFlaw.TabIndex = 11;
            // 
            // textBoxGoal
            // 
            this.textBoxGoal.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGoal.Location = new System.Drawing.Point(183, 262);
            this.textBoxGoal.Name = "textBoxGoal";
            this.textBoxGoal.ReadOnly = true;
            this.textBoxGoal.Size = new System.Drawing.Size(266, 22);
            this.textBoxGoal.TabIndex = 12;
            // 
            // textBoxSecret
            // 
            this.textBoxSecret.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSecret.Location = new System.Drawing.Point(246, 292);
            this.textBoxSecret.Name = "textBoxSecret";
            this.textBoxSecret.ReadOnly = true;
            this.textBoxSecret.Size = new System.Drawing.Size(203, 22);
            this.textBoxSecret.TabIndex = 13;
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(146, 374);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(185, 30);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete Character";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxCharacterId
            // 
            this.textBoxCharacterId.Location = new System.Drawing.Point(26, 103);
            this.textBoxCharacterId.Name = "textBoxCharacterId";
            this.textBoxCharacterId.Size = new System.Drawing.Size(100, 21);
            this.textBoxCharacterId.TabIndex = 15;
            this.textBoxCharacterId.Visible = false;
            // 
            // BrowsingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 486);
            this.Controls.Add(this.textBoxCharacterId);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxSecret);
            this.Controls.Add(this.textBoxGoal);
            this.Controls.Add(this.textBoxFlaw);
            this.Controls.Add(this.textBoxStrength);
            this.Controls.Add(this.textBoxTrait);
            this.Controls.Add(this.textBoxLifePhase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGetRandom);
            this.Controls.Add(this.buttonClose);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BrowsingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonGetRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLifePhase;
        private System.Windows.Forms.TextBox textBoxTrait;
        private System.Windows.Forms.TextBox textBoxStrength;
        private System.Windows.Forms.TextBox textBoxFlaw;
        private System.Windows.Forms.TextBox textBoxGoal;
        private System.Windows.Forms.TextBox textBoxSecret;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxCharacterId;
    }
}