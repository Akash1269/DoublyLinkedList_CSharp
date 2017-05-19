using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList_CSharp
{
    class Program
    {

        static int GetData()
        {
            Console.WriteLine("Please enter the value of data for the selected oprations");
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            DoublyLL list = new DoublyLL();
            Console.WriteLine("Welcome to Doubly lisnked list program\n");
            Console.WriteLine("Please enter the elements in the space seperated format\n");
            string[] temp = Console.ReadLine().Split(' ');
            int[] num = Array.ConvertAll(temp, int.Parse);
            foreach (int item in num)
            {
                list.InsertAtEnd(item);
            }
            int data = 0;
            int choice = 6;
            while (choice != 0)
            {
                Console.WriteLine("\n");
                list.PrintAll();
                Console.WriteLine("\n");

                Console.WriteLine("MENU");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Insert At Start");
                Console.WriteLine("2.Insert At End");
                Console.WriteLine("3.Delete At Start");
                Console.WriteLine("4.Delete At End");
                Console.WriteLine("5.Delete Item");
                Console.WriteLine("6.Print All");
                Console.WriteLine("7.Print Reverse");

                Console.WriteLine("Please Enter choice here: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        data = GetData();
                        list.InsertAtStart(data);
                        break;
                    case 2:
                        data = GetData();
                        list.InsertAtEnd(data);
                        break;
                    case 3:
                        list.DeleteAtStart();
                        break;
                    case 4:
                        list.DeleteAtEnd();
                        break;
                    case 5:
                        data = GetData();
                        list.DeleteNode(data);
                        break;
                    case 6:
                        list.PrintAll();
                        break;
                    case 7:
                        list.PrintReverse();
                        break;
                    default:
                        break;
                }
            }
        }


        
    }
}
