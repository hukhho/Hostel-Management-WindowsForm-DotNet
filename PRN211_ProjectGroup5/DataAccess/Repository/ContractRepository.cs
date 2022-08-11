using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class ContractRepository : IContractRepository
    {
        public IEnumerable<Contract> GetContracts() => ContractDAO.Instance.GetContractList();
        public Contract GetContractByID(int ContractID) => ContractDAO.Instance.GetContractByID(ContractID);
        public void InsertContract(Contract Contract) => ContractDAO.Instance.AddNew(Contract);
        public void DeleteContract(int ContractID) => ContractDAO.Instance.Remove(ContractID);
        public void UpdateContract(Contract Contract) => ContractDAO.Instance.Update(Contract);

      
    }
}
