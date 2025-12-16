using System;
using System.Collections.Generic;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// Create guest models and add them to the guest list
List<Person> guests = new List<Person>();

Person p1 = new Person(name: "Guest 1");
Person p2 = new Person(name: "Guest 2");

guests.Add(p1);
guests.Add(p2);

// Create the suite
Suite suite = new Suite(suiteType: "Premium", capacity: 2, dailyRate: 30);

// Create a new reservation, passing the suite and the guests
Reservation reservation = new Reservation(daysReserved: 10);
reservation.RegisterSuite(suite);
reservation.RegisterGuests(guests);

// Display the number of guests and the daily rate
Console.WriteLine($"Guests: {reservation.GetGuestCount()}");
Console.WriteLine($"Daily rate: {reservation.CalculateDailyRate()}");