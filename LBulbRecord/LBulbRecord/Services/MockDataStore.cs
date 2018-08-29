using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LBulbRecord.Models;

namespace LBulbRecord.Services
{
    //public class MockDataStore : IDataStore<Item>
    //{
    //    List<Item> items;

    //    public MockDataStore()
    //    {
    //        items = new List<Item>();
    //        var mockItems = new List<Item>
    //        {
    //            new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
    //            new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
    //            new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
    //            new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
    //            new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
    //            new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." },
    //        };

    //        foreach (var item in mockItems)
    //        {
    //            items.Add(item);
    //        }
    //    }

    //    public async Task<bool> AddItemAsync(Item item)
    //    {
    //        items.Add(item);

    //        return await Task.FromResult(true);
    //    }

    //    public async Task<bool> UpdateItemAsync(Item item)
    //    {
    //        var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
    //        items.Remove(oldItem);
    //        items.Add(item);

    //        return await Task.FromResult(true);
    //    }

    //    public async Task<bool> DeleteItemAsync(string id)
    //    {
    //        var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
    //        items.Remove(oldItem);

    //        return await Task.FromResult(true);
    //    }

    //    public async Task<Item> GetItemAsync(string id)
    //    {
    //        return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
    //    }

    //    public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
    //    {
    //        return await Task.FromResult(items);
    //    }
    //}

    
    public class MockRecords : IDataStore<Record>
    {
        List<Record> records;
        public MockRecords()
        {
            records = new List<Record>();
            var mockItems = new List<Record>
           {
                new Record { Id = Guid.NewGuid().ToString(),dateCompleted = DateTime.Now,
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
                unitNumber = "0101"},
                new Record { Id = Guid.NewGuid().ToString(),dateCompleted = DateTime.Now,
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
                unitNumber = "0102"},
                new Record { Id = Guid.NewGuid().ToString(),dateCompleted = DateTime.Now,
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
                unitNumber = "0103"},
    //            new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
    //            new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
    //            new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
    //            new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
    //            new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
    //            new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." },
        };

            foreach (var item in mockItems)
            {
                records.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Record item)
        {
            records.Add(item);

            return await Task.FromResult(true);
        }

         public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = records.Where((Record arg) => arg.Id.ToString() == id).FirstOrDefault();
            records.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Record> GetItemAsync(string id)
        {
            var _id = Int32.Parse(id);
            return await Task.FromResult(records.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Record>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(records);
        }

        public async Task<bool> UpdateItemAsync(Record item)
        {
            var oldItem = records.Where((Record arg) => arg.Id == item.Id).FirstOrDefault();
            records.Remove(oldItem);
            records.Add(item);

            return await Task.FromResult(true);
        }
    }
}