// See https://aka.ms/new-console-template for more information
using AbstractClassesAndInterfacesHw.Models;

Cat Portokal = new Cat("Portokal", "orange", Kind.feline, 2, 9,false);
Console.WriteLine(Portokal.PrintInfo());
Portokal.Eats("sparrow");

Cat Belche = new Cat("Belche", "white", Kind.feline, 1, 9, true);
Console.WriteLine(Belche.PrintInfo());
Belche.Eats("fish");

Dog Aaron = new Dog("Aaron", "white", Kind.canine, 1, true);
Console.WriteLine(Aaron.PrintInfo());
Aaron.Bark();

Dog RandomDzukac = new Dog("Dzukac", "grey", Kind.canine, 3, false);
Console.WriteLine(RandomDzukac.PrintInfo());
RandomDzukac.Bark();

List<Animal> Animals = new List<Animal>();
Animals.Add(Aaron);
Animals.Add(Portokal);
Animals.Add(Belche);
Animals.Add(RandomDzukac);
Animals.Add(new Dog("Dzeki", "black", Kind.canine, 2, true));
Animals.Add(new Cat("Mici", "yellow", Kind.feline, 4, 7, false));

foreach(Animal animal in Animals)
{
    if (animal.GetType().ToString() == "AbstractClassesAndInterfacesHw.Models.Dog") { animal.Bark();}
    if (animal.GetType().ToString() == "AbstractClassesAndInterfacesHw.Models.Cat") { animal.Eats("cat food"); }
}