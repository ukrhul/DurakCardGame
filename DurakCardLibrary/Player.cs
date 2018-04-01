using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakCardLibrary
{
    public abstract class Player
    {
        private string playerName;

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        
    }
}
