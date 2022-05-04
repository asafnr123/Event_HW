using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_HW
{
    internal class GameView
    {

        public void GoodShipGotDamagedEventHandler(object sender, PointsEventArgs e)
        {
            if (e.ShipDamagedTaken > 0)
                Console.WriteLine($"The ship took {e.ShipDamagedTaken} damage");
        }

        public void GoodShipGotHPEventHandler(object sender, PointsEventArgs e)
        {
            if (e.ShipCurrentHealth < 100)
            {
                Console.WriteLine($"You got {e.ShipHPRecovered} HP");
                Console.WriteLine($"HP: {e.ShipCurrentHealth}");
            }
            else
                Console.WriteLine("You are full HP");
        }

        public void GoodShipMoves(object sender, LocationEventArgs e)
        {
            Console.WriteLine($"The ship moved to ({e.ShipXLocation},{e.ShipYLocation})");
        }

        public void GoodShipDestroyed(object sender, LocationEventArgs e)
        {
            Console.WriteLine($"Your ship has been destroyed at ({e.ShipXLocation},{e.ShipYLocation})");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void BadShipDestroyed(object sender, BadShipDestroyedEventArgs e)
        {
            if (e.NumberOfBadShips <= 0)
                Console.WriteLine("YOU WON THE ROUND!");
            else
                Console.WriteLine($"You Destroyed {e.BadShipDestroyed} enemy ships");
        }

        public void LevelUp(object sender, LevelEventArgs e)
        {
            Console.WriteLine($"You are Level {e.CurrentLevel}!!");
        }










    }
}
