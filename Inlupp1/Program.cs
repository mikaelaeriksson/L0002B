// L0002B Inl 1
// Mikaela Eriksson
// Username: mikerv-0

using System;

namespace Inlupp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            // Do the following when the app is running
            while (!endApp)
            {
                // Ask for user input (price)
                Console.Write("Ange pris: ");
                // Convert the input to integer
                int pris = Convert.ToInt32(Console.ReadLine());
                // Ask for user input (paid)
                Console.Write("Betalt: ");
                // Convert the input to integer
                int betalt = Convert.ToInt32(Console.ReadLine());
                // Calculate total change
                int vaxel = betalt - pris;

                // If not paid enough
                if (betalt < pris)
                {
                    Console.Write("Du har betalat för lite. Det saknas " + (vaxel * -1) + " kr!");
                    Console.ReadLine();
                }
                // If paid right amount
                else if (betalt == pris)
                {
                    Console.Write("Tack, du har betalat rätt summa!");
                    Console.ReadLine();
                }
                // If paid too much
                else
                {
                    // Output the total change
                    Console.Write("Växel tillbaka: " + vaxel + " kr\n");

                    int femhundra, hundra, femtio, tjugo, tio, fem, ett;


                    while (vaxel >= 500)
                    {
                        //Räknar antalet 500-lappar, skriver ut om denna valör är aktuell (samma sak med resterande valörer nedan)
                        femhundra = vaxel / 500;
                        vaxel = vaxel % 500;
                        Console.Write(femhundra + " Femhundralappar\n");
                    }

                    while (vaxel >= 100)
                    {
                        //Räknar antalet 100-lappar
                        hundra = vaxel / 100;
                        vaxel = vaxel % 100;
                        Console.Write(hundra + " Hundralappar\n");
                    }
                    while (vaxel >= 50)
                    {
                        //Räknar antalet 50-lappar
                        femtio = vaxel / 50;
                        vaxel = vaxel % 50;
                        Console.Write(femtio + " Femtiolappar\n");
                    }
                    while (vaxel >= 20)
                    {
                        //Räknar antalet 20-lappar
                        tjugo = vaxel / 20;
                        vaxel = vaxel % 20;
                        Console.Write(tjugo + " Tjugolappar\n");
                    }
                    while (vaxel >= 10)
                    {
                        //Räknar antalet 10-kronor
                        tio = vaxel / 10;
                        vaxel = vaxel % 10;
                        Console.Write(tio + " Tiokronor\n");
                    }
                    while (vaxel >= 5)
                    {
                        //Räknar antalet 5-kronor
                        fem = vaxel / 5;
                        vaxel = vaxel % 5;
                        Console.Write(fem + " Femkronor\n");
                    }
                    while (vaxel >= 1)
                    {
                        //Räknar antalet 1-kronor
                        ett = vaxel / 1;
                        vaxel = vaxel % 1;
                        Console.Write(ett + " Enkronor\n");
                    }
                    Console.ReadLine();
                }

                    // The user gets the option to close the app, or continue with entering new amounts
                    Console.Write("Tryck på 'n' + Enter för att stänga appen, eller tryck på valfri annan tangent + Enter för att fortsätta: ");
                    if (Console.ReadLine() == "n") endApp = true;

                    Console.WriteLine("\n");
                
            }
        }
    }
}
