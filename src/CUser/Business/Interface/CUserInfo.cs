
namespace CUser.Business.Interface
{
    using System;
    using System.Linq;
    using CAM.Core.Business.Interface;
    using Model.Entity;
    using DBContext;

    public interface ICUserInfoCommand : IBaseInterfaceCommand<DBContextCUser>
    {
        long addUserInfo(long PassportId, string Name);
        void updateUserInfoName(long Id, string Name);

        CUserInfo readUserInfo(long Id);
        CUserInfo readUserInfoByPassport(long PassportId);
    }
}
