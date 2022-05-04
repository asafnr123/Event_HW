using System;
namespace Event_HW
{
    public class LevelEventArgs : EventArgs
    {
        public int CurrentLevel { get; set; }

        public LevelEventArgs(int level)
        {
            CurrentLevel = level;
        }
    }
}