namespace DTO {
    public class CEmployeeBelongToProject {
        // Attributes of the class
        private string strEmployeeId; 
        private string strProjectId;

        // Getters and setters for the attributes using lambda expressions
        public string EmployeeId { 
            get => strEmployeeId; 
            set => strEmployeeId = value; 
        }

        public string ProjectId {
            get => strProjectId; 
            set => strProjectId = value;
        }
    }
}
