using System;
using System.Runtime.Serialization;

namespace RectangleProject.Models
{
    [Serializable]
    public  class RectangleSideIsNullOrZero : Exception
    {
        public RectangleSideIsNullOrZero()
        {
        }

        public RectangleSideIsNullOrZero(string message) : base(message)
        {
        }

        public RectangleSideIsNullOrZero(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RectangleSideIsNullOrZero(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}