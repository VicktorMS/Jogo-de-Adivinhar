
void Main()
{
    Console.WriteLine("Bem-vindo ao jogo de adivinhação\n");
   
    
    Random rnd = new Random();
    int randomNumber = rnd.Next(1, 100);

    int counter = 3;

    do
    {
        Console.Write("Você tem {0} tentativas!\nInsira um número entre 1 e 100: ", counter);
        string userNumberString = Console.ReadLine();
        int userNumber = int.Parse(userNumberString);

        if (userNumber == randomNumber)
        {
            Console.WriteLine($"Você ganhou!, o número era {randomNumber}!");
            return;
        }

        counter--;
    } while (counter > 0);
    Console.WriteLine("Você perdeu, o número era: " + randomNumber);

}

Main();