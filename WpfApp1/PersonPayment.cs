
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
    
public partial class PersonPayment
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PersonPayment()
    {

        this.SysPaym = new HashSet<SysPaym>();

    }


    public int Id { get; set; }

    public int PersonId { get; set; }

    public System.DateTime Date { get; set; }

    public decimal Total { get; set; }

    public int RateId { get; set; }



    public virtual Person Person { get; set; }

    public virtual Rate Rate { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<SysPaym> SysPaym { get; set; }

}

}
