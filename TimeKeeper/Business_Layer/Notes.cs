using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Business_Layer
{
    class Notes
    {
        private int notesID;
        private string fileName, fileLocation, noteType;

        public int NotesID
        {
            get { return notesID; }
            set { notesID = value; }
        }

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public string FileLocation
        {
            get { return fileLocation; }
            set { fileLocation = value; }
        }
        public string NoteType
        {
            get { return noteType; }
            set { noteType = value; }
        }

        public Notes() { }

        public Notes(int noteID, string fileName, string fileLocation, string noteType)
        {
            NotesID = noteID;
            FileName = FileName;
            FileLocation = fileLocation;
            NoteType = noteType;
            
        }

    }
}
