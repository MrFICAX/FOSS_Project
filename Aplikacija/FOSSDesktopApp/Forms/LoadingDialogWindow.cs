using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Forms
{
    public partial class LoadingDialogWindow : Form
    {
        public LoadingDialogWindow()
        {
            this.DialogResult = DialogResult.OK;
            InitializeComponent();
        }
    }
}
