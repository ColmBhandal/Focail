using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocailLib
{
    internal class GameRunnerImpl : IGameRunner
    {
        private readonly IRoundProducer _roundProducer;
        private readonly Func<bool> _isGameOver;

        public GameRunnerImpl(IRoundProducer roundProducer, Func<bool> isGameOver)
        {
            _roundProducer = roundProducer;
            _isGameOver = isGameOver;
        }

        public void RunGame()
        {
            //TODO
            Console.WriteLine("TODO: Write the app!");
            Console.ReadLine();
        }
    }
}
