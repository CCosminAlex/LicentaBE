namespace Licenta.Entity.DTO
{
    public class UserDTO
    {
        public Guid? ID { get; set; }

        public string Sub_ID { get; set; }

        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public bool IsCompany { get; set; }

        public int Score { get; set; }

       
    }
}
