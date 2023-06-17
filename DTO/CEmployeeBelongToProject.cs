using System.Data;

namespace DTO {
    public class CEmployeeBelongToProject {
        public CEmployeeBelongToProject(string strEmployeeId, string strProjectId)
        {
            this.EmployeeId = strEmployeeId;
            this.ProjectId = strProjectId;
        }
        public CEmployeeBelongToProject(DataRow row)
        {
            this.EmployeeId = row["EMPLOYEE_ID"].ToString();
            this.ProjectId = row["PROJECT_ID"].ToString();
        }
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
