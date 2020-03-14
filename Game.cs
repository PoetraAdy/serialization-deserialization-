using System;

namespace Serialization_Deserialization {
    [Serializable]
    public class Game
    {
        protected int level;
        protected float rank;
        protected string name;

        public Game(int _level, float _rank, string _name) {
            level = _level;
            rank = _rank;
            name = _name;
        }

        public virtual void Run() {

        }
    }
}