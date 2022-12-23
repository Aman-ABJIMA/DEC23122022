using System;
namespace ConsoleGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            PlayerCharacter aman = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Aman"
            };
            //PlayerCharacter abhi = new PlayerCharacter(new IronBonesDefece())
            //{
            //    Name = "Abhi"
            //};
            PlayerCharacter kuldeep = new PlayerCharacter(null)
            {
                Name = "Kuldeep"
            };
            aman.Hit(10);
            //abhi.Hit(10);
            kuldeep.Hit(10);



            // var player = new PlayerCharacter();
            //PlayerCharacter[] players = new PlayerCharacter[3]
            //{
            //    new PlayerCharacter {Name = "Aman"},
            //    new PlayerCharacter(),
            //    null
            //};
            //PlayerCharacter[] players = null;
            //string p1 = players?[0]?.Name;
            //string p2 = players?[1]?.Name;
            //string p3 = players?[2]?.Name;
            //int days;
            //player.Name = "Aman";
            // player.DaysSinceLastLogin = 45;
            //int days = player.DaysSinceLastLogin ?? -1;
            //if(player is null)
            //{
            //    days = -1;
            //}
            //else
            //{
            //    days = player.DaysSinceLastLogin ?? -1;
            //}

            ////PlayerDisplayer.Write(player);
            //Console.WriteLine(days);

        }

    }
}


