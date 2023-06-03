namespace DTO {
    public class CEmployeePhoneNumber {
        // Declare the properties as private fields
        private string strId;
        private string strPhoneNumber;

        // Define public properties to get and set the private fields using lambda expressions
        public string Id {
            get => strId;
            set => strId = value;
        }

        public string PhoneNumber {
            get => strPhoneNumber;
            set => strPhoneNumber = value;
        }
    }
}
