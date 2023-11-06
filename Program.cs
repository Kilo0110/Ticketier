using System;

class Program
{
    static void Main(string[] args)
    {

        Menu menu = new Menu();
        TicketReservation program = new TicketReservation();

        int selectedMenuOption;

        Console.Clear();

        Console.WriteLine("Welcome to the Ticket Reservation Program. Written by KamCy Ahaka.");
        menu.DisplayMenu();

        Console.Write("What would you like to do? ");
        selectedMenuOption = int.Parse(Console.ReadLine());

        while (selectedMenuOption != 6)
        {
            bool eventListIsNotEmpty;

            switch (selectedMenuOption)
            {

                case 1:
                    eventListIsNotEmpty = program.CheckForEvents();

                    if (eventListIsNotEmpty == false)
                    {
                        Console.WriteLine($"To book a ticket you must first create at least one event.");
                    }
                    else
                    {

                        Console.Write("\nPlease enter your first name: ");
                        string userFirstName = Console.ReadLine();
                        Console.Write("Please enter your last name: ");
                        string userLastName = Console.ReadLine();
                        Console.Write("Please enter your age: ");
                        int userAge = int.Parse(Console.ReadLine());

                        User user = new User(userFirstName, userLastName, userAge);

                        Console.WriteLine($"Which event would you like to book a ticket for?");

                        program.ShowEvents();

                        Console.Write("Enter index of event: ");

                        int eventIndex = int.Parse(Console.ReadLine()) - 1;

                        Console.Write("Enter preferred seat number for this event: ");

                        int seatNumber = int.Parse(Console.ReadLine());

                        Event preferredEvent = program.GetEvent(eventIndex);

                        Seat preferredSeat = new Seat(seatNumber, user);

                        Ticket ticket = new Ticket(preferredEvent, preferredSeat, user);

                        user.AddNewTicket(ticket);

                        ticket.DisplayTicketDetails();

                        program.BookTicket(preferredEvent, ticket);
                    }
                    menu.DisplayMenu();
                    break;
                case 2:
                    Console.Write("\nPlease enter the type of event you want to add (concert/sportsevent/theatreplay): ");
                    string eventType = Console.ReadLine().ToLower();

                    int availableSeats;
                    string eventName;
                    string eventVenue;

                    switch (eventType)
                    {
                        case "concert":
                            Console.Write("Please enter the name of the concert: ");
                            eventName = Console.ReadLine();

                            Console.Write("Please enter the venue of the concert: ");
                            eventVenue = Console.ReadLine();

                            Console.Write("Please enter the number of seats available for the concert: ");
                            availableSeats = int.Parse(Console.ReadLine());

                            Concert concert = new Concert(eventName, new DateTime(), eventVenue, availableSeats);

                            bool isFinished = false;

                            Console.WriteLine($"Enter a list of performers for this concert, type \"Done\" when finished.");

                            do
                            {
                                Console.Write("Enter an artist name: ");
                                string newArtist = Console.ReadLine();
                                if (newArtist.ToLower() != "done")
                                {
                                    concert.AddArtist(newArtist);
                                }
                                else
                                {
                                    isFinished = true;
                                }

                            } while (isFinished == false);

                            program.AddEvent(concert);
                            menu.DisplayMenu();
                            break;

                        case "sportsevent":
                            Console.Write("Please enter the name of the event. If the event has no name, press enter: ");
                            eventName = Console.ReadLine();

                            Console.Write("Please enter the type of sport: ");
                            string sportsType = Console.ReadLine();

                            Console.Write("Please enter the venue of the event: ");
                            eventVenue = Console.ReadLine();

                            Console.Write("Please enter the number of seats available for this event. (NO COMMAS!): ");
                            availableSeats = int.Parse(Console.ReadLine());

                            Console.Write("Please enter the number of participants for this sporting event. Must be 2 or more: ");
                            int numberOfParticipants = int.Parse(Console.ReadLine());

                            if (numberOfParticipants < 2)
                            {
                                Console.WriteLine($"\nThere was an error creating your event. {numberOfParticipants} is NOT a valid value for event participants. Value must be 2 or more.\n");
                                break;
                            }
                            else
                            {
                                SportsEvent sportsEvent = new SportsEvent(eventName, sportsType, new DateTime(), eventVenue, availableSeats, numberOfParticipants);

                                Console.WriteLine($"Enter the names of all participants for this event.");

                                for (int index = 1; index <= numberOfParticipants; index++)
                                {
                                    Console.Write("Enter a participant name: ");
                                    string participant = Console.ReadLine();

                                    sportsEvent.AddParticipant(participant);

                                    Console.WriteLine($"{numberOfParticipants - index} slots remaining");
                                }
                                program.AddEvent(sportsEvent);
                                menu.DisplayMenu();
                            }

                            break;

                        case "theatreplay":
                            Console.Write("Please enter the name of the event. If the event has no name, press enter: ");
                            eventName = Console.ReadLine();

                            Console.Write("Please enter the venue of the event: ");
                            eventVenue = Console.ReadLine();

                            Console.Write("Please enter the number of seats available for this event. (NO COMMAS!): ");
                            availableSeats = int.Parse(Console.ReadLine());

                            Console.Write("Please enter the name of the Playwright for this play: ");
                            string playWright = Console.ReadLine();

                            TheaterPlay theaterPlay = new TheaterPlay(eventName, new DateTime(), eventVenue, availableSeats, playWright);

                            program.AddEvent(theaterPlay);
                            menu.DisplayMenu();

                            break;
                        default:
                            Console.WriteLine($"Invalid entry. You will be returned to the main menu.");

                            menu.DisplayMenu();
                            break;
                    }
                    break;
                case 3:
                    program.ShowEvents();
                    menu.DisplayMenu();
                    break;

                case 4:
                    Console.WriteLine($"\nWhich of the following events do you want to check for? ");

                    program.ShowEvents();

                    Console.Write("Event Index: ");
                    int eventToCheckIndex = int.Parse(Console.ReadLine()) - 1;

                    Event eventToCheck = program.GetEvent(eventToCheckIndex);

                    eventToCheck.DisplayAvailableSeats();

                    break;

                case 5:
                    eventListIsNotEmpty = program.CheckForEvents();

                    if (eventListIsNotEmpty == false)
                    {
                        Console.WriteLine($"There are no events to remove");
                    }
                    else
                    {

                        Console.WriteLine("Which event would you like to remove?");
                        program.ShowEvents();

                        Console.Write("Enter the index of the event you would like to delete: ");
                        int eventNumberToDelete = int.Parse(Console.ReadLine()
                        );

                        program.RemoveEvent(eventNumberToDelete - 1);
                    }
                    menu.DisplayMenu();
                    break;
                default:
                    Console.WriteLine($"Invalid entry. Please try again");
                    menu.DisplayMenu();
                    break;
            }

            Console.Write("What would you like to do? ");
            selectedMenuOption = int.Parse(Console.ReadLine());
        }
    }
}
