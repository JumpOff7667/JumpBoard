namespace JumpBoard
{
    class Soundboard
    {
        public string Name { get; set; }
        public string Dir { get; set; }

        public Soundboard(string name, string dir)
        {
            Name = name;
            Dir = dir;
        }
    }
}
