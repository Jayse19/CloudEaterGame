namespace API
{
    public interface IToken
    {
        public string Token { get; set; }
        public int EatenPills { get; set; }
    }
    public class StateService : IToken
    {
        public string Token { get; set; }
        public int EatenPills { get; set; }
    }

}
