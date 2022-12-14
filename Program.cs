using System.Reflection;

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

    Console.WriteLine("Press any key to exit!");
    
    Console.ReadLine();
}

static void CreateTextFile(string? fileName)
{
    if(string.IsNullOrWhiteSpace(fileName))
    {
        throw new ArgumentException("File name is not valid!");
    }

    string? pathBase = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

    string? fullPath = Path.Combine(pathBase, fileName);

    if(File.Exists(fullPath))
    {
        Console.WriteLine("File exists! You will choice other name to the file? Y = Yes or N = No");

        char? choice = Convert.ToChar(Console.ReadLine());

        if(choice == 'Y')
        {
             Console.WriteLine("What will be the file name?");
             
             CreateTextFile(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("The program will be exited!");
        }
    }
    else
    {
        File.Create(fullPath);

        Console.WriteLine("File created successfully!");
    }
}

static void OpenTextFile(string? fileName)
{
    if(string.IsNullOrWhiteSpace(fileName))
    {
        throw new ArgumentException("File name is not valid!");
    }
}