// See https://aka.ms/new-console-template for more information
using txt;

var teams = new Dictionary<string, Team>();
var players = new Dictionary<string, Player>();

while (true)
{
    Console.WriteLine("Enter command:");
    string input = Console.ReadLine();
    string[] command = input.Split(' ');

    if (command[0] == "Exit")
    {
        break;
    }
    switch (command[0])
    {
        case "create_team":
            {
                string teamName = command[1];
                teams[teamName] = new Team(teamName);
                Console.WriteLine($"Team {teamName} has been created.");
                break;
            }

        case "create_player":
            {
                string playerName = command[1];
                string position = command[2];
                players[playerName] = new Player(playerName, position);
                Console.WriteLine($"Player {playerName} has been created.");
                break;
            }
        case "add_player":
            {
                string teamName = command[1];
                string playerName = command[2];
                string position = command[3];
                players[playerName].Position = position;
                teams[teamName].AddPlayer(players[playerName]);
                Console.WriteLine($"Player {playerName} has been added to team {teamName}.");
                break;
            }

        case "remove_player":
            {
                string teamName = command[1];
                string playerName = command[2];
                teams[teamName].RemovePlayer(playerName);
                Console.WriteLine($"Player {playerName} has been removed from team {teamName}.");
                break;
            }

        case "print_team":
            {
                string teamName = command[1];
                string filePath = command[2];
                teams[teamName].PrintHistory(filePath);
                Console.WriteLine($"The history of team {teamName} is saved in {filePath}.");
                break;
            }
        case "print_log_txt":
            {
                string teamName = command[1];
                string filePath = command[2];
                teams[teamName].PrintHistory(filePath);
                Console.WriteLine($"The history of team {teamName} is saved in the text file {filePath}.");
                break;
            }
        default:
        Console.WriteLine("Invalid command.");
            break;
    }
}
