using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApplication
{
    /**
     *  This class is a collection of CheckLists
     * */
    public class CheckListStack
    {
        // Stores multiple instances of CheckList
        private List<CheckList> checklists;

        /**
         *  Default Constructor
         * */
        public CheckListStack()
        {
            checklists = new List<CheckList>();
        }

        /**
         *  Allows to access element of checklists by its index
         * */
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

        /**
         *  Public gette and setter for checklists
         * */
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
        
        /**
         *  Return the count of all checklists in the List
         * */
        public int Size()
        {
            return checklists.Count;
        }

        /**
         *  Method to remove a CheckList at specified index
         *  @param index int index at which to remove the record
         * */
        public void RemoveAt( int index )
        {
            checklists.RemoveAt(index);
        }

        public void Add( CheckList toAdd )
        {
            checklists.Add(toAdd);
        }
    }
}
