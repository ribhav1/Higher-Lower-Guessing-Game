var rand = new Random();

bool playing = true;

Console.WriteLine("Welcome to the higher or lower game\r\n");
Console.WriteLine("A random number in a range of values of your choosing will be generated");
Console.WriteLine("You will be given a certain amount of guessed of your choosing to get the number");
Console.WriteLine("After each guess, you will be told if your guess was higher or lower than the actual number\r\n");


while (playing)
{
    Console.WriteLine("Enter your settings\r\n");

    Console.Write("Enter the maximum value that can be generated: ");
    int max_rand_val = int.Parse(Console.ReadLine());

    Console.Write("Enter the number of guesses you would like: ");
    int max_guesses = int.Parse(Console.ReadLine());

    int correct_guess_val = rand.Next(max_rand_val + 1);


    Console.WriteLine($"You chose {max_rand_val} as your maximum value, and you have {max_guesses} guesses\r\n");

    int num_of_guesses = 0;

    while (true)
    {
        Console.WriteLine("Please enter a guess: ");
        int guess = int.Parse(Console.ReadLine());
        num_of_guesses++;

        if (guess < correct_guess_val)
        {
            Console.WriteLine("Your guess was too low");
        } 
        else if (guess > correct_guess_val)
        {
            Console.WriteLine("Your guess was too high");
        } 
        else if (guess == correct_guess_val)
        {
            Console.WriteLine("You guessed correctly");
            Console.WriteLine("Would you like to play again (enter yes or no)");
            string play_again = Console.ReadLine();
            if (play_again == "yes")
            {
                break;
            }
            else if
            (play_again == "no")
            {
                playing = false;
                break;
            }
        }

        if (num_of_guesses == max_guesses)
        {
            Console.WriteLine("You ran out of guesses");
            Console.WriteLine($"The correct number was {correct_guess_val}");
            Console.WriteLine("Would you like to play again (enter yes or no)");
            string play_again = Console.ReadLine();
            if (play_again == "yes")
            {
                break;
            }
            else if
            (play_again == "no")
            {
                playing = false;
                break;
            }
        }
    }
}
