using System.Collections.Generic;

namespace FormsApplication
{
    /**
     *  RecordStack is a collection of Records.
     *  The more interaction user creates, the larger RecordStack gets
     * */
    public class RecordStack
    {
        private List<Record> records;

        /**
         *  Default Constructor
         * */
        public RecordStack()
        {
            records = new List<Record>();
        }

        /**
         *  Public getter and setter for List<Record> records
         * */
        public List<Record> Records
        {
            get { return records; }
            set { records = value; }
        }

        /**
         *  Method to allow users to use square bracket (indexer) to access
         *  elements in List<Record> records
         *  @param index int index of the record to access
         * */
        public Record this[int index]
        {
            // Allows Read
            get
            {
                return records[index];
            }

            // Allows Modification
            set
            {
                records[index] = value;
            }
        }

        /**
         *  Method that returns the size of records
         *  @return count int number of records in the list
         * */
        public int Size()
        {
            return records.Count;
        }

        /**
         *  Method to remove a record at given index
         *  @param index int index at which to remove the record
         * */
        public void RemoveAt( int index)
        {
            records.RemoveAt(index);
        }

        /**
         *  Method to add a new record to List<Record> records
         *  @param toAdd Record record to add
         * */
        public void Add( Record toAdd )
        {
            records.Add(toAdd);
        }  
    }
}