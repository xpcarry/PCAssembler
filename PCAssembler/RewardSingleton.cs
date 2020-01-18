using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCAssembler
{
    public class RewardSingleton 
    {
        private static int counter = 0;
        private static RewardSingleton _reward;
        public string Coupon { get; set; }

        public RewardSingleton()
        {
            if (counter > 0)
            {
                throw new Exception();
            }
            counter++;
        }


        public static RewardSingleton Reward
        {
            get
            {
                if (_reward == null)
                {
                    _reward = new RewardSingleton();
                    counter = 1;
                }
                return _reward;
            }
        }


    }
}
