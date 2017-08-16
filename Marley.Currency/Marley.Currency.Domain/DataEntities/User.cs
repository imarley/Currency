using System;

namespace Marley.Currency.Domain.DataEntities
{
    public class User
    {
        public long Id { get; set; }
        public int ProfileId { get; set; }
        public string Name { get; set; }
        public long? Cpf { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public DateTime RegistrationDate{ get; set; }
        public virtual Profile Profile { get; set; }
    }
}