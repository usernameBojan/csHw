using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int InStoreId { get; set; }  
        public Genre Genre { get; set; }
        public double Price { get; set; }
        public bool IsRented { get; set; }    
        public int SetPrice(int year)
        {
            int price = 0;
            if (year <= 2000) { price = new Random().Next(100, 200); }
            else if (year <= 2010 && year > 2000) { price = new Random().Next(200, 300); }
            else if (year > 2010) { price = new Random().Next(300, 500); }

            return price;
        }
        public Movie() { }
        public Movie(string title, string description, int year, int storeId, Genre genre, double price, bool isRented)
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
            Price = price;
            IsRented = isRented;
            InStoreId = storeId;
        }
        public void DisplayMovieInfo()
        {
            if (IsRented)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{InStoreId}. {Title} ** | {Year} | {Genre} | {this.SetPrice(Year)} \n {Description}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else Console.WriteLine($"{InStoreId}. {Title} | {Year} | {Genre} | {this.SetPrice(Year)} \n {Description}");
        }
    }
}