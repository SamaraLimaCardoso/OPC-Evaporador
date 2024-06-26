using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Configuration;

namespace EvaporadorPlanta
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            ApplicationInstance application = new ApplicationInstance();
            application.ApplicationType = ApplicationType.Server;
            application.ConfigSectionName = "EvaporadorPlantaServer";

            try
            {
                // process and command line arguments.
                if (application.ProcessCommandLine())
                {
                    return;
                }

                // check if running as a service.
                if (!Environment.UserInteractive)
                {
                    application.StartAsService(new EvaporadorPlantaServer());
                    return;
                }

                //Carregar as configuraçõs do Aplicativo
                application.LoadApplicationConfiguration("EvaporadorPlanta.Config.xml", false).Wait();
                // Verificar o Certificado
                application.CheckApplicationInstanceCertificate(false, 0).Wait();
                // Iniciar o Servidor
                application.Start(new EvaporadorPlantaServer()).Wait();

                // run the application interactively.
                Application.Run(new ServidorPlantaEvaporador(application));
            }
            catch (Exception e)
            {
                string text = "Exception: " + e.Message;
                if (e.InnerException != null)
                {
                    text += "\r\nInner exception: ";
                    text += e.InnerException.Message;
                }
                MessageBox.Show(text, application.ApplicationName);
            }
        }
    }
}
