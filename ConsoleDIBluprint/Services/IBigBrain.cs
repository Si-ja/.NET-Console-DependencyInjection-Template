namespace ConsoleDIBluprint.Services
{
    public interface IBigBrain
    {
        /// <summary>
        /// Perform some kind of interaction with numbers, that is assumed will be
        /// handled by the Calculator, where BigBrain tries to figure out what methods
        /// of calculator should be called.
        /// </summary>
        /// <param name="a">Int value #1</param>
        /// <param name="b">Int value #2</param>
        /// <param name="action">A certain action that the calculator needs to perform.</param>
        /// <returns>Return either true or false, depening on whether the action called
        /// by the user is appropriatelly executed or not.</returns>
        bool InteractWithNumbers(int a, int b, string action);
    }
}