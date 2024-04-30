using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Formula1Car : RaceCar
    {
        private bool _status;
        public bool Status
        {
            get => _status;
            set => _status = value;
        }
        public Formula1Car(string teamName): base(teamName)
        {

        }

        public override void Accelerate()
        {
            if (Status == false)
            {
                Status = true;
            }
        }
        public override void Brake()
        {
            if (Status == true)
            {
                Status = false;
            }
        }
        public override void StartEngine()
        {
            if (Status == false)
            {
                Status = true;
            }
        }
    }
}
