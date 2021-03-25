using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Mikaela Eriksson mikerv-0 941012-2163 L0002B

namespace Inlupp2Console
{
    class Program
    {
        // The main entry poiny for the program
        static void Main(string[] args)
        {
            // Creates a list of sellers
            List<Seller> sellers = new List<Seller>();

            bool endApp = false;

            // Do the following when the app is running
            while (!endApp)
            {

                // First the user is asked how many sellers she want to register
                int s = intInput("How many sellers do you want to register?");

                // It has to be at least 1, otherwise the question is repeated
                if (s > 0)
                {
                    // Create a new seller
                    for (int i = 0; i < s; i++)
                    {
                        sellers.Add(sellerData());
                    }
                    // Categorize the seller data in the four levels
                    categorize(sellers);
                }
                else
                {
                    Console.WriteLine("Please write a valid input (only numbers, at least 1 seller)");
                }
                
                // The user gets the option to close the app, or continue register more sellers
                Console.Write("Press 'n' + Enter to close the app, or press whatever other key + Enter to continue register more sellers: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
        }

        //Function for sorting sellers and placing them in the right group
        static void categorize(List<Seller> sellers)
        {
            string FileWrite = ""; // The input data that should be written to the file
            sellers = bubblesort(sellers); // Sort the sellers with bubble sort

            Console.WriteLine("");

            // Create the four different selling levels and save as a dictionary
            Dictionary<List<int>, string> levels = new Dictionary<List<int>, string>();
            levels.Add(new List<int>() { 0, 49 }, "less than 50 items");
            levels.Add(new List<int>() { 50, 99 }, "50-99 items");
            levels.Add(new List<int>() { 100, 199 }, "100-199 items");
            levels.Add(new List<int>() { 200, 10000 }, "more than 199 items"); // Chose a high max value which will probably never be reached


            var numbers = levels.Keys; // The values included in that level
            int LatestSellers = 0; // No of sellers in the previous group
            int LatestIndex = 0; // The index of the previous group in 'numbers'

           
            // Loop through the sellers
            foreach (Seller n in sellers)
            {
                // Loop through levels
                for (int i = 0; i < numbers.Count; i++)
                {
                    List<int> list = numbers.ElementAt(i);
                    // If the seller should be in that level
                    if (n.itemsAmount >= list[0] && n.itemsAmount <= list[1])
                    {
                        if (i != LatestIndex)
                        {
                            if (LatestSellers > 0)
                            {
                                // Data that should be written to the file 
                                FileWrite += Printout(
                                    string.Format(
                                        "{0} seller(s) have reached level {1} : {2}\n",
                                        LatestSellers,
                                        LatestIndex + 1,
                                        levels[numbers.ElementAt(LatestIndex)]
                                        )
                                );
                                Console.WriteLine("");
                                // Update indexes
                                LatestIndex = i;
                                LatestSellers = 0;
                            }
                            else
                            {
                                // Update indexes based on which levels that contains sellers
                                LatestIndex = i;
                                LatestSellers = 0;
                            }
                        }
                        // Save and print seller info
                        LatestSellers += 1;
                        FileWrite += Printout(n.ToString());
                        Console.WriteLine("");
                    }
                }
            }
            FileWrite += Printout(string.Format("{0} seller(s) have reached level {1} : {2}\n",
                                        LatestSellers,
                                        LatestIndex + 1,
                                        levels[numbers.ElementAt(LatestIndex)]
                                        ));
            Console.WriteLine("");
            // Write all seller data to the file UserOutput.txt
            File.WriteAllText("UserOutput.txt", FileWrite);
        }


    // HELPING FUNCTIONS

        // Bubblesort function for sorting the list of sellers based on sold items, in increasing order
        static List<Seller> bubblesort(List<Seller> sellerList)
        {
            bool swopped = false; 
            for (int i = 0; i < sellerList.Count - 1; i++)
            {
                if (sellerList[i].itemsAmount > sellerList[i+1].itemsAmount)
                {
                    swopped = true;
                    Seller tempvar = sellerList[i];
                    sellerList[i] = sellerList[i + 1];
                    sellerList[i + 1] = tempvar;
                }
            }
            if (swopped) return bubblesort(sellerList);
            return sellerList;
        }

        // Checks for numeric input and return a value when the input is numeric 
        static int intInput(string msg)
        {
            try
            {
                return int.Parse(ReadLine(msg));
            }
            catch
            {
                // If the user types invalid input (not numbers)
                Console.WriteLine("Please write a valid input (only numbers)");
                return intInput(msg);
            }
        }

        // Returns the user input written to the console
        static string ReadLine(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        // Needed for e.g. FileWrite, returns the msg written to the console 
        static string Printout(string msg)
        {
          Console.WriteLine(msg);
          return msg;
        }


        // Creates a new seller with the requested data
        static Seller sellerData()
        {
            Console.WriteLine("");
            return
                new Seller(
                    // Asks for user input 
                    ReadLine("Name: "), intInput("Personal Number: "),
                    ReadLine("District: "), intInput("Number of items sold: ")
                    );
        }


    }
    
    class Seller
    {
            // The required data for each seller
            public string name;
            public int persNo;
            public string district;
            public int itemsAmount;

            // Constructor function
            public Seller (string Name, int PersNo, string District, int ItemsAmount)
            {
                name = Name;
                persNo = PersNo;
                district = District;
                itemsAmount = ItemsAmount;
            }

            // Format the output for seller data
            public override string ToString()
            {
                return string.Format("Name: {0}, \t Personal no: {1}, \t District: {2}, \t No of items: {3}, \t \n", name, persNo, district, itemsAmount);
            }
    }
}
