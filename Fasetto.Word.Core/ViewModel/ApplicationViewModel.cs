﻿namespace Fasetto.Word.Core {
	/// <summary>   /// The application state as a view model   /// </summary>   public class ApplicationViewModel : BaseViewModel
  {
    /// <summary>         /// The current page of the application         /// </summary>     public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Chat;

    /// <summary>
    /// True if the side menu should be showed
    /// </summary>     public bool SideMenuVisible { get; set; } = true;

    /// <summary>
    /// Navigates to the specified page
    /// </summary>
    /// <param name="page">The page to go to</param>
    public void GoToPage(ApplicationPage page)
    {
      // Set the current page 
      CurrentPage = page;

      // Show side menu or not?
      SideMenuVisible = page == ApplicationPage.Chat;
    }
  } } 