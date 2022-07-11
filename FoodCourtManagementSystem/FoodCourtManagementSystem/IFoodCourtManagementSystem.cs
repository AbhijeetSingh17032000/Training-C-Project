using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FoodCourtManagementSystem
{
    public class Food
    {
        public string name { get; set; }
        public int Id { get; set; }
        public string type { get; set; }
        public string description { get; set; }
    }
    internal interface IFoodCourtManagementSystem
    {
        void Adding();
        void Editing();
        void Viewing();
        void Listing();
    }
    public class ManageFoodItems : IFoodCourtManagementSystem
    {
        public void Adding()
        {
            if(File.Exists(@"C:\Users\abhijeetsingh9\Downloads\DotNet Project\Training\FoodItems.txt"))
            {
                FileStream fileStreamObj = new FileStream(@"C:\Users\abhijeetsingh9\Downloads\DotNet Project\Training\FoodItems.txt", FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStreamObj);
                var food = new Food
                {
                    Id = Convert.ToInt32(Console.ReadLine()),
                    name = Console.ReadLine(),
                    type = Console.ReadLine(),
                    description = Console.ReadLine()
                };
                streamWriter.WriteLine("Food Id:" + food.Id);
                streamWriter.WriteLine("Food Name:" + food.name);
                streamWriter.WriteLine("Food Type:" + food.type);
                streamWriter.WriteLine("Food Description:" + food.description);
                streamWriter.Close();   
                fileStreamObj.Close();
                Console.WriteLine("File Operation Completed.");
            }
            else
            {
                FileStream fileStreamObj = new FileStream(@"C:\Users\abhijeetsingh9\Downloads\DotNet Project\Training\FoodItems.txt", FileMode.Create, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStreamObj);
                var food = new Food
                {
                    Id = Convert.ToInt32(Console.ReadLine()),
                    name = Console.ReadLine(),
                    type = Console.ReadLine(),
                    description = Console.ReadLine()
                };
                streamWriter.WriteLine("Food Id:" + food.Id);
                streamWriter.WriteLine("Food Name:" + food.name);
                streamWriter.WriteLine("Food Type:" + food.type);
                streamWriter.WriteLine("Food Description:" + food.description);
                streamWriter.Close();
                fileStreamObj.Close();
                Console.WriteLine("File Operation Completed.");
            }
        }

        public void Editing()
        {
            Dictionary<int, Food> dictFoodList = new Dictionary<int, Food>();
            Food food = null;
            FileStream fileStream = new FileStream(@"C:\Users\abhijeetsingh9\Downloads\DotNet Project\Training\FoodItems.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStream);

            while (streamReaderObj.Peek() > 0)
            {
                food = new Food();
                string line = streamReaderObj.ReadLine();
                string[] myStrs = line.Split(':');
                food.Id = Convert.ToInt32(myStrs[1]);

                line = streamReaderObj.ReadLine();
                myStrs = line.Split(':');
                food.name = myStrs[1];

                line = streamReaderObj.ReadLine();
                myStrs = line.Split(':');
                food.type = myStrs[1];

                line = streamReaderObj.ReadLine();
                myStrs = line.Split(':');
                food.description = myStrs[1];

                dictFoodList.Add(food.Id, food);

            }
            Console.WriteLine("Enter the Food ID you want to edit:");
            int a = Convert.ToInt32(Console.ReadLine());

            foreach (var item in dictFoodList)
            {
                if (item.Key == a)
                {
                    item.Value.Id = Convert.ToInt32(a);
                    Console.WriteLine("Food Name: ");
                    item.Value.name = Console.ReadLine();
                    Console.WriteLine("Food Type: ");
                    item.Value.type = Console.ReadLine();
                    Console.WriteLine("Food Description: ");
                    item.Value.description = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The Food ID you entered is not there in the Food Database.");
                }
            }
            fileStream.Close();
            streamReaderObj.Close();
            FileStream fileStreamObj = new FileStream(@"C:\Users\abhijeetsingh9\Downloads\DotNet Project\Training\FoodItems.txt", FileMode.Create, FileAccess.Write);
            
            StreamWriter streamWriter = new StreamWriter(fileStreamObj);

            foreach (var item in dictFoodList)
            {

                streamWriter.WriteLine("Food Id: " + item.Value.Id);
                streamWriter.WriteLine("Food Name: " + item.Value.name);
                streamWriter.WriteLine("Food Type: " + item.Value.type);
                streamWriter.WriteLine("Food Description: " + item.Value.description);
            }
            streamWriter.Close();
            fileStreamObj.Close();
        }

        public void Listing()
        {
            if (File.Exists(@"C:\Users\abhijeetsingh9\Downloads\DotNet Project\Training\FoodItems.txt"))
            {
                FileStream fileStream = new FileStream(@"C:\Users\abhijeetsingh9\Downloads\DotNet Project\Training\FoodItems.txt", FileMode.Open, FileAccess.Read);
                StreamReader streamReaderObj = new StreamReader(fileStream);
                while (streamReaderObj.Peek() > 0)
                {
                    string line = streamReaderObj.ReadLine();
                    string[] myStrs = line.Split(':');
                    Console.WriteLine(myStrs[1]);
                }
                fileStream.Close();
                Console.WriteLine("File Operation Completed.");
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
        }
        public void Viewing()
        {
            Dictionary<int, Food> dictFoodList = new Dictionary<int, Food>();
            Food food=null;
            FileStream fileStream = new FileStream(@"C:\Users\abhijeetsingh9\Downloads\DotNet Project\Training\FoodItems.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStream);

            while (streamReaderObj.Peek() > 0)
            {
                food = new Food();
                string line = streamReaderObj.ReadLine();
                    string[] myStrs = line.Split(':');
                    food.Id=Convert.ToInt32(myStrs[1]);

                    line = streamReaderObj.ReadLine();
                    myStrs = line.Split(':');
                    food.name = myStrs[1];

                    line = streamReaderObj.ReadLine();
                    myStrs = line.Split(':');
                    food.type = myStrs[1];

                    line = streamReaderObj.ReadLine();
                    myStrs = line.Split(':');
                    food.description = myStrs[1];

                    dictFoodList.Add(food.Id, food);
                
            }
            Console.WriteLine("Enter the Food ID you want to access:");
            int a = Convert.ToInt32(Console.ReadLine());

            foreach (var item in dictFoodList)
            {
                if (item.Key == a)
                {

                    Console.WriteLine("Food Id: " + item.Value.Id);
                    Console.WriteLine("Food Name: " + item.Value.name);
                    Console.WriteLine("Food Type: " + item.Value.type);
                    Console.WriteLine("Food Description: " + item.Value.description);
                }
                else
                {
                    Console.WriteLine("The Food ID you entered is not there in the Food Database.");
                }
            }
            streamReaderObj.Close();
            fileStream.Close();
        }

    }
}
