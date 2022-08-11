using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ContractDAO
    {
        private static ContractDAO instance = null;

        private static readonly object instanceLock = new object();

        public static ContractDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ContractDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Contract> GetContractList()
        {
            var Contracts = new List<Contract>();
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                Contracts = context.Contracts
                                .Include(d => d.Customer)
                                .Include(e => e.Room).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Contracts;
        }


        public Contract GetContractByID(int ContractID)
        {
            Contract Contract = null;
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                Contract = context.Contracts
                    .Include(d => d.Customer)
                    .Include(e => e.Room)
                    .SingleOrDefault(m => m.ContractId == ContractID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Contract;
        }


        public void AddNew(Contract Contract)
        {
            try
            {
                Contract _Contract = GetContractByID(Contract.ContractId);
                if (_Contract == null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Contracts.Add(Contract);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Contract is already exist!!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Contract Contract)
        {
            try
            {
                Contract _Contract = GetContractByID(Contract.ContractId);
                if (Contract != null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Contracts.Update(Contract);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Contract does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Remove(int ContractID)
        {
            try
            {
                Contract Contract = GetContractByID(ContractID);
                if (Contract != null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Contracts.Remove(Contract);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Contract does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
