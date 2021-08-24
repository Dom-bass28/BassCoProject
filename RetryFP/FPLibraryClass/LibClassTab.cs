using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLibraryClass
{
    interface C
    {
        void AddRecord(CustomerInfoTable obj);
    }
    public class FLRepository : C
    {
        BassCoEntities entities;

        public FLRepository()
        {
            entities = new BassCoEntities();
        }
        public void AddRecord(CustomerInfoTable obj)
        {
            entities.CustomerInfoTables.Add(obj);
            entities.SaveChanges();
        }
        public CustomerInfoTable LogIn(decimal MemberID, string password)
        {
            var obj = (from user in entities.CustomerInfoTables
                      where user.Customer_ID == MemberID && user.Customer_Password == password
                      select user).FirstOrDefault();
            if (obj is null)
            {
                return null;
            }
            return obj;
        }
        public decimal getMaxID()
        {
            return entities.CustomerInfoTables.Max(p => p.Customer_ID);
        }
    }
}