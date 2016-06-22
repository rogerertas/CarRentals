using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CarRental
{
    class Program
    {
        /*
        Below is a simple example of booking a Kombi, Application spits out the price.
        More robust version is under construction - see RentalLibrary & Application BookACar for further details.
        */
        static void Main(string[] args)
        {
            Booking book = new Booking(new Kombi(), 1);
            Console.WriteLine(book.Price);
            Console.ReadLine();
        }
    }

    public abstract class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public double CurrentMilage { get; set; }
        public double BaseDayPrice { get; set; }
        public double PriceModifier = 1;

    }
    public class Booking
    {
        public int RentalDays { get; set; }
        public double Price { get; set; }

        public Booking(Vehicle vehicle, int rentalDays)
        {
            Price = vehicle.BaseDayPrice * rentalDays * vehicle.PriceModifier + vehicle.BaseDayPrice * vehicle.CurrentMilage;
        }

    }
    public class Kombi : Vehicle
    {
        public Kombi()
        {
            BaseDayPrice = 1;
            PriceModifier = 1.3;
            RegistrationNumber = "";
            Random rand = new Random();
            CurrentMilage = rand.Next(0, 10000);
        }
    }
}
