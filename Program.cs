using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        /// 아무것도 안 바꿨지롱 ㅋㅋㅋ
        Console.WriteLine();// 끝에 세미콜론 빠트렸다.
        Console.WriteLine();// 한칸 더 띄움
    }
}
