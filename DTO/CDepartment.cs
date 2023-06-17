using System.Data;

namespace DTO {
        public class CDepartment {
        public CDepartment(string strId, string strName)
        {
            this.Id = strId;
            this.Name = strName;
        }
        public CDepartment(DataRow row)
        {
            this.Id = row["ID"].ToString();
            this.Name = row["NAME"].ToString();
        }
        // Private data members
        private string strId; 
        private string strName; 
        private AccessLevel accessRight; 

        // Define public properties to get and set the private fields using lambda expressions
        public string Id {
            get => strId;
            set => strId = value;
        }

        public string Name { 
            get => strName;
            set => strName = value;
        }

        public AccessLevel AccessRight { 
            get => accessRight;
            set => accessRight = value;
        }
    }
}
