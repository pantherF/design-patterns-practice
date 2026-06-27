// Exercise 11 — Composition
// Topic: "Has-a" where parts cannot exist without the whole

// The room class is totally obducted from outside of the house class to enforce the composition.
// The code below gives us a compile-time error:
// var room = new Room(2, "Kitchen", 34.4);
// Error: The type or namespace name 'Room' could not be found (are you missing a using directive or an assembly reference?)

var house = new House();

house.AddRoom("Livingroom", 23.4);
house.AddRoom("Bathroom", 13.2);
house.AddRoom("Bedroom", 15.0);

// Room is not accessible outside of the House class
// If I wanted to read the Rooms list for instance, I would get a compile time error again:
//house.Rooms // 'House.Rooms' is inaccessible due to its protection level

// I could make the rooms readable through a method in the House class, that works perfectly fine.
// This is also the only way to access the Rooms list outside of the House class:
house.ShowRooms();

Console.WriteLine("___");
Console.WriteLine(house.GetTotalArea());
