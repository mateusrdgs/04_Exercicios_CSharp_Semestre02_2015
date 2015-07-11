using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApplicationHenriqueOliveira
{
    class Program
    {
        static void cadastraCliente(Cliente[] cliente, int contador)
        {
            Console.Clear();
            cliente[contador] = new Cliente();
            Console.WriteLine("CADASTRAR CLIENTE\n");            
            Console.Write("\nNome: ");
            cliente[contador].setNome(Console.ReadLine());
            Console.Write("CPF: ");
            cliente[contador].setCPF(Console.ReadLine());
            Console.Write("Data de nascimento: ");
            cliente[contador].setDataNasc(Console.ReadLine());
            Console.Write("Telefone: ");
            cliente[contador].setTelefone(Console.ReadLine());
            Console.Write("Rua: ");
            cliente[contador].endereco.setRua(Console.ReadLine());
            Console.Write("Número: ");
            cliente[contador].endereco.setNumero(Console.ReadLine());
            Console.Write("Bairro: ");
            cliente[contador].endereco.setBairro(Console.ReadLine());
            Console.Write("Cidade: ");
            cliente[contador].endereco.setCidade(Console.ReadLine());
            Console.Write("Estado: ");
            cliente[contador].endereco.setEstado(Console.ReadLine());
        }

        static void cadastraFuncionario(Funcionario[] funcionario, int contador)
        {
            Console.Clear();
            funcionario[contador] = new Funcionario();
            Console.WriteLine("CADASTRAR FUNCIONARIO\n");
            Console.Write("Nome: ");
            funcionario[contador].setNome(Console.ReadLine());
            Console.Write("CPF: ");
            funcionario[contador].setCPF(Console.ReadLine());
            Console.Write("Data de nascimento: ");
            funcionario[contador].setDataNasc(Console.ReadLine());
            Console.Write("Telefone: ");
            funcionario[contador].setTelefone(Console.ReadLine());
            Console.Write("Rua: ");
            funcionario[contador].endereco.setRua(Console.ReadLine());
            Console.Write("Número: ");
            funcionario[contador].endereco.setNumero(Console.ReadLine());
            Console.Write("Bairro: ");
            funcionario[contador].endereco.setBairro(Console.ReadLine());
            Console.Write("Cidade: ");
            funcionario[contador].endereco.setCidade(Console.ReadLine());
            Console.Write("Estado: ");
            funcionario[contador].endereco.setEstado(Console.ReadLine());
        }

        /*
        public void serializadorCliente(Cliente[] cliente, int contador)
        {
            FileStream cs = new FileStream(@"C: \Cliente.Xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(Cliente[]));
            xs.Serialize(cs, cliente[contador]);
            cs.Close();
        }
        */
        static void Main(string[] args)
        {            
            int escolha = 0;
            int contadorCliente = 0;
            int contadorFuncionario = 0;
            Cliente[] cliente = new Cliente[10];
            Funcionario[] funcionario = new Funcionario[10];

            do {

                Console.Clear();
                Console.SetCursorPosition(33, 0);
                Console.Write("REGISTRADOR\n");
                Console.Write("\n1. Cadastrar cliente");
                Console.Write("\n2. Cadastrar funcionario");
                Console.Write("\n3. Buscar cliente");
                Console.Write("\n4. Buscar funcionário");
                Console.Write("\n5. Sair");
                Console.Write("\n\nEscolha: ");
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch(escolha)
                    {
                        case 1:   
                            if(contadorCliente > 9)
                            {
                                Console.WriteLine("Cadastrar cliente");
                                Console.Beep();
                                Console.Write("\nERRO - Você não pode cadastrar mais clientes");
                                Console.Beep();
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                cadastraCliente(cliente, contadorCliente);
                                contadorCliente++;
                               //cliente[contadorCliente].serializadorCliente(cliente, contadorCliente);
                            }
                            break;

                        case 2: if (contadorFuncionario > 9)
                            {
                                Console.WriteLine("Cadastrar funcionario");
                                Console.Beep();
                                Console.Write("\nERRO - Você não pode cadastrar mais funcionarios");
                                Console.Beep();
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                cadastraFuncionario(funcionario, contadorFuncionario);
                                contadorFuncionario++;
                            }
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                        case 5:
                            Environment.Exit(0);
                            break;
                    }
                }
                else Console.Write("Opção inválida...");
                System.Threading.Thread.Sleep(500);
                
                
            } while(true);
            
            
        }
    }
}
