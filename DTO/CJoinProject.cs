namespace DTO {
    public class CJoinProject {
        public string strProjectId;
        public string strPartnerId;

        // Getter and setter methods using lambda expressions
        public string ProjectId {
            get => strProjectId;
            set => strProjectId = value;
        }

        public string PartnerId {
            get => strPartnerId;
            set => strPartnerId = value;
        }
    }

}
