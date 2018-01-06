using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NetOffice;
using NetOffice.Tools;
using NetOffice.OfficeApi.Enums;
using NetOffice.ExcelApi.Tools;
using NetOffice.OfficeApi.Tools.Contribution;
using Excel = NetOffice.ExcelApi;
using Office = NetOffice.OfficeApi;

namespace Excel03AddinCS4
{
    /*
       Diagnostics Addin Example

       Remove the DontRegisterAddin attribute to load the addin directly.
    */

    [ProgId("Excel03AddinCS4.Connect"), Guid("E0FE2411-4031-4110-A244-3CE8133C3ECD"), Codebase, Timestamp, ForceInitialize]
    [DontRegisterAddin]
    public class Addin : COMAddin
    {
        public Addin()
        {
            // Redirect console to System.Diagnostics.Trace and write a message
            Factory.Console.Mode = DebugConsoleMode.Trace;
            Factory.Console.WriteLine("Excel03AddinCS4 has been started.");

            // Shared output want send all given console messages to a named pipe
            Factory.Console.EnableSharedOutput = true;
            Factory.Console.Name = "Excel03AddinCS4";

            OnStartupComplete += Addin_OnStartupComplete;
        }

        private void Addin_OnStartupComplete(ref Array custom)
        {
            // How long NetOffice need to complete the internal initialize process
            Factory.Console.WriteLine("NetOffice has been initialized in {0}", Factory.InitializedTime);

            // The LoadingTimeElapsed instance property want give us information how long the addin need to be loaded
            Factory.Console.WriteLine("Addin has been loaded completely in {0}", LoadingTimeElapsed);
            
            // Setup a tray icon and menu with available diagnostics
            Utils.Tray.Setup(true, "Addin Diagnostics", "Addin.ico");
            Utils.Tray.ShowBalloonTip(1000, "Addin Diagnostics", "Click here to see diagnostics", TrayToolTipIcon.Info);
            Utils.Tray.Menu.AutoClose = false;
            Utils.Tray.Menu.Items.Add<TrayMenuLabelItem>("Addin Diagnostics", true, "TrayMenuHeader.png");
            Utils.Tray.Menu.Items.Add<TrayMenuSeparatorItem>();
            Utils.Tray.Menu.Items.Add<TrayMenuMonitorItem>();
            Utils.Tray.Menu.Items.Add<TrayMenuSeparatorItem>();
            Utils.Tray.Menu.Items.Add<TrayMenuItem>("Fetch books and sheets");
            Utils.Tray.Menu.Items.Add<TrayMenuItem>("Dispose all application child proxies");
            Utils.Tray.Menu.Items.Add<TrayMenuSeparatorItem>();
            Utils.Tray.Menu.Items.Add<TrayMenuAutoCloseItem>("Enable Auto Close Menu");
            Utils.Tray.Menu.Items.Add<TrayMenuCloseItem>("Close Menu");
            Utils.Tray.Menu.ItemClick += Menu_ItemClick;

            // Enable performance trace in Excel and to see all actions there need >= 10 milliseconds
            Factory.Settings.PerformanceTrace["ExcelApi"].IntervalMS = 10;
            Factory.Settings.PerformanceTrace["ExcelApi"].Enabled  = true;
            Factory.Settings.PerformanceTrace.Alert += PerformanceTrace_Alert;

            // Check excel has been started from another program like: new Excel.Application()
            bool automationMode = Utils.IsAutomation;

            // Check for admin permissions and excel is 2007 or higher in its version
            bool hasAdminPermissions = Utils.AdminPermissions;
            bool is2007OrHigher = Utils.ApplicationIs2007OrHigher;
        }

        private void Menu_ItemClick(object sender, TrayMenuItemsEventArgs args)
        {
            // see what happen in proxy live monitor

            if (args.Item.Text == "Fetch books and sheets")
            {
                foreach (Excel.Workbook book in Application.Workbooks)
                {
                    foreach (Excel.Worksheet sheet in book.Sheets)
                    {

                    }
                }
            }
            else if (args.Item.Text == "Dispose all application child proxies")
            {
                Application.DisposeChildInstances();
            }
        }

        /*
            This method is called when something failed in the COMAddin base class
        */
        protected override void OnError(ErrorMethodKind methodKind, Exception exception)
        {
            Utils.Dialog.ShowErrorDefault(methodKind, exception);
        }

        private void PerformanceTrace_Alert(PerformanceTrace sender, PerformanceTrace.PerformanceAlertEventArgs args)
        {            
            Factory.Console.WriteLine("PerformanceTrace Alert: {0}", args);
        }
    }
}
