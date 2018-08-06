using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Speedometer
    {
        /*  public int _currentSpeed;

          public int GetCurrentSpeed()
          {
              return _currentSpeed;
          }

          public void SetCurrentSpeed(int newSpeed)
          {
              if (newSpeed < 0)
              {
                  return;
              }

              if (newSpeed > 120)
              {
                  return;
              }
              *
              */

        private int _currentSpeed;
        public int CurrentSpeed
        {
            get {
                return _currentSpeed;
            }
            set {

                if (value < 0)
                {
                    return;
                }

                if (value > 120)
                {
                    return;
                }
                _currentSpeed = value;
            }

            
        }
    }
}
