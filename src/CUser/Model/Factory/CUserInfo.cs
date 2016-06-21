
namespace CUser.Model.Factory
{
    using CAM.Core.Model.Entity;
    using CAM.General.ComplexStruct;
    using Entity;
    using System;

    public class CUserBasicInformationFactory
    {
        public static CUserInfo createUserInfo()
        {
            CUserInfo userInfo = EntityBuilder.build<CUserInfo>();
            userInfo.PassportId = 0;
            userInfo.NameStruct = new UserNameStruct();
            return userInfo;
        }
    }
}
