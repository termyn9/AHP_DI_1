using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.DB
{
     class Factor
    {
            [Key] public int ID_Factor{ get; set; }
            public int ID_GroupFactor { get; set; }
            public int Number { get; set; }
            public string Title { get; set; }
            public double Weight { get; set; }
    }
}
