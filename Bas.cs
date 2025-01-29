namespace Bas;

class Perso
{
    string name;
    public Perso(string name) => this.name = name;
    public void Print() => Console.WriteLine($"Имя: {name} ");
}