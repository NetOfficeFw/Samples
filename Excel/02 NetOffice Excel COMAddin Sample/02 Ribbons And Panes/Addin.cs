using System;
using System.Runtime.InteropServices;
using NetOffice;
using NetOffice.Tools;
using NetOffice.OfficeApi.Enums;
using NetOffice.ExcelApi.Tools;
using Excel = NetOffice.ExcelApi;
using Office = NetOffice.OfficeApi;

namespace Excel02AddinCS4
{
    /*
        Ribbon & Pane Addin Example

        Remove the DontRegisterAddin attribute to load the addin directly.
    */

    [CustomUI("RibbonUI.xml", true)]
    [CustomPane(typeof(SamplePane), "Excel CPU Usage", true, PaneDockPosition.msoCTPDockPositionTop, PaneDockPositionRestrict.msoCTPDockPositionRestrictNoChange, 60, 60)]
    [ProgId("Excel02AddinCS4.Connect"), Guid("BA38FD48-47BD-43de-8177-0D067A01B566")]
    public class Addin : COMAddin
    {
        // Taskpane visibility has been changed. We upate the checkbutton in the ribbon ui for show/hide taskpane
        protected override void TaskPaneVisibleStateChanged(Office._CustomTaskPane customTaskPaneInst)
        {
            if (null != RibbonUI)
                RibbonUI.InvalidateControl("PaneVisibleToogleButton");
        }

        // Defined in RibbonUI.xml to make sure the checkbutton state is up-to-date and synchronized with taskpane visibility.
        public bool OnGetPressedPanelToggle(Office.IRibbonControl control)
        {
            if (TaskPanes.Count > 0)
                return TaskPanes[0].Visible;
            else
                return false;
        }

        // Defined in RibbonUI.xml to track the user clicked ouer checkbutton. Then we upate the panel visibility at hand.
        public void OnCheckPanelToggle(Office.IRibbonControl control, bool pressed)
        {
            if (TaskPanes.Count > 0)
                TaskPanes[0].Visible = pressed;
        }

        // Defined in RibbonUI.xml to catch the user click for the about button
        public void OnClickAboutButton(Office.IRibbonControl control)
        {
            Utils.Dialog.ShowAbout("NetOffice Addin Example", "http://netoffice.codeplex.com", "<No licence set>");
        }
    }
}
