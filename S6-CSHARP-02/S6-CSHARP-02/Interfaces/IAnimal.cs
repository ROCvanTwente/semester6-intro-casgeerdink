namespace S6_CSHARP_02.Interfaces;

public interface IAnimal
{
    string Name { get; set; }
    double Weight { get; set; }
    int Age { get; set; }

    void ChangeName(string newName);
    void ChangeWeight(double newWeight);
    void ChangeAge(int newAge);
    string GetAnimalInfo();
}