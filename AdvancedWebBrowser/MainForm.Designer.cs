namespace AdvancedWebBrowser
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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.picPageIcon = new System.Windows.Forms.PictureBox();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.cboURL = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlAddressPanel = new System.Windows.Forms.Panel();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPageIcon)).BeginInit();
            this.pnlAddressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.pnlAddressPanel);
            this.pnlControls.Controls.Add(this.btnHome);
            this.pnlControls.Controls.Add(this.btnRefresh);
            this.pnlControls.Controls.Add(this.btnForward);
            this.pnlControls.Controls.Add(this.btnBack);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(484, 31);
            this.pnlControls.TabIndex = 0;
            // 
            // picPageIcon
            // 
            this.picPageIcon.BackColor = System.Drawing.SystemColors.Window;
            this.picPageIcon.Location = new System.Drawing.Point(-1, -1);
            this.picPageIcon.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.picPageIcon.Name = "picPageIcon";
            this.picPageIcon.Size = new System.Drawing.Size(25, 25);
            this.picPageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPageIcon.TabIndex = 6;
            this.picPageIcon.TabStop = false;
            // 
            // btnNavigate
            // 
            this.btnNavigate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavigate.BackColor = System.Drawing.SystemColors.Window;
            this.btnNavigate.FlatAppearance.BorderSize = 0;
            this.btnNavigate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavigate.Image = global::AdvancedWebBrowser.Properties.Resources.ButonNavigate;
            this.btnNavigate.Location = new System.Drawing.Point(337, -1);
            this.btnNavigate.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(25, 25);
            this.btnNavigate.TabIndex = 5;
            this.btnNavigate.UseVisualStyleBackColor = false;
            // 
            // cboURL
            // 
            this.cboURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboURL.FormattingEnabled = true;
            this.cboURL.Location = new System.Drawing.Point(24, 0);
            this.cboURL.Margin = new System.Windows.Forms.Padding(0);
            this.cboURL.Name = "cboURL";
            this.cboURL.Size = new System.Drawing.Size(313, 24);
            this.cboURL.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::AdvancedWebBrowser.Properties.Resources.ButtonHome;
            this.btnHome.Location = new System.Drawing.Point(87, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(25, 25);
            this.btnHome.TabIndex = 3;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::AdvancedWebBrowser.Properties.Resources.ButtonRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(56, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Image = global::AdvancedWebBrowser.Properties.Resources.ButtonForward;
            this.btnForward.Location = new System.Drawing.Point(28, 3);
            this.btnForward.Margin = new System.Windows.Forms.Padding(0);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(25, 25);
            this.btnForward.TabIndex = 1;
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::AdvancedWebBrowser.Properties.Resources.ButtonBack;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // pnlAddressPanel
            // 
            this.pnlAddressPanel.BackColor = System.Drawing.SystemColors.Window;
            this.pnlAddressPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddressPanel.Controls.Add(this.picPageIcon);
            this.pnlAddressPanel.Controls.Add(this.btnNavigate);
            this.pnlAddressPanel.Controls.Add(this.cboURL);
            this.pnlAddressPanel.Location = new System.Drawing.Point(118, 3);
            this.pnlAddressPanel.Name = "pnlAddressPanel";
            this.pnlAddressPanel.Size = new System.Drawing.Size(363, 25);
            this.pnlAddressPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.pnlControls);
            this.Name = "MainForm";
            this.Text = "Advanced WebBrowser";
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPageIcon)).EndInit();
            this.pnlAddressPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNavigate;
        private System.Windows.Forms.ComboBox cboURL;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox picPageIcon;
        private System.Windows.Forms.Panel pnlAddressPanel;
    }
}

