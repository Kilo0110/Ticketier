# Ticketier - Ticket Booking Program

## Description

Ticketier is a ticket booking program written in C#, developed by [KamCy Ahaka](https://kamcyahaka.netlify.app/). The program allows users to create and manage events for which they want to issue tickets and reserve seats. It supports three types of events: Concert, SportsEvent, and TheatrePlay, all of which are derived classes from a base Event class.

## Features

Ticketier offers the following features:

- Add an Event: Users can add new events by providing details such as the event type, name, venue, total number of seats, and other relevant information.
- Book a Ticket: Users can book tickets for a specific event by providing their personal information, including their first name, last name, and age. A new instance of the User class is created and associated with an instance of the Ticket class, which is then added to the list of tickets for the desired event. Each ticket is also associated with a specific seat, represented by an instance of the Seat class.
- View All Events: Users can view a list of all available events along with their basic details, including the event type, name, and venue.
- View Event Details: Users can retrieve detailed information about a specific event, such as the event name, venue, total number of seats, and the number of available seats (seats that have not been reserved).
- Remove an Event: Users have the option to remove an existing event from the program, along with all associated tickets and seat reservations.
- Exit the Program: Users can safely exit the program when they have completed their desired actions.

## Usage

To use Ticketier, follow these steps:

1. Launch the program.
2. Use the menu options to select the desired action.
3. Follow the prompts and provide the necessary information.
4. Repeat steps 2 and 3 until you have completed your desired tasks.
5. When finished, select the "Exit" option to close the program.

## Dependencies

Ticketier requires the following dependencies:

C# programming environment
.NET framework

## Installation

To install Ticketier, follow these steps:

Download the Ticketier program files.
Open the files in your preferred C# development environment.
Compile the program to generate the executable file.
Run the executable file to launch Ticketier.

## Examples

Here are some examples of how you can use Ticketier:

1. Add an Event:

Select the "Add an Event" option from the menu.
Provide the necessary details such as the event type, name, venue, and total number of seats.
The event will be added to the program.

2. Book a Ticket:

Select the "Book a Ticket" option from the menu.
Provide your personal information, including your first name, last name, and age.
Select the desired event and seat.
A ticket will be reserved for you.

3.View All Events:

Select the "View all events" option from the menu.
A list of all available events will be displayed, including their basic details.

4. View Event Details:

Select the "View details of an event" option from the menu.
Choose the event for which you want to view the details.
Detailed information about the event will be displayed, including the number of available seats.

5. Remove an Event:

Select the "Remove an Event" option from the menu.
Choose the event you want to remove.
The event, along with all associated tickets and seat reservations, will be removed from the program.

## Contributions

Contributions to Ticketier are welcome. If you have any ideas, bug fixes, or improvements, please feel free to submit a pull request or open an issue on the project's repository.

## License

Ticketier is released under the [MIT License](https://en.m.wikipedia.org/wiki/MIT_License).

## Contact

For any inquiries or support, please contact me [here](https://www.twitter.com/AyamKamCy0110)

Thank you for using Ticketier! Enjoy your ticket booking experience!
