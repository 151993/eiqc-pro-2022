using System;

namespace QSS.eIQC.Handlers
{
    public abstract class BaseUpdateCommand<T> : BaseCommand
    {
        /// <summary>
        /// Get or Set Id property
        /// </summary>
        public T Id { get; set; }

        /// <summary>
        /// LastUpdate date of the record, this field is important and mandatory to be set to avoid DBUpdateCuncurrencyException. 
        /// EF checks and throw error if value has been updated in DB.
        /// </summary>
        public DateTimeOffset LastUpdated { get; set; }
    }
}
