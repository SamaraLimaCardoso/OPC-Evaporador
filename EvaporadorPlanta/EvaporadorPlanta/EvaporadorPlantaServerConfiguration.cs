using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaporadorPlanta;
using System.Runtime.Serialization;

namespace EvaporadorPlanta
{
    [DataContract(Namespace = Namespaces.EvaporadorPlanta)]
    public class EvaporadorPlantaServerConfiguration
    {
        public EvaporadorPlantaServerConfiguration()
        {
            Initialize();

        }
        /// <summary>
        /// Initializes the object during deserialization.
        /// </summary>
        [OnDeserializing()]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
    }
}
