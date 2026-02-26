namespace Exercicios.Entities
{
    public class LogRecord
    {
        public required string UserName { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogRecord))
            return false;

            LogRecord other = (LogRecord)obj;
            return UserName.Equals(other.UserName);
        }
    }
}