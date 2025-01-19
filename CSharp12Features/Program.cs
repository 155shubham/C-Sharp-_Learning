// See https://aka.ms/new-console-template for more information
using CSharp12Features;


var oldway = new EmployeeOldWayConstructor("S", "Bhardwaj");

var newway = new EmployeeNewWayConstructor("A", "Kumari");

var newwayStruct = new FindArea(3, 4);

var newwayRecord = new EmployeeRecord("N", "Kumari");

Console.WriteLine(
    $"Output for Old Way of Initialising Constructors in Class: {oldway.FirstName} {oldway.LastName}");

Console.WriteLine(
    $"Output for New Way of Initialising Constructors in Class: {newway.FirstName} {newway.LastName}");

Console.WriteLine(
    $"Output for New Way of Initialising Constructors in Struct: {newwayStruct.Area}");

Console.WriteLine(
    $"Output for New Way of Initialising Constructors in Record: {newwayRecord.firstName} {newwayRecord.lastName}");