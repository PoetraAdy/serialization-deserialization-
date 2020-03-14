using System;

namespace Serialization_Deserialization {
    [Serializable]
    public class Mobile : Game
    {
        private int point;

        public Mobile(int _level, float _rank, string _name, int _point) : base(_level, _rank, _name) {
            point = _point;
        }

        public override void Run() {
            Console.WriteLine("Mobile Game" + name + ", point " + point);
        }
    }
}