using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace ga_z
{
    [Serializable]
    class Storage
    {
        private FileInfo file;
        private ArrayList list;

        public Storage()
        {
            list = new ArrayList();
        }
        public void setFileLocation(String path)
        {
            file = new FileInfo(path);
            list.Add(file);
        }
        public void deleteFile(int index)
        {
            list.RemoveAt(index);
        }
        public ArrayList getStorage()
        {
            return list;
        }
    }
}
