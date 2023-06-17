using System.Data;
using System;

namespace DTO {
    public class CRole {
        public CRole(string strId, string strEmployeeId, string strName)
        {
            this.Id = strId;
            this.EmployeeId = strEmployeeId;
            this.Name = strName;
        }
        public CRole(DataRow row)
        {
            this.Id = row["ID"].ToString();
            this.EmployeeId = row["EMPLOYEE_ID"].ToString();
            this.Name = row["NAME"].ToString();
        }
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
