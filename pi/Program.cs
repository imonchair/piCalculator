using System;

namespace pi
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int valueNumber = Convert.ToInt32(Console.ReadLine ());
			float currentValue = 0;
			for (float i = 1; i <= valueNumber; i+=2) {
				currentValue += 4 / i;
				i += 2;
				currentValue -= 4 / i;
			}
			Console.WriteLine (Convert.ToString (currentValue));
			currentValue = 0;
			int whileCount = 0;
			float piValue = 2;
			while (true) {
				currentValue += 4 / piValue;
				piValue += 2;
				currentValue -= 4 / piValue;
				piValue += 2;
				whileCount += 1;
				if (currentValue == 3.141592) {
					break;	
				}
			}
			Console.WriteLine(Convert.ToString(whileCount));
		}
	}
}
