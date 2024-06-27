using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Opc.Ua;
using Opc.Ua.Server;

namespace EvaporadorPlanta
{
    internal class EvaporadorPlantaNodeManager : CustomNodeManager2 // classe da biblioteca OPC UA que facilita o gerenciamento de nós do servidor.
    {
        private EvaporadorPlantaServerConfiguration m_configuration; //  Armazena a configuração específica do servidor.
        private static EvaporadorPlantaState m_PlantaEvaporador1; // Armazena a instância do estado da planta do evaporador.
        //Inicializa a instância da classe e chama o construtor da classe base 
        public EvaporadorPlantaNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        :
       base(server, configuration)
        {
            SystemContext.NodeIdFactory = this;//Define a fábrica de NodeId para o contexto do sistema.
            // Define dois namespaces: um para o modelo de tipo e outro para os nós criados dinamicamente.
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = EvaporadorPlanta.Namespaces.EvaporadorPlanta;
            namespaceUrls[1] = EvaporadorPlanta.Namespaces.EvaporadorPlanta + "/Instance";
            SetNamespaces(namespaceUrls);
            // obtem a configuração para o gerenciador de nós.
            m_configuration = configuration.ParseExtension<EvaporadorPlantaServerConfiguration>();
            // Se a configuração não existir, usa valores padrão.
            if (m_configuration == null)
            {
                m_configuration = new EvaporadorPlantaServerConfiguration();
            }
        }

        //Carrega os nós predefinidos a partir de um recurso binário. 
        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                "EvaporadorPlanta.PredefinedNodes.uanodes",
                typeof(EvaporadorPlantaNodeManager).GetTypeInfo().Assembly,
                true);
            return predefinedNodes;
        }

        //Cria o espaço de endereçamento do servidor e substitui os nós predefinidos não tipados por suas versões fortemente tipadas.
        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);
                // encontrar o nó não tipado PlantaEvaporador1 que foi criado quando o modelo foi carregado.
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(EvaporadorPlanta.Objects.PlantaEvaporador1, NamespaceIndexes[0]), typeof(BaseObjectState));
                // converter o nó não tipado em um nó tipado que pode ser manipulado dentro do servidor.
                m_PlantaEvaporador1 = new EvaporadorPlantaState(null);
                m_PlantaEvaporador1.Create(SystemContext, passiveNode);
                // substitui os nós predefinidos não tipados por suas versões fortemente tipadas.
                AddPredefinedNode(SystemContext, m_PlantaEvaporador1);
            }
        }

    }
}
