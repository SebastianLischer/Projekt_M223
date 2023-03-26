namespace VotingWPF.Classes
{
    public class VoteElement : User
    {
        public int VoteElementID { get; set; }
        public string Text { get; set; }
        
        public VoteElement(string text)
        {
            this.Text = text;//Vote option
        }

        public VoteElement()
        {
        }
    }
}