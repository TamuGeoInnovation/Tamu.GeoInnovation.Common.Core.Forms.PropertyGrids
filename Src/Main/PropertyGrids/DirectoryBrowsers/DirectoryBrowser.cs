using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace USC.GISResearchLab.Common.Forms.PropertyGrids.DirectoryBrowsers
{
    /// <summary>
    /// Summary description for DirectoryBrowser.
    /// </summary>
    public class DirectoryBrowser : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.SelectedPath.ToString().Trim() + "\\";
            }

            return base.EditValue(context, provider, value);
        }
    }
}
