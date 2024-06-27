using System;
using System.Collections.Generic;
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
            Utils.Trace("Creating the Node Managers.");// mensagem de rastreamento indicando a criação dos gerenciadores de nó.

            List<INodeManager> nodeManagers = new List<INodeManager>();

            // Cria um gerenciador de nó personalizado (EvaporadorPlantaNodeManager) e o adiciona à lista de gerenciadores de nó.
            nodeManagers.Add(new EvaporadorPlantaNodeManager(server, configuration));

            // Retorna um novo MasterNodeManager configurado com o servidor (server), a configuração (configuration) e os gerenciadores de nó criados.
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }
        //metodo para Carregar e retornar as propriedades do servidor OPC UA.
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
