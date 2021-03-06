﻿namespace Fasetto.Word.Core
{
	/// <summary>
	/// Design time data for the <see cref="MessageBoxDialogViewModel"/>
	/// </summary>
	public class MessageBoxDialogDesignModel: MessageBoxDialogViewModel
	{
		#region Singleton

		/// <summary>
		/// A single instance of the design model
		/// </summary>
		public static MessageBoxDialogDesignModel Instance => new MessageBoxDialogDesignModel();

		#endregion


		#region Constructor

		/// <summary>
		/// Default Constructor
		/// </summary>
		public MessageBoxDialogDesignModel()
		{
			OkText = "Okay";
			Message = "Design time messages are fun :)";
		}

		#endregion
	}
}
