using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NetOffice.Tools;
using NetOffice.OfficeApi;
using NetOffice.OfficeApi.Tools;
using NetOffice;
using NetOffice.OfficeApi.Tools.Contribution;

namespace NetOfficeSamples.SuperAddinCS1
{
    [COMAddin("NetOffice SuperAddin Sample (COMAddin)", "This NetOffice Addin shows how to register single addin class to multiple Microsoft Office products.", 3)]
    [RegistryLocation(RegistrySaveLocation.CurrentUser)]
    [Guid("CF0E2618-37D5-4efb-BD25-58301228ED0E")]
    [ProgId("NetOfficeSample.COMAddinSuperAddin.Addin")]
    [Tweak(true)]
    [MultiRegister(RegisterIn.Excel, RegisterIn.Word, RegisterIn.PowerPoint, RegisterIn.Outlook, RegisterIn.Access, RegisterIn.MSProject)]  // MS Visio is not supported because Visio does not use the common office core
    [CustomUI("RibbonUI.xml", true)]
    public class Addin : COMAddin
    {
        public const string ADDIN_TITLE = "NetOffice SuperAddin Sample";

        public void OnAction(IRibbonControl control)
        {
            try
            {
                string version = Invoker.Default.PropertyGet(Application, "Version") as string;
                string appInfo = $"\n\nHost application: {Application.InstanceFriendlyName}\nVersion: {version}";

                switch (control.Id)
                {
                    case "customButton1":
                        Utils.Dialog.ShowMessageBox("This is the first sample button. " + appInfo, ADDIN_TITLE, DialogUtils.Result.None);
                        break;
                    case "customButton2":
                        Utils.Dialog.ShowMessageBox("This is the second sample button. " + appInfo, ADDIN_TITLE, DialogUtils.Result.None);
                        break;
                    case "btnAbout":
                        Utils.Dialog.ShowMessageBox("Sample add-in built with NetOffice COMAddin class that is registered to multiple Microsoft Office applications.", ADDIN_TITLE, DialogUtils.Result.None);
                        break;
                    default:
                        Utils.Dialog.ShowMessageBox("Unkown Control Id: " + control.Id, ADDIN_TITLE, DialogUtils.Result.None);
                        break;
                }
            }
            catch (Exception throwedException)
            {
                Utils.Dialog.ShowError(throwedException, "Unexpected state in SuperAddinCS4 OnAction");
            }
        }

        protected override void OnError(ErrorMethodKind methodKind, Exception exception)
        {
            Utils.Dialog.ShowError(exception, $"Unexpected error occured in method {methodKind}.");
        }

        [RegisterErrorHandler]
        public static void RegisterErrorHandler(RegisterErrorMethodKind methodKind, Exception exception)
        {
            MessageBox.Show($"Registration error in {methodKind}: {exception.Message}", ADDIN_TITLE);
        }
    }
}
