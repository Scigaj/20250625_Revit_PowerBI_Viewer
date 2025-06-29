using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;
using System.Windows.Forms;

namespace Revit_PowerBI_Viewer
{
    [Transaction(TransactionMode.Manual)]
    public class Command :IExternalCommand
    {
        public object DialogResilt { get; private set; }

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiApp = commandData.Application; 
            Document doc = uiApp.ActiveUIDocument.Document; // Get the active document

            using (System.Windows.Forms.Form form = new Revit_PowerBI_Viewer.SQLDoorsForm(doc)) // Pass the document to the form
            {
                if(form.ShowDialog() == DialogResult.OK) // Show the form as a dialog
                {
                    return Result.Succeeded; // Return success if the dialog was closed with OK
                }

                else
                {
                    return Result.Cancelled; // Return cancelled if the dialog was closed without OK
                }
            }


        }
    }
}
