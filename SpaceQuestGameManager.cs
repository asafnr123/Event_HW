using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_HW
{
    internal class SpaceQuestGameManager
    {
        private int goodShipHitPoints;

        private int shipXLocation;

        private int shipYlocation;

        private int numberOfBadShips;

        private int currenttLevel;


        public event EventHandler<PointsEventArgs> GoodSpaceShipGotDamaged;

        public event EventHandler<PointsEventArgs> GoodSpaceShipGotHP;

        public event EventHandler<LocationEventArgs> GoodShipLocationChanged;

        public event EventHandler<LocationEventArgs> GoodShipDestroyed;

        public event EventHandler<BadShipDestroyedEventArgs> BadShipDestroyed;

        public event EventHandler<LevelEventArgs> LevelUpReached;

        public SpaceQuestGameManager(int goodShipsHitPoint, int shipXLocation, int shipYlocation, int numberOfBadShips)
        {

            this.goodShipHitPoints = goodShipsHitPoint;
            this.shipXLocation = shipXLocation;
            this.shipYlocation = shipYlocation;
            this.numberOfBadShips = numberOfBadShips;
            this.currenttLevel = 1;
        }


        public void MoveShip(int x, int y)
        {
            this.shipXLocation = x;
            this.shipYlocation = y;
            OnGoodShipLocationChanged(x, y);
        }

        public void GoodShipGotDamaged(short damage)
        {
            if (damage > 0)
            {
                goodShipHitPoints -= damage;
            }
            onGoodShipGotDamaged(damage);
        }

        public void GoodShipGotHP(int health)
        {
            // max health is 100
            if (goodShipHitPoints < 100 && health > 0)
            {
                goodShipHitPoints += health;
                OnGoodSpaceShipGotHP(health);
            }

        }

        public void GoodSpaceShipDestroyed()
        {
            OnGoodShipDestroyed();
        }

        public void EnemyShipDestroyed(int enemyShips)
        {
            numberOfBadShips -= enemyShips;
            OnBadShipDestroyed(enemyShips);
        }

        public void LevelUp()
        {
            if (numberOfBadShips <= 0)
            {
                currenttLevel++;
                OnLevelUpReached();
                goodShipHitPoints = 100;
            }
        }

        private void onGoodShipGotDamaged(short damage)
        {
            GoodSpaceShipGotDamaged.Invoke(this, new PointsEventArgs(goodShipHitPoints, damage));
        }

        public void OnGoodSpaceShipGotHP(int health)
        {
            GoodSpaceShipGotHP.Invoke(this, new PointsEventArgs(goodShipHitPoints, health));
        }

        private void OnGoodShipLocationChanged(int x, int y)
        {
            GoodShipLocationChanged.Invoke(this, new LocationEventArgs(x, y));
        }

        private void OnGoodShipDestroyed()
        {
            GoodShipDestroyed.Invoke(this, new LocationEventArgs(shipXLocation, shipYlocation));
        }

        private void OnBadShipDestroyed(int shipDestroyed)
        {
            BadShipDestroyed.Invoke(this, new BadShipDestroyedEventArgs(numberOfBadShips, shipDestroyed));
        }

        private void OnLevelUpReached()
        {
            LevelUpReached.Invoke(this, new LevelEventArgs(currenttLevel));
        }

















    }
}
