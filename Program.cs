const string senhacorreta = "programacao";
string senha, permissaoacesso;

Console.WriteLine("---Senha---\n");

Console.Write("Olá, usuário. Por favor, digite sua senha: ");
senha = Console.ReadLine()!;

permissaoacesso = senha == senhacorreta ? "permitido" : "negado";

Console.WriteLine($"acesso {permissaoacesso}");
