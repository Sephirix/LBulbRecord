using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LBulbRecord.Models;

namespace LBulbRecord.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {
        public Record Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new Record
            {

                dateCompleted = DateTime.Now,
                dining = 0,
                kitchen = 0,
                hallway = 0,
                storage = 0,
                bedroom = 0,
                totalSurrendered =0,
                personnel="Vince",
                remarks = "all led",
                washroom =0,
                totalInstalled =0,
                totalRemoved=0,
                unitNumber = "0101"


            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddsItem", Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}