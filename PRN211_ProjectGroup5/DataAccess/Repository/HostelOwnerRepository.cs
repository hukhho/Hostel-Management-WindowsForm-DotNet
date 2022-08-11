using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class HostelOwnerRepository : IHostelOwnerRepository
    {

        public HostelOwner GetHostelOwnerByUsernameAndPassword(string username, string password) => AdminDAO.Instance.GetHostelOwnerByUsernameAndPassword(username, password);
        
      
    }
}
