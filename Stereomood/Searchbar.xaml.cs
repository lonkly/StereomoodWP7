﻿using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;

namespace TuneYourMood
{
    public partial class Searchbar
    {
        #region Delegates

        public delegate void searchPressedEventHandler(string textToSearch);

        #endregion

        #region Events

        public event searchPressedEventHandler searchPressed;

        #endregion

        private void onSearchPressed(string textToSearch)
        {
            if (searchPressed != null)
            {
                searchPressed(textToSearch);
            }
        }

        public Searchbar()
        {
            InitializeComponent();

            KeyUp += TextControl_KeyUp;
        }

        private void image1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            searchPressed(searchBox.Text);
        }

        private void TextControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                searchPressed(searchBox.Text);
            }
        }
    }
}