using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace FormsApplication
{
    /// <summary>
    ///  This class contains helper methods for saving data to XML file and reading data
    ///  from the XML file.
    /// </summary>
    public class XML
    {
        /// <summary>
        ///  Save RecordStack to .xml file
        ///  This method will be invoked when user creates a new record, deletes a record
        ///  or when the MainForm is being closed.
        /// </summary>
        public static void SaveData(RecordStack toSave)
        {
            XmlSerializer sr = new XmlSerializer( toSave.GetType());
            StreamWriter writer = new StreamWriter("FormData.xml");
            sr.Serialize(writer,toSave);
            writer.Close();
        }

        /// <summary>
        ///  Save CheckList to .xml file
        ///  This method will be invoked when user opens Checklist window, deletes a checklist
        ///  or when the CheckListForm is being closed.
        /// </summary>
        public static void SaveCheckList(CheckListStack toSave)
        {
            XmlSerializer sr = new XmlSerializer(toSave.GetType());
            StreamWriter writer = new StreamWriter("CheckList.xml");
            sr.Serialize(writer, toSave);
            writer.Close();
        }

        /// <summary>
        ///  Load RecordStack from the .xml file.
        ///  This method will be invoked when the MainForm initially opens.
        /// </summary>
        public static RecordStack LoadData()
        {
            XmlSerializer sr = new XmlSerializer(typeof(RecordStack));
            FileStream read = new FileStream("FormData.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            RecordStack toLoad = (RecordStack)sr.Deserialize(read);
            read.Close();

            return toLoad;
        }

        /// <summary>
        ///  Load CheckListStack from the .xml file.
        ///  This method will be invoked when the CheckListForm initially opens.
        /// </summary>
        public static CheckListStack LoadCheckList()
        {
            XmlSerializer sr = new XmlSerializer(typeof(CheckListStack));
            FileStream read = new FileStream("CheckList.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            CheckListStack toLoad = (CheckListStack)sr.Deserialize(read);
            read.Close();

            return toLoad;
        }
    }
}
