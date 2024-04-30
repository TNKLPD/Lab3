using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class RaceCar:IRaceCar
    {
        private readonly string _teamName;
        public string TeamName
        {
            get;
            init;
        }
        public RaceCar(string teamName)
        {
            TeamName = teamName;
        }
        public abstract void StartEngine();
        public abstract void Accelerate();
        public abstract void Brake();
    }
}
