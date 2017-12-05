namespace Asd.Infra.Data.EventSourcing
{
    using Asd.Domain.Core.Events;

    public class AsdSqlEventStore : IAsdIEventStore
    {

        public void Save<T>(T @event) where T : AsdEvent
        {
            throw new System.NotImplementedException();
        }
    }
}
