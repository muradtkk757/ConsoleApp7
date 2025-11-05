Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.Write("1-ci oyunçunun seçimi (rock/paper/scissors): ");
    string player1 = Console.ReadLine().ToLower().Trim();

    Console.Write("2-ci oyunçunun seçimi (rock/paper/scissors): ");
    string player2 = Console.ReadLine().ToLower().Trim();

    string result = RockPaperScissors(player1, player2);
    Console.WriteLine(result);

string RockPaperScissors(string player1, string player2)
{
   
    string[] validChoices = { "rock", "paper", "scissors" };


    if (!validChoices.Contains(player1) || !validChoices.Contains(player2))
    {
        return "Yanlış daxil etmə! Zəhmət olmasa 'rock', 'paper' və ya 'scissors' yazın.";
    }

  
    if (player1 == player2)
    {
        return "Bərabere (Heç-heçə)";
    }

    
    if ((player1 == "rock" && player2 == "scissors") ||    
        (player1 == "scissor" && player2 == "paper") ||  
        (player1 == "paper" && player2 == "rock"))        
    {
        return "1-ci oyunçu qalib gəldi!";
    }
    else
    {
    
        return "2-ci oyunçu qalib gəldi!";
    }
}




