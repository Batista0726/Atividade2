using MinhaEmpresa.Cliente;
using MinhaEmpresa.Produto;
using System;

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente("Ana Rafael", "anarafael@gmail.com");
        Produto produto = new Produto("agua");

        Console.WriteLine($"Cliente: {cliente.Nome} \nEmail: {cliente.Email} \nProduto: {produto.Produtos}");
    }
}
