using Pessoa;
using Interface;
using Enum;

Persona person = new Persona(); //var person = new Persona(); does the same thing
person.Nome = "Yudi";
person.Idade = 20;
person.Cidade = "São Bernardo";

Animal animal = new Animal();
animal.Nome = "Marty";
animal.Dono = "Yudi";
animal.Especie = "Cachorro";

var pessoa1 = (Pessoas)0;
Pessoas pessoa2 = Pessoas.João;
Pessoas pessoa3 = (Pessoas)4;

Console.WriteLine(pessoa3);