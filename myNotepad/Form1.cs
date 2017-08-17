/******************************************************************************
Author:      S.Conaty
Date:        06/08/2017
Name:        Form1.cs
Description: Main Form for application.
 *****************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace myNotepad
{
    public partial class MyNotepadFrm : Form
    {
        // Initilaize variables
        string OurFilename = "";
        string LastFindWord;
        string LastSavedVersion = "";
        bool LastFindDown;
        bool LastFindMatchCase;
        public int FoundWordIndex = 0;

        // Save
        void DoSave(string filename)
        {
            OurFilename = filename;
            textBox.SaveFile(filename);
        }

        // SaveAs
        void DoSaveAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DoSave(saveFileDialog1.FileName);
            }
        }

        public MyNotepadFrm()
        {
            InitializeComponent();            
        }

        // Undo 
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        // Cut
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        // Copy
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        // Paste
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        // Delete
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectedText = "";
        }

        // Returns True if a change has been made to the file
        bool CheckChanges()
        {
            if (LastSavedVersion != "" && LastSavedVersion != textBox.Text)
            {
                return true;
            }
            else
                return false;
        }

        // Open File
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set File Filter
            openFileDialog1.Filter = "Text Files (TXT)|*.TXT;";

            // Check if the File has changed since opening
            if (CheckChanges())
            {
                // Offer the option to Save
                DialogResult doYouWantToSave = MessageBox.Show("Do you want to Save this File before opening another?",
                                                               "Save File", MessageBoxButtons.YesNoCancel);
                // If the user choses to Save, run DoSa
                if (doYouWantToSave == DialogResult.Yes)
                {
                    if (OurFilename != "")
                    {
                        DoSave(OurFilename);
                    }
                    else
                    {
                        DoSaveAs();
                    }
                }
                else if (doYouWantToSave == DialogResult.Cancel)
                {
                    return;
                }
            }
            // Check the user has hit OK on the Open File Dialogue
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox.LoadFile(openFileDialog1.FileName);
                OurFilename = openFileDialog1.FileName;
            }

            // Set variable to new file text
            LastSavedVersion = textBox.Text;

        } // openToolStripMenuItem_Click

        // Save File
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OurFilename))
            {
                DoSaveAs();
            }
            else
            {
                DoSave(OurFilename);
            }
        }

        // Save File As
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoSaveAs();
        }

        // Find String
        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFind find = new frmFind(this);
            find.Show(this);            
        }

        // Find Method
        public void DoFind(string search, bool down, bool match_case)
        {
            LastFindWord = search;
            LastFindDown = down;
            LastFindMatchCase = match_case;

            int startIndex;
            if (FoundWordIndex == 0)
            {
                startIndex = textBox.SelectionStart;
            }
            else
            {
                startIndex = textBox.SelectionStart + 1;
            }

            if (down)
            {
                if (match_case)
                {
                    FoundWordIndex = textBox.Find(search, startIndex, RichTextBoxFinds.MatchCase);
                }
                else
                {
                    FoundWordIndex = textBox.Find(search, startIndex, RichTextBoxFinds.None);
                }
            }
            else
            {
                if (match_case)
                {
                    FoundWordIndex = textBox.Find(search, 0, textBox.SelectionStart, RichTextBoxFinds.Reverse | RichTextBoxFinds.MatchCase);
                }
                else
                {
                    FoundWordIndex = textBox.Find(search, 0, textBox.SelectionStart, RichTextBoxFinds.Reverse | RichTextBoxFinds.None);
                }
            }

            if (FoundWordIndex == -1)
            {
                MessageBox.Show("Word not found!");
            }
        } // DoFind

        // Find Next
        private void FindNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LastFindWord != "" && LastFindWord != null)
            {
                DoFind(LastFindWord, true, LastFindMatchCase);
            }
        }

        // Find Previous
        private void FindPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LastFindWord != "" && LastFindWord != null)
            {
                DoFind(LastFindWord, false, LastFindMatchCase);
            }
        }

        // Exit
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Select All
        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        // Open New
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckChanges())
            {
                var info = new System.Diagnostics.ProcessStartInfo(Application.ExecutablePath);
                System.Diagnostics.Process.Start(info);
            }
        }

        // Word Wrap
        private void WordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.WordWrap = !textBox.WordWrap;
        }

        // Font
        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog changeFont = new FontDialog();
            changeFont.ShowDialog();

            textBox.SelectionFont = changeFont.Font;
        }


        // Line and Col in StatusBar
        private void TextBox_SelectionChanged(object sender, EventArgs e)
        {
            // Get the line.
            int cursorPosition = textBox.SelectionStart;
            int lineIndex = textBox.GetLineFromCharIndex(cursorPosition);

            // Get the column.
            int firstChar = textBox.GetFirstCharIndexFromLine(lineIndex);
            int column = (cursorPosition - firstChar) + 1;
            
            // Set Status Strip Variables.
            lineNoInStatusStrip.Text = (lineIndex + 1).ToString();
            colStatusStrip.Text = column.ToString();
        }

        // Night Mode
        private void NightModeOnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.BackColor == Color.White)
            {
                textBox.BackColor = Color.Black;
                textBox.ForeColor = Color.White;
            }
            else
            {
                textBox.BackColor = Color.White;
                textBox.ForeColor = Color.Black;
            }
        }

        // Replace
        private void ReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplace replace = new frmReplace(this);
            replace.Show(this);
        }

        // Disable Copy, Cut and Paste unless text is selected
        private void EditToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (textBox.SelectedText != "")
            {
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }

            if (textBox.Text == "")
            {
                findToolStripMenuItem.Enabled = false;
                findNextToolStripMenuItem.Enabled = false;
                findPreviousToolStripMenuItem.Enabled = false;
            }
            else
            {
                findToolStripMenuItem.Enabled = true;
                findNextToolStripMenuItem.Enabled = true;
                findPreviousToolStripMenuItem.Enabled = true;
            }
        } // editToolStripMenuItem_DropDownOpened

        // About
        private void AboutMyNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout(this);
            about.Show(this);
        }
    }
}
