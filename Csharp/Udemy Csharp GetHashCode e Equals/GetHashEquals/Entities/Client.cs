namespace Udemy_Csharp_GetHashCode_e_Equals.Entities
{
    public class Client
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

        public override bool Equals(object? obj)
        {
            if (!(obj is Client))
            return false;

            Client other = obj as Client;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}