using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;

namespace ConsoleAdventure.Project.Models
{
  public class Room : IRoom
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Item> Items { get; set; }
    public Dictionary<string, IRoom> Exits { get; set; }
    public Dictionary<IItem, KeyValuePair<string, IRoom>> LockedExits { get; set; }


    public Room(string name, string description)
    {
      Name = name;
      Description = description;
      Items = new List<Item>();
      Exits = new Dictionary<string, IRoom>();
      LockedExits = new Dictionary<IItem, KeyValuePair<string, IRoom>>();

    }
  }
}