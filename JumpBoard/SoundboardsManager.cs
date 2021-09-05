using System.Collections.Generic;

namespace JumpBoard
{
    class SoundboardsManager
    {
        private static SoundboardsManager instance;
        public List<Soundboard> Soundboards { get; set; }


        private SoundboardsManager()
        {
            Soundboards = new();
        }

        public static SoundboardsManager GetInstance()
        {
            if (instance == null)
            {
                instance = new SoundboardsManager();
            }

            return instance;
        }
    }
}
