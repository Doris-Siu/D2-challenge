using D2_challenge;

int choice, data, k, x;

var list = new SingleLinkedList();

list.CreateList();

while (true)
{
    Console.WriteLine("1. Display list");
    Console.WriteLine("2. Count the number of nodes");
    Console.WriteLine("3. Search for an element");
    Console.WriteLine("4. Insert a node in empty list/ in the beginning of list");
    Console.WriteLine("5. Insert a node at the end of list");
    Console.WriteLine("6. Insert a node after a specified node");
    Console.WriteLine("7. Insert a node before a specified node");
    Console.WriteLine("8. Insert a node at a specified position");




    Console.WriteLine("999. Quit");

    Console.Write("Enter your choice: ");
    choice = int.Parse(Console.ReadLine());

    if (choice == 999)
        break;

    switch (choice)
    {
        case 1:
            list.DisplayList();
            break;

        case 2:
            list.CountNodes();
            break;

        case 3:
            Console.Write("Enter the element to be searched: ");
            data = int.Parse(Console.ReadLine());
            list.Search(data);
            break;

        case 4:
            Console.Write("Enter the element to be inserted: ");
            data = int.Parse(Console.ReadLine());
            list.InsertInBeginning(data);
            break;

        case 5:
            Console.Write("Enter the element to be inserted: ");
            data = int.Parse(Console.ReadLine());
            list.InsertAtEnd(data);
            break;

        case 6:
            Console.Write("Enter the element to be inserted: ");
            data = int.Parse(Console.ReadLine());

            Console.Write("Enter the specified node: ");
            x = int.Parse(Console.ReadLine());

            list.InsertAfter(data, x);
            break;

        case 7:
            Console.Write("Enter the element to be inserted: ");
            data = int.Parse(Console.ReadLine());

            Console.Write("Enter the specified node: ");
            x = int.Parse(Console.ReadLine());

            list.InsertBefore(data, x);
            break;

        case 8:
            Console.Write("Enter the element to be inserted: ");
            data = int.Parse(Console.ReadLine());

            Console.Write("Enter the specified position: ");
            k = int.Parse(Console.ReadLine());

            list.InsertAtPosition(data,k);
            break;

        default:
            Console.WriteLine("Invalid choice");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Exiting...");

}

