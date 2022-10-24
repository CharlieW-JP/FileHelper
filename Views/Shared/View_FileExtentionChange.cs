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
    public partial class View_FileExtentionChange : Form
    {
        public View_FileExtentionChange()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string pathValue = textBox1.Text;

            string originEx = textBox2.Text;

            string newEx = textBox3.Text;

            FileExtentionChange change = new FileExtentionChange();
            change.Process(pathValue, originEx, newEx);

        }
    }
}
