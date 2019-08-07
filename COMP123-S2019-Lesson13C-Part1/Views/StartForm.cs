using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson13C_Part1.Views
{
    public partial class StartForm : COMP123_S2019_Lesson13C_Part1.Views.StartForm
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Back Button Clicked");
        }
    }
}
