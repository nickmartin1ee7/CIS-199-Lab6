/**
 *  Grading ID:  L8486
 *  Due date:    10/27/19
 *  Class:       CIS 199-75
 *  Lab:         6
 *  Description: Loops though parallel arrays containing ranges for grade letter.
 **/

using System;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // (Cancel button) Clears all results from submit button
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NumWordsTypedTextBox.Text = "";
            GradeResultLabel.Text = "";
            NumWordsTypedTextBox.Select();  // Select textbox as insertion point
        }

        // (Accept button) Loops though parallel arrays containing ranges for grade letter
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            char gradeLetter = '\x00'; // Grade letter for result label. Placeholder: Null byte char
            char[] gradeLetterArray     = { 'A', 'B', 'C', 'D', 'F' }; // Array[4] PARALLEL: Array containing grade letters
            int[] wordsTypedRangeArray  = {  76,  51,  31,  16,  0 };    // Array[4] PARALLEL: Array containing maximum range value for associated grade letter
            //                 Array index: [0]  [1]  [2]  [3]  [4]
            bool valid = false;     // Valid flag to escape for loop on discovery
            if (int.TryParse(NumWordsTypedTextBox.Text, out int wordsTyped) && wordsTyped >= 0) // wordsTyped.Range: [0, infinity)
            {
                for (int x = 0; x <= wordsTypedRangeArray.Length - 1 && !valid; ++x)  // Start 0, go up until 4 or valid == true
                {
                    if (wordsTyped >= wordsTypedRangeArray[x])  // If found match
                    {
                        valid = true;                           // Set flag to true
                        gradeLetter = gradeLetterArray[x];      // Assign parallel grade letter
                    }
                }
                if (valid)                                      // If match was found in sorting
                    GradeResultLabel.Text = $"{gradeLetter}";   // Assign grade letter to label text
                // No else needed. Valid result range is [0, infinity).
            }
            else       // If invalid input, display error message
            {
                MessageBox.Show("Error! Words typed amount invalid.");
            }
        }
    }
}
