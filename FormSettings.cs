using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWork_Sapper
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            HandComplexityEnabled();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HandComplexity_CheckedChanged(object sender, EventArgs e)
        {
            Сomplexity.Enabled = !Сomplexity.Enabled;
            CheckedComplexity.Enabled = !CheckedComplexity.Enabled;
            HandComplexityEnabled();
        }
        private void HandComplexityEnabled()
        {
            XFields.Enabled = !XFields.Enabled;
            YFields.Enabled = !YFields.Enabled;
            Bombs.Enabled = !Bombs.Enabled;
            hScrollBarX.Enabled = !hScrollBarX.Enabled;
            hScrollBarY.Enabled = !hScrollBarY.Enabled;
            hScrollBarBomb.Enabled = !hScrollBarBomb.Enabled;
        }
        private void Сomplexity_Click(object sender, EventArgs e)
        {

        }
    }
}
