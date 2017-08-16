using System.Runtime.Serialization;

namespace Marley.Currency.Domain.DataEntities
{
    [DataContract]
    public class Stock
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal? Value { get; set; }
        [DataMember]
        public decimal? Oscillation { get; set; }
    }
}