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
        
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
       
        // Show a simple message box as a placeholder for the Power BI viewer functionality
        MessageBox.Show("Plugin Created Yo!");
        return Result.Succeeded;
        
            
        }
    }
}
