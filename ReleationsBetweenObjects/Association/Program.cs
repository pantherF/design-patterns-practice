// Exercise 9 — Association
// Topic: Permanent link via field

var porsche = new Car("Porsche");
var chevrolet = new Car("Chevrolet");

var john = new Driver("John", porsche);
var jessica = new Driver("John");

john.StartJourney();
jessica.StartJourney(); // car is null here, so the car text will just not show.

john.Car = chevrolet; // John now got himself a new car, a chevrolet.
john.StartJourney(); // John here just changed cars, his car still exists, but it is not his anymore.

jessica.Car = porsche; // John gave his car to Jessica, now the porsche belongs to Jessica.
jessica.StartJourney();

// Conclusion: The car and driver are associated, but can exist without one another.
// I now expanded the StartJourney class, so that one driver can use another persons car too, now this can happen as well:

john.StartJourney(porsche); // John borrows Jessicas car because his chevrolet has broken down.
