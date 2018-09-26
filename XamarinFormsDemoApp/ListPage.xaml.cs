using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsDemoApp
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            var names = new List<string>
            {
                "Bhaskar",
                "Mosh",
                "John",
                "Peter",
                "Ruby"
            };

            listView.ItemsSource = names;
        }
    }
}
