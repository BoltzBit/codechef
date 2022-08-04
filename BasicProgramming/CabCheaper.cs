using System;

public class CabCheaper{
	public static void ChoseCab(){
		var TestCase = int.Parse(Console.ReadLine()!);

		for(var i = 0; i < TestCase; i++){
			var cabPrices = Console.ReadLine()!.Split(" ");

			var cheaperCab = Cheaper(int.Parse(cabPrices[0]), int.Parse(cabPrices[1]));

			Console.WriteLine(cheaperCab);
		}
	}

	public static string Cheaper(int a, int b){
		return a > b ? 
			"SECOND" : a == b ? 
				"ANY" : "FIRST";
	}
}
