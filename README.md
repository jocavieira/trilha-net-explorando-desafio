# Hotel Reservation System 🏨

This project is part of the **DIO Fullstack Bootcamp** and demonstrates basic **C# console application development** using object-oriented programming concepts following the rules set by "diagrama_classe_hotel.png".

## Description

The application simulates a **simple hotel reservation system** where users can:

- Create suites with different types, capacities, and daily rates
- Register guests for a suite
- Remove guests and calculate the total cost of their stay
- Apply discounts automatically for long stays (10+ days)
- List all registered guests

The project focuses on **classes, lists, methods, and basic user input/output in C#**.

## How to Use

1. Run the program.
2. Define the suites and guests.
3. Use the menu to:
   - Register guests
   - Register a suite
   - Remove guests and calculate the daily rate
   - Exit the program
4. The system will display:
   - The number of guests
   - The total daily rate (with discount if applicable)

## Technologies Used

- C#
- .NET

## Classes

- **Person** – Represents a guest with name and surname.
- **Suite** – Represents a hotel suite with type, capacity, and daily rate.
- **Reservation** – Manages suite assignment, guest registration, and cost calculation.
