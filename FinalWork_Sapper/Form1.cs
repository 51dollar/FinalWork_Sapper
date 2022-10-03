using System.Diagnostics.PerformanceData;
using FinalWork_Sapper.Controllers;

namespace FinalWork_Sapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MapController.Init(this);
        }
    }
}