using System; //İlk olarak bir menü karşımıza çıkıyor ve o menüden istediğimiz yönlendirmeyi yaparak sona eleman ekliyor ve çıkartabiliyoruz

public class Node
{
    public int Data;      
    public Node Next;     

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    private Node Head;    

    public LinkedList()
    {
        Head = null;      
    }

    
    public void AddLast(int data)
    {
        Node newNode = new Node(data);

        if (Head == null) 
        {
            Head = newNode;
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

   
    public void Remove(int data)
    {
        if (Head == null)
        {
            Console.WriteLine("Liste boş, çıkarılacak eleman yok.");
            return;
        }

        
        if (Head.Data == data)
        {
            Head = Head.Next;
            return;
        }

        
        Node current = Head;
        while (current.Next != null && current.Next.Data != data)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            Console.WriteLine("Eleman listede bulunamadı.");
        }
        else
        {
            current.Next = current.Next.Next;
        }
    }

    
    public void PrintList()
    {
        if (Head == null)
        {
            Console.WriteLine("Liste boş.");
            return;
        }

        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " > ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

public class Program
{
    public static void Main()
    {
        LinkedList list = new LinkedList();  

        while (true)
        {
            Console.WriteLine("\nYapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1. Eleman ekleme (sona)");
            Console.WriteLine("2. Eleman çıkarma");
            Console.WriteLine("3. Listeyi yazdırma");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçiminiz: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Lütfen eklenecek sayıyı girin: ");
                int data = Convert.ToInt32(Console.ReadLine());
                list.AddLast(data);
                Console.WriteLine($"{data} sayısı listeye eklendi.");
            }
            else if (choice == "2")
            {
                Console.Write("Lütfen çıkarılacak sayıyı giriniz: ");
                int data = Convert.ToInt32(Console.ReadLine());
                list.Remove(data);
            }
            else if (choice == "3")
            {
                Console.WriteLine("Liste durumu:");
                list.PrintList();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Çıkılıyor...");
                break; 
            }
            else
            {
                Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
            }
        }
    }
}
