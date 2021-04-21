using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksBeer.Views
{
	public class Cadastro
	{
		private int qtdMinAlcool;

		public int QtdMinAlcool
		{
			get { return qtdMinAlcool; }
			set
			{
				if (value > 0)
				{
					qtdMinAlcool = value;
				}
				else
				{
					throw new Exception("A quantidade de bebidas alcoolicas não pode ser menor que 1");
				}
			}
		}
		private int qtdMinS_alcool;

		public int QtdMinS_alcool
		{
			get { return qtdMinS_alcool; }
			set
			{
				if (value > 0)
				{
					qtdMinS_alcool = value;
				}
				else
				{
					throw new Exception("A quantidade de bebidas não alcoolicas não pode ser menor que 1");
				}
			}
		}


		private string nome;

		public string Nome
		{
			get { return nome; }
			set
			{
				if (nome.Length >= 3)
				{
					nome = value;
				}
				else
				{
					throw new Exception("Informa um nome com mais de 2 caracteres.");
				}
			}
		}
		private string rua;

		public string Rua
		{
			get { return rua; }
			set
			{
				if (rua.Length >= 3)
				{
					rua = value;
				}
				else
				{
					throw new Exception("O nome da rua deve ter ao menos 2 caracteres.");
				}
			}
		}
		private string cidade;

		public string Cidade
		{
			get { return cidade; }
			set
			{
				if (cidade.Length >= 3)
				{
					cidade = value;
				}
				else
				{
					throw new Exception("O nome da cidade deve ter ao menos 2 caracteres.");
				}
			}
		}
		private string telefone;

		public string Telefone
		{
			get { return telefone; }
			set
			{
				if (telefone.Length >= 4 && telefone.Length <= 9)
				{
					telefone = value;
				}
				else
				{
					throw new Exception("O número de telefone deve ter ao menos 4 dígitos e o máximo 8.");
				}
			}
		}
		private string nomeUsuario;

		public string NomeUsuario
		{
			get { return nomeUsuario; }
			set
			{
				if (nomeUsuario.Length >= 3)
				{
					nomeUsuario = value;
				}
				else
				{
					throw new Exception("O número de usuário deve ter ao menos 3 caracteres.");
				}
			}
		}
		private int idade;

		public int Idade
		{
			get { return idade; }
			set
			{
				if (value >= 12 || value < 120)
				{
					idade = value;
				}
				else
				{
					throw new Exception("A idade mínima para comprar é de 12 anos.");
				}
			}
		}
		private int numeroCasa;

		public int NumeroCasa
		{
			get { return numeroCasa; }
			set
			{
				if (value > 0)
				{
					numeroCasa = value;
				}
				else
				{
					throw new Exception("O número da casa deve ser maior que zero.");
				}
			}
		}
		private int cep;

		public int Cep
		{
			get { return cep; }
			set
			{
				if (value > 0 && value < 10)
				{
					cep = value;
				}
				else
				{
					throw new Exception("O número CEP deve ser maior que zero.");
				}
			}
		}
		private string senha;

		public string Senha
		{
			get { return senha; }
			set
			{
				if (senha.Length >= 3)
				{
					senha = value;
				}
				else
				{
					throw new Exception("A senha deve ter no mínimo 3 caracteres.");
				}
			}
		}
		private string cpf;

		public string Cpf
		{
			get { return cpf; }
			set
			{
				if (cpf.Length == 11)
				{
					cpf = value;
				}
				else
				{
					throw new Exception("O Cpf precisa ter no mínimo 11 caracteres");
				}
			}
		}
		private string bairro;

		public string Bairro
		{
			get { return bairro; }
			set
			{
				if (bairro.Length > 5)
				{
					bairro = value;
				}
				else
				{
					throw new Exception("O nome do bairro precisa ter no mínimo 6 caracteres");
				}
			}
		}
	}
}
