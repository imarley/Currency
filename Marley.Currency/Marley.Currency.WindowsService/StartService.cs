using System;
using System.Configuration;
using System.ServiceProcess;
using Marley.Currency.WindowsService.Services;
using Plataforma.Infrastructure.WindowService.Service.Services;

namespace Marley.Currency.WindowsService
{
    public partial class StartService : ServiceBase
    {
        #region Fields

        
        #endregion

        #region Constructors

        public StartService()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods Protected

        protected override void OnStart(string[] args)
        {
            timerStart.Start();
        }

        protected override void OnStop()
        {
            timerStart.Stop();
        }

        #endregion

        #region Methods Private

        private void timerStart_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                var start = int.Parse(ConfigurationManager.AppSettings["Start"]);
                var finish = int.Parse(ConfigurationManager.AppSettings["Finish"]);
                var alltime = bool.Parse(ConfigurationManager.AppSettings["AllTime"]);
                var hour = DateTime.Now.Hour;
                if (alltime == false && (hour < start || hour > finish)) return;
                timerStart.Stop();
                Main.Load();
            }
            catch (Exception ex)
            {
                UtilService.Log($"[{DateTime.Now.ToShortTimeString()}] {ex.Message}" + Environment.NewLine, ConfigurationManager.AppSettings["Log"]);
            }
            finally
            {
                GC.SuppressFinalize(this);
                timerStart.Start();
            }
        }

        #endregion
    }
}
