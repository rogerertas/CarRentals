using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RentalLibrary;
using System.Web;

namespace Application
{
    public class BookACar : RentalModel
    {
        private BookingRepository _bookingRepository;

        public void CarRentalService()
        {
            _bookingRepository = new BookingRepository();
        }
        
        public void Book(int BookingNumber, int RegistrationNumber, int CustomerBirthDate, string VehicleCategory, DateTime TimeOfRental, int CurrentMilage)
        {
            var booking = new Booking();
                //BookingNumber, RegistrationNumber, CustomerBirthDate, VehicleCategory, TimeOfRental, CurrentMilage
                ;
            _bookingRepository.Save(booking);
        }

    }


    public class BookingRepository : RentalModel
    {
        public void Save(Booking booking)
        {
            using (var context = new RentalModel())
            {
                context.Booking.Add(booking);
                context.SaveChanges();
            }
        }
    }
}


/* Det här ska registreras:

  Bokningsnummer
 Registreringsnummer
 Kundens personnummer
 Bilkategori
 Datum och tidpunkt för utlämning
 Aktuell mätarställning på bilen (km)

*/

