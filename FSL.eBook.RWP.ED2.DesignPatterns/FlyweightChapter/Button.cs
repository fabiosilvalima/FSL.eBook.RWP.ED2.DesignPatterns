namespace FSL.eBook.RWP.ED2.DesignPatterns.FlyweightChapter
{
    public sealed class Button : 
        Control
    {
        public Button()
        {
            Tag = Tags.Button;
        }

        public override string Create(string text)
        {
            return $"<input type='button' value='{text}' /> => {text}";
        }
    }
}