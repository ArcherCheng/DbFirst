using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class OrderTypes
    {
        public int Id { get; set; }
        public string OrderType { get; set; }
        public string TypeColor { get; set; }
        public byte TypePrice { get; set; }
        public int SortOrder { get; set; }
        public bool IsOnOff { get; set; }
        public int ComId { get; set; }
        public int WriteUserId { get; set; }
        public int WriteType { get; set; }
        public DateTime WriteTime { get; set; }
        public string WriteIp { get; set; }
    }
}
