using System.Runtime.Serialization;

namespace F1Karte.Aplikacija.Servisi
{
    [Serializable]
    public class BillNotFoundException : Exception
    {
        public BillNotFoundException()
        {
        }

        public BillNotFoundException(string? message) : base(message)
        {
        }

        public BillNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BillNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}