using System;
using System.Collections.Generic;

namespace Gym
{
    public class Gym
    {
        List<IHumanInterface> collection;

        public Gym()
        {
            collection = new List<IHumanInterface>();
        }

        public Gym Add(IHumanInterface human)
        {
            collection.Add(human);

            return this;
        }

        public void Train()
        {
            if (collection.Count != 0)
            {
                foreach (IHumanInterface human in collection)
                {
                    human.WillTrain();

                    if (human.GetApproach() == 0)
                    { 
                        Console.WriteLine("{0}: finished", human.GetName());
                    }
                    else
                    {
                        Console.WriteLine("{0}: {1} too long...", human.GetName(), human.GetApproach());
                    }
                }

                collection.RemoveAll(human => human.GetApproach() == 0);
            }
            else
            {
                Console.WriteLine("Gym is empty");
            }
        }
    }
}
