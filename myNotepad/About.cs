/******************************************************************************
Author:      S.Conaty
Date:        07/08/2017
Name:        About.cs
Description: About Form containing information about the application.
 *****************************************************************************/

using System;
using System.Windows.Forms;

namespace myNotepad
{
    public partial class FrmAbout : Form
    {
        MyNotepadFrm ownerForm = null;

        public FrmAbout(MyNotepadFrm ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }

        // Close
        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
