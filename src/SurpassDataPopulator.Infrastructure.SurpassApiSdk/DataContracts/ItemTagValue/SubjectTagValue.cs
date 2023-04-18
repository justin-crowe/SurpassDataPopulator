namespace SurpassApiSdk.DataContracts.ItemTagValue
{
    public class SubjectTagValue
    {
        public string Text { get; set; }

        public long Id { get; set; }

        public bool Deleted { get; set; }

        public SubjectTagGroup TagGroup { get; set; }
    }
}
