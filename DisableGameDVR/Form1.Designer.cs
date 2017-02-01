namespace DisableGameDVR
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
            this.toggleDVRCheckbox = new System.Windows.Forms.CheckBox();
            this.toggleBarCheckbox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gameDVRPictureBox = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gameBarPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameDVRPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toggleDVRCheckbox
            // 
            this.toggleDVRCheckbox.AutoSize = true;
            this.toggleDVRCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleDVRCheckbox.Location = new System.Drawing.Point(3, 3);
            this.toggleDVRCheckbox.Name = "toggleDVRCheckbox";
            this.toggleDVRCheckbox.Size = new System.Drawing.Size(97, 102);
            this.toggleDVRCheckbox.TabIndex = 0;
            this.toggleDVRCheckbox.Text = "GameDVR";
            this.toggleDVRCheckbox.UseVisualStyleBackColor = true;
            this.toggleDVRCheckbox.CheckedChanged += new System.EventHandler(this.toggleDVRCheckbox_CheckedChanged);
            // 
            // toggleBarCheckbox
            // 
            this.toggleBarCheckbox.AutoSize = true;
            this.toggleBarCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleBarCheckbox.Location = new System.Drawing.Point(3, 111);
            this.toggleBarCheckbox.Name = "toggleBarCheckbox";
            this.toggleBarCheckbox.Size = new System.Drawing.Size(97, 28);
            this.toggleBarCheckbox.TabIndex = 3;
            this.toggleBarCheckbox.Text = "GameBar";
            this.toggleBarCheckbox.UseVisualStyleBackColor = true;
            this.toggleBarCheckbox.CheckedChanged += new System.EventHandler(this.toggleBarCheckbox_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gameDVRPictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.toggleBarCheckbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toggleDVRCheckbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameBarPictureBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 168);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // gameDVRPictureBox
            // 
            this.gameDVRPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameDVRPictureBox.Image = global::DisableGameDVR.Properties.Resources.game_dvr;
            this.gameDVRPictureBox.Location = new System.Drawing.Point(106, 3);
            this.gameDVRPictureBox.Name = "gameDVRPictureBox";
            this.gameDVRPictureBox.Size = new System.Drawing.Size(401, 102);
            this.gameDVRPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gameDVRPictureBox.TabIndex = 7;
            this.gameDVRPictureBox.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(432, 142);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@vasinnet";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // gameBarPictureBox
            // 
            this.gameBarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameBarPictureBox.Image = global::DisableGameDVR.Properties.Resources.game_bar;
            this.gameBarPictureBox.Location = new System.Drawing.Point(106, 111);
            this.gameBarPictureBox.Name = "gameBarPictureBox";
            this.gameBarPictureBox.Size = new System.Drawing.Size(401, 28);
            this.gameBarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gameBarPictureBox.TabIndex = 4;
            this.gameBarPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(510, 168);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure GameDVR & GameBar";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameDVRPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox toggleDVRCheckbox;
        private System.Windows.Forms.CheckBox toggleBarCheckbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox gameBarPictureBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox gameDVRPictureBox;
    }
}

