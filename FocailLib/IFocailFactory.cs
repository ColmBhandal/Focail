using System;

namespace FocailLib
{
    /// <summary>
    /// Factory for producing instances of types for the focail game
    /// </summary>
    public interface IFocailFactory
    {
        /// <summary>
        /// Create a new game runner
        /// </summary>
        /// <param name="roundProducer">Object for producing a sequence of input data for each round</param>
        /// <param name="isGameOver">Function which defines when the game is over</param>
        /// <returns></returns>
        IGameRunner NewGameRunner(IRoundProducer roundProducer, Func<bool> isGameOver);
    }
}