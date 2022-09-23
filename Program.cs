namespace Part6_Looping_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Snakeyes
            string choice = "";

            while (choice != "q")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear(); // Optional
                Console.WriteLine("Welcome to the looping problems menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Percent Passing");
                Console.WriteLine("3 - Odd Sum");
                Console.WriteLine("4 - Random Numbers");
                Console.WriteLine("5 - Dice Game");
                Console.WriteLine("...");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1"){
                    Console.WriteLine("You chose option 1 - Prompter");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Prompter();
                }
                else if (choice == "2"){
                    Console.WriteLine("You chose option 2 - Percent Passing");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    PercentPassing();
                }
                else if (choice == "3"){
                    Console.WriteLine("You chose option 3 - Odd Sum");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    OddSum();
                }
                else if (choice == "4"){
                    Console.WriteLine("You chose option 4 - Random Numbers");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    RandomNumbers();
                }
                else if (choice == "5"){
                    Console.WriteLine("You chose option 5 - Dice Game");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    GambleDice();
                }
                else if (choice == "q"){
                    Console.WriteLine("Goodbye");
                }
                else{
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
        public static void Prompter()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("Welcome to the prompter, please enter the minimum value: ");
            bool loop = Int32.TryParse(Console.ReadLine(), out int minValue);
            while (loop == false)
            {
                Console.WriteLine("You did not enter a valid value please re enter the min value: ");
                loop = Int32.TryParse(Console.ReadLine(), out minValue);
            }
            Console.WriteLine("Please enter the maximum value: ");
            loop = Int32.TryParse(Console.ReadLine(), out int maxValue);
            if (maxValue < minValue){
                loop = false;
            }
            while (loop == false)
            {
                Console.WriteLine("You did not enter a valid value please re enter the max value: ");
                loop = Int32.TryParse(Console.ReadLine(), out maxValue);
                if (maxValue < minValue){
                    loop = false;
                }
            }

            Console.WriteLine($"Please enter a value in the range of {minValue} and {maxValue}");
            loop = Int32.TryParse(Console.ReadLine(), out int userNumber);
            if (loop && (userNumber < minValue || userNumber > maxValue)){
                loop = false;
            }
            while (loop == false)
            {
                Console.WriteLine($"You did not enter a valid number please enter a value in the range of {minValue} and {maxValue}");
                loop = Int32.TryParse(Console.ReadLine(), out userNumber);
                if (loop && (userNumber < minValue || userNumber > maxValue)){
                    loop = false;
                }
            }
            Console.WriteLine("\nCongratulations, you have escaped from the prompter \npress enter to return to the main menu");
            Console.ReadLine();
        }
        public static void PercentPassing()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Welcome to percent passing, enter as many scores you want and we will calculate the average of how many are above 70%.");
            int average = 0; int count = 0; int score;
            Console.WriteLine("Please enter your first score.");
            bool loop = Int32.TryParse(Console.ReadLine(), out score);
            while (loop == false)
            {
                Console.WriteLine("Please re enter your first score.");
                loop = Int32.TryParse(Console.ReadLine(), out score);
            }
            if (score >= 70){
                average += 100; count++;
            }
            else{
                count++;
            }
            int tries = 2;
            for (int i = 1; i < tries; i++)
            {
                Console.WriteLine("Please enter  your next score or hit enter to calculate.");
                if (Int32.TryParse(Console.ReadLine(), out score)) {
                    if (score >= 70){
                        average += 100; count++;
                    }
                    else{
                        count++;
                    }
                    tries++;
                }
                
            }
            Console.WriteLine($"{average / count}% of the scores were above 70%");
            Console.ReadLine();
        }
        public static void OddSum()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Welcome to Odd Sum adder");
            Console.WriteLine("Please enter an Odd number and we will give you the sum of it + all odd numbers leading up to it.");
            bool loop = Int32.TryParse(Console.ReadLine(), out int oddNum);
            while (loop = false || oddNum % 2 == 0 || oddNum < 0)
            {
                Console.WriteLine("You have not entered a valid odd number");
                Console.WriteLine("Please enter a valid odd number");
                loop = Int32.TryParse(Console.ReadLine(), out oddNum);
            }
            int total = oddNum;
            for (int i = 1; i < oddNum; i += 2)
            {
                total += i;
            }
            Console.WriteLine($"Your odd sum is {total}");
            Console.ReadLine();
        }
        public static void RandomNumbers()
        {
            Console.BackgroundColor= ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine("Welcome to random number generator");
            Console.WriteLine("After you enter a min and max value we will give you 25 random numbers.");
            Console.WriteLine("Please enter the minimum value for the random numbers: ");
            bool loop = Int32.TryParse(Console.ReadLine(), out int minRandValue);
            while (loop == false)
            {
                Console.WriteLine("Please re enter the minimum value for the random numbers: ");
                loop = Int32.TryParse(Console.ReadLine(), out minRandValue);
            }
            Console.WriteLine("Please enter the maximum value: ");
            loop = Int32.TryParse(Console.ReadLine(), out int maxValue);
            if (maxValue < minRandValue){
                loop = false;
            }
            while (loop == false)
            {
                Console.WriteLine("You did not enter a valid value please re enter the max value: ");
                loop = Int32.TryParse(Console.ReadLine(), out maxValue);
                if (maxValue < minRandValue){
                    loop = false;
                }
            }
            int maxRandValue = maxValue + 1;
            Random rand = new Random();
            
            string stringToWrite = "";
            for (int i = 1; i <= 25; i++)
            {
                stringToWrite = stringToWrite+($"{rand.Next(minRandValue, maxRandValue)}, ");
            }
            stringToWrite = (stringToWrite.TrimEnd()).TrimEnd(',');
            Console.WriteLine($"Here are your 25 Random Numbers: {stringToWrite}");
            Console.ReadLine();
        }
        public static void GambleDice()
        {
            Random rand = new Random();
            double bankAcc = 100.00;
            bool continueToRun = true;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Welcome to Cheese Casino, the fair casino where you bet on dice rolls, please enjoy your stay.\n");

            while (continueToRun)
            {
                Console.WriteLine($"You currently have ${bankAcc} in your bank account. How much would you like to bet?");
                if (Double.TryParse(Console.ReadLine(), out double betAmount)){
                    if (betAmount < 0){
                        Console.WriteLine("Your bet is a negative number so we will just set it to 0 instead.");
                        betAmount = 0;
                    }
                    else if (betAmount > bankAcc){
                        Console.WriteLine($"You bet more money than your total bank account so we will just change it to ${bankAcc}");
                        betAmount = bankAcc;
                    }
                    int betNumber = 2;
                    bankAcc = bankAcc - betAmount;
                    Console.WriteLine("What would you like to bet on?");
                    Console.WriteLine("'Doubles' : Win double your bet");
                    Console.WriteLine("'Not Doubles' : Win half your bet");
                    Console.WriteLine("'Even Sum' : Win your bet");
                    Console.WriteLine("'Odd Sum' : Win your bet");
                    Console.WriteLine("'Specific' : Specify a number and if you succeed get triple your bet");
                    string betType = Console.ReadLine().ToLower().Trim();
                    betType = betType.Replace(" ", "");
                    if (betType == "specific"){
                        Console.WriteLine("What number would you like to bet on from 2-12");
                        Int32.TryParse(Console.ReadLine(), out betNumber);
                        while (betNumber <= 1 || betNumber > 12){
                            Console.WriteLine("You did not bet a valid number please pick from 2-12");
                            Int32.TryParse(Console.ReadLine(), out betNumber);
                        }
                    }
                    else if (betType != "oddsum" && betType != "notdoubles" && betType != "evensum" && betType != "doubles"){
                        bool loop = false;
                        while (loop == false)
                        {
                            Console.WriteLine("You did not enter a valid option please choose again");
                            betType = Console.ReadLine().ToLower();
                            betType = betType.Replace(" ", "");
                            if (betType == "specific"){
                                Console.WriteLine("What number would you like to bet on from 2-12");
                                Int32.TryParse(Console.ReadLine(), out betNumber);
                                while (betNumber <= 1 || betNumber > 12)
                                {
                                    Console.WriteLine("You did not bet a valid number please pick from 2-12");
                                    Int32.TryParse(Console.ReadLine(), out betNumber);
                                }
                                loop = true;
                            }
                            else if (betType == "oddsum" || betType == "notdoubles" || betType == "evensum" || betType == "doubles"){
                                loop = true;
                            }
                        }
                    }

                    //Below code is an ascii art for rolling dice.
                    Console.WriteLine("  ____\r\n /\\' .\\    _____\r\n/: \\___\\  / .  /\\\r\n\\' / . / /____/..\\\r\n \\/___/  \\'  '\\  /\r\n          \\'__'\\/");
                    int dice1 = rand.Next(1, 7); int dice2 = rand.Next(1, 7);
                    int y = Console.CursorTop; int x = Console.CursorLeft;
                    DiceDrawing(dice1);
                    Console.SetCursorPosition(x+8, y);
                    DiceDrawing(dice2);
                    Console.WriteLine($"\n {dice1} + {dice2} = {dice1+dice2}");
                    Console.WriteLine("\n");
                    int diceSum = dice1 + dice2;
                    if (betType == "doubles" && dice1 == dice2){
                        betAmount = betAmount * 3;
                        bankAcc += betAmount;

                        Console.WriteLine($"You bet Doubles and won double your bet, your current balance is: ${bankAcc}");
                    }
                    else if (betType == "evensum" && diceSum % 2 == 0){
                        betAmount = betAmount * 2;
                        bankAcc += betAmount;

                        Console.WriteLine($"You bet Even Sum and won your bet, your current balance is: ${bankAcc}");
                    }
                    else if (betType == "oddsum" && diceSum % 2 != 0){
                        betAmount = betAmount * 2;
                        bankAcc += betAmount;

                        Console.WriteLine($"You bet Odd Sum and won your bet, your current balance is: ${bankAcc}");
                    }
                    else if (betType == "notdoubles" && dice1 != dice2){
                        betAmount = betAmount * 1.5;
                        bankAcc += betAmount;

                        Console.WriteLine($"You bet Not Doubles and won your bet, your current balance is: ${bankAcc}");
                    }
                    else if (betType == "specific" && betNumber == diceSum){
                        betAmount = betAmount * 4;
                        bankAcc += betAmount;
                        Console.WriteLine($"You bet Specific and won your bet, your current balance is: ${bankAcc}");
                    }
                    else{
                        Console.WriteLine($"You lost your bet, your current balance is: ${bankAcc}");
                    }

                }
                else{
                    Console.WriteLine("Error this is not a numeric ammount to bet");
                }
                if (bankAcc == 0){
                    Console.WriteLine("You went bankrupt so we are kicking you out.");
                    continueToRun = false;
                    Console.ReadLine();
                }
                else{
                    Console.WriteLine("Would you like to play again? 'Y' or 'N'");

                    string continueQuestion = Console.ReadLine();
                    continueQuestion = continueQuestion.ToUpper().Trim();
                    if (continueQuestion == "Y"){
                        Console.Clear();
                    }
                    else{
                        continueToRun = false;
                    }
                }


            }

        }
        public static void DiceDrawing(int dice)
        {
            int y = Console.CursorTop; int x = Console.CursorLeft;
            if (dice == 1)
            {
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|   |");
                Console.SetCursorPosition(x, y + 3); Console.Write("| o |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|   |");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 2)
            {
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o  |");
                Console.SetCursorPosition(x, y + 3); Console.Write("|   |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|  o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 3)
            {
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o  |");
                Console.SetCursorPosition(x, y + 3); Console.Write("| o |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|  o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 4)
            {
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 3); Console.Write("|   |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 5)
            {
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 3); Console.Write("| o |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 6)
            {
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 3); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 4); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }

        }
    }
}