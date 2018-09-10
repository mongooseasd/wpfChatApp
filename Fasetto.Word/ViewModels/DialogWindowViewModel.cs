﻿using Fasetto.Word.Core; using System.Windows; using System.Windows.Controls;
using System.Windows.Input;  namespace Fasetto.Word {
  /// <summary>   /// The View Model for the custom flat window   /// </summary>   public class DialogWindowViewModel : WindowViewModel
  {
    #region Public Properties 
    /// <summary>
    /// The title of this dialog window
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// The content to host inside the dialog
    /// </summary>
    public Control Content { get; set; }

    #endregion 

    #region Constructor     /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="window"></param>     public DialogWindowViewModel(Window window) : base(window)
    {

    }

    #endregion   } } 