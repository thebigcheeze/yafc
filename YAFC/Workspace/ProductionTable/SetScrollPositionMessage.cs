namespace YAFC
{
    internal class SetScrollPositionMessage
    {
        
        public SetScrollPositionMessage(float top)
        {
            Top = top;
        }

        public float Top { get; }
    }
}