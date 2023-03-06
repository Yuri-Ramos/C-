using ExemploExplorando.models;
using System.Globalization;
using Newtonsoft.Json;


int numero = 28;

bool par = false;
// if ternario
par = numero.Ehpar();
string message = "o numero " + " " + "é " + (par ? "par" : "impar");

Console.WriteLine(message);













// // Classes genericas

// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);


// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("30");

// Console.WriteLine(arrayInteiro[0]);













// dynamic variavelDinamica = 56M; //variavel dinamica que pode ter varios tipos ao longo do programa
// Console.WriteLine($"Tipo de arquivo: {variavelDinamica.GetType()},Valor: {variavelDinamica}");






// String conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> venda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonima = listaVenda.Select(x => new { x.produto, x.Preco });


// foreach (var venda in listaAnonima)
// {
//     Console.WriteLine(venda.Produto + " " + venda.Preco);
// }




// // tipos anoimos podem apenas trazer o ger e nao mudar os valores nao pode retornar em metodos
// var tipoAnonimo = new { Nome = "Leonardos", Sobrenome = "Do Pneu", Altura = "1.52" };
// Console.WriteLine("nome: " + tipoAnonimo.Nome);
// Console.WriteLine("nome: " + tipoAnonimo.Altura);
// Console.WriteLine("nome: " + tipoAnonimo.Sobrenome);












// //tipos nulos

// bool? desejaReceberEmail = null;


// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("Deseja Receber");

// }
// //Console.WriteLine($"o usuario quer receber email ?"+ (desejaReceberEmail ? "Deseja" : "Não dejeja ou nao optou"));















// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);


// foreach(Venda venda in listaVenda)
// {
//     Console.WriteLine($"Venda {venda.Id} produto {venda.Produto} Preço {venda.Preco} desconto {(venda.Desconto.HasValue ? $"desconto: {venda.Desconto.Value:C2}":$"Sem desconto")}"); 
// }












// DateTime dateTime = DateTime.Now;
// // iso 8601 padroniza a data entre sistemas
// List<Venda> list = new List<Venda>();

// Venda v1 = new Venda(1,"material", 25.00M, dateTime);
// Venda v2 = new Venda(2,"materiala", 35.00M,dateTime);
// Venda v3 = new Venda(1,"materiala", 35.00M,dateTime);
// Venda v4 = new Venda(1,"materiala", 35.00M,dateTime);
// Venda v5 = new Venda(1,"materiala", 35.00M,dateTime);
// Venda v6 = new Venda(1,"materiala", 35.00M,dateTime);

// list.Add(v1);
// list.Add(v2);
// list.Add(v3);
// list.Add(v4);
// list.Add(v5);
// list.Add(v6);


// string json = JsonConvert.SerializeObject(list, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", json);

// Console.WriteLine(json);











// int numero = 101;
// bool ehPar = false;
//  // if ternario
// ehPar = numero % 2 == 0;
// Console.WriteLine($"numero: {numero} é par ?" + (ehPar ? "Sim" : "não"));

// // if (numero%2==0)
// // {
// //     Console.WriteLine($"o numero: {numero} é par ");
// // }
// // else
// // {
// //     Console.WriteLine($"o numero: {numero} é impar ");

// // }









// Pessoa p1 = new Pessoa("Yuri", "Panos");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"Nome: {nome} {sobrenome}");








// tuplas
// LeituraArquivo arquivo = new LeituraArquivo();

// var (Sucesso, Linhas, _) =arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if(Sucesso)
// {   
//     //Console.WriteLine($"Quantidade linhas do arquivo : {QuantidadedeLinhas}");
//     foreach (string line in Linhas)
//      {
//         Console.WriteLine($"{line}");
//      }
// }
//      else
//      {
//         Console.WriteLine("Nao foi possivel ler o aquivo");
//      }









// // pode colocar muitos tipos de dados em uma só classe
// (int, string, string) tupla = (1, "yuri", "Ramos");

// Console.WriteLine($"id {tupla.Item1} {tupla.Item2} {tupla.Item3}");

// ValueTuple<int, string, string> outroExemplo =(1, "yuri", "Ramosss");

// // ou 
// // nao consegue nomear um obj
// var outroExemploTuple = Tuple.Create(1, "yuri", "Ramossss");
// Console.WriteLine($"id {outroExemplo.Item1} {outroExemplo.Item2} {outroExemplo.Item3}");

// Console.WriteLine($"id {outroExemploTuple.Item1} {outroExemploTuple.Item2} {outroExemploTuple.Item3}");















// Dictionary<string, string> estados = new Dictionary<string,string>();

// estados.Add("Rio", "RJ");
// estados.Add("bahia", "BH");
// estados.Add("MINAs", "MG");


// foreach (var estado in estados){
// Console.WriteLine(estado);
// }
// estados.Remove("Rio");

// estados["bahia"] = "BH foi alterdada";
// foreach (var estado in estados){
// Console.WriteLine(estado);
// }

// string chave = "Rio";
// Console.WriteLine("Verificando a "+chave);
// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine("valor existe ");
// }else {

//     Console.WriteLine("Valor Não existente");

// }








// // tipo de pilha o Ultimo a entrar é o primeiro a sair 
// Stack<int> pilha = new Stack<int>();

// pilha.Push(0);
// pilha.Push(4);
// pilha.Push(7);
// pilha.Push(3);


// foreach(int item in pilha){
//     Console.WriteLine(item);
// }
// pilha.Pop();

// foreach(int item in pilha){
//     Console.WriteLine("item: " + item);
// }













// // Tipo de fila First in first out
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(22);
// fila.Enqueue(245);
// fila.Enqueue(2789);


// foreach (int i in fila){
//     Console.WriteLine(i);


// }
// Console.WriteLine($"Fila: {fila.Dequeue()}");
// //fila.Dequeue(); remove sempre o primeiro da fila 

// fila.Enqueue(2759);

// foreach (int i in fila){
//     Console.WriteLine(i);


// }





// new ExemploExcecao().Metodo1();







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