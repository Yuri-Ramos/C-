using ExemploExplorando.models;
using System.Globalization;











// try// tente
// {



//     string[] linhas = File.ReadAllLines("Arquivos/arquivo Leitura.txt");


//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }catch(FileNotFoundException ex){
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo, arquivo nao encontrado {ex.Message}");
// }


// catch(DirectoryNotFoundException ex){
//     Console.WriteLine($" Diretorio nao encontrado {ex.Message}");
// }
// catch(Exception ex){
//     Console.WriteLine($"Ocorreu uma excessao generica {ex.Message}");
// }
// // este bloco vai ser executado sempre
// finally{
//     Console.WriteLine("Chegou até aqui!");
// }












// string dataString = "2022-12-17 18:00";
// // DateTime data =  DateTime.Now; // Mora a data de agora no sistema
// //DateTime data =  DateTime.Parse("20/12/2001 18:00");
// bool sucesso = DateTime.TryParseExact(dataString, 
//                         "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture, 
//                         DateTimeStyles.None, out DateTime data); // Conversao da data com tratamento de excessão

// if(sucesso){
//     Console.WriteLine($"Conversao com sucesso! Data: {data}");
// }
// else{
//     Console.WriteLine("insira uma nova data!");
// }
// //DateTime data = DateTime.Parse(dataString); // converte a data para uma data valida, contudo pode dar erros se for invalido
// Console.WriteLine(data);

// Console.WriteLine(data.ToString("yy/MMMMMMMM/dd HH:mm")); // Formatação de horas e datas

// Console.WriteLine(data.ToShortTimeString()); // Formatação de horas e datas
// Console.WriteLine(data.ToShortDateString()); // Formatação de horas e datas











// altera a cultura do sistema 
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonerario = 82.40M;
// // Fomatando de acordo para a cultura 
// //Console.WriteLine(valorMonerario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));// formata para o real pega as configuraçoes do seu windows
// Console.WriteLine(valorMonerario.ToString("C1"));// usando apenas as casas decimais 

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));// formata como porcentagem 
// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));







// string numero1 = "10";
// string numero2 = "20";

// string resultado = (numero1 + numero2);

// Console.WriteLine(resultado);


















// Pessoa p1 = new Pessoa();
// p1.Nome = "Yuri";
// p1.Idade = 22;
// p1.Sobrenome="ferreira";


// Pessoa p2 = new Pessoa();

// p2.Nome = "Joaquina";
// p2.Idade = 2;
// p2.Sobrenome="Pagodeiro";

// Pessoa p3 = new Pessoa(nome:"Joaozin", sobrenome:"das cove");

// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Curso deIngles";
// cursoDeIngles.Alunos = new List<Pessoa>();
// cursoDeIngles.Adicionar(p1);
// cursoDeIngles.Adicionar(p3);
// cursoDeIngles.ListarAlunos();
// cursoDeIngles.Remover(p1);
// cursoDeIngles.ListarAlunos();


// Pessoa p1 = new Pessoa();
// Pessoa p2 = new Pessoa();

// p1.Nome = "Yuri";
// p1.Idade = 22;
// p2.Nome = "Joaquina";
// p2.Idade = 2;
// p1.Sobrenome="ferreira";
// p2.Sobrenome="Pagodeiro";

// p1.Apresentar();
// p2.Apresentar();