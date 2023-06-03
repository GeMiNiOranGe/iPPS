namespace DTO {
    class CDepartment {
        // Private data members
        private string strId; 
        private string strName; 
        private AccessLevel accessRight; 

        // Define public properties to get and set the private fields using lambda expressions
        public string Id {
            get => strId;
            set => strId = value;
        }

        public string Name { 
            get => strName;
            set => strName = value;
        }

        public AccessLevel AccessRight { 
            get => accessRight;
            set => accessRight = value;
        }
    }
}
