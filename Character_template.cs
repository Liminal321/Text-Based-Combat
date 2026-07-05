using System;

namespace abdulmoez
{
    public class CharacterBase
    {
        private string name;
        private bool isAlive = true;

        public bool IsAlive { get; set; }
        private int health;
        private int maxHealth = 100;

        public int Health
        {
            get { return health; }
            set
            {
                try
                {
                    if (value == 0)
                    {
                        isAlive = false;
                    }

                    if (value > maxHealth || value < 0 || !isAlive)
                    {
                        throw new ArgumentException("Health is out of bounds (Either Player is dead, value exceeds or doesn't reach standards)", nameof(value));
                    }

                    health = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Name cannot be empty.", nameof(value));
                    }

                    if (value.Any(char.IsDigit) || value.Any(char.IsSymbol))
                    {
                        throw new ArgumentException("Name contains invalid characters.", nameof(value));
                    }

                    name = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
        }

        public CharacterBase(string _name, int _health, bool _status)
        {
            try
            {
                Name = _name;
                Health = _health;
                isAlive = _status;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
