﻿namespace Fasetto.Word.Core
{
	/// <summary>
	/// A view mode lfor a menu item
	/// </summary>
	public class MenuItemViewModel : BaseViewModel
  {
    /// <summary>
    /// Text to display for the menu item
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// The icon for this menu item
    /// </summary>
    public IconType Icon { get; set; }
    
    /// <summary>
    /// The type of this menu item
    /// </summary>
    public MenuItemType Type { get; set; }
  }
}
