using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class TrackingIDRepetidoException : Exception
    {
        public TrackingIDRepetidoException(string message) : base(message)
        {            
        }

        public TrackingIDRepetidoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
