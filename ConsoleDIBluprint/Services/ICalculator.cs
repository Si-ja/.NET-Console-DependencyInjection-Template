namespace ConsoleDIBluprint.Services
{
    public interface ICalculator
    {
        /// <summary>
        /// Put two integer values together.
        /// </summary>
        /// <param name="a">Int value #1</param>
        /// <param name="b">Int value #2</param>
        /// <returns>The sum of combined values</returns>
        int PutTwoIntNumbersTogether(int a, int b);

        /// <summary>
        /// Subtrackt value #2 from value #1.
        /// </summary>
        /// <param name="a">Int value #1</param>
        /// <param name="b">Int value #2</param>
        /// <returns>The subtraction of value #2 from value #1</returns>
        int SubtractTwoIntNumbers(int a, int b);
    }
}