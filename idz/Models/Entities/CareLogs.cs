//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace idz.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class CareLogs
    {
        public System.Guid CareLog_ID { get; set; }
        public System.DateTime Time { get; set; }
        public System.Guid Pet_ID { get; set; }
        public System.Guid Employee_ID { get; set; }
        public System.Guid CareType_ID { get; set; }
    
        public virtual CareTypes CareTypes { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Pets Pets { get; set; }
    }
}
