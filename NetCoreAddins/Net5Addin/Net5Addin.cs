using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Extensibility;

namespace NetOfficeSamples
{
    [ComVisible(true)]
    [Guid("9A205EF3-1BFD-4B72-82D0-BC7CC3CF9697")]
    [ProgId("NetOfficeSamples.Net5Addin")]
    public class Net5Addin : IDTExtensibility2
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
