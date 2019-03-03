using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NetOffice;
using NetOffice.Tools;
using NetOffice.OfficeApi.Enums;
using NetOffice.ExcelApi.Tools;
using Excel = NetOffice.ExcelApi;
using Office = NetOffice.OfficeApi;

namespace Excel01AddinCS4
{
    /*
        Minimum Addin Example

        Remove the DontRegisterAddin attribute to load the addin directly.
    */

    [COMAddin("Excel01AddinCS4", "Miminum Addin Example", 3)]
    [ProgId("Excel05AddinCS4.Connect"), Guid("BB5D9F5A-267A-462E-9980-C65204969BE3")]
    public class Addin : COMAddin
    {
        public Addin()
        {
            OnStartupComplete += Addin_OnStartupComplete;
            OnDisconnection += Addin_OnDisconnection;
        }

        private void Addin_OnStartupComplete(ref Array custom)
        {

        }

        private void Addin_OnDisconnection(ext_DisconnectMode removeMode, ref Array custom)
        {

        }
    }
}
