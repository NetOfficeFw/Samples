using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ExampleBase
{
    /// <summary>
    /// Application config options dialog
    /// </summary>
    partial class FormOptions : Form
    {
        #region Fields

        private static int _lcid = FormOptions.DefaultLCID;

        #endregion

        #region Properties

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        /// <param name="rootDirectory">current output directory</param>
        public FormOptions(string rootDirectory)
        {
            InitializeComponent();

            if (1031 == _lcid)
                radioButtonLanguage1031.Checked = true;

            if (Application.StartupPath != rootDirectory)
                radioButtonDocumentsFolder.Checked = true;
        }

        /// <summary>
        /// Current Language LCID
        /// </summary>
        public static int LCID
        {
            get
            {
                return _lcid;
            }
        }

        /// <summary>
        /// Current output directory for created office files
        /// </summary>
        public string RootDirectory
        {
            get
            {
                return radioButtonApplicationFolder.Checked ? Application.StartupPath : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "NetOfficeSamples");
            }
        }

        /// <summary>
        /// Default Language LCID. (1033 En-us)
        /// </summary>
        public static int DefaultLCID
        {
            get
            {
                return 1033;
            }
        }

        /// <summary>
        /// Default output directory for created office files
        /// </summary>
        public static string DefaultRootDirectory
        {
            get
            {
                return Application.StartupPath;
            }
        }

        #endregion

        #region Trigger

        private void radioButtonLanguage1033_CheckedChanged(object sender, EventArgs e)
        {
            _lcid = radioButtonLanguage1031.Checked ? 1031 : 1033;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (radioButtonDocumentsFolder.Checked)
            {
                string folder = this.RootDirectory;
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion
    }
}
