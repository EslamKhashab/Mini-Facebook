namespace MiniFacebook.Shared.GlobalResponse
{
    public class GenericGlobalResponse<T> : GlobalResponse
    {
        public new T Data { get; set; }
    }
}
