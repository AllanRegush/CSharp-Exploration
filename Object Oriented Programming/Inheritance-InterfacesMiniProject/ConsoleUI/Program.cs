using System;
using System.Collections.Generic;
using ConsoleUI.Interfaces;
using ConsoleUI.Models;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var purchasables = new List<IPurchasable>();
            var rentables = new List<IRentable>();

            var beachBall = new BeachBallModel
            {
                ProductName = "Super Beach Ball 30",
                NumberInStock = 10
            };

            var sunScreen = new SunScreenModel
            {
                ProductName = "Super Sunscreen SPF 9000",
                NumberInStock = 30
            };

            var surfBoard = new SurfBoardModel
            {
                ProductName = "Surf Board",
                NumberInStock = 1
            };

            purchasables.Add(beachBall);
            purchasables.Add(sunScreen);

            rentables.Add(beachBall);
            rentables.Add(surfBoard);

            Console.WriteLine("Do you want to Rent or Purchase? (rent/purchase)");
            string response = Console.ReadLine();
            if (response.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Item : {item.ProductName}, In Stock: {item.NumberInStock}");
                    Console.WriteLine("Rent this Item? (yes/no)");
                    string wantToRent = Console.ReadLine();
                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }
                    Console.WriteLine("Return this Item? (yes/no)");
                    string wantToReturn = Console.ReadLine();
                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnItem();
                    }
                }
                Console.WriteLine("Have A Good Day!");
            }
            else
            {
                foreach (var item in purchasables)
                {
                    Console.WriteLine($"Item : {item.ProductName}, In Stock: {item.NumberInStock}");
                    Console.WriteLine("Purchase this Item? (yes/no)");
                    string wantToPurchase = Console.ReadLine();
                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }
                Console.WriteLine("Have A Good Day!");
            }
            Console.ReadLine();
        }
    }
}
