using System.Data;

namespace DTO {
    public class CEmployeePhoneNumber {
        public CEmployeePhoneNumber(string strId, string strEmployeeId, string strPhoneNumber)
        {
            this.Id = strId;
            this.EmployeeId = strEmployeeId;
            this.PhoneNumber = strPhoneNumber;
        }
        public CEmployeePhoneNumber(DataRow row)
        {
            this.Id = row["ID"].ToString();
            this.EmployeeId = row["EMPLOYEE_ID"].ToString();
            this.PhoneNumber = row["PHONE_NUMBER"].ToString();
        }
        // Declare the properties as private fields
        private string strId;
        public string strEmployeeId;
        private string strPhoneNumber;

        // Define public properties to get and set the private fields using lambda expressions
        public string Id {
            get => strId;
            set => strId = value;
        }

        public string EmployeeId
        {
            get => strEmployeeId;
            set => strEmployeeId = value;
        }

        public string PhoneNumber {
            get => strPhoneNumber;
            set => strPhoneNumber = value;
        }
    }
}
