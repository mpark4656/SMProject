using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace FormsApplication
{
    public partial class MainForm : Form
    {
        // Data structure that stores records
        private RecordStack interactions;

        // Keeps track of the current record number that is displayed
        private int CurrentIndex;


        /**********************************************************************************************
         * The following methods handle events created when user clicks buttons on the form
         * 1. Copy Button
         * 2. Ping Button
         * 3. Clear Button
         * 4. Send All to Clipboard
         * 5. Format Phone Number
         * 6. MSRA Button
         * *******************************************************************************************/
        /**
         *  Default Constructor
         * */
        public MainForm()
        {
            InitializeComponent();
        }

        // Send the username field content to client's clipboard
        private void copyUsernameButton_Click(object sender, EventArgs e)
        {
            if( 0 < usernameField.Text.Length )
            {
                Clipboard.SetText(usernameField.Text);
            }
        }

        // Send the telephone field content to client's clipboard
        private void copyPhoneButton_Click(object sender, EventArgs e)
        {
            if( 0 < phoneField.Text.Length )
            {
                Clipboard.SetText(phoneField.Text);
            }
        }

        // Add parentheses and dashes in the phone number
        private void phoneFormatButton_Click(object sender, EventArgs e)
        {
            phoneField.Text = phoneField.Text.Replace("-", "");
            phoneField.Text = phoneField.Text.Replace("(", "");
            phoneField.Text = phoneField.Text.Replace(")", "");
            phoneField.Text.Trim();

            if ( phoneField.Text.Length < 7)
            {
                return;
            }
            else if( phoneField.Text.Length <= 7 )
            {
                phoneField.Text = phoneField.Text.Insert(3, "-");
            }
            else if( phoneField.Text.Length <= 10 )
            {
                phoneField.Text = phoneField.Text.Insert(0, "(");
                phoneField.Text = phoneField.Text.Insert(4, ")");
                phoneField.Text = phoneField.Text.Insert(8, "-");
            }
            else
            {
                phoneField.Text = phoneField.Text.Insert(0, "(");
                phoneField.Text = phoneField.Text.Insert(4, ")");
                phoneField.Text = phoneField.Text.Insert(8, "-");
            }
        }

        // Send the classification field content to client's clipboard
        private void copyClassificationButton_Click(object sender, EventArgs e)
        {
            if( 0 < classificationBox.Text.Length )
            {
                Clipboard.SetText(classificationBox.Text);
            }
        }

        // Send the Interaction field content to client's clipboard
        private void copyInteractionButton_Click(object sender, EventArgs e)
        {
            if( 0 < interactionField.Text.Length )
            {
                Clipboard.SetText(interactionField.Text);
            }
        }

        // Send the Asset Field content to client's clipboard
        private void copyAssetButton_Click(object sender, EventArgs e)
        {
            if( 0 < assetField.Text.Length )
            {
                Clipboard.SetText(assetField.Text);
            }
        }

        // Send the Machine Field content to client's clipboard
        private void copyMachineButton_Click(object sender, EventArgs e)
        {
            if( 0 < machineField.Text.Length )
            {
                Clipboard.SetText(machineField.Text);
            }
        }

        // Send the Description Field content to client's clipboard
        private void copyInfoButton_Click(object sender, EventArgs e)
        {
            if( 0 < descriptionField.Text.Length )
            {
                Clipboard.SetText(descriptionField.Text);
            }
        }

        // User clicks "Ping Continuously" button
        private void pingButton_Click(object sender, EventArgs e)
        {
            LaunchCommandPing();
        }

        // User clicks MSRA button
        private void msraButton_Click(object sender, EventArgs e)
        {
            LaunchCommandMsra();
        }

        // User clicks RDC Button
        private void rdcButton_Click(object sender, EventArgs e)
        {
            LaunchCommandRdc();
        }

        // User clicks UNC Button
        private void uncButton_Click(object sender, EventArgs e)
        {
            LaunchCommandUnc();
        }

        // Launch cmd.exe with PING command
        private void LaunchCommandPing()
        {
            string arg = "c:\\Windows\\System32\\ping -t " + machineField.Text;

            ProcessStartInfo cmd = new ProcessStartInfo("c:\\Windows\\System32\\cmd.exe", "/K " + arg );

            Process exeProcess = Process.Start( cmd );
        }

        // Launch MSRA with /offerRA parameter
        private void LaunchCommandMsra()
        {
            ProcessStartInfo cmd = new ProcessStartInfo( "c:\\Windows\\System32\\msra.exe" , 
                                                         "/offerRA " + machineField.Text );

            Process exeProcess = Process.Start(cmd);
        }

        // Launch RDC with /prompt parameter
        private void LaunchCommandRdc()
        {
            ProcessStartInfo cmd = new ProcessStartInfo( "c:\\Windows\\System32\\mstsc.exe",
                                                         "/prompt " + "/v " + machineField.Text);

            Process exeProcess = Process.Start(cmd);
        }

        // Attempt UNC(Universal Naming Convention) Connection
        private void LaunchCommandUnc()
        {
            ProcessStartInfo cmd = new ProcessStartInfo("c:\\Windows\\System32\\RUNDLL32" , "SHELL32.DLL,SHHelpShortcuts_RunDLL Connect");
            
            if( machineField.Text.Length > 0 )
            {
                Clipboard.SetText("\\\\" + machineField.Text + "\\c$");
                MessageBox.Show("\"\\\\" + machineField.Text + "\\c$\" has been sent to clipboard",
                             "Attention", MessageBoxButtons.OK);
            }

            Process exeProcess = Process.Start(cmd);
        }

        // User clicks Copy Title Button
        private void copyTitleButton_Click(object sender, EventArgs e)
        {
            if(0 < titleField.Text.Length )
            {
                Clipboard.SetText(titleField.Text);
            }
        }

        // Display a popup message when user clicks "Clear" button
        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to clear all contents on Record #" + CurrentIndex + "?", 
                                                        "Confirm" , MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                clear();
            }
        }

        // Private function to clear all text fields on the form
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

        // Allow user to select all contents in the description text box when they press Control - A
        private void descriptionField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
            }
        }

        // User clicks Send All to Clipboard button.
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





        /**********************************************************************************************
         * The following methods changes the Title depending on the ticket classification
         * *******************************************************************************************/
        // User changes the content of Classification Field
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
            else
            {
                return;
            }
        }





        /**********************************************************************************************
         * The following methods handle events created when user navigates to different records, add
         * records or remove records
         * 1. load
         * 2. save
         * 3. New Button
         * 4. Delete Button
         * 5. Previous Button
         * 6. Next Button
         * 7. Go Button
         * 8. Index TextBox
         * *******************************************************************************************/

        // Load the record and display it. The index given is untranslated index.
        private void load( int index )
        {
            CurrentIndex = index;
            recordNumberLabel.Text = "#" + index;
            Record toLoad = interactions[index - 1];

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

        private void save( int index )
        {
            interactions[index - 1].Username = usernameField.Text;
            interactions[index - 1].Classification = classificationBox.Text;
            interactions[index - 1].Interaction = interactionField.Text;
            interactions[index - 1].Telephone = phoneField.Text;
            interactions[index - 1].Asset = assetField.Text;
            interactions[index - 1].Machine = machineField.Text;
            interactions[index - 1].Title = titleField.Text;
            interactions[index - 1].Description = descriptionField.Lines;
        }

        // User clicks New button. Create a new record and add it to the stack
        private void newButton_Click(object sender, EventArgs e)
        {
            save(CurrentIndex);
            Record newRecord = new Record();
            interactions.Add(newRecord);
            XML.SaveData(interactions);
            load(interactions.Size());
        }

        // User clicks Delete button. Delete the current record.
        private void deleteButton_Click(object sender, EventArgs e)
        {
            int toDelete = CurrentIndex;

            DialogResult dialogResult = MessageBox.Show("Do you want to delete Record #" + CurrentIndex + "?",
                                                        "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // If there is only 1 record, simply clear the current form
                if (interactions.Size() <= 1)
                {
                    clear();
                    XML.SaveData(interactions);
                }
                else
                {
                    interactions.RemoveAt(toDelete - 1);

                    if (toDelete > interactions.Size())
                    {
                        load(interactions.Size());
                    }
                    else
                    {
                        load(toDelete);
                    }

                    XML.SaveData(interactions);
                }
            }
            else
            {
                return;
            } 
        }

        // User clicks Previous button. Navigate to the previous interaction.
        private void prevButton_Click(object sender, EventArgs e)
        {
            save(CurrentIndex);
            XML.SaveData(interactions);

            int toPrev = CurrentIndex - 1;

            if( toPrev <= 0 )
            {
                load(interactions.Size());
            }
            else
            {
                load(toPrev);
            }
        }

        // User clicks Next button. Navigate to the next interaction.
        private void nextButton_Click(object sender, EventArgs e)
        {
            save(CurrentIndex);
            XML.SaveData(interactions);

            int toNext = CurrentIndex + 1;

            if( toNext > interactions.Size() )
            {
                load(1);
            }
            else
            {
                load(toNext);
            }
        }

        // Validate the input that user enters in indexBox
        private void indexBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(indexBox.Text, "[^0-9]"))
            {
                indexBox.Text = Convert.ToString(CurrentIndex);
            }
            else if( Convert.ToInt32(indexBox.Text) > interactions.Size() )
            {
                indexBox.Text = Convert.ToString(interactions.Size());
            }
            else if( Convert.ToInt32(indexBox.Text) < 1 )
            {
                indexBox.Text = Convert.ToString(1);
            }
            else
            {
                return;
            }
        }

        // Navigate to the entered index when user clicks Go button
        private void goToButton_Click(object sender, EventArgs e)
        {
            save(CurrentIndex);
            XML.SaveData(interactions);
            load(Convert.ToInt32(indexBox.Text));
        }

        // Navigate to the entered index when user hits Enter key while indexBox has focus
        private void indexBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goToButton.PerformClick();
            }
        }






        /**********************************************************************************************
         * The following functions perform any necessary action when the form loads or when the form
         * closes
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
            if ( File.Exists("FormData.xml"))
            {
                interactions = XML.LoadData();

                // Load the last record
                load(interactions.Size());
            }
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
         *   and save all data to .xml file
         * */
        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            save(CurrentIndex);
            XML.SaveData(interactions);
        }
    }
}
