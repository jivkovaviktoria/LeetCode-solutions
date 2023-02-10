using System;
using System.Collections.Generic;
using System.Linq;

namespace DisplayTableOfFoodOrdersInARestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IList<string>> orders = new List<IList<string>>()
            {
                new List<string>() { "David", "3", "Ceviche" },
                new List<string>() { "Corina", "10", "Beef Burrito" },
                new List<string>() { "David", "3", "Fried Chicken" },
                new List<string>() { "Carla", "5", "Water" },
                new List<string>() { "Carla", "5", "Ceviche" },
                new List<string>() { "Rous", "3", "Ceviche" }
            };

            foreach (var row in DisplayTable(orders))
                Console.WriteLine(string.Join(",", row));
            
            //Expected:
            // Table,Beef Burrito,Ceviche,Fried Chicken,Water
            // 3    ,0           ,2      ,1            ,0
            // 5    ,0           ,1      ,0            ,1
            // 10   ,1           ,0      ,0            ,0
        }
        
        //We use a dictionary with string key (table) and another Dictionary as a value which stores the foodItem(key) and the count
        //of this item. We have HashSet items so we can add every unique item and order them alphabeticaly for the result.
        //We loop though the orders and add each order.
        //We insert the first row of the result List (Table and then each item /order them alphabetically/).
        //Then we loop though each order and add the count for each foodItem
        
        public static IList<IList<string>> DisplayTable(IList<IList<string>> orders) {
            Dictionary<string, Dictionary<string, int>> ordersByTable = new Dictionary<string, Dictionary<string, int>>();
            HashSet<string> items = new HashSet<string>();
        
            foreach(var order in orders){
                var table = order[1];
                var item = order[2];
            
            
                if(ordersByTable.ContainsKey(table) == false){
                    ordersByTable.Add(table, new Dictionary<string, int>());
                }
            
                if(ordersByTable[table].ContainsKey(item) == false){
                    ordersByTable[table].Add(item, 0);
                }
            
                ordersByTable[table][item]++;
                items.Add(item);
            }
        
        
            List<IList<string>> ans = new List<IList<string>>();
        
            var row = new List<string>();
            row.Add("Table");
        
            var sorted = items.OrderBy(x => x, StringComparer.Ordinal);
        
            foreach(var item in sorted){
                row.Add(item);
            }
        
            ans.Add(row);
        
            foreach(var order in ordersByTable.OrderBy(x => int.Parse(x.Key))){
                var currentRow = new List<string>();
            
                currentRow.Add(order.Key);
            
                foreach(var item in sorted){
                    if(order.Value.ContainsKey(item)){
                        currentRow.Add(order.Value[item].ToString());
                    }
                    else{
                        currentRow.Add("0");
                    }
                }
            
                ans.Add(currentRow);
            }
        
            return ans;
        }
    }
}