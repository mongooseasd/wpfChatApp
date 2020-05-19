﻿namespace Fasetto.Word.Core
{
	/// <summary>
	/// Design time data for a <see cref="TextEntryViewModel"/>
	/// </summary>
	public class TextEntryDesignModel: TextEntryViewModel
	{
		#region Singleton

		/// <summary>
		/// A single instance of the design model
		/// </summary>
		public static TextEntryDesignModel Instance => new TextEntryDesignModel();

		#endregion


		#region Constructor

		/// <summary>
		/// Default Constructor
		/// </summary>
		public TextEntryDesignModel()
		{
			Label = "Name";
			OriginalText = "Gud Boi";
			EditedText = "Editing :)";
		}

		#endregion
	}
}