using System.Data;
using System;

namespace DTO {
    public class CEmployee {
        public CEmployee(string strId, string strDepartmentId, string strFirstName, string strMiddleName, string strLastName, bool bSex, DateTime dtDateOfBirth, string strCitizenIdNumber)
        {
            this.Id = strId;
            this.DepartmentId = strDepartmentId;
            this.FirstName = strFirstName;
            this.MiddleName = strMiddleName;
            this.LastName = strLastName;
            this.Sex = bSex;
            this.DateOfBirth = dtDateOfBirth;
            this.CitizenIdNumber = strCitizenIdNumber;
        }
        public CEmployee(DataRow row)
        {
            this.Id = row["ID"].ToString();
            this.DepartmentId = row["DEPARTMENT_ID"].ToString();
            this.FirstName = row["FIRST_NAME"].ToString();
            this.MiddleName = row["MIDDLE_NAME"].ToString();
            this.LastName = row["LAST_NAME"].ToString();
            this.Sex = Convert.ToBoolean(row["SEX"]);
            this.DateOfBirth = Convert.ToDateTime(row["DATE_OF_BIRTH"]);
            this.CitizenIdNumber = row["CITIZEN_ID_NUMBER"].ToString();
        }
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
