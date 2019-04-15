using System;

namespace Quiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            string name;
            int age;
            int daysPerWeek;
            int startMonth;
            double rate;
            string EXIT = "EXIT";
            string sentinal;
            
            double[ , ] PRICE_CHART = {
                                        {30.00, 60.00, 88.00, 115.00, 140.00},
                                        {26.00, 52.00, 70.00, 96.00, 120.00},
                                        {24.00, 46.00, 67.00, 89.00, 110.00},
                                        {22.00, 40.00, 60.00, 75.00, 88.00},
                                        {20.00, 35.00, 50.00, 66.00, 84.00}
                                        };
            string [] monthName = {"Jan", "Feb.", "Mar.", "Apr.", "May", "Jun.", "Jul.", "Aug.", "Sep.", "Oct.", "Nov.", "Dec."};
            int [] monthCount = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            double [] monthTotal = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        //Setting Primer
        System.Console.WriteLine("Thank you for visiting World Family Daycare. To enter the program, please type 'ENTER'");
        sentinal = Console.ReadLine();

        while(sentinal != EXIT){

            System.Console.WriteLine("Please enter your childs name");
            name = Console.ReadLine();

            System.Console.WriteLine($"Please enter the number of the start month {name} will be attending 1-12");
            startMonth = Convert.ToInt32(Console.ReadLine());

            //Defencive for month 1-12
            while (startMonth < 1 || startMonth > 12){
                System.Console.WriteLine("You have entered an invalad number. Please typer a number between 1-12");
                startMonth = Convert.ToInt32(Console.ReadLine());
            }
            startMonth = startMonth - 1;

            System.Console.WriteLine($"Please enter the age of {name} between 0-4. 4 indicates 4 or older");
            age = Convert.ToInt32(Console.ReadLine());

            //Defencive for age to be 0-4
            while(age < 0 || age > 4){
                System.Console.WriteLine("You have entered an invalad age. Please type an age between 0-4");
                 age = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine($"Please enter the amount of Days per Week between {name} will be attending. 1-5");
            daysPerWeek = Convert.ToInt32(Console.ReadLine());

            //Defencive for days per week 1-5
            while(daysPerWeek < 1 || daysPerWeek > 5){
                System.Console.WriteLine("You have entered an invalad number. Please type a number between 1-5");
                daysPerWeek = Convert.ToInt32(Console.ReadLine());
            }
            daysPerWeek = daysPerWeek - 1;

            monthCount[startMonth] = monthCount[startMonth] + 1;
            rate = PRICE_CHART[age, daysPerWeek];
            monthTotal[startMonth] = monthTotal[startMonth] + rate;

            System.Console.WriteLine($"You total for {name}, is ${rate} starting in the month of {monthName[startMonth]}. ");
            System.Console.WriteLine("To continue, please type 'CONT'. To exit, please type 'EXIT'");
            sentinal = Console.ReadLine();
        }//end of while primer loop

        for(int i = 0; i < monthCount.Length; i++){
            System.Console.WriteLine("The total count of students per month:");
            System.Console.WriteLine($"{monthName[i]}: {monthCount[i]}");
            System.Console.WriteLine("The total sum of money per Month");
            System.Console.WriteLine($"{monthName[i]}: ${monthTotal[i]}");
        }
        System.Console.WriteLine("END");
                   
        }
    }
}
