using System;
using System.Threading;
namespace Event_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpaceQuestGameManager shipManager = new SpaceQuestGameManager(100, 0, 0, 10);
            GameView view = new GameView();

            shipManager.GoodSpaceShipGotDamaged += view.GoodShipGotDamagedEventHandler;
            shipManager.GoodSpaceShipGotHP += view.GoodShipGotHPEventHandler;
            shipManager.GoodShipLocationChanged += view.GoodShipMoves;
            shipManager.BadShipDestroyed += view.BadShipDestroyed;
            shipManager.GoodShipDestroyed += view.GoodShipDestroyed;
            shipManager.LevelUpReached += view.LevelUp;

            shipManager.GoodShipGotDamaged(40);
            Thread.Sleep(1000);
            shipManager.GoodShipGotHP(20);
            Thread.Sleep(2000);
            shipManager.MoveShip(100, 300);
            Thread.Sleep(2000);
            shipManager.EnemyShipDestroyed(8);
            shipManager.LevelUp();
            Thread.Sleep(2000);
            shipManager.LevelUp();
            shipManager.MoveShip(550, 265);
            shipManager.GoodShipGotDamaged(100);
            Thread.Sleep(2000);
            shipManager.GoodSpaceShipDestroyed();










        }





    }
}
