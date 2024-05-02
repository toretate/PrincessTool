using System;
using System.Windows.Forms;

namespace AioiLight.PrincessTool
{
    internal static class Dialog
    {
        internal static string Folder(string def, IntPtr handle)
        {
            //var dialog = new CommonOpenFileDialog();
            var dialog = new FolderBrowserDialog
            {
                InitialDirectory = def
            };

            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK) {
                return dialog.SelectedPath;
            }
            return null;
        }

        internal static void Error(string caption, string text, IntPtr handle)
        {
            _ = TaskDialog.ShowDialog(handle, new TaskDialogPage()
            {
                Text = text,
                Icon = TaskDialogIcon.Error,
                Caption = caption,
                Buttons =
                {
                    TaskDialogButton.OK
                },
                DefaultButton = TaskDialogButton.OK
            });
        }
    }
}
