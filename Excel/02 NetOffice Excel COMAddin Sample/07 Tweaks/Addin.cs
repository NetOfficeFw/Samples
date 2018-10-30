using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Runtime.InteropServices;
using NetOffice.Tools;
using NetOffice.ExcelApi.Tools;
using NetOffice.ExcelApi;



namespace Excel07AddinCS4
{
    /*
      Tweaks Addin Example

      Remove the DontRegisterAddin attribute to load the addin directly.
    */

    [COMAddin("NetOfficeCS45 Sample Excel Addin", "This Addin shows you the COMAddin tweak option from the NetOffice Tools", 3)]
    [ProgId("Excel07AddinCS4.Connect"), Guid("DF2DA04E-CD24-4F48-B7F2-A7C3C56E877A")]
    [Tweak(true)]  // <== the tweak attribute
    public class Addin : COMAddin
    {
        // We set some default- and custom tweaks in the register method.
        // Please note: Installers like .msi or other doesnt call the static register methods for your (managed) addin while un-/registration.
        // You have to set these entries at hand in the corresponding deployment project.
        [RegisterFunction(RegisterMode.CallAfter)]
        public static void Register(Type type, RegisterCall registerCall)
        {
            // SetTweakPersistenceEntry sets the key for you in the current registry key.
            // We set a custom tweak and a Netoffice default tweak.
            SetTweakPersistenceEntry(type, "ShowTray", "yes", false);
            SetTweakPersistenceEntry(type, "NOConsoleMode", "trace", false);
        }

        // This method was called for all (currently found) tweaks while startup. This means the NetOffice tweaks and your own tweaks.
        // You have to decide the tweak is allowed or not. Please keep in your mind: All NetOffice tweak names starts with 'NO'
        protected override bool AllowApplyTweak(string name, string value)
        {
            // we accept all tweaks
            return true;
        }

        // This method was called from IDTExtensibility2.OnStartupComplete for all your custom tweaks if its allowed(see AllowApplyTweak)
        protected override void ApplyCustomTweak(string name, string value)
        {
            if (name == "ShowTray" && value == "yes")
            {
                Utils.Tray.Text = "Excel07AddinCS4.Addin";
                Utils.Tray.Visible = true;
            }
        }

        // This method was called while disconnection for all your allowed custom aplied tweaks to remove or unload them.
        // Please keep in your mind: the method is never called in state of unexpected termination. you have no warranties for the method.
        protected override void DisposeCustomTweak(string name, string value)
        {
            if (name == "ShowTray")
            {
                Utils.Tray.Text = "Excel07AddinCS4.Addin";
                Utils.Tray.Visible = false;
            }
        }
    }
}
