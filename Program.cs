using System;

class Program{

    public static void greeting(string Name, string Surname ,int Age){ //Benden istnmese bile bir void oluşturdum.
        Console.WriteLine($"Merhaba {Name} {Surname}, {Age} yaşındasınız. Hoş geldiniz!");
    }

    static void Main(){

        Console.Write("Pls Enter Your Name: "); 
        string Name = Console.ReadLine(); // Kullanıcıdan isim girdisi alınır
        
        Console.Write("Pls Enter Your Surname: ");
        string Surname = Console.ReadLine(); // kullanıcıdan soyad girişi alınır
        
        Console.Write("Pls Enter Your Age: ");
        int Age = Convert.ToInt32(Console.ReadLine()); //Kullanıcıdan yaş girdisi alınır

        greeting(Name ,Surname, Age);

    }
}