﻿// See https://aka.ms/new-console-template for more information
using ConsoleAppAssign;

Console.WriteLine("Hello, World!");
var prods = new SortedList<string, Products>();


       prods.Add("P1", new Products { PName = "shampoo", Price = 100, MfDate = new DateTime(2024, 2, 1), ExpDate = new DateTime(2024, 5, 1) });
       prods.Add("P2", new Products { PName = "soaps 2", Price = 200, MfDate = new DateTime(2024, 3, 1), ExpDate = new DateTime(2024, 5, 1) });
       prods.Add("P3", new Products { PName = "book 3", Price = 300, MfDate = new DateTime(2024, 4, 1), ExpDate = new DateTime(2024, 5, 1) });
       prods.Add("P4", new Products { PName = "pen 4", Price = 400, MfDate = new DateTime(2024, 5, 1), ExpDate = new DateTime(2024, 5, 1) });
       prods.Add("P5", new Products { PName = "dresses", Price = 500, MfDate = new DateTime(2024, 10, 1), ExpDate = new DateTime(2024, 5, 1) });
       prods.Add("P6", new Products { PName = "clothes", Price = 800, MfDate = new DateTime(2024, 7, 1), ExpDate = new DateTime(2024, 5, 1) });

 foreach (var product in prods.Values)

            {

                Console.WriteLine($"Index: {prods.IndexOfKey(product.PName)}");

                Console.WriteLine($"Name: {product.PName}");

                Console.WriteLine($"Price: {product.Price}");

                Console.WriteLine($"MfDate: {product.MfDate}");

                Console.WriteLine($"ExpDate: {product.ExpDate}");

                Console.WriteLine();

            }
  
