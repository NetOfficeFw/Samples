using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Excel02AddinCS4
{
    public partial class SamplePane : UserControl, NetOffice.ExcelApi.Tools.ITaskPane // Not necessary to implement ITaskPane but its helpful
    {
        #region Ctor

        public SamplePane()
        {           
            InitializeComponent();
        }

        #endregion

        #region Properties

        private PerformanceCounter Counter { get; set; }

        #endregion

        #region ITaskpane

        public void OnConnection(NetOffice.ExcelApi.Application application, NetOffice.OfficeApi._CustomTaskPane parentPane, object[] customArguments)
        {
            Counter = new PerformanceCounter("Process", "% Processor Time", "Excel");
            UsageTimer.Enabled = true;
        }

        public void OnDisconnection()
        {
            UsageTimer.Enabled = false;
            if (null != Counter)
            {
                Counter.Dispose();
                Counter = null;
            }
        }

        public void OnDockPositionChanged(NetOffice.OfficeApi.Enums.MsoCTPDockPosition position)
        {
            
        }

        public void OnVisibleStateChanged(bool visible)
        {
            
        }

        #endregion

        #region UI Trigger

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UsageLabel.Location = new Point(
                                    (Width / 2 - UsageLabel.Width / 2),
                                    (Height / 2 - UsageLabel.Height / 2));
        }

        private void UsageTimer_Tick(object sender, EventArgs e)
        {
            if (null != Counter)
            {
                float value = Counter.NextValue();
              
                int barValue = Convert.ToInt32(value);
                if (barValue < 0)
                    barValue = 0;
                if (barValue > 100)
                    barValue = 100;
                UsageLabel.Text = String.Format("{0} %", barValue);
                UsageBar.Value = barValue;
            }
            else
            {
                UsageLabel.Text = String.Empty;
            }
        }

        #endregion
    }
}
