String Especie;
	String Raça;
	String Alcunha;
	String Idade;
	String PelagemCor;
	

	Console.Write("Espécie:");
	Especie = Console.ReadLine()!;
	

	Console.Write("Raça:");
	Raça = Console.ReadLine()!;
	

	Console.Write("Alcunha:");
	Alcunha = Console.ReadLine()!;
	

	Console.Write("Idade (anos):");
	Idade = Console.ReadLine()!;
	

	Console.Write("Pelagem/cor:");
	PelagemCor = Console.ReadLine()!;
	

	Console.WriteLine();
	Console.ForegroundColor = ConsoleColor.DarkGray;
	Console.WriteLine("+=========================================================+");
	Console.Write("|                 ");
	

	Console.ForegroundColor = ConsoleColor.Green;
	Console.Write("Pet Hotel \"Nem um pio\"");
	

	Console.ForegroundColor = ConsoleColor.DarkGray;
	Console.WriteLine("                  |");
	

	Console.ForegroundColor = ConsoleColor.DarkGray;
	Console.WriteLine("+=========================================================+");
	Console.Write("|Espécie:");
	

	Console.ForegroundColor = ConsoleColor.Blue;
	Console.Write(Especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
	

	Console.ForegroundColor = ConsoleColor.DarkGray;
	Console.WriteLine("                                  |");
	 
	Console.ForegroundColor = ConsoleColor.DarkGray;
	Console.WriteLine("+=========================================================+");
	Console.Write("|Atende pela alcunha de:");
	

	Console.ForegroundColor = ConsoleColor.Blue;
	Console.Write(Alcunha.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));
	


	Console.ForegroundColor = ConsoleColor.DarkGray;
	Console.WriteLine("   |");
	

	Console.Write("| Idade: ");
	Console.ForegroundColor = ConsoleColor.DarkBlue;
	Console.Write(Idade.Trim().ToUpper().PadLeft(2, '.').Substring(0, 2));
	

	Console.ForegroundColor = ConsoleColor.DarkGray;
	Console.Write("| Pelagem/Cor: ");
	

	Console.ForegroundColor = ConsoleColor.DarkBlue;
	Console.Write(PelagemCor.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
	

	Console.ForegroundColor = ConsoleColor.DarkGray;
	Console.WriteLine("         |");
	

	Console.ForegroundColor = ConsoleColor.DarkGray;
	Console.Write("+=========================================================+");