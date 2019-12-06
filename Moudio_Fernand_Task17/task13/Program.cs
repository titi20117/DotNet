using System;
using Department.BLL;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task13
{
    static class Program
    {
        public static RewardsBL rewardsBL;
        public static UsersBL usersBL;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            usersBL = new UsersBL();
            rewardsBL = new RewardsBL();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }
    }
    
    
         
    

}
