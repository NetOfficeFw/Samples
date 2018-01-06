using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NetOffice;
using System.Drawing;
using NetOffice.Tools;
using NetOffice.OfficeApi.Enums;
using NetOffice.ExcelApi.Tools;
using NetOffice.ExcelApi.Tools.Contribution;
using NetOffice.OfficeApi.Tools.Contribution;
using Excel = NetOffice.ExcelApi;
using Office = NetOffice.OfficeApi;

namespace Excel06AddinCS4
{
    /*
      Utils Addin Example

      Remove the DontRegisterAddin attribute to load the addin directly.
   */

    [ProgId("Excel06AddinCS4.Connect"), Guid("CC85F97A-F409-4497-B2F2-A9581D4A2ED2"), Codebase, Timestamp]
    [DontRegisterAddin]
    public class Addin : COMAddin
    {
        public Addin()
        {
            OnStartupComplete += Addin_OnStartupComplete;
        }

        private void UseDialogUtils()
        {
            // Get or set to suspend dialogs if application is in automation mode
            bool foo1 = Utils.Dialog.SuppressOnAutomation;

            // Get or set to suspend dialogs if application main window is hidden
            bool foo2 = Utils.Dialog.SuppressOnHide;

            //Get or set to suspend dialogs generaly
            bool foo3 = Utils.Dialog.SupressGeneraly;

            // show a predefined text dialog - the last argument is the result when the dialog is suspended
            Utils.Dialog.ShowText("Excel06AddinCS4", "Hello from DialogUtils", 5, true, DialogUtils.Result.No);

            // This is an example to bring up your own dialog modal to the application window
            //-----------------------------------------------
            // Form form1 = new Form();
            // Utils.Dialog.ShowDialog(Application.Hwnd, form, true, DialogUtils.Result.None);
        }

        private void UseColorUtils()
        {
            // Colors in excel use a double representation
            // NetOffice color utils help to deal with them
            
            if (Application.Workbooks.Count > 0 && Application.Workbooks[1].Worksheets.Count > 0)
            {
                Excel.Worksheet sheet = Application.Workbooks[1].Worksheets[1] as Excel.Worksheet;

                double setColor = Utils.Color.ToDouble(Color.Red);
                sheet.Range("A1:B4").Interior.Color = setColor;

                Color getColor = Utils.Color.ToColor(sheet.Range("A1:B4").Interior.Color);
            }
        }

        private void UseTrayUtils()
        {
            // setup a tray icon to signalize we are loaded
            // and show NetOffice diagnostics default dialog on double click
            Utils.Tray.Setup(true, "Excel06AddinCS4", "Addin.ico");
            Utils.Tray.ShowBalloonTip(3000, "Sample", "Hello from Excel06AddinCS4", TrayToolTipIcon.Info);
            Utils.Tray.DoubleClick += delegate { Utils.Dialog.ShowDiagnostics(); };
            // add some standard menu items to the tray
            TrayMenuItem item1 = Utils.Tray.Menu.Items.Add<TrayMenuItem>("Item 1");
            TrayMenuProgressItem item2 = Utils.Tray.Menu.Items.Add<TrayMenuProgressItem>("Item 2");
            item2.Value = 60;
            TrayMenuCheckboxItem item3 = Utils.Tray.Menu.Items.Add<TrayMenuCheckboxItem>("Item 3");
            TrayMenuDropDownListItem item4 = Utils.Tray.Menu.Items.Add<TrayMenuDropDownListItem>("Item 4");
            item4.DataSource.Add("SubItem1", "SubItem2", "SubItem3");
            TrayMenuButtonItem item5 = Utils.Tray.Menu.Items.Add<TrayMenuButtonItem>("Item 5");
        }

        private void UseFileUtils()
        {
            // File utils want help to find the current valid file extension for a file type
            
            // A template that contains macros is "xlsm" in modern office applications
            // but its not in older version - FileUtils take care for that
            string currentFileExtension = Utils.File.FileExtension(DocumentFormat.TemplateMacros);

            // Build a valid file path for a normal document without macros
            string fullFileName = Utils.File.Combine(@"C:\MyFiles", "Book1", DocumentFormat.Normal);
        }

        private void Addin_OnStartupComplete(ref Array custom)
        {
            UseTrayUtils();
            UseColorUtils();
            UseDialogUtils();
            UseFileUtils();
        }
    }
}
