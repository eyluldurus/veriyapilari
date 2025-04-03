// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> hashTable = new Dictionary<int, string>();

        // Eleman ekleme işlemi
        hashTable.Add(1, "Elma");
        hashTable.Add(2, "Armut");
        hashTable.Add(3, "Muz");
        hashTable.Add(4, "Çilek");

        Console.WriteLine("Hash Table içeriği:");
        foreach (var item in hashTable)
        {
            Console.WriteLine("Anahtar: " + item.Key + ", Değer: " + item.Value);
        }

        // Arama işlemi
        Console.Write("\nAramak istediğiniz anahtarı girin: ");
        int searchKey = Convert.ToInt32(Console.ReadLine());

        if (hashTable.ContainsKey(searchKey))
        {
            Console.WriteLine($"Anahtar {searchKey} bulundu! Değer: {hashTable[searchKey]}");
        }
        else
        {
            Console.WriteLine("Anahtar bulunamadı.");
        }
    }
}
