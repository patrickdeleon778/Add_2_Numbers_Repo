bool playAgain = true;
//bool validResponse1 = true;

//bool validResponse2 = true;
bool playAgainResponse = true;

bool isNum1;
bool isNum2;

string? userAnswer;
string input1;
string input2;

int num1;
//int num1Again;
int num2;

    while(playAgain == true)
    {   
        //validResponse1 = true;
            playAgainResponse = true;

            Console.Write("Input 1st number: ");

            do
            {
                input1 = Console.ReadLine();
                isNum1 = int.TryParse(input1, out num1);
                
                if(isNum1 != true)
                {
                    Console.Write("Please Enter a NUMBER: ");
                }
            }
            while(isNum1 != true);

            Console.Write("Input 2nd number: ");

            do
            {
                input2 = Console.ReadLine();
                isNum2 = int.TryParse(input2, out num2);

                if(isNum2 != true)
                {
                    Console.Write("PLEASE JUST ENTER A NUMBER: ");
                }
            }
            while(isNum2 != true);

            Console.WriteLine($"Your result is: {num1 + num2}");
        //     while(isNum1 == true)
        //     {
        //         if(isNum1 == true)
        //         {
        //             validResponse1 = false;
        //             playAgain = true;
        //             //int num1Again = num1;
        //         }
        //         else if(isNum1 == false)
        //         {
        //             Console.WriteLine("Please Enter a NUMBER!");
        //             validResponse1 = true;
        //             playAgain = true;
        //             isNum1 = false;
        //         }
        //     }

        //     Console.Write("Input 2nd number: ");

        //     input2 = Console.ReadLine();
        //     isNum2 = int.TryParse(input2, out num2);

        //     if(isNum2 == true)
        //     {
        //         validResponse1 = false;
        //         playAgain = true;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Please Enter a NUMBER!");
        //         validResponse1 = true;
        //         playAgain = true;
        //     }
        //     Console.WriteLine($"Your result is: {num1 + num2}");
        // }

        //validResponse2 = true;

        // while(validResponse2 == true)
        // {

        //     Console.Write("Input 2nd number: ");

        //     input2 = Console.ReadLine();
        //     isNum2 = int.TryParse(input2, out num2);

        //     if(isNum2 == true)
        //     {
        //         validResponse2 = false;
        //         playAgain = true;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Please Enter a NUMBER!");
        //         validResponse2 = true;
        //         playAgain = true;
        //     }
        // }
            //Console.WriteLine($"Your result is: {num1 + num2}");
            
            while(playAgainResponse == true)
            {
                Console.Write("Do you want to run the program again? (Y/N): "); // console asks if the user wants to run the program again

                userAnswer = Console.ReadLine().ToUpper();

                if(userAnswer == "Y")
                {
                    playAgain = true;
                    playAgainResponse = false;
                }
                else if(userAnswer == "N")
                {
                    playAgain = false;
                    playAgainResponse = false;
                }
                else
                {   
                    playAgain = false;
                    playAgainResponse = true;
                    Console.WriteLine(userAnswer + " isn't a valid response. Please Enter an actual valid response please.");
                }
            //int userNum2 = Convert.ToInt32(Console.ReadLine());
            }//Console.WriteLine($"Your result is: {userNum1 + userNum2}");
            //Console.WriteLine("Your result is " + (num2) + ".");
        //Console.WriteLine($"Your result is: {num1 + num2}");
    }