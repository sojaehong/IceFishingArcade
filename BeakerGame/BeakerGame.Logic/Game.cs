//TDD : Test-Driven Development -> test case를 먼저 작성

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeakerGame.Logic
{
    public class Game
    {
        public Game()
        {
            _beakers = new Dictionary<string, Beaker>();

            _beakers.Add("A", new Beaker(8, 8));
            _beakers.Add("B", new Beaker(5, 0));
            _beakers.Add("C", new Beaker(3, 0));
        }

        private Dictionary<string, Beaker> _beakers;

        public void Move(string from, string to)
        {
            Move(_beakers[from], _beakers[to]);
        }

        public void Move(char from, char to)
        {
            Move(_beakers[from.ToString()], _beakers[to.ToString()]);
        }

        private void Move(Beaker from, Beaker to)
        {
            int liter = Math.Min(from.Liter, to.Capacity - to.Liter);

            to.Liter += liter;
            from.Liter -= liter;

            MoveCount++;
        }

        public int this[string name]
        {
            get { return GetLiter(name); }
        }

        public int GetLiter(string name)
        {
            return _beakers[name].Liter;
        }

        public bool IsCompleted()
        {
            return _beakers["A"].Liter == 4 && _beakers["B"].Liter == 4;
        }

        public int MoveCount { get; private set; }
    }
}
