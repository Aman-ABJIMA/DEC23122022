using System;
using System.Runtime.CompilerServices;

class PlayerCharacter
{
	private readonly ISpecialDefence _specialDefence;
	public string Name { get; set; }

	public int Health { get; private set; } = 100;
	//public int? DaysSinceLastLogin { get; set; }
	public DateTime? dob { get; set; }
    public bool? IsNew { get; set; }

    //public bool? IsNew { get; set; }

    public PlayerCharacter(ISpecialDefence specialDefence)
	{
		_specialDefence = specialDefence;
	}
	public void Hit(int damage)
	{
		int damageReduction;
		damageReduction = _specialDefence.CalculateDamageReduction();
		int totalDamageTaken = Math.Abs(damage - damageReduction);
		Health -= totalDamageTaken;
		Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken}");
	}
	public PlayerCharacter()
	{
		//dob= DateTime.MinValue; //magic number
		//DaysSinceLastLogin = -1; //magic number
		//dob = null;
		//DaysSinceLastLogin = null;
		
	}

}

	