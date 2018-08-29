using System;

using LBulbRecord.Models;

namespace LBulbRecord.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Record Item { get; set; }
        public ItemDetailViewModel(Record item = null)
        {
            Title = item?.personnel;
            Item = item;
        }
    }
}
