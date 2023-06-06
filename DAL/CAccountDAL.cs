using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class CAccountDAL {
        private static CAccountDAL instance;

        public static CAccountDAL Instance {
            get {
                if (instance == null) {
                    instance = new CAccountDAL();
                };
                return instance;
            }
            private set => instance = value;
        }

        private CAccountDAL() { }

        //public bool Login(string userId, string password) {

        //}
    }
}
