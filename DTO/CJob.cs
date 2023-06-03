namespace DTO {
    class CJob {
        // Attributes of the class
        private string strId; 
        private string strEmployeeId;
        private string strProjectId; 
        private string strJobManagerId; 
        private string strName; 
        private AccessLevel accessRight; 
        private StatusType status; 
        private bool isPublicProject; 
        private bool isPublicDepartment;

        // Getters and setters for the attributes using lambda expressions
        public string Id {
            get => strId;
            set => strId = value;
        }

        public string EmployeeId { 
            get => strEmployeeId; 
            set => strEmployeeId = value;
        }

        public string ProjectId { 
            get => strProjectId; 
            set => strProjectId = value;
        }
        public string JobManagerId { 
            get => strJobManagerId; 
            set => strJobManagerId = value;
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

        public bool IsPublicProject {
            get => isPublicProject; 
            set => isPublicProject = value;
        }

        public bool IsPublicDepartment {
            get => isPublicDepartment;
            set => isPublicDepartment = value;
        }
    }
}
