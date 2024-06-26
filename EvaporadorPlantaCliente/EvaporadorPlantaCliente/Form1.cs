using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Configuration;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace EvaporadorPlantaCliente
{
    public partial class Form1 : Form
    {
        private Session session;
        private ApplicationConfiguration appConfiguration; // Adiciona como campo de classe   

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
        }

        // Botão de conectar
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            upcua_Inicia();
            inicializacaoEscrita();
            ReadVar();
            ReadNovasVar();
            // Inicia o Timer
            timer1.Start();
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

        void ReadVar()
        {
            Console.WriteLine("Atualizei....................................");
            if (SC001 != newSC001)
            {
                try
                {
                    var SC001 = session.ReadValue(NodeId.Parse("ns=2;i=301"));
                    sc001.Text = SC001.Value != null ? SC001.Value.ToString() : "null";
                    //sc001.ForeColor = System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    sc001.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show($"Erro ao realizar leitura: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (SC002 != newSC002)
            {
                try
                {
                    var SC002 = session.ReadValue(NodeId.Parse("ns=2;i=344"));
                    sc002.Text = SC002.Value != null ? SC002.Value.ToString() : "null";
                }
                catch (Exception ex)
                {
                    sc002.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show($"Erro ao realizar leitura: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (SC003 != newSC003)
            {
                try
                {
                    var aux = session.ReadValue(NodeId.Parse("ns=2;i=309"));
                    sc003.Text = aux.Value != null ? aux.Value.ToString() : "null";
                }
                catch (Exception ex)
                {
                    sc003.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show($"Erro ao realizar leitura: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (FV001 != newFV001)
            {
                try
                {
                    var aux = session.ReadValue(NodeId.Parse("ns=2;i=331"));
                    fv001.Text = aux.Value != null ? aux.Value.ToString() : "null";
                }
                catch (Exception ex)
                {
                    fv001.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show($"Erro ao realizar leitura: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (FV002 != newFV002)
            {
                try
                {
                    var SC001 = session.ReadValue(NodeId.Parse("ns=2;i=317"));
                    fv002.Text = SC001.Value != null ? SC001.Value.ToString() : "null";
                }
                catch (Exception ex)
                {
                    fv002.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show($"Erro ao realizar leitura: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (TV001 != newTV001)
            {
                try
                {
                    var aux = session.ReadValue(NodeId.Parse("ns=2;i=270"));
                    tv001.Text = aux.Value != null ? aux.Value.ToString() : "null";
                }
                catch (Exception ex)
                {
                    tv001.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show($"Erro ao realizar leitura: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (LT001 != newLT001)
            {
                try
                {
                    var LT0011 = session.ReadValue(NodeId.Parse("ns=2;i=292"));
                    LT001T1.Text = LT0011.Value != null ? LT0011.Value.ToString() : "null";
                    LT001T2.Text = LT0011.Value != null ? LT0011.Value.ToString() : "null";
                    LT001T3.Text = LT0011.Value != null ? LT0011.Value.ToString() : "null";
                    LT001T4.Text = LT0011.Value != null ? LT0011.Value.ToString() : "null";
                    LT001T5.Text = LT0011.Value != null ? LT0011.Value.ToString() : "null";
                }
                catch (Exception ex)
                {
                    LT001T1.ForeColor = System.Drawing.Color.Red;
                    LT001T2.ForeColor = System.Drawing.Color.Red;
                    LT001T3.ForeColor = System.Drawing.Color.Red;
                    LT001T4.ForeColor = System.Drawing.Color.Red;
                    LT001T5.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show($"Erro ao realizar leitura: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (TT001 != newTT001)
            {
                try
                {
                    var aux = session.ReadValue(NodeId.Parse("ns=2;i=262"));
                    TT0011.Text = aux.Value != null ? aux.Value.ToString() : "null";
                }
                catch (Exception ex)
                {
                    TT0011.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show($"Erro ao realizar leitura: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void ReadVar1()
        {
            SC001 = session.ReadValue(NodeId.Parse("ns=2;i=301")).ToString();
            SC002 = session.ReadValue(NodeId.Parse("ns=2;i=344")).ToString();
            SC003 = session.ReadValue(NodeId.Parse("ns=2;i=309")).ToString();
            FV001 = session.ReadValue(NodeId.Parse("ns=2;i=331")).ToString();
            FV002 = session.ReadValue(NodeId.Parse("ns=2;i=317")).ToString();
            TV001 = session.ReadValue(NodeId.Parse("ns=2;i=270")).ToString();
            LT001 = session.ReadValue(NodeId.Parse("ns=2;i=292")).ToString();
            TT001 = session.ReadValue(NodeId.Parse("ns=2;i=262")).ToString();
        }
        void ReadNovasVar()
        {
            newSC001 = session.ReadValue(NodeId.Parse("ns=2;i=301")).ToString();
            newSC002 = session.ReadValue(NodeId.Parse("ns=2;i=344")).ToString();
            newSC003 = session.ReadValue(NodeId.Parse("ns=2;i=309")).ToString();
            newFV001 = session.ReadValue(NodeId.Parse("ns=2;i=331")).ToString();
            newFV002 = session.ReadValue(NodeId.Parse("ns=2;i=317")).ToString();
            newTV001 = session.ReadValue(NodeId.Parse("ns=2;i=270")).ToString();
            newLT001 = session.ReadValue(NodeId.Parse("ns=2;i=292")).ToString();
            newTT001 = session.ReadValue(NodeId.Parse("ns=2;i=262")).ToString();
            Console.WriteLine(newSC001);
        }


        /// <summary>
        /// ESCRITAAAA DAS VARIAVEIS 
        /// </summary>
        /// <returns></returns>
        /// 

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
                    //MessageBox.Show("Escrito com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Escrita Falhou!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                var NodeId = "ns=2;i=301";
                var value = SC001T.Text;
                double valorDouble = double.Parse(value);
                WriteValue(NodeId, valorDouble);
            }
        }
        private void SC002T_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var NodeId = "ns=2;i=344";
                var value = SC002T.Text;
                double valorDouble = double.Parse(value);
                WriteValue(NodeId, valorDouble);
            }
        }
        private void SC003T_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var NodeId = "ns=2;i=309";
                var value = SC003T.Text;
                double valorDouble = double.Parse(value);
                WriteValue(NodeId, valorDouble);        
            }
        }
        private void FV001T_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var NodeId = "ns=2;i=331";
                var value = FV001T.Text;
                double valorDouble = double.Parse(value);
                WriteValue(NodeId, valorDouble);
            }
        }
        private void FV002T_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var NodeId = "ns=2;i=317";
                var value = FV002T.Text;
                double valorDouble = double.Parse(value);
                WriteValue(NodeId, valorDouble);
            }
        }
        private void TV001T_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var NodeId = "ns=2;i=270";
                var value = TV001T.Text;
                double valorDouble = double.Parse(value);
                WriteValue(NodeId, valorDouble);
            }
        }

        void inicializacaoEscrita()
        {
            try
            {
                //
                double valorDouble = 0;
                var NodeId = "ns=2;i=301";
                WriteValue(NodeId, valorDouble);
                NodeId = "ns=2;i=344";
                WriteValue(NodeId, valorDouble);
                NodeId = "ns=2;i=309";
                WriteValue(NodeId, valorDouble);
                NodeId = "ns=2;i=331";
                WriteValue(NodeId, valorDouble);
                NodeId = "ns=2;i=317";
                WriteValue(NodeId, valorDouble);
                NodeId = "ns=2;i=270";
                WriteValue(NodeId, valorDouble);
                NodeId = "ns=2;i=292";
                WriteValue(NodeId, valorDouble);
                NodeId = "ns=2;i=262";
                WriteValue(NodeId, valorDouble);
                MessageBox.Show("Inicializado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Inicialização Falhou!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadVar();
        }


    }

}



