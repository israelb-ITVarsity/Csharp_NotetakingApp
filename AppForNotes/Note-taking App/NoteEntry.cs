namespace NoteTakingApp.Data
{

    public class NoteEntry
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public byte[] ImageData { get; set; }//to add a field for image path
    }
}