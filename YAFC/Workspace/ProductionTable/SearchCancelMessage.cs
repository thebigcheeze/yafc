namespace YAFC
{
    internal class SearchCancelMessage
    {
        public SearchCancelMessage(string reason)
        {
            Reason = reason;
        }

        public string Reason { get; }
    }
}