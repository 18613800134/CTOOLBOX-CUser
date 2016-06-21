
namespace CUser.Business.Aggregate
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Data.Entity.SqlServer;
    using System.Collections.Generic;

    using Model.Entity;
    using Model.Factory;
    //using Model.Filter;

    using CAM.Core.Business.Interface;
    using CAM.Core.Business.Aggregate;

    using Interface;
    //using Rule;

    using CAM.Common.Data;
    using CAM.Common.Convert;


    public partial class Aggregate : ICUserInfoCommand
    {

        public long addUserInfo(long PassportId, string Name)
        {
            try
            {
                IRepository<CUserInfo> res = createRepository<CUserInfo>();
                CUserInfo dbObj = CUserBasicInformationFactory.createUserInfo();

                dbObj.PassportId = PassportId;
                dbObj.NameStruct.Name = Name;

                dbObj.validate();
                res.add(dbObj);
                commit();

                return dbObj.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateUserInfoName(long Id, string Name)
        {
            try
            {
                IRepository<CUserInfo> res = createRepository<CUserInfo>();
                CUserInfo dbObj = res.read(m => m.Id == Id);

                dbObj.NameStruct.Name = Name;

                dbObj.validate();
                res.update(dbObj);
                commit();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CUserInfo readUserInfo(long Id)
        {
            IRepository<CUserInfo> res = createRepository<CUserInfo>();
            return res.read(m => m.Id == Id);
        }


        public CUserInfo readUserInfoByPassport(long PassportId)
        {
            IRepository<CUserInfo> res = createRepository<CUserInfo>();
            return res.read(m => m.PassportId == PassportId);
        }
    }
}
