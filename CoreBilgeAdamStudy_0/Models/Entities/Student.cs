namespace CoreBilgeAdamStudy_0.Models.Entities
{

    //Lazy Loading : Normal şartlarda bir Entity Framework yapısı siz bir class'ı tetiklediginizde onun ilişkide oldugu class'ları cagırmaz...Sadece ve sadece siz o tetiklediginiz class instance'inden ilişkide baska instance'lara ulasmak istediginizde Lazy Loading sayesinde bir sorgu atılır. Bu performans kazandırır...

    //.Net Core'da Framework'den farklı olarak sadece virtual yazmak Lazy Loading'i tetiklemeye yetmez. EntityFrameworkCore.Proxies kütüphanesinin de indirilip Middleware'de Lazy Loading'in kullanılacagının bildirilmesi gerekir... (Middleware tarafındaki UseLazyLoadingProxies() metodu bu sistemin eklenmesi icin bir ifadedir)

  
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ConsultantID { get; set; }


        //Relational Properties
        public virtual Consultant Consultant { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
