﻿using System.Windows.Forms;
using System.Diagnostics;

namespace OptiTera
{
    public partial class ExternalConfig : UserControl
    {
        public ExternalConfig()
        {
            InitializeComponent();
        }

        private void ncSetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Purizer/OxiBoost/blob/master/OxiBoost/readMe/ncSettings.md");
        }

        private void prioDL_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.prnwatch.com/prio");
        }

        private void teraSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Purizer/OxiBoost/blob/master/OxiBoost/readMe/teraSettings.md");
        }

    }
}
