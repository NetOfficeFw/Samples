using System;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NetOffice;
using NetOffice.Tools;
using NetOffice.OfficeApi.Enums;
using NetOffice.ExcelApi.Tools;
using Excel = NetOffice.ExcelApi;
using Office = NetOffice.OfficeApi;
using NetOffice.OfficeApi.Tools.Utils;

namespace LoaderShim
{
    /*
        NetOffice Example Addin Loader
    */

    [ProgId("LoaderShimCS4.Connect"), Guid("D94FA3BE-8ECB-4965-A970-4F27B094E7F4"), Codebase, Timestamp]
    public class Connect : COMAddin
    {
        private Dictionary<string, Type> Addins { get; set; }

        public Connect()
        {
            SetupAvailableAddins();
            AssignExtensibility();
        }
         
        private Office.Tools.IOfficeCOMAddin Current { get; set; }

        private void AssignExtensibility()
        {
            OnConnection += Connect_OnConnection;
            OnDisconnection += Connect_OnDisconnection;
            OnStartupComplete += Connect_OnStartupComplete;
            OnAddInsUpdate += Connect_OnAddInsUpdate;
            OnBeginShutdown += Connect_OnBeginShutdown;
        }

        private void SetupAvailableAddins()
        {
            Addins = new Dictionary<string, Type>();
            Addins.Add("Simple Addin", typeof(Excel01AddinCS4.Addin));
            Addins.Add("Ribbons and Panes", typeof(Excel02AddinCS4.Addin));
            Addins.Add("Troubleshooting and Diagnostics", typeof(Excel03AddinCS4.Addin));
            Addins.Add("Register and Unregister", typeof(Excel05AddinCS4.Addin));
            Addins.Add("Tools and Helpers", typeof(Excel06AddinCS4.Addin));
            Addins.Add("Tweaks", typeof(Excel07AddinCS4.Addin));
        }

        public override string GetCustomUI(string RibbonID)
        {
            if (null != Current)
                return Current.GetCustomUI(RibbonID);
            else
                return String.Empty;
        }

        public override void CTPFactoryAvailable(object CTPFactoryInst)
        {
            if (null != Current)
                Current.CTPFactoryAvailable(CTPFactoryInst);
        }        

        private void Connect_OnBeginShutdown(ref Array custom)
        {
            if (null != Current)
                (Current as IDTExtensibility2).OnBeginShutdown(ref custom);
        }

        private void Connect_OnAddInsUpdate(ref Array custom)
        {
            if (null != Current)
                (Current as IDTExtensibility2).OnAddInsUpdate(ref custom);
        }

        private void Connect_OnStartupComplete(ref Array custom)
        {
            if (null != Current)
                (Current as IDTExtensibility2).OnStartupComplete(ref custom);
        }

        private void Connect_OnDisconnection(ext_DisconnectMode removeMode, ref Array custom)
        {
            if (null != Current)
                (Current as IDTExtensibility2).OnDisconnection(removeMode, ref custom);
        }

        private void Connect_OnConnection(object application, ext_ConnectMode connectMode, object addInInst, ref Array custom)
        {
            if (null != Addins)
            { 
                SelectionForm form = new SelectionForm(Addins);
                DialogUtils.Result result = Utils.Dialog.ShowDialog(Application.Hwnd, form, true);
                if (result == DialogUtils.Result.OK)
                    Current = Activator.CreateInstance(Addins[form.SelectedName]) as Office.Tools.IOfficeCOMAddin;
            }

            if (null != Current)
            {
                (Current as IDTExtensibility2).OnConnection(Application.UnderlyingObject, connectMode, addInInst, ref custom);
            }
        }

        public void OnLoadRibonUI(Office.IRibbonUI ribbonUI)
        {
            Current.GetType().InvokeMember("RibbonUI", 
                BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance,
                null, Current, new object[] { ribbonUI });
        }

        public bool OnGetPressedPanelToggle(Office.IRibbonControl control)
        {
            return (bool)Current.GetType().InvokeMember("OnGetPressedPanelToggle",
                  BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
                  null, Current, new object[] { control });
        }

        public void OnCheckPanelToggle(Office.IRibbonControl control, bool pressed)
        {
            Current.GetType().InvokeMember("OnCheckPanelToggle",
                  BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
                  null, Current, new object[] { control, pressed });
        }

        public void OnClickAboutButton(Office.IRibbonControl control)
        {
            Current.GetType().InvokeMember("OnClickAboutButton",
                 BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
                 null, Current, new object[] { control });
        }
    }
}
