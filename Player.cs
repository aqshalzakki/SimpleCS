using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    internal class Player
    {
        public static int playerCount = 0;
        public static string[] roles = { "fighter", "wizard", "support", "tank", "assassins" };

        public string name;
        public int health;
        public int damage;
        private string? role;

        public Player(string name, int health, int damage, string role)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
            Role = role;

            playerCount++;
        }

        public string? Role
        {
            get { return role; }
            set
            {
                if (roles.Contains(value)){
                    role = value;
                }
            }
        }
    }
}