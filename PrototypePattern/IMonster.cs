using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public interface IMonster
    {
        public float Health { get; set; }
        public float Speed { get; set; }
        public IMonster clone();
    }
}
