using System.Collections.Generic;

public class Menu
{
  private List<Prompt> _mainMenuPrompts = new List<Prompt>();

  public Menu()
  {
    string[] prompts = { "Book a ticket", "Add an event", "View all events", "View available seats for an event", "Remove event", "Exit" };

    foreach (string prompt in prompts)
    {
      Prompt menuPrompt = new Prompt(prompt);
      _mainMenuPrompts.Add(menuPrompt);
    }
  }

  public void DisplayMenu()
  {
    Console.WriteLine("");
    _mainMenuPrompts.ForEach(prompt =>
    {
      Console.WriteLine($"{_mainMenuPrompts.IndexOf(prompt) + 1}. {prompt.GetPrompt()}");

    });
  }
}
