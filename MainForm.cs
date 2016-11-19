using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace FormsApplication
{
    /**
     *  MainForm is the primary form that user interacts with. It is the first form that opens
     *  when user starts the application.
     *  
     *  A reference to this form will be created in the main function
     * */
    public partial class MainForm : Form
    {
        // RecordStack is a collection of Records
        // One Record has variables that store all information for one interaction ticket
        // Data will be read from FormData.xml (Given that it exists) and they will be stored
        // in RecordStack interactions.
        private RecordStack interactions;

        // Keeps track of the current record number.
        // The Record number label at the top left corner of the form will use this variable.
        // Here, index represents the untranslated record #
        // Untranslated Index: Counts from #1 as humans normally do
        // Translated Index: Counts from 0 as many programming languages do for arrays
        private int CurrentIndex;

        // Another form (CheckListForm) updates this static variable
        public static string checkListToAdd = null;

        /**
         *  Default Constructor
         * */
        public MainForm()
        {
            InitializeComponent();
        }

        /**********************************************************************************************
         * This section contains methods that deal with the following event actions
         * 1. Copy Button
         * 2. Clear Button
         * 3. Send All to Clipboard Button
         * 4. Format Phone Number Button
         * 5. Ping Button
         * 6. MSRA Button
         * 7. RDC Button
         * 8. UNC Button
         * 9. Add Title Tag
         * *******************************************************************************************/

        /**
         *  User clicks Copy button next to username text field.
         *  Action: Send the text contents inside the Username field to client's clipboard
         *  
         *  If there is no content in the text field, no action is taken.
         * */
        private void copyUsernameButton_Click(object sender, EventArgs e)
        {
            // Check if the length of texts inside the UsernameField is larger than 0
            // If so, copy the texts
            if( 0 < usernameField.Text.Length )
            {
                Clipboard.SetText(usernameField.Text);
            }
        }

        /**
         *  User clicks Copy button next to Telephone text field.
         *  Action: Send the text contents inside the Telephone field to client's clipboard
         *  
         *  If there is no content in the text field, no action is taken.
         * */
        private void copyPhoneButton_Click(object sender, EventArgs e)
        {
            // Check if the length of texts inside Telephone field is larger than 0
            // If so, copy the texts
            if ( 0 < phoneField.Text.Length )
            {
                Clipboard.SetText(phoneField.Text);
            }
        }

        /**
         *  User clicks F button next to the Telephone number field
         *  Action: Change the format of the Telephone to (xxx)xxx-xxxx
         * */
        private void phoneFormatButton_Click(object sender, EventArgs e)
        {
            // If the text field contains the following characters, remove them
            // . ( ) -
            phoneField.Text = phoneField.Text.Replace("-", "");
            phoneField.Text = phoneField.Text.Replace("(", "");
            phoneField.Text = phoneField.Text.Replace(")", "");
            phoneField.Text = phoneField.Text.Replace(".", "");

            // Remove any whitespace before or after the string literal
            phoneField.Text.Trim();

            // If the length of Telephone number is less than 7 characters, do nothing
            if ( phoneField.Text.Length < 7)
            {
                return;
            }
            // If the length of the Telephone number is 7 characters,
            // format it as xxx-xxxx
            else if( phoneField.Text.Length == 7 )
            {
                phoneField.Text = phoneField.Text.Insert(3, "-");
            }
            // If the length of the Telephone number is between 8 and 10 characters,
            // (User probably provided full Telephone number with the area code)
            // Then, format it as (xxx)xxx-xxxx
            else if( phoneField.Text.Length <= 10 )
            {
                phoneField.Text = phoneField.Text.Insert(0, "(");
                phoneField.Text = phoneField.Text.Insert(4, ")");
                phoneField.Text = phoneField.Text.Insert(8, "-");
            }
            // Any length higher than 10 characters, simply change the format
            // to (xxx)xxx-xxxx
            else
            {
                phoneField.Text = phoneField.Text.Insert(0, "(");
                phoneField.Text = phoneField.Text.Insert(4, ")");
                phoneField.Text = phoneField.Text.Insert(8, "-");
            }
        }

        /**
         * User clicks C button next to the Classification drop-down box
         * Action: Copy the contents inside the Classification text box
         * 
         * If no classification is selected, no action is taken
         * */
        private void copyClassificationButton_Click(object sender, EventArgs e)
        {
            if( 0 < classificationBox.Text.Length )
            {
                Clipboard.SetText(classificationBox.Text);
            }
        }

        /**
         * User clicks C button next to the Interaction text field
         * Action: Copy the contents inside the Interaction text field
         * 
         * If the text box is empty, then no action is taken
         * */
        private void copyInteractionButton_Click(object sender, EventArgs e)
        {
            if( 0 < interactionField.Text.Length )
            {
                Clipboard.SetText(interactionField.Text);
            }
        }

        /**
         *  User clicks C button next to the Asset text field
         *  Action: Copy the contents inside the Interaction text field
         *  
         *  If the text box is empty, then no action is taken
         * */
        private void copyAssetButton_Click(object sender, EventArgs e)
        {
            if( 0 < assetField.Text.Length )
            {
                Clipboard.SetText(assetField.Text);
            }
        }

        /**
         *  User clicks C button next to the Machine text field
         *  Action: Copy the contents inside the Machine text field
         *  
         *  If the text box is empty, then no action is taken
         * */
        private void copyMachineButton_Click(object sender, EventArgs e)
        {
            if( 0 < machineField.Text.Length )
            {
                Clipboard.SetText(machineField.Text);
            }
        }

        /**
         *  User clicks C button next to the Description text box
         *  Action: Copy the contents inside the Description text box
         *  
         *  If the text box is empty, then no action is taken
         * */
        private void copyInfoButton_Click(object sender, EventArgs e)
        {
            if( 0 < descriptionField.Text.Length )
            {
                Clipboard.SetText(descriptionField.Text);
            }
        }

        /**
         *  User clicks Copy Title Button
         * */
        private void copyTitleButton_Click(object sender, EventArgs e)
        {
            if (0 < titleField.Text.Length)
            {
                Clipboard.SetText(titleField.Text);
            }
        }

        /**
         *  User clicks P button below the Machine text field
         *  Action: Open Command Prompt and attempt to ping the machine with -t parameter
         *  */
        private void pingButton_Click(object sender, EventArgs e)
        {
            LaunchCommandPing();
        }

        /**
         *  User clicks MSRA button
         *  Action: Launch MSRA
         * */
        private void msraButton_Click(object sender, EventArgs e)
        {
            LaunchCommandMsra();
        }

        /**
         *  User clicks RDC Button
         *  Action: Launch RDC
         * */
        private void rdcButton_Click(object sender, EventArgs e)
        {
            LaunchCommandRdc();
        }

        /**
         *  User clicks UNC Button
         *  Action: Launch Map a Network Drive dialog box
         * */
        private void uncButton_Click(object sender, EventArgs e)
        {
            LaunchCommandUnc();
            
        }

        /**
         *  Launch cmd.exe with PING -t command
         * */
        private void LaunchCommandPing()
        {
            // Process.Start() may throw System.ComponentModel.Win32Exception
            try
            {
                // This is the argument (command)
                string arg = "C:\\Windows\\System32\\ping -t " + machineField.Text;

                // Create ProcessStartInfo
                // /K accepts a command and once executed, the command prompt window stays open.
                // /C does the same thing except that the command prompt window closes after execution
                ProcessStartInfo cmd = new ProcessStartInfo("C:\\Windows\\System32\\cmd.exe", "/K " + arg);

                // Start the Process
                Process exeProcess = Process.Start(cmd);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "A problem has occurred.",
                    "Error", MessageBoxButtons.OK
                );
            }
        }

        /**
         *  Launch Microsoft Remote Assistance with /offerRA parameter
         *  If the machine name is specified, it will automatically connect to the machine
         * */
        private void LaunchCommandMsra()
        {
            // Process.Start() may throw System.ComponentModel.Win32Exception
            try
            {
                ProcessStartInfo cmd = new ProcessStartInfo("C:\\Windows\\System32\\msra.exe",
                                                         "/offerRA " + machineField.Text);

                Process exeProcess = Process.Start(cmd);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "A problem has occurred.",
                    "Error", MessageBoxButtons.OK
                );
            }
        }

        /**
         *  Launch RDC with /prompt parameter and /v
         *  The Remote Desktop Connection will prompt for credential even though it is opened with
         *   Administrator credential
         * */
        private void LaunchCommandRdc()
        {
            ProcessStartInfo cmd = new ProcessStartInfo(
                "C:\\Windows\\System32\\mstsc.exe",
                "/prompt " + "/v " + machineField.Text
            );

            // Process.Start() may throw System.ComponentModel.Win32Exception
            try
            {
                Process exeProcess = Process.Start(cmd);
            }
            catch(System.ComponentModel.Win32Exception)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "A problem has occurred.",
                    "Error", MessageBoxButtons.OK
                );
            }
            
        }

        /**
         *  Attempt UNC(Universal Naming Convention) Connection by mapping a network drive
         * */
        private void LaunchCommandUnc()
        {
            // Create a cmd file in the same directory as the executable file
            StreamWriter createFile = new StreamWriter("makeNewConnection.cmd");

            // Write command lines to makeNewConnection.cmd
            // RUNDLL32 SHELL32.DLL,SHHelpShortcuts_RunDLL Connect will open "Map a Network Drive" dialog box
            // explorer.exe /e,::{20D04FE0-3AEA-1069-A2D8-08002B30309D} will open Computer window
            createFile.WriteLine("C:\\Windows\\System32\\RUNDLL32 SHELL32.DLL,SHHelpShortcuts_RunDLL Connect");
            createFile.WriteLine("explorer.exe /e,::{20D04FE0-3AEA-1069-A2D8-08002B30309D}");

            // Close the file
            createFile.Close();

            // Opening the makeNewConnection.cmd via Explorer.exe ensures that the file is opened with the
            // credential of the currently logged on user
            ProcessStartInfo fileExplorer = new ProcessStartInfo(
                "explorer.exe" ,
                Path.Combine(System.Environment.CurrentDirectory ,
                "makeNewConnection.cmd")
            );

            // Send "\\MACHINE\c$" to the clipboard (This is how to map the C share on this particular network) 
            Clipboard.SetText("\\\\" + machineField.Text + "\\c$");

            // Inform user that the share path has been copied
            MessageBox.Show(
                "\"\\\\" + machineField.Text + "\\c$\" has been sent to the clipboard.", 
                "Attention", MessageBoxButtons.OK
            );

            // Process.Start() may throw System.ComponentModel.Win32Exception
            try
            {
                Process startFileExplorer = Process.Start(fileExplorer);

            }
            catch(System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Unable to start process.", "Error", MessageBoxButtons.OK);
            }
        }

        /**
         *  User clicks the Clear button.
         *  Action: Ask for Confirmation and then clear the information on current record
         *  @post The current record is not deleted (The total number of records in interaction remains the same)
         * */
        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Do you want to clear all contents on Record #" + CurrentIndex + "?", 
                "Confirm" ,
                MessageBoxButtons.YesNo
            );

            if (dialogResult == DialogResult.Yes)
            {
                clear();
            }
        }

        /**
         *  This method clears all data on the current record.
         * */
        private void clear()
        {
            usernameField.Text = "";
            classificationBox.Text = "";
            interactionField.Text = "";
            phoneField.Text = "";
            assetField.Text = "";
            machineField.Text = "";
            titleField.Text = "";
            descriptionField.Text = "";
        }

        /**
         *  User can normally press Control - A to select and highlight all texts in a text box.
         *  However, Windows form does not allow that shortcut for Multiline text box
         *  This event emulates the Control - A shortcut and allows user to select all texts in the
         *  description text box.
         * */
        private void descriptionField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
            }
        }

        /**
         *  User clicks the CL button.
         *  Action: CheckListForm will open as dialog window
         *          Once the form closes, the Description Box will be updated
         * */
        private void checklistButton_Click(object sender, EventArgs e)
        {
            // Initialize the static variable
            checkListToAdd = "";

            // Create a new form of type CheckListForm
            CheckListForm checklistForm = new CheckListForm();

            // Open the dialog box
            checklistForm.ShowDialog();
            
            // Update the Decsription (Insert the new checklist)
            descriptionField.Text += checkListToAdd;
        }

        /**
         *  User clicks Send All to Clipboard button.
         * */
        private void copyAllButton_Click(object sender, EventArgs e)
        {
            // string buffer
            string toSend = "";

            // This variable decides whether separating line should be drawn
            bool hasAboveInfo = false;

            // If the username field has any content, add it to the buffer
            if( usernameField.Text.Length > 0 )
            {
                toSend += "Username: " + usernameField.Text + Environment.NewLine;
                hasAboveInfo = true;
            }

            // If the classification field has any content, add it to the buffer
            if( classificationBox.Text.Length > 0 )
            {
                toSend += "Classification: " + classificationBox.Text + Environment.NewLine;
                hasAboveInfo = true;
            }
            
            // If the interaction field has any content, add it to the buffer
            if( interactionField.Text.Length > 0 )
            {
                toSend += "Interaction: " + interactionField.Text + Environment.NewLine;
                hasAboveInfo = true;
            }
            
            // If the Phone field has any contents, add it to the buffer
            if( phoneField.Text.Length > 0 )
            {
                toSend += "Phone: " + phoneField.Text + Environment.NewLine;
                hasAboveInfo = true;
            }
            
            // If the Asset field has any content, add it to the buffer
            if( assetField.Text.Length > 0 )
            {
                toSend += "Asset: " + assetField.Text + Environment.NewLine;
                hasAboveInfo = true;
            }
            
            // If the Machine field has any content, add it to the buffer
            if( machineField.Text.Length > 0 )
            {
                toSend += "Machine: " + machineField.Text + Environment.NewLine;
                hasAboveInfo = true;
            }
            
            // If any of the above information is in the buffer, draw a separating line
            if(hasAboveInfo)
            {
                toSend += "--------------------------------" + Environment.NewLine;
            }
            
            // Add disclaimer statements and then the description contents
            toSend += Environment.NewLine;
            toSend += "Troubleshooting:" + Environment.NewLine;
            toSend += "-----------------------------------------------------------------" + Environment.NewLine;
            toSend += "** Obtained Customer's Permission before making any remote connections" + Environment.NewLine;
            toSend += "** Ensured that the customer closed any sensitive or personal documents " +
                      "before making any foreground connections" +
                      Environment.NewLine;
            toSend += Environment.NewLine;
            toSend += descriptionField.Text;

            Clipboard.SetText(toSend);
        }

        /**
         *  The Title field gains focus (User clicks the Title field or tabs into it).
         *  Action: Add classification tag
         *  
         *  Unclassified NNPI - Add "NNPI - "
         *  Classified - Add "SIPR - "
         *  Classified NNPI - Add "SIPR - "
         * */
        private void titleField_Enter(object sender, EventArgs e)
        {
            if(classificationBox.Text.Equals("Unclassified NNPI") && !titleField.Text.Contains("NNPI"))
            {
                titleField.Text = "NNPI - " + titleField.Text;
            }
            else if(classificationBox.Text.Equals("Classified") && !titleField.Text.Contains("SIPR"))
            {
                titleField.Text = "SIPR - " + titleField.Text;
            }
            else if(classificationBox.Text.Equals("Classified NNPI") && !titleField.Text.Contains("SIPR"))
            {
                titleField.Text = "SIPR - " + titleField.Text;
            }
            else
            {
                return;
            }
        }

        /**********************************************************************************************
         * This section contains methods that are called while user navigates to a different record
         * (Such as clicking Prev or Next button or specifying the Record# to view in the index field),
         * creates a new record, or deletes a new record. 
         * 1. load
         * 2. save
         * 3. New Button
         * 4. Delete Button
         * 5. Previous Button
         * 6. Next Button
         * 7. Go Button
         * 8. Index TextBox
         * *******************************************************************************************/

        /**
         *  This method displays the specified record
         *  @param index int untranslated record number to display
         *  @Pre The index MUST not be out of boundary - this method does NOT check for OutOfBoundIndex
         *       The method invoking this method is responsible for input validation
         * */
        private void load( int index )
        {
            // Get the current Record number
            CurrentIndex = index;

            // Update Record# Label
            recordNumberLabel.Text = "#" + index;

            // Translate the given index and load the specified record
            Record toLoad = interactions[index - 1];

            // Display the information on the loaded record
            usernameField.Text = toLoad.Username;
            classificationBox.Text = toLoad.Classification;
            interactionField.Text = toLoad.Interaction;
            phoneField.Text = toLoad.Telephone;
            assetField.Text = toLoad.Asset;
            machineField.Text = toLoad.Machine;
            titleField.Text = toLoad.Title;
            descriptionField.Lines = toLoad.Description;
            indexBox.Text = Convert.ToString(index);
            totalCountLabel.Text = Convert.ToString(interactions.Size());
        }

        /**
         *  This method saves the specified record to RecordStack interactions
         *  @param index int untranslated record number to save
         *  @Pre The index MUST not be out of boundary - this method does NOT check for OutOfBoundIndex
         *       The method invoking this method is responsible for input validation
         * */
        private void save( int index )
        {
            // Translate the index and save the information at the index
            interactions[index - 1].Username = usernameField.Text;
            interactions[index - 1].Classification = classificationBox.Text;
            interactions[index - 1].Interaction = interactionField.Text;
            interactions[index - 1].Telephone = phoneField.Text;
            interactions[index - 1].Asset = assetField.Text;
            interactions[index - 1].Machine = machineField.Text;
            interactions[index - 1].Title = titleField.Text;
            interactions[index - 1].Description = descriptionField.Lines;
        }

        /**
         *  User clicks New button to create a new record
         *  Action: Create a new record and save it to RecordStack interactions and save all data to XML file
         * */
        private void newButton_Click(object sender, EventArgs e)
        {
            // Save the current record
            save(CurrentIndex);

            // Create a new Record and add it to interactions
            Record newRecord = new Record();
            interactions.Add(newRecord);

            // Save all data (RecordStack) to the xml file
            try
            {
                XML.SaveData(interactions);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show(
                    "A problem has occurred while saving data. FormData.xml may be corrupted.",
                    "Error",
                    MessageBoxButtons.OK
                );
            }

            // Load the newly created Record (Remember that load() accepts untranslated index)
            load(interactions.Size());
        }

        /**
         *  User clicks the Delete button to delete current record being displayed
         *  Action: Delete the current record and save all data to XML file
         * */
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Untranslated Index of the Record to delete
            int toDelete = CurrentIndex;

            // Obtain confirmation from user. Do they really want to delete the record?
            DialogResult dialogResult = MessageBox.Show(
                "Do you want to delete Record #" + CurrentIndex + "?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            // If user responds "Yes" to the confirmation,
            if (dialogResult == DialogResult.Yes)
            {
                // If there is only 1 record, simply clear the current form.
                // The form must have at least 1 Record to function
                if (interactions.Size() <= 1)
                {
                    clear();
                }
                // There are multiple records, so the current record will be completely removed
                else
                {
                    // Remove the record at the translated index
                    interactions.RemoveAt(toDelete - 1);

                    if (toDelete > interactions.Size())
                    {
                        load(interactions.Size());
                    }
                    else
                    {
                        load(toDelete);
                    }
                }
            }
            // User responded "No" to the confirmation. Take no action.
            else
            {
                return;
            }

            // Save all data (RecordStack) to the xml file
            // As you can see, the following code runs regardless of whether user chooses Yes or No to
            // the confirmation.
            try
            {
                XML.SaveData(interactions);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show(
                    "A problem has occurred while saving data. FormData.xml may be corrupted.",
                    "Error",
                    MessageBoxButtons.OK
                );
            }
        }

        /**
         *  User clicks Left Arrow button (Previous Button).
         *  Action: Load the previous record and display it
         * */
        private void prevButton_Click(object sender, EventArgs e)
        {
            // Save the current record to RecordStack interactions
            save(CurrentIndex);

            // Get the untranslated index of the previous record
            int toPrev = CurrentIndex - 1;

            // If the previous index is zero or lower, it will load the
            // last record in the RecordStack interactions
            if( toPrev <= 0 )
            {
                load(interactions.Size());
            }
            // If the previous index is in the middle range, simply load it
            else
            {
                load(toPrev);
            }
        }

        /**
         *  User clicks Right Arrow button (Next Button).
         *  Action: Load the next record and display it
         * */
        private void nextButton_Click(object sender, EventArgs e)
        {
            // Save the current record to RecordStack interactions
            save(CurrentIndex);

            // Get the untranslated index of the next record
            int toNext = CurrentIndex + 1;

            // If the next index is higher than the size of current interactions
            // go back to the first record and load it
            if ( toNext > interactions.Size() )
            {
                load(1);
            }
            // If the next index is in the middle range, simply load it
            else
            {
                load(toNext);
            }
        }

        /**
         *  Index Box receives input from user. User specifies the record# they want to access.
         *  Due to the high possibility of invalid input such as Out-Of-Bound index, non integer characters
         *  and etc, a strict validation is required.
         *  
         *  Event is raised when user changes the texts inside the Index box. If the entered charater is non-integer,
         *  the character is immediately removed. If the entered integer is out of bound, it will also be removed and
         *  a index value that is within range will replace the removed integer.
         * */
        private void indexBox_TextChanged(object sender, EventArgs e)
        {
            // If no character is entered, set the new texts to '1'
            if( indexBox.Text.Length < 1)
            {
                indexBox.Text = Convert.ToString(1);
            }
            // If entered character is NOT numeric, replace it with the CurrentIndex
            else if (System.Text.RegularExpressions.Regex.IsMatch(indexBox.Text, "[^0-9]"))
            {
                indexBox.Text = Convert.ToString(CurrentIndex);
            }
            // If the entered integer is larger than the current size of interactions,
            // set the new texts to the index of the last record in the interactions
            else if( Convert.ToInt32(indexBox.Text) > interactions.Size() )
            {
                indexBox.Text = Convert.ToString(interactions.Size());
            }
            // If the entered integer is lower than 1, set the new texts to '1'
            else if( Convert.ToInt32(indexBox.Text) < 1 )
            {
                indexBox.Text = Convert.ToString(1);
            }
            // If the entered character is valid, take no action
            else
            {
                return;
            }
        }

        /**
         * User hits Enter key while the index box has focus. Load and display the record
         * specified by the value in the Index box.
         * @pre It is assumed that the entered integer is valid and within range
         * */
        private void indexBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Save the current record
                save(CurrentIndex);

                // Load the record at the given index
                load(Convert.ToInt32(indexBox.Text));
            }
        }

        /**********************************************************************************************
         * This section has methods define event actions for when the MainForm first opens and when the
         * MainForm is closing.
         * 1. MainForm Loads
         * 2. MainForm Closing
         * *******************************************************************************************/

        /**
         *  This method performs necessary actions to retrieve data from xml file when the Form 
         *   application opens
         *  If "FormData.xml" file exists in the same directory as the .exe file, then it will try to
         *   read the file.
         *  If the file does not exist, then form will simply add a blank record.
         * */
        private void mainWindow_Load(object sender, EventArgs e)
        {
            // If FormData.xml exists in the current directory, try to read data from it
            if(File.Exists("FormData.xml"))
            {
                try
                {
                    // Save data in RecordStack interactions
                    interactions = XML.LoadData();

                    // Load the last record
                    load(interactions.Size());
                }
                catch(System.InvalidOperationException)
                {
                    MessageBox.Show(
                        "A problem has occurred while reading from FormData.xml." +
                        "Try removing or renaming FormData.xml. Then, reopen this application.",
                        "Error",
                        MessageBoxButtons.OK
                    );

                    // Close the form after displaying the error message
                    this.Close();
                }
            }
            // If the file does not exist, simply create an empty record (Fresh Start).
            else
            {
                Record initial = new Record();
                interactions = new RecordStack();
                interactions.Add(initial);
                CurrentIndex = 1;
            }
        }

        /**
         *  While the form is being closed (User clicked Close button), save the current record
         *   and then save all data in RecordStack interactions to .xml file
         * */
        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // makeNewConnection.cmd file is created if user attempts to make UNC connections.
            // Before closing the form, check to see if this file exists. If it does, remove it.
            if(File.Exists("makeNewConnection.cmd"))
            {
                File.Delete("makeNewConnection.cmd");
            }

            // Save data at current index (Current Record being displayed)
            // Then, save all data (RecordStack) to the xml file
            try
            {
                save(CurrentIndex);
                XML.SaveData(interactions);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show(
                    "A problem has occurred while saving data. FormData.xml may be corrupted.",
                    "Error",
                    MessageBoxButtons.OK
                );
            }
        }
    }
}