
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WpfApp1
{

using System;
    using System.Collections.Generic;
    
public partial class Client
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Client()
    {

        this.Order = new HashSet<Order>();

    }


    public int Id { get; set; }

    public string Login { get; set; }

    public string Password { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string MiddleName { get; set; }

    public Nullable<System.DateTime> BirthDay { get; set; }

    public Nullable<double> Phone { get; set; }

    public string Email { get; set; }

    public decimal Balance { get; set; }

    public string Role { get; set; }

    public string Photo { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Order> Order { get; set; }

}

}
