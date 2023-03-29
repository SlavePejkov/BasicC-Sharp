namespace Class08_Library
{
    public class Song
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public EnumClass Genre { get; set; }

        public Song(string title, int lenght, EnumClass genre)
        {
            Title = title;
            Length = lenght;
            Genre = genre;
        }
    }
}
