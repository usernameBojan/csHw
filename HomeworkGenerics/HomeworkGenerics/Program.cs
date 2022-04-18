using HomeworkGenerics;
using HomeworkGenerics.Classes;
using HomeworkGenerics.Enums;

Cat Portokal = new Cat("Portokal", 2, HomeworkGenerics.Enums.Type.Cat, 9, false);
Cat Leo = new Cat("Leo", 4, HomeworkGenerics.Enums.Type.Cat, 8, true);

Dog Aaron = new Dog("Aaron", 1, HomeworkGenerics.Enums.Type.Dog, true, "bacon");
Dog RandomDzukac = new Dog("Dzukac", 3, HomeworkGenerics.Enums.Type.Dog, false, "bread");

Fish Dory = new Fish("Dory", 5, HomeworkGenerics.Enums.Type.Fish, "blue", "small");
Fish Nemo = new Fish("Nemo", 4, HomeworkGenerics.Enums.Type.Fish, "orange", "small");

PetStore<Fish> FishStore = new PetStore<Fish> { };
PetStore<Dog> DogStore = new PetStore<Dog>();
PetStore<Cat> CatStore = new PetStore<Cat>();

FishStore.AddPets(Nemo, Dory);
DogStore.AddPets(Aaron, RandomDzukac);
CatStore.AddPets(Portokal, Leo);

Console.WriteLine("-------DOGS---------------");
DogStore.printPets();
Console.WriteLine("-------CATS---------------");
CatStore.printPets();
Console.WriteLine("-------FISH---------------");
FishStore.printPets();

Console.WriteLine("\n");
DogStore.BuyPet(RandomDzukac.Name);
CatStore.BuyPet(Leo.Name);
Console.WriteLine("\n");

Console.WriteLine("-------DOGS---------------");
DogStore.printPets();
Console.WriteLine("-------CATS---------------");
CatStore.printPets();
Console.WriteLine("-------FISH---------------");
FishStore.printPets();
Console.ReadLine();