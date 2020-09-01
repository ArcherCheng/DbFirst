using System;
using System.Linq;
using System.Threading.Tasks;
using DbFirst.FoodPos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace DbFirst
{
    class Program
    {
        public static void Main(string[] args = null)
        {
            Console.WriteLine("begin Main");
            GetMaxTakeNo();
        }

        public static void GetMaxTakeNo() 
        {
            var db = new AppDbContext();
            // var today = System.DateTime.Now.AddDays(-30);
            var today = System.DateTime.Today;
            var orderType = "內用";

            var order = db.OrderMaster
            .Where(x => x.OrderDate.Date == today.Date && x.OrderType == orderType)
            .Select(x => (int?)x.TakeNo)
            .Max();

            if (order == null)
                order = 0;
            else
                order = (int?)order + 1;

            Console.WriteLine($"TakeNo = {order}");
            // Console.WriteLine($"orderDate = {order.OrderDate}");

            var result = db.Food.Find(1);
            Console.WriteLine(result.FoodName);

            Console.ReadLine();
        }

    }

}
