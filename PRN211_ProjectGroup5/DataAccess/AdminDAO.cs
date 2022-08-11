using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;


namespace DataAccess
{
    public class AdminDAO
    {
        private static AdminDAO instance = null;

        private static readonly object instanceLock = new object();

        public static AdminDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AdminDAO();
                    }
                    return instance;
                }
            }
        }

     

        public HostelOwner GetHostelOwnerByUsernameAndPassword(string username, string password)
        {
            HostelOwner hostelOwner = null;
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                hostelOwner = context.HostelOwners.SingleOrDefault(m => m.Username == username & m.Password == password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return hostelOwner;
        }


       
    }
}
