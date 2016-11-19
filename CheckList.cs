using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApplication
{
    /**
     *  This class contains name of a checlist and the contents of the checklist
     * */
    public class CheckList
    {
        // Name of this checklist
        private string display;

        // Array of strings representing the contents of the checklist
        private string[] value;

        /**
         *  Default Constructor
         * */
        public CheckList()
        {
            display = "";
            value = new string[1];
            value[0] = "";
        }

        /**
         *  Non-Default Constructor
         * */
        public CheckList( string display , string[] value )
        {
            Display = display;
            Value = value;
        }

        /**
         *  Public getter and setter for display
         * */
        public string Display
        {
            get
            {
                return display;
            }
            set
            {
                display = value;
            }
        }

        /**
         *  Public getter and setter for value
         * */
        public string[] Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }
    }
}
