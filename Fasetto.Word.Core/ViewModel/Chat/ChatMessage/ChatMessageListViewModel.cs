﻿using System.Collections.Generic;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
	/// <summary>
	/// A view model for the overview chat list
	/// </summary>
	public class ChatMessageListViewModel : BaseViewModel
	{
		#region Public Properties

		/// <summary>
		/// The chat list items for the list
		/// </summary>
		public List<ChatMessageListItemViewModel> Items { get; set; }

		/// <summary>
		/// True to show the attached menu, false to hide it
		/// </summary>
		public bool AttachmentMenuVisible { get; set; } = false;

		/// <summary>
		/// True if any popup menus are visible
		/// </summary>
		public bool AnyPopupVisible => AttachmentMenuVisible;

		/// <summary>
		/// The view model for the attachment menu
		/// </summary>
		public ChatAttachmentPopupMenuViewModel AttachmentMenu { get; set; }
		#endregion


		#region Public Command
		/// <summary>
		/// The command for when the attachment button is clicked
		/// </summary>
		public ICommand AttachmentButtonCommand { get; set; }

		/// <summary>
		/// The command for when the area outside of any popup is clicked
		/// </summary>
		public ICommand PopupClickawayCommand { get; set; }

		/// <summary>
		/// The command for when the user clicks the send button
		/// </summary>
		public ICommand SendCommand { get; set; }
		#endregion


		#region Constructor
		/// <summary>
		/// Default constructor
		/// </summary>
		public ChatMessageListViewModel()
		{
			// Create commands
			AttachmentButtonCommand = new RelayCommand(AttachmentButton);
			PopupClickawayCommand = new RelayCommand(PopupClickaway);
			SendCommand = new RelayCommand(Send);

			// Make a default menu
			AttachmentMenu = new ChatAttachmentPopupMenuViewModel();
		}
		#endregion


		#region Command Methods
		/// <summary>
		/// When the attachment button is clicked show/hide the attachment popup
		/// </summary>
		public void AttachmentButton()
		{
			// Tooggle menu visibility
			AttachmentMenuVisible ^= true;
		}

		/// <summary>
		/// When the popup clickaway area is clicked hide any popups
		/// </summary>
		public void PopupClickaway()
		{
			// Hide attachment menu
			AttachmentMenuVisible = false;
		}

		/// <summary>
		/// When the user clicks the send button, sends the message
		/// </summary>
		public void Send()
		{
			IoC.UI.ShowMessage(new MessageBoxDialogViewModel
			{
				Title = "Send message",
				Message = "Thank you for writing a nice message",
				OkText = "Ok"
			});
		}

		#endregion
	}
}
