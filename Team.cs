using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txt
{
    public class Team
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public List<string> History { get; set; }

        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();
            History = new List<string> { $"Team {name} was created." };
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
            History.Add($"Player {player.Name} has joined team {Name}.");
        }

        public void RemovePlayer(string playerName)
        {
            var player = Players.Find(p => p.Name == playerName);
            if (player != null)
            {
                Players.Remove(player);
                History.Add($"Player {playerName} left team {Name}.");
            }
        }

        public void PrintHistory(string filePath)
        {
            File.AppendAllLines(filePath, History);
        }
    }
}
