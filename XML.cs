using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace FormsApplication
{
    public class XML
    {
        /**
         * Save RecordStack to .xml file
         * This method will be invoked when user creates a new record, deletes a record
         *  or when the form is being closed.
         * */
        public static void SaveData(RecordStack toSave)
        {
            XmlSerializer sr = new XmlSerializer( toSave.GetType());
            StreamWriter writer = new StreamWriter("FormData.xml");
            sr.Serialize(writer,toSave);
            writer.Close();
        }

        /**
         *  Load RecordStack from the .xml file.
         *  This method will be invoke when the form initially opens.
         * */
        public static RecordStack LoadData()
        {
            XmlSerializer sr = new XmlSerializer(typeof(RecordStack));
            FileStream read = new FileStream("FormData.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            RecordStack toLoad = (RecordStack)sr.Deserialize(read);
            read.Close();

            return toLoad;
        }
    }
}
