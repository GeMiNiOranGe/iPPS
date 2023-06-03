namespace DTO {
    public class CAccount {
        public string strId;
        public string strEmployeeId;
        public string strPassword;
        public bool isActive;

        // Getter and setter methods using lambda expressions
        public string Id {
            get => strId;
            set => strId = value;
        }

        public string EmployeeId {
            get => strEmployeeId;
            set => strEmployeeId = value;
        }

        public string Password {
            get => strPassword;
            set => strPassword = value;
        }

        public bool IsActive {
            get => isActive;
            set => isActive = value;
        }
    }

}
