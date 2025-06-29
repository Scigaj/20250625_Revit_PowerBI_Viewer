using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Autodesk.Revit.UI;
using System.Reflection;
using System.Windows.Media.Imaging;
using System.IO;



namespace Revit_PowerBI_Viewer
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Application : IExternalApplication
    {

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
        public Result OnStartup(UIControlledApplication application)
        { 
            RibbonPanel panel = RibbonPanel(application);
            string thisAsemblyPath = Assembly.GetExecutingAssembly().Location;

            if (panel.AddItem(new PushButtonData("PowerBI Runner", "Publish to PowerBI", thisAsemblyPath, "Revit_PowerBI_Viewer.Command")) is PushButton button)
            {
                button.ToolTip = "Publish your Revit data in PowerBI";

                Uri uri = new Uri(Path.Combine(Path.GetDirectoryName(thisAsemblyPath), "Resources", "Revit_PowerBI.png"));
                BitmapImage bitmap = new BitmapImage(uri);
                button.LargeImage = bitmap;

            }
            else
            {
                Debug.WriteLine("Failed to add PowerBI Viewer button to the ribbon panel.");
            }

            return Result.Succeeded;
        }

        public RibbonPanel RibbonPanel(UIControlledApplication a)
        {
            string tab = "PowerBI Runner";
            string panelName = "Export";
            RibbonPanel ribbonPanel = null;


            try
            {
                a.CreateRibbonTab(tab);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                // Tab already exists, do nothing
            }

            try
            {
                a.CreateRibbonPanel(tab, panelName);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                // Panel already exists, do nothing
            }

            List<RibbonPanel> panels = a.GetRibbonPanels(tab);
            foreach (RibbonPanel p in panels.Where(p => p.Name == "Export"))
            {
                ribbonPanel = p;            
            }

            return ribbonPanel;
        }
    }
    
}
