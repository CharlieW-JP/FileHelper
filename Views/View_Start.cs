using FileHelper.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileHelper.Views
{
    public partial class View_Start : Form
    {
        public View_Start()
        {
            InitializeComponent();
        }

        private void fileExtentionChange_Click(object sender, EventArgs e)
        {
            View_FileExtentionChange fec = new View_FileExtentionChange();
            fec.Show();
        }
    }
}
