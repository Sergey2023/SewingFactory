//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SewingFactory.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class StorageAccessories
    {
        public int Id { get; set; }
        public int IdAccessories { get; set; }
        public int Quantity { get; set; }
    
        public virtual Accessories Accessories { get; set; }
    }
}
