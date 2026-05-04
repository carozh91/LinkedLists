using SimpleList;
using System.ComponentModel.Design;

var list = new SinglyLinkedList<string>();
var option = string.Empty;
var value = string.Empty;
do
{
    option = Menu();
    switch (option)
    {
        case "1":
            Console.WriteLine("Enter a value:");
            value = Console.ReadLine() ?? string.Empty;
            list.InsertAtBegining(value);
            break;
        case "2":
            Console.WriteLine("Enter a value:");
            value = Console.ReadLine() ?? string.Empty;
            list.InsertAtEnding(value);
            break;
        case "3":
            Console.WriteLine("Enter a value:");
            value = Console.ReadLine() ?? string.Empty;
            var exists = list.Contains(value);
            if (exists) 
            {
                Console.WriteLine($"Value '{value}' found in the list");
            }
            else
            {
                Console.WriteLine($"Value '{value}' not found in the list");
            }
                break;
        case "4":
            Console.WriteLine("Enter a value:");
            value = Console.ReadLine() ?? string.Empty;
            list.Remove(value);
            break;
        case "5":
            list.Reverse();
            break;
        case "6":
            Console.WriteLine(list);
            break;
        case "0":
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again");
            break;
    }
} while (option != "0");

string Menu()
{
    Console.WriteLine("1. Insert at begining");
    Console.WriteLine("2. Insert at the end");
    Console.WriteLine("3. Search for a value");
    Console.WriteLine("4. Remove a value");
    Console.WriteLine("5. Reverse list");
    Console.WriteLine("6. Order list");
    Console.WriteLine("7. Insert ordered");
    Console.WriteLine("8. Show list");
    Console.WriteLine("0. Exit");
    Console.WriteLine("Choose an option:");
    return Console.ReadLine() ?? string.Empty;
}   


