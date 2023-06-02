using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class CPartner {
        // Attributes of the class
        private string strId; 
        private string strName; 
        private string strCode; 
        private string strFunctional; 
        private string strFullnameERC;
        private string strAddress; 
        private string strTaxCode; 
        private string strLegalRepresentative; 
        private string strTitleOfLegalRepresentative;

        // Getters and setters for the attributes using lambda expressions
        public string StrId { 
            get => strId;
            set => strId = value;
        }

        public string StrName { 
            get => strName; 
            set => strName = value; 
        }

        public string StrCode {
            get => strCode;
            set => strCode = value;
        }

        public string StrFunctional {
            get => strFunctional; 
            set => strFunctional = value;
        }

        public string StrFullnameERC { 
            get => strFullnameERC; 
            set => strFullnameERC = value;
        }

        public string StrAddress { 
            get => strAddress;
            set => strAddress = value;
        }

        public string StrTaxCode { 
            get => strTaxCode; 
            set => strTaxCode = value; 
        }

        public string StrLegalRepresentative {
            get => strLegalRepresentative;
            set => strLegalRepresentative = value;
        }

        public string StrTitleOfLegalRepresentative { 
            get => strTitleOfLegalRepresentative; 
            set => strTitleOfLegalRepresentative = value; 
        }
    }

}
