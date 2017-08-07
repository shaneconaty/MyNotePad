/******************************************************************************
Author:      S.Conaty
Date:        07/08/2017
Name:        Find.cs
Description: Find Form.
 *****************************************************************************/
using System;
using System.Windows.Forms;

namespace myNotepad
{
    public partial class frmFind : Form
    {
        MyNotepadFrm ownerForm = null; 
    
        public frmFind(MyNotepadFrm ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            ownerForm.DoFind(FindTextBox.Text, rdoDown.Checked, chkMatchCase.Checked);

            if (chkCloseIfFound.Checked)
            {
                this.Close();
            }
        }
    }
}
