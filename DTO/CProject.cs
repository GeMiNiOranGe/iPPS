using System.Data;

namespace DTO {
        public class CProject {
        public CProject(string strId,  string strName)
        {
            this.Id = strId;
            this.Name = strName;
        }
        public CProject(DataRow row)
        {
            this.Id = row["ID"].ToString();
            this.Name = row["NAME"].ToString();
        }
        public string strId ;
        public string strEmployeeId ;
        public string strProjectManagerId ;
        public string strName ;
        public AccessLevel accessRight ;
        public StatusType status ;
        public string strCustomerName ;

        // Getter and setter methods using lambda expressions
        public string Id {
            get => strId;
            set => strId = value;
        }

        public string EmployeeId {
            get => strEmployeeId;
            set => strEmployeeId = value;
        }

        public string ProjectManagerId {
            get => strProjectManagerId;
            set => strProjectManagerId = value;
        }

        public string Name {
            get => strName;
            set => strName = value;
        }

        public AccessLevel AccessRight {
            get => accessRight;
            set => accessRight = value;
        }

        public StatusType Status {
            get => status;
            set => status = value;
        }

        public string CustomerName {
            get => strCustomerName;
            set => strCustomerName = value;
        }
    }
}
