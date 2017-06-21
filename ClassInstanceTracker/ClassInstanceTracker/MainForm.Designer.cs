namespace ClassInstanceTracker
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
			this._flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this._randomizeButton = new System.Windows.Forms.Button();
			this._refreshLog = new System.Windows.Forms.Button();
			this._buttonPanelLabel = new System.Windows.Forms.Label();
			this._headerLabel = new System.Windows.Forms.Label();
			this._logger = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// _flowLayoutPanel
			// 
			this._flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._flowLayoutPanel.Location = new System.Drawing.Point(12, 280);
			this._flowLayoutPanel.Name = "_flowLayoutPanel";
			this._flowLayoutPanel.Size = new System.Drawing.Size(600, 181);
			this._flowLayoutPanel.TabIndex = 5;
			// 
			// _randomizeButton
			// 
			this._randomizeButton.Location = new System.Drawing.Point(350, 44);
			this._randomizeButton.Name = "_randomizeButton";
			this._randomizeButton.Size = new System.Drawing.Size(262, 217);
			this._randomizeButton.TabIndex = 3;
			this._randomizeButton.Text = "Randomize Instances";
			this._randomizeButton.UseVisualStyleBackColor = true;
			this._randomizeButton.Click += new System.EventHandler(this.OnRandmomizeClick);
			// 
			// _refreshLog
			// 
			this._refreshLog.Location = new System.Drawing.Point(181, 44);
			this._refreshLog.Name = "_refreshLog";
			this._refreshLog.Size = new System.Drawing.Size(163, 217);
			this._refreshLog.TabIndex = 2;
			this._refreshLog.Text = "Refresh Log";
			this._refreshLog.UseVisualStyleBackColor = true;
			this._refreshLog.Click += new System.EventHandler(this.OnRefreshClick);
			// 
			// _buttonPanelLabel
			// 
			this._buttonPanelLabel.AutoSize = true;
			this._buttonPanelLabel.Location = new System.Drawing.Point(11, 264);
			this._buttonPanelLabel.Name = "_buttonPanelLabel";
			this._buttonPanelLabel.Size = new System.Drawing.Size(164, 13);
			this._buttonPanelLabel.TabIndex = 4;
			this._buttonPanelLabel.Text = "Click a button below to remove it:";
			// 
			// _headerLabel
			// 
			this._headerLabel.AutoSize = true;
			this._headerLabel.Location = new System.Drawing.Point(12, 13);
			this._headerLabel.Name = "_headerLabel";
			this._headerLabel.Size = new System.Drawing.Size(262, 13);
			this._headerLabel.TabIndex = 0;
			this._headerLabel.Text = "Level Up Code Challenge By Brian Tran [06/21/2017]";
			// 
			// _logger
			// 
			this._logger.Location = new System.Drawing.Point(15, 44);
			this._logger.Name = "_logger";
			this._logger.ReadOnly = true;
			this._logger.Size = new System.Drawing.Size(160, 217);
			this._logger.TabIndex = 6;
			this._logger.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 473);
			this.Controls.Add(this._logger);
			this.Controls.Add(this._headerLabel);
			this.Controls.Add(this._buttonPanelLabel);
			this.Controls.Add(this._refreshLog);
			this.Controls.Add(this._randomizeButton);
			this.Controls.Add(this._flowLayoutPanel);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel _flowLayoutPanel;
		private System.Windows.Forms.Button _randomizeButton;
		private System.Windows.Forms.Button _refreshLog;
		private System.Windows.Forms.Label _buttonPanelLabel;
		private System.Windows.Forms.Label _headerLabel;
		private System.Windows.Forms.RichTextBox _logger;
	}
}