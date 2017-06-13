using System;
using System.Collections.Generic;

namespace console_adventure
{
    public class Mansion
    {
        public List<Room> Rooms = new List<Room>();

    }
    public class Room
{
  public string description;
  public List<Room> Exits = new List<Room>();
}
}