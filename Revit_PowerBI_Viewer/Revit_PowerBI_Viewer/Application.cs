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

            if (panel.AddItem(new PushButtonData("PowerBI Viewer", "PowerBI Viewer", thisAsemblyPath, "Revit_PowerBI_Viewer.Command")) is PushButton button)
            {
                button.ToolTip = "View PowerBI reports in Revit";

                Uri uri = new Uri(Path.Combine(Path.GetDirectoryName(thisAsemblyPath), "Resources", "jacobian.ico"));
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
            string tab = "Michal_S";
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
                a.CreateRibbonPanel(tab, "PowerBI Viewer");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                // Panel already exists, do nothing
            }

            List<RibbonPanel> panels = a.GetRibbonPanels(tab);
            foreach (RibbonPanel p in panels.Where(p => p.Name == "PowerBI Viewer"))
            {
                ribbonPanel = p;            
            }

            return ribbonPanel;
        }
    }
    
}
