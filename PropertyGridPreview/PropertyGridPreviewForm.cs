using PropertyGridPreview.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyGridPreview
{
    public partial class PropertyGridPreviewForm : Form
    {
        public PropertyGridPreviewForm()
        {
            InitializeComponent();
            propertyGrid.SelectedObject = new Info();
        }

        private void PropertyGridPreviewForm_ResizeEnd(object sender, EventArgs e)
        {

        }
    }
}
