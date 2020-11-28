using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Extensibility;

namespace NetOfficeSamples
{
    [ComVisible(true)]
    [Guid("E5C5C7DE-D206-448D-BC01-A3FA00B33DF6")]
    [ProgId("NetOfficeSamples.NetCore3Addin")]
    public class NetCore3Addin : IDTExtensibility2
    {
        public void OnConnection(object application, ext_ConnectMode connectMode, object addInInst, ref Array custom)
        {
            Trace.WriteLine($"Addin connected to application. Mode: {connectMode}");
            var type = application.GetType();
            var name = type.FullName;
            var isCom = Marshal.IsComObject(application);

            try
            {
                var unknown = Marshal.GetIUnknownForObject(application);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"Marshal failed. {ex}");
            }
        }

        public void OnDisconnection([In] ext_DisconnectMode removeMode, [In, MarshalAs(29, SafeArraySubType = VarEnum.VT_VARIANT)] ref Array custom)
        {
            Trace.WriteLine($"Addin disconnecting from application. Mode: {removeMode}");
        }

        public void OnAddInsUpdate([In, MarshalAs(29, SafeArraySubType = VarEnum.VT_VARIANT)] ref Array custom)
        {
        }

        public void OnStartupComplete([In, MarshalAs(29, SafeArraySubType = VarEnum.VT_VARIANT)] ref Array custom)
        {
            Trace.WriteLine($"Addin startup completed.");
        }

        public void OnBeginShutdown([In, MarshalAs(29, SafeArraySubType = VarEnum.VT_VARIANT)] ref Array custom)
        {
        }
    }
}
