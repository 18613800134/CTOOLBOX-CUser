
namespace CUser.Business.DBContext
{
    using System.Data.Entity;
    using CAM.Common.Data;
    using CUser.Model.Entity;

    public class DBContextCUser : BaseDBContext<DBContextCUser>
    {
        public IDbSet<CUserInfo> CUserInfo { get; set; }
    }
}
