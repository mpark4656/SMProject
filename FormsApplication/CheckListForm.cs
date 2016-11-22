using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FormsApplication.Checklist;
using FormsApplication.Records;
using FormsApplication.XMLSerializer;

namespace FormsApplication
{
    public partial class CheckListForm : Form
    {
        // Collection of checklists
        CheckListStack checkLists = new CheckListStack();

        // AddCheckListForm to update these static variables
        // It's easier to transfer variables between forms using static variables
        public static string displayToAdd;
        public static string[] valueToAdd;

        /**
         *  Default Constructor
         * */
        public CheckListForm()
        {
            InitializeComponent();

            // This form window opens at the center of the parent form
            StartPosition = FormStartPosition.CenterParent;

            LoadCheckList();

            // Initialize the static variables
            initStaticVariables();
        }

        /**
         *  This method initializes static variables
         * */
        private void initStaticVariables()
        {
            displayToAdd = "";
            valueToAdd = new string[1];
            valueToAdd[0] = "";
        }

        /**
         *  Load the contents of checkLists to the CheckListSelectionBox
         * */
        private void LoadCheckList()
        {
            // Clear all current items
            CheckListSelectionBox.Items.Clear();

            // Load checklists from CheckListStack checkLists
            for (int i = 0; i < checkLists.Size(); i++)
            {
                CheckListSelectionBox.Items.Add(checkLists[i].Display);
            }
        }

        /**
         *  This method checks to see if an item in CheckListSelectionBox list box
         *  is checked. If a valid item index is selected, it will return true.
         *  @return true bool if a valid item index is selected
         * */
        private bool isSelected()
        {
            // If the selected item index from CheckListSelectionBox is out of bound, 
            // or item is not selected, take no action
            if (CheckListSelectionBox.SelectedIndex < 0 ||
                CheckListSelectionBox.SelectedIndex >= checkLists.Size()
            )
            {
                return false;
            }

            return true;
        }

        /**
         *  User clicks the Add button to add a new CheckList
         *  Action: Create and open AddCheckListForm
         *          Create a new CheckList with updated values of displayToAdd and valueToAdd
         *          Save the updated checkLists to XML file
         *          Reload the checkLists
         * */
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Initialize the static variables
            initStaticVariables();

            // Open AddCheckListForm
            AddCheckListForm addCheckListForm = new AddCheckListForm();
            addCheckListForm.ShowDialog();

            // Trim whitespace around displayToAdd
            displayToAdd = displayToAdd.Trim();

            // If updated displayToAdd is emmpty string, take no further action
            if( displayToAdd.Length <= 0 )
            {
                return;
            }

            // Create a new CheckList
            CheckList toAdd = new CheckList(displayToAdd, valueToAdd);

            // Add the CheckList to CheckListStack checkLists
            checkLists.Add(toAdd);

            // Save the updated checkLists to XML file
            try
            {
                XML.SaveCheckList(checkLists);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show(
                    "A problem has occurred while saving data. CheckList.xml may be corrupted.",
                    "Error",
                    MessageBoxButtons.OK
                );
            }

            // Reload the checkLists
            LoadCheckList();
        }

        /**
         *  User clicks the Delete button
         *  Action: Delete the selected checklist after user's confirmation
         * */
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // If the selected item index is out of bound, take no action
            if (!isSelected())
            {
                return;
            }

            // Confirm that user really wants to delete the selected checklist
            DialogResult result = MessageBox.Show(
                "Do you want to remove the selected Checklist?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if( result == DialogResult.No )
            {
                return;
            }

            // Remove the checklist at specified index
            checkLists.RemoveAt(CheckListSelectionBox.SelectedIndex);

            // Save the updated checklist to XML file
            try
            {
                XML.SaveCheckList(checkLists);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show(
                    "A problem has occurred while saving data. CheckList.xml may be corrupted.",
                    "Error",
                    MessageBoxButtons.OK
                );
            }
            
            // Load the updated checklist
            LoadCheckList();
        }

        /**
         *  User clicks the Modify button to modify the selected checklist
         * */
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            // If a checklist is not selected, take no further action
            if(!isSelected())
            {
                return;
            }

            // Update the static variables so the CheckListModifyForm can access the
            // values of these variables
            displayToAdd = checkLists[CheckListSelectionBox.SelectedIndex].Display;
            valueToAdd = checkLists[CheckListSelectionBox.SelectedIndex].Value;

            // Open CheckListModifyForm
            AddCheckListForm modifyForm = new AddCheckListForm("Modify Checklist", "Modify");
            modifyForm.ShowDialog();

            // Update the contents of the selected CheckList
            checkLists[CheckListSelectionBox.SelectedIndex].Display = displayToAdd;
            checkLists[CheckListSelectionBox.SelectedIndex].Value = valueToAdd;

            // Save the updated checklist to XML file
            try
            {
                XML.SaveCheckList(checkLists);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show(
                    "A problem has occurred while saving data. CheckList.xml may be corrupted.",
                    "Error",
                    MessageBoxButtons.OK
                );
            }

            // Reload the updated checkLists
            LoadCheckList();
        }

        /**
         *  User clicks the Move Up button
         *  Action: Move the Checklist one up on the list
         * */
        private void MoveUpButton_Click(object sender, EventArgs e)
        {
            // If there is no checklist selected, take no action
            if(!isSelected())
            {
                return;
            }

            int currentIndex = CheckListSelectionBox.SelectedIndex;
            int newIndex = currentIndex - 1;

            // If the newIndex is lower than 0 (In other words, the selected checklist was
            // already the first item on the list), take no further action
            if( newIndex < 0 )
            {
                return;
            }

            CheckList temp = checkLists[newIndex];
            checkLists[newIndex] = checkLists[currentIndex];
            checkLists[currentIndex] = temp;

            // Reload the updated checkLists
            LoadCheckList();

            // Leave the same checklist (Now in the new position) selected
            CheckListSelectionBox.SetSelected(newIndex , true);
        }

        /**
         *  User clicks the Move Down button
         *  Action: Move the Checklist one down on the list
         * */
        private void MoveDownButton_Click(object sender, EventArgs e)
        {
            // If there is no checklist selected, take no action
            if (!isSelected())
            {
                return;
            }

            int currentIndex = CheckListSelectionBox.SelectedIndex;
            int newIndex = currentIndex + 1;

            // If the newIndex equals to checkLists.Sizse() or higher, it means
            // the selected Checklist is already the last item on the list
            if (newIndex >= checkLists.Size())
            {
                return;
            }

            CheckList temp = checkLists[newIndex];
            checkLists[newIndex] = checkLists[currentIndex];
            checkLists[currentIndex] = temp;

            // Reload the updated checkLists
            LoadCheckList();

            // Leave the same checklist (Now in the new position) selected
            CheckListSelectionBox.SetSelected(newIndex, true);
        }

        /**
         *  User clicks the Insert button
         *  Action: Update MainForm.checkListToAdd with the value of selected checklist
         * */
        private void InsertButton_Click(object sender, EventArgs e)
        {
            // If the selected item index is out of bound, take no action
            if( !isSelected())
            {
                return;
            }

            // Add two newlines to the buffer (MainForm.checkListToAdd)
            MainForm.checkListToAdd = Environment.NewLine + 
                                      Environment.NewLine;

            // Add each line of the selected item's value(Actual Checklist)
            // to the buffer (MainForm.checkListToAdd)
            for ( int i = 0; i < checkLists[CheckListSelectionBox.SelectedIndex].Value.Length; i++ )
            {
                MainForm.checkListToAdd += checkLists[CheckListSelectionBox.SelectedIndex].Value[i];
                MainForm.checkListToAdd += Environment.NewLine;
            }

            // Close this form
            Close();
        }

        /**
         *  User double-clicks an item in the list box
         *  Action: Insert the checklist into the Descriptio Field
         *  
         *  It can simply PerformClick() for InsertButton
         * */
        private void CheckListSelectionBox_DoubleClick(object sender, EventArgs e)
        {
            InsertButton.PerformClick();
        }

        /**
         *  User clicks the "Send to Clipboard" button
         *  Action: Send the value of selected checklist to the client's clipboard
         * */
        private void CopyButton_Click(object sender, EventArgs e)
        {
            // If the selected item index is out of bound, take no action
            if (!isSelected())
            {
                MessageBox.Show("Select a checklist to copy.", "Error", MessageBoxButtons.OK);
                return;
            }

            // Buffer to store string[] value
            string toSend = "";

            // Add each line of the selected item's value(Actual Checklist)
            // to the buffer, toSend
            for (int i = 0; i < checkLists[CheckListSelectionBox.SelectedIndex].Value.Length; i++)
            {
                toSend += checkLists[CheckListSelectionBox.SelectedIndex].Value[i];
                toSend += Environment.NewLine;
            }

            // If the length of toSend is larger than 0, send it to the clipboard
            if( toSend.Length > 0)
            {
                Clipboard.SetText(toSend);
            }
            else
            {
                Clipboard.SetText( " " );
            }

            // Close this form
            Close();
        }

        /**
         *  User clicks the Cancel button
         *  Action: Close this form
         * */
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /**
         *  This method performs necessary actions to retrieve data from xml file when the Form 
         *   opens
         *  If "CheckList.xml" file exists in the same directory as the .exe file, then it will try to
         *   read the file.
         *  If the file does not exist, then form will simply start with a blank checklist.
         * */
        private void CheckListForm_Load(object sender, EventArgs e)
        {
            // If CheckList.xml exists in the current directory, try to read data from it
            if (File.Exists("CheckList.xml"))
            {
                try
                {
                    // Save data in RecordStack interactions
                    checkLists = XML.LoadCheckList();

                    // Load checkLists
                    LoadCheckList();
                }
                catch (System.InvalidOperationException)
                {
                    MessageBox.Show(
                        "A problem has occurred while reading from CheckList.xml." +
                        "Try removing or renaming CheckList.xml. Then, reopen this application.",
                        "Error",
                        MessageBoxButtons.OK
                    );

                    // Close the form after displaying the error message
                    Close();
                }
            }
            // If the file does not exist, take no action.
            else
            {
                return;
            }
        }

        /**
         *  While the form is being closed, save the current checkLists to XML file
         * */
        private void CheckListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save all data (CheckListStack) to the xml file
            try
            {
                XML.SaveCheckList(checkLists);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show(
                    "A problem has occurred while saving data. CheckList.xml may be corrupted.",
                    "Error",
                    MessageBoxButtons.OK
                );
            }
        }
    }
}
