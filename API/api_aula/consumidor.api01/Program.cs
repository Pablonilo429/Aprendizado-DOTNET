// See https://aka.ms/new-console-template for more information
using static System.Net.WebRequestMethods;
using consumidor.api01;
using Flurl;
using Flurl.Http;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

string url = "https://localhost:7071";
Item tarefa1 = new Item();
Item tarefa2 = new Item();

tarefa1.Id = 1;
tarefa1.Name = "Pagar o agiota";
tarefa1.Finalizado = true;

tarefa2.Id = 2;
tarefa2.Name = "Pagar a Karolinne";
tarefa2.Finalizado = false;


//gerar tarefa
string endpoint = url + "/api/TarefaItems";



//flurl
endpoint.PostJsonAsync(tarefa1);
endpoint.PostJsonAsync(tarefa2);

//ler a lista
IEnumerable<Item> listaTarefas = await endpoint.GetJsonAsync<IEnumerable<Item>>();


foreach(Item item in listaTarefas)
{
    Console.WriteLine($"A tarefa: {item.Name} está {item.Finalizado} de id: {item.Id}");
}


//Alterar

Console.WriteLine("Vamos Alterar! Digite um ID:");

int id = Convert.ToInt32(Console.ReadLine());
Item tarefa3 = new Item();
string endpoint_alterar = url + $"/api/TarefaItems/{id}";

tarefa3.Id = 1;
tarefa3.Name = "Fazer o L";
tarefa3.Finalizado = true;

await endpoint_alterar.PutJsonAsync(tarefa3);

listaTarefas = await endpoint.GetJsonAsync<IEnumerable<Item>>();  
foreach (Item item in listaTarefas)
{
    Console.WriteLine($"A tarefa: {item.Name} está {item.Finalizado} de id: {item.Id} ");
}


//deletar 

Console.WriteLine("Vamos Deletar!");

string endpoint_deletar = url + $"/api/TarefaItems/2";
await endpoint_deletar.DeleteAsync();



listaTarefas = await endpoint.GetJsonAsync<IEnumerable<Item>>();
foreach (Item item in listaTarefas)
{
    Console.WriteLine($"A tarefa: {item.Name} está {item.Finalizado} de id: {item.Id} ");
}


Console.WriteLine("Aperte Qualquer tecla para finalizar o app");
Console.ReadLine();

