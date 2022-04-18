using HomeworkGenerics.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkGenerics
{
    public class PetStore<T> where T : Classes.Pet
    {
        public List<T> pets;
        public PetStore()
        {
            pets = new List<T>();
        }
        public void printPets()
        {
            foreach (T pet in pets)
            {
                Console.WriteLine(pet.PrintInfo());
            }
        }
        public void BuyPet(string name)
        {
                T pet = pets.Single(x => x.Name == name);
                if (pet == null)
                {
                    Console.WriteLine($"We don't have any pet with name like that.");
                }
                pets.Remove(pet);
                Console.WriteLine($"You have successfully bought {pet.Name}. Congratulations and take care of him well.");
        }
        public void AddPets(T firstPet, T secondPet)
        {
            pets.Add(firstPet);
            pets.Add(secondPet);
        }
    }
}