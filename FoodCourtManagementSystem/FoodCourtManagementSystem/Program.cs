using System;

namespace FoodCourtManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManageFoodItems manageFoodItemsObj = new ManageFoodItems();
            manageFoodItemsObj.Editing();
            Console.Read();
        }
    }
}
