using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApplication.Checklist
{
    /// <summary>
    ///  This class contains name of a checlist and the contents of the checklist
    /// </summary>
    public class CheckList
    {
        // Name of this checklist
        private string display;

        // Array of strings representing the contents of the checklist
        private string[] value;

        /// <summary>
        ///  Default Constructor
        /// </summary> 
        public CheckList()
        {
            display = "";
            value = new string[1];
            value[0] = "";
        }

        /// <summary>
        ///  Non-Default Constructor
        /// </summary>
        public CheckList( string display , string[] value )
        {
            Display = display;
            Value = value;
        }

        /// <summary>
        ///  Public getter and setter for display
        /// </summary>
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

        /// <summary>
        ///  Public getter and setter for value
        /// </summary>
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
