using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class CAccountDAL {
        #region Singleton Design Pattern
        private static CAccountDAL instance;

        public static CAccountDAL Instance {
            get => instance ?? (instance = new CAccountDAL());
            private set => instance = value;
        }

        private CAccountDAL() { }
        #endregion

        //public bool Login(string userId, string password) {

        //}
    }
}
