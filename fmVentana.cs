using Autodesk.Revit.Creation;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuluginHelloWorld
{
    public partial class fmVentana : Form
    {
        UIDocument uidoc;
        Autodesk.Revit.DB.Document doc;
        public fmVentana(UIDocument uidoc, Autodesk.Revit.DB.Document doc)
        {
            InitializeComponent();
            this.uidoc = uidoc;
            this.doc = doc;
        }

        private void fmVentana_Load(object sender, EventArgs e)
        {

        }
    }
}
