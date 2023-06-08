using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
    public enum LoginStatus {
        Success = 0,
        InvalidInput = 1,
        InvalidAccount = 2,
        LockedAccount = 3,
        OtherError = 4
    }

    public class CAccountBLL {
        #region Singleton Design Pattern
        private static CAccountBLL instance;

        public static CAccountBLL Instance {
            get => instance ?? (instance = new CAccountBLL());
            private set => instance = value;
        }

        private CAccountBLL() { }
        #endregion

        public LoginStatus GetLoginStatus(DTO.CAccount account) {
            //if (string.IsNullOrWhiteSpace(account.EmployeeId)) {

            //}
            //if (1 <= account.EmployeeId.Length && account.EmployeeId.Length <= 8) {

            //}

            //if (DAL.CAccountDAL.Instance.CheckAccount(account)) {
            //    return DAL.CAccountDAL.Instance.IsActive(account);
            //}
            //else {
            //    return false;
            //}

            // Check account existence
            bool bExist = DAL.CAccountDAL.Instance.IsAccountExist(account);
            // Check active account
            bool bActive = DAL.CAccountDAL.Instance.IsActive(account);

            if (string.IsNullOrEmpty(account.EmployeeId) || string.IsNullOrEmpty(account.Password)) {
                return LoginStatus.InvalidInput;
            }
            else if (bExist) {
                return bActive ? LoginStatus.Success : LoginStatus.LockedAccount;
            }
            else if (!bExist) {
                return LoginStatus.InvalidAccount;
            }
            else {
                return LoginStatus.OtherError;
            }
        }
    }
}
