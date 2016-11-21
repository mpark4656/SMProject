using System.Collections.Generic;

namespace FormsApplication.Records
{
    /// <summary>
    ///  RecordStack is a collection of Records.
    ///  The more interaction user creates, the larger RecordStack gets
    /// </summary>
    public class RecordStack
    {
        private List<Record> records;

        /// <summary>
        ///  Default Constructor
        /// </summary>
        public RecordStack()
        {
            records = new List<Record>();
        }

        /// <summary>
        ///  Public getter and setter for List<Record> records
        /// </summary>
        public List<Record> Records
        {
            get { return records; }
            set { records = value; }
        }

        /// <summary>
        ///  Method to allow users to use square bracket (indexer) to access
        ///  elements in List<Record> records
        /// </summary>
        /// <param name="index">
        ///  int index at which to access and modify the Record
        /// </param>
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

        /// <summary>
        ///  Method that returns the size of records
        /// </summary>
        /// <returns>
        ///  count int number of records in the list
        /// </returns>
        public int Size()
        {
            return records.Count;
        }

        /// <summary>
        ///  Method to remove a record at given index
        /// </summary>
        /// <param name="index">
        ///  index int index at which to remove the record
        /// </param>
        public void RemoveAt( int index)
        {
            records.RemoveAt(index);
        }

        /// <summary>
        ///  Method to add a new record to List<Record> records
        /// </summary>
        /// <param name="toAdd">
        ///  Record record to add
        /// </param>
        public void Add( Record toAdd )
        {
            records.Add(toAdd);
        }  
    }
}