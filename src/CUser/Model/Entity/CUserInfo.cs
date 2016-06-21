
namespace CUser.Model.Entity
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    using CAM.Core.Model.Entity;
    using CAM.General.ComplexStruct;

    public class CUserInfo : BaseEntityNormal
    {
        [Index(IsClustered = false, IsUnique = false)]
        public long PassportId { get; set; }

        public UserNameStruct NameStruct { get; set; }

    }
}
