using System;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace Modless
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        private static MainForm _form;
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            if (_form != null && !_form.IsDisposed)
            {
                if (_form.WindowState == System.Windows.Forms.FormWindowState.Minimized)
                    _form.WindowState = System.Windows.Forms.FormWindowState.Normal;

                _form.Activate();
                return Result.Succeeded;
            }

            _form = new MainForm();

            _form.Show(new RevitWindow(commandData.Application.MainWindowHandle));

            return Result.Succeeded;
        }

        private class RevitWindow : IWin32Window
        {
            public RevitWindow(IntPtr handle) { Handle = handle; }
            public IntPtr Handle { get; }
        }
    }
}
 