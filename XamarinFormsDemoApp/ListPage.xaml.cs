using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinFormsDemoApp.Model;

namespace XamarinFormsDemoApp
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            Contact contacts = new Contact();
            listView.ItemsSource = contacts.GetContacts();
        }
    }
}
