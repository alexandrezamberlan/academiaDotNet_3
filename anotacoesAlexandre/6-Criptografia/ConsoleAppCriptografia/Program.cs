using ConsoleAppCriptografia;
//string dadoCripto;
//string dadoCripto2;
//string msg, msg2;
//string msgDescripto, msgDescripto2;

//Simetrica s = new Simetrica();
//Console.WriteLine("Utilizando chaves simétricas");
//Console.WriteLine("Algoritmo AES");
//Console.WriteLine("Digite uma mensagem para ser critografada: ");
//msg = Console.ReadLine();

//Console.WriteLine("Digite outra mensagem para ser critografada: ");
//msg2 = Console.ReadLine();


//dadoCripto = s.EncryptData(msg, "@lex@ndr&");
//Console.WriteLine("Mensagem critografada: " + dadoCripto);
//dadoCripto2 = s.EncryptData(msg2, "UFN");
//Console.WriteLine("Mensagem critografada: " + dadoCripto2);

//msgDescripto = s.DecryptData(dadoCripto, "@lex@ndr&");
//Console.WriteLine("Msg 1 descripto = " + msgDescripto);
//msgDescripto2 = s.DecryptData(dadoCripto2, "UFN");
//Console.WriteLine("Msg 2 descripto = " + msgDescripto2);

//s.EncryptAesManaged("turma de sábado de C#");



string dadoCripto;
string dadoCripto2;
string msg, msg2;
string msgDescripto, msgDescripto2;

Console.WriteLine("Utilizando Chaves assimétricas");
Assimetrica a = new Assimetrica();

Console.WriteLine("Digite uma mensagem para ser critografada: ");
msg = Console.ReadLine();

//Console.WriteLine("Digite outra mensagem para ser critografada: ");
//msg2 = Console.ReadLine();

Console.WriteLine(a.getPublicKey());

dadoCripto = a.encrypt(msg);
Console.WriteLine("Mensagem critpo 1 " + dadoCripto);

//dadoCripto2 = a.encrypt(msg2);
//Console.WriteLine("Mensagem critpo 2 " + dadoCripto2);

msgDescripto = a.decrypt(dadoCripto);
Console.WriteLine("Mensagem descriptografada: " + msgDescripto);

//msgDescripto2 = a.decrypt(dadoCripto2);
//Console.WriteLine("Mensagem 2 descriptografada: " + msgDescripto2);


