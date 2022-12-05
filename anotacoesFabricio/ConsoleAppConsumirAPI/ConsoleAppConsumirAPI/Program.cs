using Newtonsoft.Json;
using System.Net.Http.Json;

namespace ConsoleAppConsumirAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string BaseUrl = "http://localhost:5258/";
            int op = 0;

            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1 - para efetuar uma consulta");
                Console.WriteLine("2 - para efetuar um cadastro");
                Console.WriteLine("0 - para FINALIZAR");

                op = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                switch (op)
                {
                    case 1:
                        List<Pessoa>? pessoas = new List<Pessoa>();

                        HttpClient client = new HttpClient();
                        client.BaseAddress = new Uri(BaseUrl);
                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Accept.Add(
                            new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                        );

                        HttpResponseMessage response = await client.GetAsync("api/pessoas");

                        if (response.IsSuccessStatusCode)
                        {
                            var dados = response.Content.ReadAsStringAsync().Result;
                            pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(dados);

                            foreach (Pessoa item in pessoas)
                            {
                                Console.WriteLine(item.Id + " - " + item.nome);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Erro: " + response.StatusCode.ToString());
                        }
                        break;
                    case 2:
                        Pessoa p = new Pessoa();
                        Console.WriteLine("Informe o nome da pessoa:");
                        p.nome = Console.ReadLine();

                        try
                        {
                            HttpClient clientPost = new HttpClient();
                            HttpResponseMessage responsePost = await clientPost.PostAsJsonAsync(
                                BaseUrl + "api/pessoas", p);
                            Console.WriteLine("Response:" + responsePost.StatusCode);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Erro: " + ex.Message);
                        }
                        break;
                    default:
                        break;
                }


            } while (op != 0);

        }
    }
}