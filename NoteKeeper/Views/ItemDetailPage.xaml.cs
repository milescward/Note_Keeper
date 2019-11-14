using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using NoteKeeper.Models;
using NoteKeeper.ViewModels;
using System.Collections.Generic;
using NoteKeeper.Services;

namespace NoteKeeper.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            this.viewModel = viewModel;
            BindingContext = this.viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
        }

        public void Cancel_Clicked(Object sender, EventArgs eventArgs)
        {
            viewModel.NoteHeading = "XXXXXXX";
            DisplayAlert("Cancel option", "heading value is " + viewModel.Note.Heading, "B2", "B1" );
        }

        public void Save_Clicked(Object sender, EventArgs eventArgs)
        {
            DisplayAlert("Save option", "Save?", "Button2", "Button1");
        }

    }
}