using System;

class Program
{
    static void Main(string[] args)
    {
        // Ініціалізація двох груп
        SinglyLinkedList group1 = new SinglyLinkedList();
        SinglyLinkedList group2 = new SinglyLinkedList();

        // Додавання студентів у групу 1
        group1.Add("Петренко");
        group1.Add("Iваненко");
        group1.Add("Шевченко");

        // Додавання студентів у групу 2
        group2.Add("Коваль");
        group2.Add("Олiйник");

        Console.WriteLine("Група 1:");
        group1.Print();

        Console.WriteLine("\nГрупа 2:");
        group2.Print();

        // Переносимо L студентів
        int L = 2;
        int K = group1.TransferStudents(group2, L);

        Console.WriteLine($"\nПеренесено {K} студентiв.");

        Console.WriteLine("\nГрупа 1 пiсля переносу:");
        group1.Print();

        Console.WriteLine("\nГрупа 2 пiсля переносу:");
        group2.Print();
    }
}
