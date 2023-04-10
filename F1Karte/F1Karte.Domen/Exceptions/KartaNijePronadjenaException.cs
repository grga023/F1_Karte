using System.Runtime.Serialization;

namespace F1Karte.Infrastruktura.Repositozitorijumi
{
    [Serializable]
    public class KartaNijePronadjenaException : Exception
    {
        public KartaNijePronadjenaException()
        {
        }

        public KartaNijePronadjenaException(string? message) : base(message)
        {
        }

        public KartaNijePronadjenaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected KartaNijePronadjenaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}