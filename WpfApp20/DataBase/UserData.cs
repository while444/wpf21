//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp20.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserData
    {
        public int id { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Birthdate { get; set; }
    
        public virtual Role Role { get; set; }
        public virtual Status Status { get; set; }
    }
}
