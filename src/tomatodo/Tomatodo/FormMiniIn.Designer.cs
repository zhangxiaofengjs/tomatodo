namespace tomatodo
{
	partial class FormMiniIn
	{
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.textBoxDetail = new System.Windows.Forms.TextBox();
			this.buttonTo = new System.Windows.Forms.Button();
			this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.comboBoxCatagory = new System.Windows.Forms.ComboBox();
			this.dateTimePickerDeadDate = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// textBoxDetail
			// 
			this.textBoxDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDetail.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxDetail.Location = new System.Drawing.Point(199, 3);
			this.textBoxDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxDetail.Name = "textBoxDetail";
			this.textBoxDetail.Size = new System.Drawing.Size(391, 25);
			this.textBoxDetail.TabIndex = 1;
			this.textBoxDetail.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxDetail_PreviewKeyDown);
			this.textBoxDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDetail_KeyDown);
			// 
			// buttonTo
			// 
			this.buttonTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTo.Location = new System.Drawing.Point(594, 2);
			this.buttonTo.Name = "buttonTo";
			this.buttonTo.Size = new System.Drawing.Size(95, 25);
			this.buttonTo.TabIndex = 2;
			this.buttonTo.Text = "To";
			this.buttonTo.UseVisualStyleBackColor = true;
			this.buttonTo.Click += new System.EventHandler(this.buttonTo_Click);
			// 
			// trayIcon
			// 
			this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.trayIcon.Text = "notifyIcon1";
			this.trayIcon.Visible = true;
			// 
			// comboBoxCatagory
			// 
			this.comboBoxCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCatagory.FormattingEnabled = true;
			this.comboBoxCatagory.Location = new System.Drawing.Point(1, 2);
			this.comboBoxCatagory.Name = "comboBoxCatagory";
			this.comboBoxCatagory.Size = new System.Drawing.Size(128, 25);
			this.comboBoxCatagory.TabIndex = 3;
			// 
			// dateTimePickerDeadDate
			// 
			this.dateTimePickerDeadDate.CustomFormat = "M/d";
			this.dateTimePickerDeadDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDeadDate.Location = new System.Drawing.Point(132, 4);
			this.dateTimePickerDeadDate.Name = "dateTimePickerDeadDate";
			this.dateTimePickerDeadDate.Size = new System.Drawing.Size(64, 23);
			this.dateTimePickerDeadDate.TabIndex = 4;
			// 
			// FormMiniIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(690, 29);
			this.Controls.Add(this.dateTimePickerDeadDate);
			this.Controls.Add(this.comboBoxCatagory);
			this.Controls.Add(this.buttonTo);
			this.Controls.Add(this.textBoxDetail);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormMiniIn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "tomatodo-in";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxDetail;
		private System.Windows.Forms.Button buttonTo;
		private System.Windows.Forms.NotifyIcon trayIcon;
		private System.Windows.Forms.ComboBox comboBoxCatagory;
		private System.Windows.Forms.DateTimePicker dateTimePickerDeadDate;

	}
}

