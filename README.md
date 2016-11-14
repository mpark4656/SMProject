# SMProject
Stores ticket information and facilitates Enterprise ticket creation

![Program GUI Image](https://cloud.githubusercontent.com/assets/16367862/20277207/9fb6379a-aa6d-11e6-92e1-b212ef10829a.png)

## Features
- Simple Graphical User Interface for easy use
- Ticket Information is saved locally in a XML file (in the same directory as the .exe file) - users decide when their records can be removed and have complete control over saved records
- Larger font size than original SMPad to improve readability
- Quick Copy: Sends information in the individual text field to the clipboard with a click of the button
- Copy All: Copies all information on the record in a special format
- Format Telephone Number: When telephone number is entered with digits only (i.e. 1234567890), change it to (123)456-7890 with a click of the button - users no longer need to manually enter parentheses or dashes
- Classification tag is automatically added to the Title given that the Classification text field has the correct classification specified - tag is automatically added when the Title field gains focus
- Continuous Ping: Opens cmd.exe and pings specified machine name or IP Address with a click of the button - users can instantly find out whether the machine name can be resolved to an IP Address or whether the host has network connectivity
- MSRA: Opens attempts Microsoft Remote Assistance to specified machine with /offerRA parameter
- RDC: Attempts Remote Desktop Connection to specified machine with /prompt parameter
- UNC: Opens "Map a Network Drive" dialog window with UNC path sent to clipboard
- Window can be enlarged. However, minimum size is enforced to maintain proper positions of GUI components

## Future Improvement Ideas
- Enable CL button for adding checklists
- Allow user to increase or decrease font size

## Copyright
Created by mpark
