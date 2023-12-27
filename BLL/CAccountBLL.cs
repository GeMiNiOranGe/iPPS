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

        public const string USER_ID_PLACEHOLDER = "ID người dùng";
        public const string PASSWORD_PLACEHOLDER = "Mật khẩu";

        //change from 'query directly for value' to 'query for returned value. then, compare with current value'
        public LoginStatus GetLoginStatus(DTO.CAccount account) {
            //// Check account existence
            //bool bExist = DAL.CAccountDAL.Instance.IsAccountExist(account);
            //// Check active account
            //bool bActive = DAL.CAccountDAL.Instance.IsActive(account);

            //if (account.EmployeeId == USER_ID_PLACEHOLDER && account.Password == PASSWORD_PLACEHOLDER)
            //    return LoginStatus.InvalidInput;
            //if (bExist)
            //    return bActive ? LoginStatus.Success : LoginStatus.LockedAccount;
            //if (!bExist)
            //    return LoginStatus.InvalidAccount;
            //return LoginStatus.OtherError;

            var newAccount = DAL.CAccountDAL.Instance.GetAccount(account);

            bool IsExist = newAccount.EmployeeId == account.EmployeeId && newAccount.Password == account.Password;
            
            if (newAccount.EmployeeId == USER_ID_PLACEHOLDER && newAccount.Password == PASSWORD_PLACEHOLDER)
                return LoginStatus.InvalidInput;
            if (IsExist)
                return newAccount.IsActive ? LoginStatus.Success : LoginStatus.LockedAccount;
            if (!IsExist)
                return LoginStatus.InvalidAccount;
            return LoginStatus.OtherError;
        }
    }
}
