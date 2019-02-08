using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QazLatyn;
namespace QazLatynConverter.WinForms.Example
{
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
        }

        private void btnCyrl2Latyn_Click(object sender, EventArgs e)
        {
            string cyrlText = this.txtCyrl.Text;
            string latynText = QazLatynHelper.Cyrl2Latyn(cyrlText);
            this.txtLatyn.Text = latynText;
        }
    }
}
