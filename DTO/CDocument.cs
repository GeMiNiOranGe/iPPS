namespace DTO {
    public class CDocument {
        // Attributes
        public string strId;
        public string strJobId;
        public string strTitle;
        public int iRevisionNumber;
        public int iLastestRevision;
        public string strPackage;
        public string type;
        public string strWorkItem;
        public string strPartnerCode;
        public string strPartnerName;
        public System.DateTime dtDate;
        public string strIssuePurpose;
        public string strPreparedBy;
        public string strCheckedBy;
        public string strApprovedBy;
        public string strAction;
        public string strSupport;
        public string strReference;
        public string strTo;
        public System.DateTime dtIssuedOn;
        public string strIssuedVia;

        // Get and set methods defined using lambda expressions
        public string Id { 
            get => strId; 
            set => strId = value;
        }

        public string JobId { 
            get => strJobId; 
            set => strJobId = value; 
        }

        public string Title { 
            get => strTitle; 
            set => strTitle = value;
        }

        public int RevisionNumber {
            get => iRevisionNumber;
            set => iRevisionNumber = value;
        }

        public int LastestRevision { 
            get => iLastestRevision; 
            set => iLastestRevision = value; 
        }

        public string Package {
            get => strPackage; 
            set => strPackage = value; 
        }

        public string Type {
            get => type; 
            set => type = value;
        }

        public string WorkItem { 
            get => strWorkItem; 
            set => strWorkItem = value; 
        }

        public string PartnerCode {
            get => strPartnerCode;
            set => strPartnerCode = value; 
        }

        public string PartnerName {
            get => strPartnerName; 
            set => strPartnerName = value; 
        }

        public System.DateTime Date { 
            get => dtDate;
            set => dtDate = value;
        }

        public string IssuePurpose {
            get => strIssuePurpose;
            set => strIssuePurpose = value;
        }

        public string PreparedBy { 
            get => strPreparedBy; 
            set => strPreparedBy = value; 
        }

        public string CheckedBy {
            get => strCheckedBy;
            set => strCheckedBy = value;
        }

        public string ApprovedBy {
            get => strApprovedBy;
            set => strApprovedBy = value;
        }

        public string Action {
            get => strAction;
            set => strAction = value;
        }

        public string Support {
            get => strSupport;
            set => strSupport = value;
        }

        public string Reference {
            get => strReference;
            set => strReference = value;
        }

        public string To {
            get => strTo;
            set => strTo = value;
        }

        public System.DateTime IssuedOn {
            get => dtIssuedOn;
            set => dtIssuedOn = value;
        }

        public string IssuedVia {
            get => strIssuedVia;
            set => strIssuedVia = value;
        }
    }
}
