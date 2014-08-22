namespace WindowsFormsApplication1
{
    partial class MatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchForm));
            this.fishy = new System.Windows.Forms.PictureBox();
            this.sharky1 = new System.Windows.Forms.PictureBox();
            this.sharky2 = new System.Windows.Forms.PictureBox();
            this.sharky3 = new System.Windows.Forms.PictureBox();
            this.shark1Text = new System.Windows.Forms.TextBox();
            this.shark2Text = new System.Windows.Forms.TextBox();
            this.shark3Text = new System.Windows.Forms.TextBox();
            this.okayClose = new System.Windows.Forms.Button();
            this.ClientMatchStatusStrip = new System.Windows.Forms.StatusStrip();
            this.ClientMatchStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fishy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharky1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharky2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharky3)).BeginInit();
            this.ClientMatchStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fishy
            // 
            this.fishy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fishy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fishy.Location = new System.Drawing.Point(22, 34);
            this.fishy.Name = "fishy";
            this.fishy.Size = new System.Drawing.Size(410, 484);
            this.fishy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fishy.TabIndex = 0;
            this.fishy.TabStop = false;
            // 
            // sharky1
            // 
            this.sharky1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sharky1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sharky1.InitialImage = global::WindowsFormsApplication1.Resource1.MysteryDatet;
            this.sharky1.Location = new System.Drawing.Point(453, 34);
            this.sharky1.Name = "sharky1";
            this.sharky1.Size = new System.Drawing.Size(153, 104);
            this.sharky1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sharky1.TabIndex = 1;
            this.sharky1.TabStop = false;
            // 
            // sharky2
            // 
            this.sharky2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sharky2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sharky2.InitialImage = global::WindowsFormsApplication1.Resource1.MysteryDatet;
            this.sharky2.Location = new System.Drawing.Point(453, 199);
            this.sharky2.Name = "sharky2";
            this.sharky2.Size = new System.Drawing.Size(153, 104);
            this.sharky2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sharky2.TabIndex = 2;
            this.sharky2.TabStop = false;
            // 
            // sharky3
            // 
            this.sharky3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sharky3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sharky3.InitialImage = global::WindowsFormsApplication1.Resource1.MysteryDatet;
            this.sharky3.Location = new System.Drawing.Point(453, 365);
            this.sharky3.Name = "sharky3";
            this.sharky3.Size = new System.Drawing.Size(153, 104);
            this.sharky3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sharky3.TabIndex = 3;
            this.sharky3.TabStop = false;
            // 
            // shark1Text
            // 
            this.shark1Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.shark1Text.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.shark1Text.Enabled = false;
            this.shark1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shark1Text.Location = new System.Drawing.Point(453, 138);
            this.shark1Text.Multiline = true;
            this.shark1Text.Name = "shark1Text";
            this.shark1Text.Size = new System.Drawing.Size(153, 49);
            this.shark1Text.TabIndex = 4;
            this.shark1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shark2Text
            // 
            this.shark2Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.shark2Text.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.shark2Text.Enabled = false;
            this.shark2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shark2Text.Location = new System.Drawing.Point(453, 303);
            this.shark2Text.Multiline = true;
            this.shark2Text.Name = "shark2Text";
            this.shark2Text.Size = new System.Drawing.Size(153, 49);
            this.shark2Text.TabIndex = 5;
            this.shark2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shark3Text
            // 
            this.shark3Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.shark3Text.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.shark3Text.Enabled = false;
            this.shark3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shark3Text.Location = new System.Drawing.Point(453, 469);
            this.shark3Text.Multiline = true;
            this.shark3Text.Name = "shark3Text";
            this.shark3Text.Size = new System.Drawing.Size(153, 49);
            this.shark3Text.TabIndex = 6;
            this.shark3Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // okayClose
            // 
            this.okayClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okayClose.BackColor = System.Drawing.SystemColors.Control;
            this.okayClose.Location = new System.Drawing.Point(471, 532);
            this.okayClose.Name = "okayClose";
            this.okayClose.Size = new System.Drawing.Size(118, 34);
            this.okayClose.TabIndex = 7;
            this.okayClose.Text = "OK";
            this.okayClose.UseVisualStyleBackColor = false;
            this.okayClose.Click += new System.EventHandler(this.okayClose_Click);
            // 
            // ClientMatchStatusStrip
            // 
            this.ClientMatchStatusStrip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientMatchStatusStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientMatchStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientMatchStatus});
            this.ClientMatchStatusStrip.Location = new System.Drawing.Point(0, 576);
            this.ClientMatchStatusStrip.Name = "ClientMatchStatusStrip";
            this.ClientMatchStatusStrip.Size = new System.Drawing.Size(635, 22);
            this.ClientMatchStatusStrip.TabIndex = 8;
            // 
            // ClientMatchStatus
            // 
            this.ClientMatchStatus.BackColor = System.Drawing.SystemColors.Info;
            this.ClientMatchStatus.Name = "ClientMatchStatus";
            this.ClientMatchStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 598);
            this.Controls.Add(this.ClientMatchStatusStrip);
            this.Controls.Add(this.okayClose);
            this.Controls.Add(this.shark3Text);
            this.Controls.Add(this.shark2Text);
            this.Controls.Add(this.shark1Text);
            this.Controls.Add(this.sharky3);
            this.Controls.Add(this.sharky2);
            this.Controls.Add(this.sharky1);
            this.Controls.Add(this.fishy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 610);
            this.Name = "MatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Match Form";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.fishy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharky1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharky2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharky3)).EndInit();
            this.ClientMatchStatusStrip.ResumeLayout(false);
            this.ClientMatchStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fishy;
        private System.Windows.Forms.PictureBox sharky1;
        private System.Windows.Forms.PictureBox sharky2;
        private System.Windows.Forms.PictureBox sharky3;
        private System.Windows.Forms.TextBox shark1Text;
        private System.Windows.Forms.TextBox shark2Text;
        private System.Windows.Forms.TextBox shark3Text;
        private System.Windows.Forms.Button okayClose;
        private System.Windows.Forms.StatusStrip ClientMatchStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ClientMatchStatus;
    }
}