using DesafioPOO.Models;
Iphone X999 = new Iphone("9999-9999", "X999", "EDF-999", 64);
Nokia i234 = new Nokia("8888-8888", "i234", "PDF-099", 32);

string gta = "GTA San Andreas: Mobile";
string Netflix = "Netflix: Filmes e Séries";

Console.WriteLine("Iphone:");

X999.Ligar();
X999.ReceberLigacao();
X999.InstalarAplicativo(gta);
X999.InstalarAplicativo(Netflix);

Console.WriteLine("Nokia:");

i234.Ligar();
i234.ReceberLigacao();
i234.InstalarAplicativo(gta);
i234.InstalarAplicativo(Netflix);
// TODO: Realizar os testes com as classes Nokia e Iphone