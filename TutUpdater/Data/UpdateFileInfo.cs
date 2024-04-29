using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpdaterGame.Data
{
    [Serializable]
    public class UpdateFileInfo
    {
        public UpdateFileInfo(String name, String desc)
        {
            Name = name;
            Description = desc;
        }

        public String Name { get; set; }
        public String Description { get; set; }
    }
}
