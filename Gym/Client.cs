using System;
namespace Gym
{
    public class Client : IHumanInterface
    {
        string Name;
        uint Approach;

        public Client(string name, uint approach)
        {
            Name = name;
            Approach = approach;
        }

        public string GetName()
        {
            return Name;
        }

        public uint GetApproach()
        {
            return Approach;
        }

        public void WillTrain()
        {
            if (Approach != 0)
            {
                Approach--;
            }
        }
    }
}
