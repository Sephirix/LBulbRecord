using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LBulbRecord.Models;
using LBulbRecord.ViewModels;

namespace LBulbRecord.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel sd)
        {
            InitializeComponent();

            BindingContext = this.viewModel = sd;
            
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Record
            {
                Id = Guid.NewGuid().ToString(),
                dateCompleted = DateTime.Now,
                dining = 0,
                kitchen = 0,
                hallway = 0,
                storage = 0,
                bedroom = 0,
                totalSurrendered = 0,
                personnel = "Vince",
                remarks = "all led",
                washroom = 0,
                totalInstalled = 0,
                totalRemoved = 0,
                unitNumber = "0101"
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}