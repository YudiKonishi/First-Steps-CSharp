namespace Interface
{
    interface IAnimal // parecido com struct
    {
        void Nome(string name);
        void Dono(string nameOwner);
        void Especie(string species);
    }

    class Animal: IAnimal
    {
        public string Nome { get; set; }
        public string Dono { get; set; }
        public string Especie { get; set; }

        void IAnimal.Nome(string name)
        {
            this.Nome = name;
        } 
        void IAnimal.Dono(string nameOwner)
        {
            this.Dono = nameOwner;
        }
        void IAnimal.Especie(string species)
        {
            this.Especie = species;
        }
    }
    
}