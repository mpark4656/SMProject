using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApplication.Checklist
{
    /// <summary>
    ///  This class is a collection of CheckLists
    /// </summary>
    public class CheckListStack
    {
        // Stores multiple instances of CheckList
        private List<CheckList> checklists;

        /// <summary>
        ///  Default Constructor
        /// </summary>
        public CheckListStack()
        {
            checklists = new List<CheckList>();
        }

        /// <summary>
        ///  Allows to access element of checklists by its index
        /// </summary>
        public CheckList this[int index]
        {
            get
            {
                return checklists[index];
            }
            set
            {
                checklists[index] = value;
            }
        }

        /// <summary>
        ///  Public gette and setter for checklists
        /// </summary>
        public List<CheckList> Checklists
        {
            get
            {
                return checklists;
            }
            set
            {
                checklists = value;
            }
        }

        /// <summary>
        ///  Return the count of all checklists in the List
        /// </summary>
        public int Size()
        {
            return checklists.Count;
        }

        /// <summary>
        ///  Method to remove a CheckList at specified index
        /// </summary>
        /// 
        /// <param name="index">
        ///  int index at which to remove the record
        /// </param>
        public void RemoveAt( int index )
        {
            checklists.RemoveAt(index);
        }

        /// <summary>
        ///  Method to add a CheckList to the end of this List
        /// </summary>
        /// 
        /// <param name="toAdd">
        ///  CheckList A checklist to add to this collection
        /// </param>
        public void Add( CheckList toAdd )
        {
            checklists.Add(toAdd);
        }
    }
}
