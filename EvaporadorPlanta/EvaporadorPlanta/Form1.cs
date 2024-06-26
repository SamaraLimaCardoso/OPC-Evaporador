using Opc.Ua.Configuration;
using Opc.Ua.Server;
using Opc.Ua;
using System;
using System.Windows.Forms;


namespace EvaporadorPlanta
{
    public partial class ServidorPlantaEvaporador : Form
    {
        private ApplicationInstance m_application;
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        public ServidorPlantaEvaporador()
        {
            InitializeComponent();
        }

        public ServidorPlantaEvaporador(ApplicationInstance application)
        {
            InitializeComponent();

            m_application = application;
            m_server = application.Server as StandardServer;
            m_configuration = application.ApplicationConfiguration;

            //Exibir URL SERVIDOR
            comboBox1.Items.Clear();

            foreach (EndpointDescription endpoint in m_server.GetEndpoints())
            {
                if (comboBox1.FindStringExact(endpoint.EndpointUrl) == -1)
                {
                    comboBox1.Items.Add(endpoint.EndpointUrl);
                }
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
