Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("What do you want to do?");
    
    Console.WriteLine("1 - Open text file existing.");

    Console.WriteLine("2 - Create a new text file.");

    string? option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("What text file you which open?");
            OpenTextFile(Console.ReadLine());
        break;

        case "2":
             Console.WriteLine("What will be the file name?");
             CreateTextFile(Console.ReadLine());
             break;
        default:
            Console.WriteLine("Invalid Option! The program will be exited!");
            break;
    }
}

static void CreateTextFile(string? fileName)
{
    throw new NotImplementedException();
}

static void OpenTextFile(string? fileName)
{
    if(string.IsNullOrWhiteSpace(fileName))
    {
        throw new ArgumentException("Option selected is not valid!");
    }
}