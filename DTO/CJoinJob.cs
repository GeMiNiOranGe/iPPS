namespace DTO {
    public class CJoinJob {
        // Private data members
        public string strEmployeeId;
        public string strJobId;
        public System.DateTime dtJobStartDate;
        public System.DateTime dtJobEndDate;

        // Getter and setter methods using lambda expressions
        public string EmployeeId {
            get => strEmployeeId;
            set => strEmployeeId = value;
        }

        public string JobId {
            get => strJobId;
            set => strJobId = value;
        }
        
        public System.DateTime JobStartDate {
            get => dtJobStartDate;
            set => dtJobStartDate = value;
        }

        public System.DateTime JobEndDate {
            get => dtJobEndDate;
            set => dtJobEndDate = value;
        }
    }
}
