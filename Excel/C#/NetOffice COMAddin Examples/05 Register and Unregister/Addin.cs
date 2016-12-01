using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NetOffice;
using NetOffice.Tools;
using NetOffice.OfficeApi.Enums;
using NetOffice.ExcelApi.Tools;
using Excel = NetOffice.ExcelApi;
using Office = NetOffice.OfficeApi;

namespace Excel05AddinCS4
{
    /*
       Diagnostics Addin Example

       Remove the DontRegisterAddin attribute to load the addin directly.
    */

    [ProgId("Excel05AddinCS4.Connect"), Guid("F0813E2B-C963-431E-A0B3-971A1F70E8A8"), Codebase, Timestamp]
    [RegistryLocation(RegistrySaveLocation.InstallScopeCurrentUser)]
    [DontRegisterAddin]
    public class Addin : COMAddin
    {       
        // We want that NetOffice call this method after register
        [RegisterFunction(RegisterMode.CallAfter)]
        private static void Register(Type type, RegisterCall registerCall, InstallScope scope, OfficeRegisterKeyState keyState)
        {
            
        }

        // We want that NetOffice call this method after unregister
        [UnRegisterFunction(RegisterMode.CallAfter)]
        private static void UnRegister(Type type, RegisterCall registerCall, InstallScope scope, OfficeUnRegisterKeyState keyState)
        {
           
        }

        // An unexpected error occured in register or unregister action
        [RegisterErrorHandler]
        private static void RegisterError(RegisterErrorMethodKind methodKind, Exception exception)
        {
            Office.Tools.Utils.DialogUtils.ShowRegisterError("Excel05AddinCS4", methodKind, exception);
        }
    }
}
