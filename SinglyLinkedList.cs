using System;

public class SinglyLinkedList
{
    public Node Head;

    public void Add(string lastName)
    {
        Node newNode = new Node(lastName);
        newNode.Next = Head;
        Head = newNode;
    }

    public bool Remove(string lastName)
    {
        Node current = Head, previous = null;

        while (current != null)
        {
            if (current.LastName == lastName)
            {
                if (previous == null) Head = current.Next;
                else previous.Next = current.Next;
                return true;
            }
            previous = current;
            current = current.Next;
        }
        return false;
    }

    public Node Search(string lastName)
    {
        Node current = Head;
        while (current != null)
        {
            if (current.LastName == lastName)
                return current;
            current = current.Next;
        }
        return null;
    }

    public void Print()
    {
        Node current = Head;
        while (current != null)
        {
            Console.WriteLine(current.LastName);
            current = current.Next;
        }
    }

    public int TransferStudents(SinglyLinkedList toList, int L)
    {
        int count = 0;
        while (Head != null && count < L)
        {
            string student = Head.LastName;
            Remove(student);
            toList.Add(student);
            count++;
        }
        return count;
    }
}
