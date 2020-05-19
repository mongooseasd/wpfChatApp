﻿using Fasetto.Word.Core;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Word
{
    /// <summary>
    /// Interaction logic for PasswordEntryControl.xaml
    /// </summary>
    public partial class PasswordEntryControl : UserControl
    {
        public GridLength LabelWidth { get; set; }

        // Using a DependencyProperty as the backing store for LabelWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelWidthProperty =
            DependencyProperty.Register(
                "LabelWidth",
                typeof(GridLength),
                typeof(PasswordEntryControl),
                new PropertyMetadata(GridLength.Auto, LabelWidthChangedCallback)
                );

        public PasswordEntryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the label width has changed
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        public static void LabelWidthChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                // Set the column definition width to the new value
                ((PasswordEntryControl) d).LabelColumnDefinition.Width = (GridLength)e.NewValue;
            }
            catch (Exception ex)
            {
                Debugger.Break();

                ((PasswordEntryControl) d).LabelColumnDefinition.Width = GridLength.Auto;
            }
        }

        private void CurrentPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is PasswordEntryViewModel viewModel)
                viewModel.CurrentPassword = CurrentPassword.SecurePassword;
        }

        private void NewPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is PasswordEntryViewModel viewModel)
                viewModel.NewPassword = NewPassword.SecurePassword;
        }

        private void ConfirmPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is PasswordEntryViewModel viewModel)
                viewModel.ConfirmPassword = ConfirmPassword.SecurePassword;
        }
    }
}
