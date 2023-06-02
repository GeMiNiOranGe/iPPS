namespace DTO {
    public class CRole {
        public string strId;
        public string strEmployeeId;
        public string strName;
        public AccessLevel permissionLevel;

        // Getter and setter methods using lambda expressions
        public string Id {
            get => strId;
            set => strId = value;
        }

        public string EmployeeId {
            get => strEmployeeId;
            set => strEmployeeId = value;
        }

        public string Name {
            get => strName;
            set => strName = value;
        }

        public AccessLevel PermissionLevel {
            get => permissionLevel;
            set => permissionLevel = value;
        }
    }

}
