using System;

namespace FormsApplication.Records
{
    /// <summary>
    ///  Record stores all the contents of an interaction ticket
    /// </summary>
    public class Record
    {
        private string username;
        private string classification;
        private string interaction;
        private string telephone;
        private string asset;
        private string machine;
        private string title;
        private string[] description;

        /// <summary>
        ///  Default Constructor
        ///  Initialize all variables
        /// </summary>
        public Record()
        {
            Username = "";
            Classification = "";
            Interaction = "";
            Telephone = "";
            Asset = "";
            Machine = "";
            Title = "";
            description = null;
        }

        /// <summary>
        ///  Constructor that accepts contents of text fields
        /// </summary>
        public Record(string username, 
                      string classification,
                      string interaction ,
                      string phone,
                      string asset,
                      string machine,
                      string title,
                      string[] desc)
        {
            Username = username;
            Classification = classification;
            Interaction = interaction;
            Telephone = phone;
            Asset = asset;
            Machine = machine;
            Title = title;
            Description = desc;
        }

        /// <summary>
        ///  Getter and Setter for username
        /// </summary>
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        ///  Getter and Setter for classification
        /// </summary>
        public string Classification
        {
            get { return classification; }
            set { classification = value; }
        }

        /// <summary>
        ///  Getter and Setter for interaction
        /// </summary>
        public string Interaction
        {
            get { return interaction; }
            set { interaction = value; }
        }

        /// <summary>
        ///  Getter and Setter for telephone
        /// </summary>
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        /// <summary>
        ///  Getter and Setter for asset
        /// </summary>
        public string Asset
        {
            get { return asset; }
            set { asset = value; }
        }

        /// <summary>
        ///  Getter and Setter for machine
        /// </summary>
        public string Machine
        {
            get { return machine; }
            set { machine = value; }
        }

        /// <summary>
        ///  Getter and Setter for title
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        ///  Getter and Setter for description
        /// </summary>
        public string[] Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}