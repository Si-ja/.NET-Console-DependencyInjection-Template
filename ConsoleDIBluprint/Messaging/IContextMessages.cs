namespace ConsoleDIBluprint.Messaging
{
    public interface IContextMessages
    {
        /// <summary>
        /// Provide some information, that operations are running.
        /// </summary>
        void ProgressInformation();

        /// <summary>
        /// Provide some information on when a certain error is triggered.
        /// </summary>
        void UnexpectedError();
    }
}