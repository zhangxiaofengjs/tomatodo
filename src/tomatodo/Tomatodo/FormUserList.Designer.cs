namespace tomatodo
{
	partial class FormUserList
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
			this.checkedListBox = new System.Windows.Forms.CheckedListBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkedListBox
			// 
			this.checkedListBox.FormattingEnabled = true;
			this.checkedListBox.Location = new System.Drawing.Point(1, 0);
			this.checkedListBox.Name = "checkedListBox";
			this.checkedListBox.Size = new System.Drawing.Size(210, 256);
			this.checkedListBox.TabIndex = 0;
			this.checkedListBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.checkedListBox_Format);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(136, 262);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// FormUserList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(211, 286);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.checkedListBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "FormUserList";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "选择用户";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckedListBox checkedListBox;
		private System.Windows.Forms.Button buttonOK;
	}
}