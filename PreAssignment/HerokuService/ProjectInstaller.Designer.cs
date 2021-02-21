namespace HerokuService
{
    partial class ProjectInstaller
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
            this.serviceProcessInstallerHeroku = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstallerHeroku = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller1
            // 
            this.serviceProcessInstallerHeroku.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.serviceProcessInstallerHeroku.Password = null;
            this.serviceProcessInstallerHeroku.Username = null;
            // 
            // serviceInstaller1
            // 
            this.serviceInstallerHeroku.ServiceName = "Heroku";
            this.serviceInstallerHeroku.StartType = System.ServiceProcess.ServiceStartMode.Automatic;

            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstallerHeroku,
            this.serviceInstallerHeroku});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstallerHeroku;
        private System.ServiceProcess.ServiceInstaller serviceInstallerHeroku;
    }
}