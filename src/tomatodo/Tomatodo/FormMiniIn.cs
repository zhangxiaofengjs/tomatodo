using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tomatodo.tomatoIF;
using THInfo;

namespace tomatodo
{
	public partial class FormMiniIn : Form, IMessageFilter
	{
		TUser[] _users = null;
		TUser[] _selectedUsers = null;
		
		public FormMiniIn()
		{
			InitializeComponent();

			TIFMgr.DataSource = new HInfoDataSource();
			if( TIFMgr.Login("869", "888") )
			{
				TCatagory[] cataList =TIFMgr.DataSource.GetCatagories(TIFMgr.LoginUser.Id);

				comboBoxCatagory.DataSource = cataList;
				comboBoxCatagory.DisplayMember = "Name";

				_users = TIFMgr.DataSource.GetUsers();
			}

			Application.AddMessageFilter(this);
		}

		#region IMessageFilter メンバ

		public bool PreFilterMessage(ref Message m)
		{
			return false;
		}

		#endregion

		private void textBoxDetail_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Enter:
					{
						e.Handled = true;
						break;
					}
			}
		}

		private void CommitTodoItem()
		{
			List<TodoItem> listItems = new List<TodoItem>();

			foreach (TUser user in _selectedUsers)
			{
				TodoItem item = new TodoItem();
				item.Detail = textBoxDetail.Text;
				item.FromUser = TIFMgr.LoginUser;
				item.ToUser = user;
				item.IsDoneMemoRequired = true;
				item.DeadDate = dateTimePickerDeadDate.Value;
				item.Catagory = comboBoxCatagory.SelectedItem as TCatagory;

				listItems.Add(item);
			}
			ITomatoDataSource dataSource = TIFMgr.DataSource;
			if (dataSource.Insert(listItems.ToArray()))
			{
				trayIcon.ShowBalloonTip(2000, "提示", "追加成功\n" + listItems[0].Detail + "...", ToolTipIcon.Info);
			}
		}

		private void textBoxDetail_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				CommitTodoItem();
			}
		}

		private void buttonTo_Click(object sender, EventArgs e)
		{
			FormUserList form = new FormUserList();
			form.Users = _users;
			if (form.ShowDialog(this) == DialogResult.OK)
			{
				_selectedUsers = form.SelectedUsers;
				buttonTo.Text = "to:" + _selectedUsers[0].Name;
			}
		}
	}
}
