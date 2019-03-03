using System;
using System.Windows.Forms;
using ExampleBase;
using Access = NetOffice.AccessApi;
using DAO = NetOffice.DAOApi;

namespace AccessExamplesCS4
{
    /// <summary>
    /// Example 4 - Database informations
    /// </summary>
    internal partial class Example04 : UserControl, IExample
    {
        #region Ctor

        public Example04()
        {
            InitializeComponent();
        }

        #endregion

        #region IExample Member

        public void RunExample()
        {
            // its an example with an own visual control
            // checkout ShowDatabaseInfo
        }

        public void Connect(IHost hostApplication)
        {
            HostApplication = hostApplication;
        }

        public string Caption
        {
            get { return "Example04"; }
        }

        public string Description
        {
            get { return "Database informations"; }
        }

        public UserControl Panel
        {
            get { return this; }
        }

        #endregion

        #region Properties

        internal IHost HostApplication { get; private set; }

        #endregion

        #region Methods

        private void ShowDatabaseInfo(string filePath)
        {
            // start access
            Access.Application accessApplication = new Access.Application();

            // open database
            DAO.Database database = accessApplication.DBEngine.Workspaces[0].OpenDatabase(filePath);

            TreeNode tnTableDefs = treeViewInfo.Nodes.Add("Tables");
            foreach (DAO.TableDef item in database.TableDefs)
                tnTableDefs.Nodes.Add(item.Name);

            TreeNode tnQueryDefs = treeViewInfo.Nodes.Add("Queries");
            foreach (DAO.QueryDef item in database.QueryDefs)
                tnQueryDefs.Nodes.Add(item.Name);

            TreeNode tnRelations = treeViewInfo.Nodes.Add("Relations");
            foreach (DAO.Relation item in database.Relations)
                tnRelations.Nodes.Add(item.Name);

            TreeNode tnContainers = treeViewInfo.Nodes.Add("Containers");
            foreach (DAO.Container item in database.Containers)
                tnContainers.Nodes.Add(item.Name);
        }

        #endregion

        #region UI Trigger

        private void buttonSelectDatabase_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files|*.*|Microsoft Access Databases|*.accdb;*.mdb";
            ofd.FilterIndex = 2;
            if (DialogResult.OK == ofd.ShowDialog(this))
            {
                textBoxFilePath.Text = ofd.FileName;
                treeViewInfo.Nodes.Clear();
                ShowDatabaseInfo(textBoxFilePath.Text);
            }
        }

        #endregion
    }
}
