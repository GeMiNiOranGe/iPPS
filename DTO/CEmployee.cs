namespace DTO {
    public class CEmployee {
        // Declare the properties as private fields
        private string strId;
        private string strDepartmentId;
        private string strFirstName;
        private string strMiddleName;
        private string strLastName;
        private bool bSex; // true is male, false is female
        private System.DateTime dtDateOfBirth;
        private string strCitizenIdNumber;
        private EmployeeType type;

        // Define public properties to get and set the private fields using lambda expressions
        public string Id {
            get => strId;
            set => strId = value;
        }

        public string DepartmentId {
            get => strDepartmentId;
            set => strDepartmentId = value;
        }

        public string FirstName {
            get => strFirstName;
            set => strFirstName = value;
        }

        public string MiddleName {
            get => strMiddleName;
            set => strMiddleName = value;
        }

        public string LastName {
            get => strLastName;
            set => strLastName = value;
        }

        public bool Sex {
            get => bSex;
            set => bSex = value;
        }

        public System.DateTime DateOfBirth {
            get => dtDateOfBirth;
            set => dtDateOfBirth = value;
        }

        public string CitizenIdNumber {
            get => strCitizenIdNumber;
            set => strCitizenIdNumber = value;
        }

        public EmployeeType Type {
            get => type;
            set => type = value;
        }
    }
}
