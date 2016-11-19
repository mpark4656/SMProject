# SMProject
Stores ticket information and facilitates Enterprise ticket creation

## Main Application Window
![Program GUI Image](https://cloud.githubusercontent.com/assets/16367862/20451366/4447ca70-adc6-11e6-9fd5-f14fe9485ab3.png)

## Main Checklist Window
![Program GUI Image](https://cloud.githubusercontent.com/assets/16367862/20456682/1a67277c-ae49-11e6-9179-c750a815b002.png)

## Add Checklist Window
![Program GUI Image](https://cloud.githubusercontent.com/assets/16367862/20456688/4d4a2fa4-ae49-11e6-94cd-70b90ae7a975.png)

## Modify Checklist Window
![Program GUI Image](https://cloud.githubusercontent.com/assets/16367862/20456691/6765437e-ae49-11e6-87d0-44793db0ed2f.png)

## Features
- Simple Graphical User Interface for easy use
- Ticket Information is saved locally in a XML file (in the same directory as the .exe file) - users decide when their records can be removed and have complete control over saved records
- Larger font size than original SMPad to improve readability
- Copy Field: Sends information in the individual text field to the clipboard with a click of the button
- Copy All: Copies all information on the record in a special format
- Format Telephone Number: When telephone number is entered with digits only (i.e. 1234567890), change it to (xxx)xxx-xxxx format with a click of the button - users no longer need to manually enter parentheses or dashes
- Classification tag is automatically added to the Title given that the Classification text field has the correct classification entered - tag is automatically added when the Title field gains focus
- Ping: Opens cmd.exe and continuously pings the specified machine name or IP Address with a click of the button - users can instantly find out whether the machine name can be resolved to an IP Address or whether the host has network connectivity
- MSRA: Opens Microsoft Remote Assistance and attempts to connect to the specified machine with /offerRA parameter
- RDC: Attempts Remote Desktop Connection to specified machine with /prompt parameter
- UNC: Opens "Map a Network Drive" dialog window with UNC path sent to clipboard
- Add Checklist: Add a checklist to the Description or send a checklist to the clipboard
- Window can be enlarged. However, minimum size is enforced to maintain proper positions of GUI components

## Copyright
Created by mpark
