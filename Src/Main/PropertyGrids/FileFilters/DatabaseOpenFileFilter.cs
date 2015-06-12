using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Windows.Forms;
using USC.GISResearchLab.Common.Utils.FileTypes;

namespace USC.GISResearchLab.Common.Forms.PropertyGrids.FileFilters
{
    public class DatabaseOpenFileFilter : UITypeEditor
	{
        private OpenFileDialog ofd = new OpenFileDialog();

		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			return UITypeEditorEditStyle.Modal;
		}

		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
            string path = value.ToString();
            if (File.Exists(path))
            {
                ofd.FileName = value.ToString();
            }
            else
            {
                ofd.FileName = "";
            }
            ofd.Filter = FileTypes.getFileTypeList(FileTypes.FILE_TYPE_DATABASES);
            if (ofd.ShowDialog() == DialogResult.OK)
			{
                return ofd.FileName;
			}
			return base.EditValue (context, provider, value);
		}
	}
}

