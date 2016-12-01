using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoaderShim
{
    public partial class SelectionForm : Form
    {
        internal class SampleAddinDescription
        {
            internal SampleAddinDescription(string name)
            {
                Name = name;
            }
            public string Name { get; private set; }
        }

        public SelectionForm(Dictionary<string, Type> addins)
        {
            InitializeComponent();

            List<SampleAddinDescription> list = new List<SampleAddinDescription>();
            foreach (KeyValuePair<string, Type> item in addins)
                list.Add(new SampleAddinDescription(item.Key));
            
            AddinGrid.SelectionChanged += delegate
            {
                ProceedButton.Enabled = AddinGrid.SelectedRows.Count > 0;
            };
            AddinGrid.DataSource = list;
        }

        public string SelectedName
        {
            get
            {
                return AddinGrid.SelectedRows.Count > 0 ? 
                    (AddinGrid.SelectedRows[0].DataBoundItem as SampleAddinDescription).Name : null;
            }
        }

        public int SelectedIndex
        {
            get
            {
                return AddinGrid.SelectedRows.Count > 0 ?  AddinGrid.SelectedRows[0].Index : -1;
            }
        }

        private void AddinGrid_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedIndex > -1)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
