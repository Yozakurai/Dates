
//3. uzd
Console.WriteLine("\n3.uzd\n");
Konstruktors pirmais = new Konstruktors();
Konstruktors otrais = new Konstruktors(3);
Konstruktors tresais = new Konstruktors(3.3);
Konstruktors ceturtais = new Konstruktors("h");
class Konstruktors
{
    public Konstruktors()
    {
        Console.WriteLine("Default konstruktors");
    }
    public Konstruktors(in int i)
    {
        Console.WriteLine($"int tipa parametrs: {i}");
    }
    public Konstruktors(in double d)
    {
        Console.WriteLine($"double tipa parametrs: {d}");
    }
    public Konstruktors(in string s)
    {
        Console.WriteLine($"string tipa parametrs: {s}");
    }

}
class Pirmais
{
    public Pirmais()
    {
        Console.WriteLine("Tiek izveidots Pirmais objekts");
    }
    ~Pirmais()
    {
        Console.WriteLine("objekts tiek iznicinats");
    }
}
class Otrais : Pirmais //Otrais klase tiek mantota no klases Pirmais
{
    public Otrais() // konstruktors funkcija
    {
        Console.WriteLine("Tiek izveidots Otrais objekts");
    }
    ~Otrais() // destruktors funkcija
    {
        Console.WriteLine("Otrais objekts tiek iznicinats");
    }
}
class Tresais : Otrais
{
    public Tresais()
    {
        Console.WriteLine("Tiek izveidots Tresais objekts");
    }
    ~Tresais()
    {
        Console.WriteLine("Tresais objekts tiek iznicinats");
    }
}

