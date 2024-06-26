using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;
using Opc.Ua.Server;

namespace EvaporadorPlanta
{
    //DEVE ESTENDER A CLASSE SERVIDOR DO PADRÃO
    internal class EvaporadorPlantaServer : StandardServer
    {
        //Usa o conceito de gerenciador de nó, por este motivo precisamos de um metodo para criar um gerenciador de nó
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Utils.Trace("Creating the Node Managers.");

            List<INodeManager> nodeManagers = new List<INodeManager>();

            // create the custom node managers.
            nodeManagers.Add(new EvaporadorPlantaNodeManager(server, configuration));

            // create master node manager.
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }
        //metodo para especificar as propriedades do servidor
        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties properties = new ServerProperties();

            properties.ManufacturerName = "LIEC-OPAS";
            properties.ProductName = "Servidor do Modelo de Informação de Planta do Evaporador";
            properties.ProductUri = "http://opcfoundation.org/EvaporadorPlanta/InformationModelServer/v1.0";
            properties.SoftwareVersion = Utils.GetAssemblySoftwareVersion();
            properties.BuildNumber = Utils.GetAssemblyBuildNumber();
            properties.BuildDate = Utils.GetAssemblyTimestamp();

            // TBD - All applications have software certificates that need to added to the properties.

            return properties;
        }
    }
}
