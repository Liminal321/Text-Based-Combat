using System;

    namespace World
    {
        public class CharacterBase
        {
            private string name;
            private bool isAlive = true;

            public bool IsAlive {get;set;}
            private int health;                      
            private int maxHealth = 100;
            
            public int Health
            {
                get {return health;}
                set 
                {
                    if (value == 0)
                {
                    isAlive = false;         
                }
                    if (value > maxHealth || value < 0 || !isAlive)
                    {
                        throw new ArgumentException ("Health is out of bounds (Either Player is dead,Value exceeds or Doesnt reach standards)", nameof(value));
                    } 
                    
                    health = value;
                }
            }
            public string Name
            {
                get {return name;}
                set
                {
                    if (value != null && value.Any(char.IsDigit) || value.Any(char.IsSymbol))
                    {
                        throw new ArgumentException("Name contains a number", nameof(value));
                    } 
                    name = value;
                    }
            }
        public CharacterBase(string _name, int _health,bool _status)
        {
           name = _name;
           health = _health;
           isAlive = _status; 
        }
        }
    }
