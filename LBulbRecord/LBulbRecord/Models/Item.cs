using System;
 
namespace LBulbRecord.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }

    public class Record
    {

        public string Id { get; set; }
        public string unitNumber { get; set; }
        public string personnel { get; set; }
        public DateTime dateCompleted { get; set; }
        public int totalInstalled { get; set; }
        public int totalRemoved { get; set; }
        public int totalSurrendered { get; set; }
        public int hallway { get; set; }
        public int kitchen { get; set; }
        public int dining { get; set; }
        public int bedroom { get; set; }
        public int washroom { get; set; }
        public int storage { get; set; }
        public string remarks { get; set; }
    }
}