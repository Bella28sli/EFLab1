//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFLab1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff_Choice
    {
        public int Id_Staff_Choice { get; set; }
        public Nullable<int> Clients_ID { get; set; }
        public Nullable<int> Employee_ID { get; set; }
    
        public virtual Clients Clients { private get; set; }
        public virtual Staff Staff { private get; set; }
    }
}