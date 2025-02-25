using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuluginHelloWorld
{
    // plantilla curso antony
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Autodesk.Revit.DB.Document doc = uidoc.Document;
            TaskDialog.Show("Hola", "Holloowrld");
            //fmVentana ventana = new fmVentana(uidoc, doc);
            //ventana.TopMost = true;

            //System.Windows.Forms.Application.Run(ventana);


            return Result.Succeeded;
        }
    }
}
