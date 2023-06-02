namespace DTO {
    // A class to represent a project implemented by a department
    public class CImplementProject {
        // Attributes of the class
        private string strDepartmentId; 
        private string strProjectId;
        private System.DateTime dtProjectStartDate; 
        private System.DateTime dtProjectEndDate; 

        // Getters and setters for the attributes using lambda expressions
        public string DepartmentId {
            get => strDepartmentId; 
            set => strDepartmentId = value;
        }
        public string ProjectId {
            get => strProjectId;
            set => strProjectId = value; 
        }
        public System.DateTime ProjectStartDate {
            get => dtProjectStartDate; 
            set => dtProjectStartDate = value; 
        }
        public System.DateTime ProjectEndDate { 
            get => dtProjectEndDate;
            set => dtProjectEndDate = value;
        }
    }
}
