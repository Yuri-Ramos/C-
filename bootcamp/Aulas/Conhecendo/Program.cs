using Conhecendo.Models;


Calculadora calc = new Calculadora();

//  calc.Somar(5,6);
//  calc.Subtrair(5,6);
//  calc.Multiplicar(5,6);
//  calc.Dividir(5,5);
// calc.Potencia(5,6);

int numero = 10;
Console.WriteLine($"{numero++}");

calc.Raiz(2);












// bool choveu = true;
// bool estaTarde= true;


// if (choveu && estaTarde)
// {
//     Console.WriteLine("Vou Pedalar");
// }
// else{
//     Console.WriteLine("Vou pedalar um outro dia");
// }









// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDeResponsavel = false;

// if (ehMaiorDeIdade && possuiAutorizacaoDeResponsavel)
// {
//     Console.WriteLine("Passou");
// }
// else {
//     Console.WriteLine(" não Passou");
// }


















// programa para saber se a letra digitada é uma vogal ou não 

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();


// if(letra== "a" || letra=="e" || letra=="i" || letra=="o" || letra== "u"){
//     Console.WriteLine($"a {letra} [e uma vogal");
// }

// else{
//     Console.WriteLine($"a {letra} e uma consuante");

// }
// switch(letra){
// case "a": 
// case "e": 
// case "i": 
// case "o": 
// case "u": 


// Console.WriteLine($"a {letra} e uma vogal");
// break;

// default:
// Console.WriteLine($"a {letra} e uma consuante");
// break;
// }












// int quantidade = 03;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra >0 && quantidade>= quantidadeCompra;

// Console.WriteLine($"Quantidade: {quantidade}")  ;
// Console.WriteLine($"QuantidadeCompra: {quantidadeCompra}");
// Console.WriteLine($"Possivel realizar venda ? {possivelVenda}");

// if (quantidadeCompra==0){
// Console.WriteLine($"Possivel realizar venda: Não ! valor igual a zero");

// }
// else {

// Console.WriteLine($"Possivel realizar venda ? {possivelVenda}");
// }



// if(quantidadeCompra==0) 
// {
//     Console.WriteLine($"venda nao posso ser = {quantidadeCompra}");
   
    
// }
// else if (possivelVenda)
// {
//   Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. agendaremos seu pedido por falta de estoque");
    
// }











































//cast implicito

// int h = 5;
// double j=h;


// int h = int.MaxValue;
// double j=h;


// Console.WriteLine(j);

// ordem das operações é a mesma da matematica a ordem é alterada com parenteses

// double a = 4/(2+2);
// Console.WriteLine(a);













// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("yyyy-MM-dd"));
// int a = 0;
// int b= 1;
// int c = a+b;

// c= c+5;

// c -= 5;
//cast-casting 
// int d = Convert.ToInt32("5"); //convert altera null para 0.
// int d= int.Parse("5");// parce nao aceita nulo
// int f = 5;
// string g = f.ToString();// primario no java 


// Console.WriteLine(a);






// Console.WriteLine(c);

// string apresentacao = "olá seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;


// Console.WriteLine($"{apresentacao},{quantidade},{altura.ToString("0-00")},{preco},{condicao}");

// // instancia de objeto com canelcase
// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome ="Yuri";
// pessoa1.Idade = 18;

// pessoa1.Apresentar();
