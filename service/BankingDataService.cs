using banking_system.models;
using banking_system.persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system.service
{
    public class BankingDataService
    {
        public BankingDataService() { }

        public int SaveBankingData(BankingData bankingData)
        {
            Console.WriteLine(String.Format("INFO: Saving the following BankingData={0}", bankingData.ToString()));
            int success = BankingDataRepository.SaveBankingData(bankingData);
            Console.WriteLine("BankingData was successfully saved.");

            return success;
        }

        public BankingData GetBankingDataByCardOwnerCardNumberUserId(BankingData bankingData)
        {
            Console.WriteLine(String.Format("INFO: Trying to retrieve BankingData for user with id={0}.", bankingData.UserId));
            DataTable dt = BankingDataRepository.GetBankingDataByCardNumberCardOwnerUserId(bankingData);
            foreach (DataRow dr in dt.Rows)
            {
                int bankingDataId = Int32.Parse(dr["banking_data_id"].ToString());
                bankingData.BankingDataId = bankingDataId;
            }

            Console.WriteLine(String.Format("INFO: BankingData for user with id={0} was successfully retrieved.", bankingData.UserId));
            return bankingData;
            
        }
    }
}
