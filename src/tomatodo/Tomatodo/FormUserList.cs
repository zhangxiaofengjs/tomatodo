using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tomatodo.tomatoIF;

namespace tomatodo
{
	public partial class FormUserList : Form
	{
		public TUser[] Users
		{
			set
			{
				checkedListBox.Items.Clear();
				checkedListBox.Items.AddRange(value);
			}
		}

		public TUser[] SelectedUsers
		{
			get
			{
				TUser[] users = new TUser[checkedListBox.CheckedItems.Count];
				checkedListBox.CheckedItems.CopyTo(users, 0);

				return users;
			}
		}

		public FormUserList()
		{
			InitializeComponent();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void checkedListBox_Format(object sender, ListControlConvertEventArgs e)
		{
			TUser user = e.ListItem as TUser;
			e.Value = user.Name;
		}
	}
}
