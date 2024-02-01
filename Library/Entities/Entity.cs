using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public abstract class Entity
    {
        private long id;

        public long Id 
        { 
            get => id;
            protected set => id = value;
        }
    }
}
