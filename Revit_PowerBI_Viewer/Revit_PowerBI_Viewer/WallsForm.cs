using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace Revit_PowerBI_Viewer
{
    public partial class WallsForm : System.Windows.Forms.Form
    {
        Document Doc;

        public WallsForm(Document doc) // Fixed parameter name
        {
            InitializeComponent();
            Doc = doc; // Fixed assignment
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICollection<Element> walls = new FilteredElementCollector(Doc, Doc.ActiveView.Id) // Fixed ActiveView usage
                .OfCategory(BuiltInCategory.OST_Walls)
                .ToElements(); // Fixed method call
            TaskDialog.Show("Wall Count", $"There are {walls.Count.ToString()} walls in the active view.", TaskDialogCommonButtons.Ok); // Fixed TaskDialog usage
        }
    }
}