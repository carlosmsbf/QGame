
namespace A2CBarros
{
    partial class PlayGame
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMazeStructure = new System.Windows.Forms.Panel();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.lblBoxesRemaining = new System.Windows.Forms.Label();
            this.lblBoxesMoving = new System.Windows.Forms.Label();
            this.txtBoxesRemaining = new System.Windows.Forms.TextBox();
            this.txtBoxesMoving = new System.Windows.Forms.TextBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlInformation.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // pnlMazeStructure
            // 
            this.pnlMazeStructure.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMazeStructure.Location = new System.Drawing.Point(0, 28);
            this.pnlMazeStructure.Name = "pnlMazeStructure";
            this.pnlMazeStructure.Size = new System.Drawing.Size(821, 676);
            this.pnlMazeStructure.TabIndex = 1;
            // 
            // pnlInformation
            // 
            this.pnlInformation.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlInformation.Controls.Add(this.lblBoxesRemaining);
            this.pnlInformation.Controls.Add(this.lblBoxesMoving);
            this.pnlInformation.Controls.Add(this.txtBoxesRemaining);
            this.pnlInformation.Controls.Add(this.txtBoxesMoving);
            this.pnlInformation.Location = new System.Drawing.Point(827, 28);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(265, 470);
            this.pnlInformation.TabIndex = 2;
            // 
            // lblBoxesRemaining
            // 
            this.lblBoxesRemaining.AutoSize = true;
            this.lblBoxesRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxesRemaining.Location = new System.Drawing.Point(3, 136);
            this.lblBoxesRemaining.Name = "lblBoxesRemaining";
            this.lblBoxesRemaining.Size = new System.Drawing.Size(259, 25);
            this.lblBoxesRemaining.TabIndex = 3;
            this.lblBoxesRemaining.Text = "Number of Remaining Boxes";
            // 
            // lblBoxesMoving
            // 
            this.lblBoxesMoving.AutoSize = true;
            this.lblBoxesMoving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxesMoving.Location = new System.Drawing.Point(3, 39);
            this.lblBoxesMoving.Name = "lblBoxesMoving";
            this.lblBoxesMoving.Size = new System.Drawing.Size(166, 25);
            this.lblBoxesMoving.TabIndex = 2;
            this.lblBoxesMoving.Text = "Number of Moves";
            // 
            // txtBoxesRemaining
            // 
            this.txtBoxesRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxesRemaining.Location = new System.Drawing.Point(30, 182);
            this.txtBoxesRemaining.Name = "txtBoxesRemaining";
            this.txtBoxesRemaining.Size = new System.Drawing.Size(100, 34);
            this.txtBoxesRemaining.TabIndex = 1;
            // 
            // txtBoxesMoving
            // 
            this.txtBoxesMoving.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxesMoving.Location = new System.Drawing.Point(30, 67);
            this.txtBoxesMoving.Name = "txtBoxesMoving";
            this.txtBoxesMoving.Size = new System.Drawing.Size(100, 34);
            this.txtBoxesMoving.TabIndex = 0;
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlButton.Controls.Add(this.btnMoveRight);
            this.pnlButton.Controls.Add(this.btnMoveLeft);
            this.pnlButton.Controls.Add(this.btnMoveUp);
            this.pnlButton.Controls.Add(this.btnMoveDown);
            this.pnlButton.Location = new System.Drawing.Point(827, 504);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(265, 200);
            this.pnlButton.TabIndex = 3;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveRight.Location = new System.Drawing.Point(180, 99);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(82, 76);
            this.btnMoveRight.TabIndex = 3;
            this.btnMoveRight.Text = "→";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveLeft.Location = new System.Drawing.Point(4, 99);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(82, 76);
            this.btnMoveLeft.TabIndex = 2;
            this.btnMoveLeft.Text = "←";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveUp.Location = new System.Drawing.Point(92, 17);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(82, 76);
            this.btnMoveUp.TabIndex = 1;
            this.btnMoveUp.Text = "↑";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDown.Location = new System.Drawing.Point(92, 99);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(82, 76);
            this.btnMoveDown.TabIndex = 0;
            this.btnMoveDown.Text = "↓";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 706);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlInformation);
            this.Controls.Add(this.pnlMazeStructure);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlayGame";
            this.Text = "PlayGame";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMazeStructure;
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Label lblBoxesRemaining;
        private System.Windows.Forms.Label lblBoxesMoving;
        private System.Windows.Forms.TextBox txtBoxesRemaining;
        private System.Windows.Forms.TextBox txtBoxesMoving;
    }
}