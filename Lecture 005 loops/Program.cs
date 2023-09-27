using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lecture_005_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 3
            // 1.Calculate Total Concrete Volume

            // In construction projects, concrete is often used for various purposes such as foundations and columns.In this assignment, you will create a C# program that calculates the total volume of concrete needed for a construction project. The user will provide the dimensions (length, width, and height) of multiple concrete elements, and the program should calculate and display the total volume of concrete required.

            // Requirements:
            // Create a C# program that allows the user to input the number of concrete elements to be calculated.
            // For each concrete element, prompt the user to enter the length, width, and height.
            // Calculate the volume of each concrete element(volume = length * width * height).
            // Sum up the volumes of all concrete elements to find the total concrete volume.
            // Display the total concrete volume required for the entire project.


            //Console.WriteLine("Hi, this is a tool to calculate the volume of concrete if you wwish to continue press 'C'");
            //string startingOrder = Console.ReadLine();
            //if (startingOrder != "C" || startingOrder != "c")
            //{
            //    return;
            //}



            //Console.WriteLine("if you want to add an element please enter the element name below or press 'E' if you are done.");

            //string elementName = Console.ReadLine();

            //if (elementName != "E" || elementName != "e") 

            //{
            //    return;
            //}

            /* Console.WriteLine("if you want to add an element please enter the element name below or press 'E' if you want to exit.");

             string elementName = Console.ReadLine();
             double totalVolume = 0;

             while (elementName != "E" || elementName != "e")
             {


                 if (elementName == "E" || elementName == "e")
                 {
                     break;
                 }
                 Console.WriteLine("Please enter the element length below in meters");
                 double elementLength = double.Parse(Console.ReadLine());

                 Console.WriteLine("Please enter the element width below in meters");
                 double elementWidth = double.Parse(Console.ReadLine());

                 Console.WriteLine("Please enter the element height below in meters");
                 double elementHeight = double.Parse(Console.ReadLine());

                 double elementVolume = elementLength * elementWidth * elementHeight;

                 Console.WriteLine($"The volumn of element {elementName} is {elementVolume}m^3");

                 totalVolume += elementVolume;

                 Console.WriteLine("if you want to add an element please enter the element name below or press 'E' if you are done.");
                 elementName = Console.ReadLine();

             }

             Console.WriteLine($"The total volume is {totalVolume}");



             Console.ReadLine();

             */








            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            //2. Room Classification

            // Create a C# program that prompts the user to enter the number of rooms in a building.
            // Use a while loop to ensure that the user enters a valid positive integer for the number of rooms.If they enter a non - positive number or a non - integer value, prompt them again until a valid input is received.

            // For each room, use a switch statement to classify the room based on its function. The user should choose from the following options:

            // Bedroom
            // Living Room
            // Kitchen
            // Bathroom
            // Office
            // Other(for any room not listed)

            // After classifying each room, display the classification to the user.
            // Once all rooms are classified, display a summary of the number of rooms in each category(e.g., number of bedrooms, number of bathrooms).
            // Allow the user to repeat the classification process for another building if desired.

            string repeatCondation;

            while (bool.Parse(repeatCondation = "Y"))
            {
                Console.WriteLine("please insert the number of room below");

                double theNumberOfRooms = double.Parse(Console.ReadLine());

                while (theNumberOfRooms < 0 || theNumberOfRooms % 1 > 0)
                {

                    Console.WriteLine("ERROR: Invaled input the number of rooms needs to be positive integer. Please reenter the nuber of rooms");
                    theNumberOfRooms = double.Parse(Console.ReadLine());


                }
                Console.WriteLine($"The number of rooms is {theNumberOfRooms}");

                int roomType = 0;
                int bedroom = 0;
                int livingroom = 0;
                int kitchen = 0;
                int bathroom = 0;
                int office = 0;
                int other = 0;


                for (int i = 1; i < theNumberOfRooms + 1; i++)
                {

                    Console.WriteLine($"Please enter the type of room {i} below, press 1 for Bedroom, 2 for Living Room, 3 for Kitchen, 4 Bathroom, 5 Office");
                    roomType = int.Parse(Console.ReadLine());
                    switch (roomType)
                    {
                        case 1:
                            Console.WriteLine($"Room {i} is Bedroom");
                            bedroom++;
                            break;
                        case 2:
                            Console.WriteLine($"Room {i} is Livingroom");
                            livingroom++;
                            break;
                        case 3:
                            Console.WriteLine($"Room {i} is kitchen");
                            kitchen++;
                            break;
                        case 4:
                            Console.WriteLine($"Room {i} is Bathroom");
                            bathroom++;
                            break;
                        case 5:
                            Console.WriteLine($"Room {i} is Office");
                            office++;
                            break;
                        default:
                            Console.WriteLine($"Room {i} is Other");
                            other++;
                            break;
                    }
                }

                Console.WriteLine($"The samary of the building is {bedroom} Bedroom, {livingroom} Livingroom, {kitchen} Kitchen, {bathroom} Bathroom, {office} Office, {other} Other");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("if you wish to repeat the process please press 'Y'");
                repeatCondation = Console.ReadLine();
                
            }
            Console.ReadLine(); 
        }





    }
}
