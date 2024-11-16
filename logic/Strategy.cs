using System.Diagnostics;
using PlayerDotNet.models;

namespace PlayerDotNet.logic
{
    public abstract class Strategy
    {
        public static PlayerAction Decide(GameState? gameState)
        {
            Debug.WriteLine("GOT POST");
            //TODO: Add your logic here!
            if(gameState != null)
                Console.WriteLine(gameState.Bases.ToString());
            else
                Console.WriteLine("Nothing recieved");

            return new PlayerAction(1,1,1);
        }
    }
}
