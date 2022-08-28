using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // System.Collections namespace
        // Arraylistin içinde birden fazla veri tipi saklanabilir. 

        ArrayList liste = new ArrayList();
        // liste.Add("Ayşe");
        // liste.Add(2);
        // liste.Add(true);
        // liste.Add('A');

        // //İçerisindeki verilere erişim 
        // Console.WriteLine(liste[1]);
        // foreach (var item in liste)
        // {
        //     Console.WriteLine(item);            
        // }
        // Addrange birden fazla elemanı eklemek
        Console.WriteLine("******Addrange*****");

        // string[] renkler = {"mavi", "Kırmızı", "Sarı"};
        // liste.AddRange(renkler);
        // foreach (var item in liste)
        //     Console.WriteLine(item);
        
        List<int> sayi = new List<int>{1,8,9,3,4,65};
        liste.AddRange(sayi);
        foreach (var item in liste)
            Console.WriteLine(item);
        // Sort
        liste.Sort(); // Farklı veri tipleri olduğu için sıralama yapamaz. 

        // Binary Search -ilk önce sort sonra binary search yapılabiliyor. 
        Console.WriteLine("******Binary Search*****");
        Console.WriteLine(liste.BinarySearch(9));

        // Reverse ortasından ters çeviriyor. 
        Console.WriteLine("******Reverse*****");
        liste.Reverse();
        foreach (var item in liste)
            Console.WriteLine(item);
        
        // Clear
        Console.WriteLine("******Reverse*****"); 
        liste.Clear();
        
    }
}