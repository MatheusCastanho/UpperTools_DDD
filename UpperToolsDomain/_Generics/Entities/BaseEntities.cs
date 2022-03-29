using System.ComponentModel.DataAnnotations;
using UpperToolsDomain.Notifications;

namespace UpperToolsDomain.Entities.Generics
{
    class BaseEntities : Notifies
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
