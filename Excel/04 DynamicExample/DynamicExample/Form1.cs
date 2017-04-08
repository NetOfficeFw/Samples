using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NetOffice;

namespace WindowsFormsApplication1
{
    /*
        COMDynamicObject class interacts as full wrapper incl. all NetOffice com proxy management.
        This allows a very lightweight use of com components at runtime with C# dynamics or visual basic latebinding.
        The only drawback is the missing event support.
         
        In NetOffice 1.7.4 - each time NetOffice can not find a wrapper for a proxy,
        a COMDynamicObject instance is given in return.

        COMDynamicObject inherites from ICOMObject interface.
        Each wrapper class in NetOffice 1.7.4 implements these interface.
        (
            If you already use/know NetOffice:
            Using the COMObject base class now is depricated - use ICOMObject instead
        )
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupUI();
        }

        private dynamic Application { get; set; }

        private void StartExcelButton_Click(object sender, EventArgs e)
        {
            Application = new COMDynamicObject("Excel.Application");
            LogBox.AppendText("Application Has Been started" + Environment.NewLine);
            SetupUI();
        }

        private void AddWorkbookButton_Click(object sender, EventArgs e)
        {
            dynamic books = Application.Workbooks;
            dynamic book = books.Add();
            dynamic sheets = book.Sheets;
            foreach (dynamic item in sheets)
                LogBox.AppendText("Sheet Name " + item.Name + Environment.NewLine);
            SetupUI();
        }

        private void DisposeChildsButton_Click(object sender, EventArgs e)
        {
            Application.DisposeChildInstances();
            LogBox.AppendText("Application Child Instance Has Been Disposed." + Environment.NewLine);
            SetupUI();
        }

        private void QuitExcelButton_Click(object sender, EventArgs e)
        {
            Application.DisplayAlerts = false;
            Application.Quit();
            Application.Dispose();
            Application = null;
            LogBox.AppendText("Application Has Been Disposed." + Environment.NewLine);
            SetupUI();
        }

        private void SetupUI()
        {
            if (null != Application)
                LogBox.AppendText("Proxy Count " + Application.Factory.ProxyCount + Environment.NewLine);

            StartExcelButton.Enabled = null == Application;
            AddWorkbookButton.Enabled = null != Application;
            DisposeChildsButton.Enabled = null != Application;
            QuitExcelButton.Enabled = null != Application;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (null != Application)
                {
                    Application.Quit();
                    Application.Dispose();
                    Application = null;
                }
            }
            catch
            {
                // Nothing we can do at this point
                ;
            }          
        }
    }
}
