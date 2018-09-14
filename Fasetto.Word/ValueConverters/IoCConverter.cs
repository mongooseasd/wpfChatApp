﻿using Fasetto.Word.Core;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Fasetto.Word
{
	/// <summary>
	/// Converts a string name to a service pulled from the IoC container
	/// </summary>
	public class IoCConverter : BaseValueConverter<ApplicationPageValueConverter>
  {
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      // Find the appropriate page
      switch ((string)value)
      {
        case nameof(ApplicationViewModel):
          return IoC.Get<ApplicationViewModel>();

        default:
          Debugger.Break();
          return null;
      }
    }

    public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
