/******************************************************************************
Author:      S.Conaty
Date:        07/08/2017
Name:        Replace.cs
Description: Form for Find and Replace.
 *****************************************************************************/

using System;
using System.Windows.Forms;

namespace myNotepad
{
    public partial class frmReplace : Form
    {
        MyNotepadFrm ownerForm = null;

        public frmReplace(MyNotepadFrm ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            ownerForm.DoFind(FindTextBox.Text, true , chkMatchCase.Checked);
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            // If the string has not been found already
            if (ownerForm.FoundWordIndex == 0)
            {
                ownerForm.DoFind(FindTextBox.Text, true, chkMatchCase.Checked);
            }

            // Check after the search if the string has been found
            if (ownerForm.FoundWordIndex != 0)
            {
                // Delete the found string
                ownerForm.textBox.Text = ownerForm.textBox.Text.Remove(ownerForm.FoundWordIndex, FindTextBox.Text.Length);
                // Insert the new string
                ownerForm.textBox.Text = ownerForm.textBox.Text.Insert(ownerForm.FoundWordIndex, replaceTextBox.Text);
            }
        }

        // Cancel
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Replace All
        private void BtnReplaceAll_Click(object sender, EventArgs e)
        {
            ownerForm.textBox.Text = ownerForm.textBox.Text.Replace(FindTextBox.Text, replaceTextBox.Text);

        }
    }
}
