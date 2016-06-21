
namespace CUser.Business.Aggregate
{
    using CAM.Core.Business.Interface;
    using CAM.Core.Business.Aggregate;
    using DBContext;

    public partial class Aggregate : BaseAggregate, IBaseInterfaceCommand<DBContextCUser>
    {
        public Aggregate()
        {
            this.dbContext = new DBContextCUser();
        }

        public DBContextCUser DBContext
        {
            get { return (DBContextCUser)this.dbContext; }
        }
    }
}
