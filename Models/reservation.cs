namespace HotelChallenge.Models
{
    public class Reservation
    {
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int DaysReserved { get; set; }

        public Reservation() { }

        public Reservation(int daysReserved)
        {
            DaysReserved = daysReserved;
        }

        public void RegisterGuests(List<Person> guests)
        {
            if (guests.Count <= Suite.Capacity)
            {
                Guests = guests;
            }
            else
            {
                throw new Exception("Number of guests exceeds the suite capacity.");
            }
        }
        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetGuestCount()
        {
            return Guests.Count;
        }

        public decimal CalculateDailyRate()
        {
            decimal total = DaysReserved * Suite.DailyRate;

            if (DaysReserved >= 10)
            {
                total = total - (total * 0.10M); 
            }

            return total;
        }
    }   
}