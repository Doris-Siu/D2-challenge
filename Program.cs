using D2_challenge;

int choice, data, k, x;

var list = new SingleLinkedList();

while (true)
{
    Console.WriteLine("1. Display list");
    Console.WriteLine("2. Count the number of nodes");
    Console.WriteLine("3. Quit");

    Console.Write("Enter your choice: ");
    choice = int.Parse(Console.ReadLine());

    if (choice == 3)
        break;

    switch (choice)
    {
        case 1:
            list.DisplayList();
            break;

        case 2:
            list.CountNodes();
            break;

        default:
            Console.WriteLine("Invalid choice");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Exiting...");

}

