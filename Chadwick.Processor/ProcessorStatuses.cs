namespace Chadwick.Processor
{
    /// <summary>
    /// Job Statuses
    /// </summary>
    public static class ProcessorStatuses
    {
        /// <summary>
        /// The jobs is finished
        /// </summary>
        public const string Finished = "Finished";
        
        /// <summary>
        /// The job is pending and waiting processing
        /// </summary>
        public const string Pending = "Pending";
        
        /// <summary>
        /// The job is currently processing
        /// </summary>
        public const string Processing = "Processing";
    }
}