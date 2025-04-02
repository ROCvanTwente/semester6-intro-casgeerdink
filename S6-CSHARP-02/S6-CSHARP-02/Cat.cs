using S6_CSHARP_02.Interfaces;

namespace S6_CSHARP_02;

public class Cat : IAnimal
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }

    public Cat(string name, double weight, int age)
    {
        Name = name;
        Weight = weight;
        Age = age;
    }

    public void ChangeName(string newName)
    {
        Name = newName;
    }

    public void ChangeWeight(double newWeight)
    {
        Weight = newWeight;
    }

    public void ChangeAge(int newAge)
    {
        Age = newAge;
    }

    public string GetAnimalInfo()
    {
        return $"Kat: {Name}, Gewicht: {Weight} kg, Leeftijd: {Age} jaar";
    }
}