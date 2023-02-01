using System;
using System.Net;

namespace bookStore
{
    class characters
    {
        private int _Id;
        private string _Name;
        private string _Race;
        private int _Power;
        private int _Magic;
        private int _Health;
        private static int _count = 0;

        public characters()
        {
            _Id = 0;
            _Name = "";
            _Race = "";
            _Power = 0;
            _Magic = 0;
            _Health = 0;
        }
        public characters(int id, string name, string race, int power, int magic, int health)
        {
            _Id = id;
            _Name = name;
            _Race = race;
            _Power = power;
            _Magic = magic;
            _Health = health;
        }
        public int GetId()
        {
            return _Id;
        }
        public string GetName()
        {
            return _Name;
        }
        public string GetRace()
        {
            return _Race;
        }
        public int GetPower()
        {
            return _Power;
        }
        public int GetMagic()
        {
            return _Magic;
        }
        public int GetHealth()
        {
            return _Health;
        }
        public void SetId(int id)
        {
            _Id = id;
        }
        public void SetName(string name)
        {
            _Name = name;
        }
        public void SetRace(string race)
        {
            _Race = race;
        }
        public void SetPower(int power)
        {
            _Power = power;
        }
        public void SetMagic(int magic)
        {
            _Magic = magic;
        }
        public void SetHealth(int health)
        {
            _Health = health;
        }
        public void SetCount()
        {
            _count++;
        }
        public int GetCount()
        {
            return _count;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            characters orc = new characters();
            orc.SetCount();
            orc.SetId(1);
            orc.SetName("Zhor The Ruthless");
            orc.SetRace("Orc");
            orc.SetPower(20);
            orc.SetHealth(25);
            orc.SetMagic(0);

            characters elf = new characters();
            elf.SetCount();
            elf.SetId(2);
            elf.SetName("Aegnor");
            elf.SetRace("Elven");
            elf.SetPower(5);
            elf.SetMagic(15);
            elf.SetHealth(10);

            characters human = new characters(3, "Ragnar", "Human", 10, 10, 10);
            human.SetCount();
            characters goblin = new characters(4, "Bogrod", "Goblin", 15, 5, 10);
            goblin.SetCount();

            Console.WriteLine($"There are {human.GetCount()} characters.");

            displayCharacters(orc);
            displayCharacters(human);
            displayCharacters(goblin);
            displayCharacters(elf);

        }
        static void displayCharacters(characters character)
        {
            Console.WriteLine("Here's the character information");
            Console.WriteLine($"Character ID: {character.GetId()}");
            Console.WriteLine($"Character name: {character.GetName()}");
            Console.WriteLine($"Character race: {character.GetRace()}");
            Console.WriteLine($"Character power: {character.GetPower()}");
            Console.WriteLine($"Character magic: {character.GetMagic()}");
            Console.WriteLine($"Character health: {character.GetHealth()}");
        }

    }
}