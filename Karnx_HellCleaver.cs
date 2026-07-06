using System;
namespace abdulmoez
{
    public class Karnx : CharacterBase
    {
        public string kname;
        public int khealth;
        public bool kstatus;
        public Karnx() : base("Karnx", 100, true)
        {
            kname = Name;
            khealth = Health;
            kstatus = IsAlive;


        }

        public void Cleaver_rush(int damage) {
            damage = 20;
        }

        public void Cleaver_Ablaze(int damage) {
            damage = 10;
        }
        public void HellCleave_Full_Power(int damage){
            damage = 50;
        }
    }
}
