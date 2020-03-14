using System;

namespace Serialization_Deserialization {
    [Serializable]
    public class PC : Game
    {
        private double achievement;

        public PC(int _level, float _rank, string _name, double _achievement) : base(_level, _rank, _name) {
            achievement = _achievement;
        }

        public override void Run() {
            Console.WriteLine("Game" + name + ", jumlah " + achievement);
        }
    }
}