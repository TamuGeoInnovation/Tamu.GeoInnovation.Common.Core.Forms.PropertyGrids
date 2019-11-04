using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Windows.Forms;
using USC.GISResearchLab.Common.Utils.FileTypes;

namespace USC.GISResearchLab.Common.Forms.PropertyGrids.FileFilters
{
    public class OutputShapefileFileFilter : UITypeEditor
    {
        private SaveFileDialog sfd = new SaveFileDialog();

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            string path = value.ToString();
            if (File.Exists(path))
            {
                sfd.FileName = value.ToString();
            }
            else
            {
                sfd.FileName = "";
            }
            sfd.Filter = FileTypes.getFileTypeList(FileTypes.FILE_TYPE_SHAPEFILES);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                return sfd.FileName;
            }
            return base.EditValue(context, provider, value);
        }
    }
}
