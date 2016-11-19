﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApplication
{
    public partial class AddCheckListForm : Form
    {
        /**
         *  Default Constructor
         *  This constructor is called when use is adding a new checklist
         * */
        public AddCheckListForm()
        {
            InitializeComponent();
        }

        /**
         *  This contructor is invoked when user is modifying a current existing Checklist
         *  Modifying and Adding have similar capabilities so all we really need is to change
         *  the name of the Window and the Button name.
         * */
        public AddCheckListForm( string title , string modifyButton )
        {
            InitializeComponent();

            this.Text = title;
            AddButton.Text = modifyButton;

            // Load the contents of the current checklist
            DisplayField.Text = CheckListForm.displayToAdd;
            ValueField.Lines = CheckListForm.valueToAdd;
        }

        /**
         *  User clicks the Add button
         *  Action: Update CheckListForm.displayToAdd and CheckListForm.valueToAdd
         * */
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Trim whitespace around the Display Field Text
            DisplayField.Text = DisplayField.Text.Trim();

            // If Display Field ie empty, prompt user to enter a display name
            if ( DisplayField.Text.Length <= 0)
            {
                MessageBox.Show("Enter the Name of the Checklist.", "Name Required", MessageBoxButtons.OK);

                // Set the focus on DisplayField
                DisplayField.Focus();
                return;
            }

            // Update the variables
            CheckListForm.displayToAdd = DisplayField.Text;
            CheckListForm.valueToAdd = ValueField.Lines;

            // Close the form
            Close();
        }

        /**
         *  User clicks Cancel/Close button
         *  Action: Close this form
         * */
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
