using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    static class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            Console.WriteLine(player.Name);
            //int days= player.DaysSinceLastLogin.GetValueOrDefault(-1);
            //int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;
            //int days = player.DaysSinceLastLogin ?? -1;
            
           // Console.WriteLine($"{days} since last login");
            //if(player.DaysSinceLastLogin==null)
            //if(!player.DaysSinceLastLogin.HasValue)
            //if (player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin);
            //}
            //else
            //{
            //    Console.WriteLine("No value for Days Since Last Login");
            //}
               
            
            if (player.dob==null)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(player.dob);
            }
            if(player.IsNew is null)
            {
                Console.WriteLine("Player new status is unknown");
            }
            else if(player.IsNew==true)
            {
                Console.WriteLine("Player is new to the game");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
        }


    }
}
