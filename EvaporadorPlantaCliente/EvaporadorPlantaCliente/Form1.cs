using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Configuration;
using System;
using System.Timers;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace EvaporadorPlantaCliente
{
    public partial class Form1 : Form
    {
        private Session session;
        private ApplicationConfiguration appConfiguration; // Adiciona como campo de classe   
        private System.Timers.Timer timer;

        // IDs dos nós e chaves correspondentes
        //parametros do servidor
        public string SC001;
        public string SC002;
        public string SC003;
        public string FV001;
        public string FV002;
        public string TV001;
        public string LT001;
        public string TT001;
        //parametros do servidor
        public string newSC001;
        public string newSC002;
        public string newSC003;
        public string newFV001;
        public string newFV002;
        public string newTV001;
        public string newLT001;
        public string newTT001;



        public Form1()
        {
            InitializeComponent();
            // Associe o evento ao botão
            buttonConnect.Click += buttonConnect_Click;

            // Inicializa o Timer com intervalo de 1 milissegundo
            timer = new System.Timers.Timer(1);
            timer.Elapsed += AtualizaTodaHora; // Associa o método AtualizaTodaHora ao evento Elapsed

            // Configura o evento que será acionado a cada intervalo do Timer
            timer.Elapsed += AtualizaTodaHora;

        }

        // Botão de conectar
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            upcua_Inicia();
            ReadVar();
            ReadNovasVar();
            // Inicia o Timer
            timer.Start();
        }

        /// <summary>
        /// Configuração do Cliente OPC UA
        /// </summary>
        /// <returns></returns>
        ApplicationConfiguration OpcUa_Client_Configuration()
        {
            // Cria uma nova instância de configuração da aplicação OPC UA
            var config = new ApplicationConfiguration()
            {
                // Nome da aplicação OPC UA
                ApplicationName = "OPCUa_AS",

                // URI da aplicação OPC UA
                ApplicationUri = @"opc.tcp://localhost:48030",

                // Tipo de aplicação OPC UA (Cliente neste caso)
                ApplicationType = ApplicationType.Client,

                // Configuração de Segurança
                SecurityConfiguration = new SecurityConfiguration
                {
                    // Identificação do Certificado da Aplicação OPC UA
                    ApplicationCertificate = new CertificateIdentifier
                    {
                        StoreType = @"Directory",
                        StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\MachineDefault",
                        SubjectName = Utils.Format(@"CN={0}, DC={1}", "OPCUa_AS", System.Net.Dns.GetHostName())
                    },

                    // Certificados de Emissor Confiáveis
                    TrustedIssuerCertificates = new CertificateTrustList
                    {
                        StoreType = @"Directory",
                        StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Certificate Authorities"
                    },

                    // Certificados de Pares Confiáveis
                    TrustedPeerCertificates = new CertificateTrustList
                    {
                        StoreType = @"Directory",
                        StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Applications"
                    },

                    // Armazenamento de Certificados Rejeitados
                    RejectedCertificateStore = new CertificateTrustList
                    {
                        StoreType = @"Directory",
                        StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\RejectedCertificates"
                    },

                    // Aceitação Automática de Certificados Não Confiáveis
                    AutoAcceptUntrustedCertificates = true,

                    // Adiciona o Certificado da Aplicação ao Armazenamento de Confiáveis
                    AddAppCertToTrustedStore = true
                },

                // Configurações de Transporte
                TransportConfigurations = new TransportConfigurationCollection(),

                // Limites de Transporte
                TransportQuotas = new TransportQuotas { OperationTimeout = 10000 },

                // Configurações do Cliente OPC UA
                ClientConfiguration = new ClientConfiguration { DefaultSessionTimeout = 50000 },

                // Configurações de Rastreamento
                TraceConfiguration = new TraceConfiguration()
            };

            // Valida a configuração da aplicação OPC UA
            config.Validate(ApplicationType.Client).GetAwaiter().GetResult();

            // Configura a validação de certificados para aceitar certificados não confiáveis
            if (config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
            {
                config.CertificateValidator.CertificateValidation += (s, e) =>
                {
                    e.Accept = (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted);
                };
            }

            var application = new ApplicationInstance
            {
                ApplicationName = "OPCUa_AS",
                ApplicationType = ApplicationType.Client,
                ApplicationConfiguration = config
            };

            return config;
        }
        Session OpcUa_Create_Session(ApplicationConfiguration client_configuration, EndpointDescription client_end_point)
        {
            return Session.Create(
                client_configuration,
                new ConfiguredEndpoint(null, client_end_point, EndpointConfiguration.Create(client_configuration)),
                false,
                "",
                10000,
                null,
                null
            ).GetAwaiter().GetResult();
        }
        private void upcua_Inicia()
        {
            try
            {
                Console.WriteLine("Tentando conectar...");

                // Obter o endpoint do textBox1
                string server_address = textBox1.Text;

                if (string.IsNullOrWhiteSpace(server_address))
                {
                    MessageBox.Show("Por favor, insira um endpoint válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Chama a configuração e criação da sessão OPC UA
                appConfiguration = OpcUa_Client_Configuration();
                EndpointDescription endpoint = CoreClientUtils.SelectEndpoint(server_address, useSecurity: false);
                session = OpcUa_Create_Session(appConfiguration, endpoint);

                // Mudar a cor do texto do textBox1 para verde se a conexão for bem-sucedida
                textBox1.ForeColor = System.Drawing.Color.Green;
                MessageBox.Show("Conexão estabelecida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                textBox1.ForeColor = System.Drawing.Color.Red;  // Mudar a cor do texto para vermelho se a conexão falhar
                MessageBox.Show($"Erro ao conectar ao servidor OPC UA: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        /// <summary>
        /// ATUALIZAÇÃO E LEITURA DAS VARIAVEIS 
        /// </summary>
        /// <returns></returns>
        /// 

        void AtualizaTodaHora(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("AtualizaTodaHora....................................");
            ReadNovasVar();

            if (SC001 != newSC001)
            {
                sc001.Text = session.ReadValue(NodeId.Parse("ns=2;i=285")).ToString();
                SC001 = session.ReadValue(NodeId.Parse("ns=2;i=285")).ToString();
            }
            if (SC002 != newSC002)
            {
                sc002.Text = session.ReadValue(NodeId.Parse("ns=2;i=285")).ToString();
                SC002 = session.ReadValue(NodeId.Parse("ns=2;i=285")).ToString();
            }
            if (SC003 != newSC003)
            {
                sc003.Text = session.ReadValue(NodeId.Parse("ns=2;i=320")).ToString();
                SC003 = session.ReadValue(NodeId.Parse("ns=2;i=320")).ToString();
            }
            if (FV001 != newFV001)
            {
                fv001.Text = session.ReadValue(NodeId.Parse("ns=2;i=307")).ToString();
                FV001 = session.ReadValue(NodeId.Parse("ns=2;i=307")).ToString();
            }
            if (FV002 != newFV002)
            {
                fv002.Text = session.ReadValue(NodeId.Parse("ns=2;i=293")).ToString();
                FV002 = session.ReadValue(NodeId.Parse("ns=2;i=293")).ToString();
            }
            if (TV001 != newTV001)
            {
                tv001.Text = session.ReadValue(NodeId.Parse("ns=2;i=254")).ToString();
                TV001 = session.ReadValue(NodeId.Parse("ns=2;i=254")).ToString();
            }
            if (LT001 != newLT001)
            {
                LT001T1.Text = session.ReadValue(NodeId.Parse("ns=2;i=276")).ToString();
                LT001T2.Text = session.ReadValue(NodeId.Parse("ns=2;i=276")).ToString();
                LT001T3.Text = session.ReadValue(NodeId.Parse("ns=2;i=276")).ToString();
                LT001T4.Text = session.ReadValue(NodeId.Parse("ns=2;i=276")).ToString();
                LT001T5.Text = session.ReadValue(NodeId.Parse("ns=2;i=276")).ToString();
                LT001 = session.ReadValue(NodeId.Parse("ns=2;i=276")).ToString();
            }
            if (TT001 != newTT001)
            {
                TT0011.Text = session.ReadValue(NodeId.Parse("ns=2;i=246")).ToString();
                TT001 = session.ReadValue(NodeId.Parse("ns=2;i=246")).ToString();
            }
            Thread.Sleep(100); // Atualiza a cada intervalo de tempo
        }

        void ReadVar()
        {
            Console.WriteLine("LIIIIIIIIIIIIIIIIIIIIIII....................................");
            SC001 = session.ReadValue(NodeId.Parse("ns=2;i=285")).ToString();
            SC002 = session.ReadValue(NodeId.Parse("ns=2;i=285")).ToString();
            SC003 = session.ReadValue(NodeId.Parse("ns=2;i=320")).ToString();
            FV001 = session.ReadValue(NodeId.Parse("ns=2;i=307")).ToString();
            FV002 = session.ReadValue(NodeId.Parse("ns=2;i=293")).ToString();
            TV001 = session.ReadValue(NodeId.Parse("ns=2;i=254")).ToString();
            LT001 = session.ReadValue(NodeId.Parse("ns=2;i=276")).ToString();
            TT001 = session.ReadValue(NodeId.Parse("ns=2;i=246")).ToString();
        }
        void ReadNovasVar()
        {
            Console.WriteLine("LIIIIIIIIIIIIIIIIIIIIIII........AAAAAAAAA............................");
            newSC001 = session.ReadValue(NodeId.Parse("ns=2;i=285")).ToString();
            newSC002 = session.ReadValue(NodeId.Parse("ns=2;i=285")).ToString();
            newSC003 = session.ReadValue(NodeId.Parse("ns=2;i=320")).ToString();
            newFV001 = session.ReadValue(NodeId.Parse("ns=2;i=307")).ToString();
            newFV002 = session.ReadValue(NodeId.Parse("ns=2;i=293")).ToString();
            newTV001 = session.ReadValue(NodeId.Parse("ns=2;i=254")).ToString();
            newLT001 = session.ReadValue(NodeId.Parse("ns=2;i=276")).ToString();
            newTT001 = session.ReadValue(NodeId.Parse("ns=2;i=246")).ToString();
            Console.WriteLine(newSC001);
        }

        public void WriteValue(string nodeId, object value)
        {
            try
            {
                WriteValue writeValue = new WriteValue
                {
                    NodeId = new NodeId(nodeId),
                    AttributeId = Attributes.Value,
                    Value = new DataValue
                    {
                        Value = value,
                        StatusCode = StatusCodes.Good,
                        ServerTimestamp = DateTime.MinValue,
                        SourceTimestamp = DateTime.MinValue
                    }
                };

                WriteValueCollection valuesToWrite = new WriteValueCollection { writeValue };
                StatusCodeCollection results;
                DiagnosticInfoCollection diagnosticInfos;

                session.Write(null, valuesToWrite, out results, out diagnosticInfos);

                if (StatusCode.IsGood(results[0]))
                {
                    MessageBox.Show("Write succeeded!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Write failed!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }

        private void SC001T_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Aqui você pode executar a lógica desejada quando o Enter é pressionado
                MessageBox.Show("Enter pressionado!");
                var value = textBox1.Text;
                double valorDouble = double.Parse(value);
                WriteValue("ns=2;i=285", valorDouble);
                // Por exemplo, chamar um método para processar o texto

            }
        }
    }

}



