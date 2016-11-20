using System;

namespace FormsApplication.Records
{
    /**
     *  Record stores all the contents of an interaction ticket
     * */
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

        /**
         *  Default Constructor
         *  Initialize all variables
         * */
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
        
        /**
         *  Constructor that accepts contents of text fields
         * */
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

        /**
         *  Getter and Setter for username
         * */
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        /**
         *  Getter and Setter for classification
         * */
        public string Classification
        {
            get { return classification; }
            set { classification = value; }
        }

        /**
         *  Getter and Setter for interaction
         * */
        public string Interaction
        {
            get { return interaction; }
            set { interaction = value; }
        }

        /**
         *  Getter and Setter for telephone
         * */
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        /**
         *  Getter and Setter for asset
         * */
        public string Asset
        {
            get { return asset; }
            set { asset = value; }
        }

        /**
         *  Getter and Setter for machine
         * */
        public string Machine
        {
            get { return machine; }
            set { machine = value; }
        }

        /**
         *  Getter and Setter for title
         * */
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        /**
         *  Getter and Setter for description
         * */
        public string[] Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}