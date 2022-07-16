namespace allYouCanEat
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Hello! Welcome to our Buffet. We're serving all you can eat meals for $9.99.\n Water is free but if you would like to add any soda or coffee,we do charge seperately.\n");
            Console.WriteLine("Due to staffing, without a reservation, we can take parties of six or lower.\n How many do you have today?");

            int numberOfGuests = Convert.ToInt32(Console.ReadLine());
            double buffetPrice = numberOfGuests * 9.99;
            double TotalBill = 0;

            if (numberOfGuests <= 6)
            {
                Console.WriteLine("Wonderful, we have a table available for " + numberOfGuests + " of you immediately. Please, follow me to be seated!");
                Console.WriteLine("Before you head over to the buffet, let's get everyone started with some drinks!");
            }
            else if (numberOfGuests > 6)
            {
                Console.WriteLine("Unfortunately, without a reservation, we will not be able to accomodate a party that large. Have a peaceful day.");
                return;
            }

            string[] drinkChoice = { "Soda", "Coffee", "Water" };
            string drinkOrder = "";

            double[] guestDrinkOrder = { 2.99, 3.99, 0 };
            int totalNumberOfWater = 0;
            int totalNumberOfSodas = 0;
            int totalNumberOfCoffees = 0;
       
            int index = 0;

            while ( index < numberOfGuests)
            {
                index++;

                Console.WriteLine(" Person number " + index + " , what can I get for you? Soda, Coffee, or Water?");
                drinkOrder = Console.ReadLine();

                if (drinkOrder == drinkChoice[0])
                {
                    Console.WriteLine(drinkChoice[0] + " coming right up!");
                    TotalBill += guestDrinkOrder[0];
                    totalNumberOfSodas++;
                }
                else if (drinkOrder == drinkChoice[1])
                {
                    Console.WriteLine(drinkChoice[1] + " coming right up!");
                    TotalBill += guestDrinkOrder[1];
                    totalNumberOfCoffees ++;
                }
                else if (drinkOrder == drinkChoice[2])
                {
                    Console.WriteLine(drinkChoice[2] + "coming right up!");
                    TotalBill += guestDrinkOrder[2];
                    totalNumberOfWater++;
                }
                else 
                {
                    Console.WriteLine("I'm sorry, we don't offer that.");
                    index--;
                }
            }
            Console.WriteLine(" \n\n When everyone is finished, ill be back with the bill.\n...\n...\n... ");
            
            Console.WriteLine(" \n\n Now that everyone has finished, there were " + totalNumberOfSodas + " soda(s) ordered.");
            Console.WriteLine(" there were " + totalNumberOfCoffees + " coffee(s) ordered.");
            Console.WriteLine(" there were " + totalNumberOfWater + " water(s) ordered.");
            Console.WriteLine(" and there were a total of " + numberOfGuests + " meals ordered\n...adding up to " + buffetPrice + " for food.");

            TotalBill += buffetPrice;
            Console.WriteLine(" This brings the total bill to " + TotalBill + " \nHow would you like to pay?");





        }


    }
}

