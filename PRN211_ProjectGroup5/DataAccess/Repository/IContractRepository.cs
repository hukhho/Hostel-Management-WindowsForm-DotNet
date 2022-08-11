using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IContractRepository
    {
        IEnumerable<Contract> GetContracts();
        Contract GetContractByID(int contractID);
        void InsertContract(Contract Contract);
        void DeleteContract(int ContractID);
        void UpdateContract(Contract contract);
    }
}
