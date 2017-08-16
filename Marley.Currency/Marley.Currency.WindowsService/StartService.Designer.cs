using System.Configuration;

namespace Marley.Currency.WindowsService
{
    partial class StartService
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timerStart = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.timerStart)).BeginInit();
            // 
            // timerStart
            // 
            this.timerStart.Enabled = true;
            this.timerStart.Interval = double.Parse(ConfigurationManager.AppSettings["Interval"]);
            this.timerStart.Elapsed += new System.Timers.ElapsedEventHandler(this.timerStart_Elapsed);
            // 
            // MarleyCurrency
            // 
            this.ServiceName = "Marley Currency";
            ((System.ComponentModel.ISupportInitialize)(this.timerStart)).EndInit();

        }

        #endregion

        private System.Timers.Timer timerStart;
    }
}
