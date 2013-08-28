using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire
{
    class Fire
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();

            //for (int i = 0; i < (width / 2) - 1; i++)
            //{
            //    result.Append(".");

            //}

            //result.Append("##");

            //for (int i = 0; i < (width / 2) - 1; i++)
            //{
            //    result.Append(".");
            //}
            //result.AppendLine();
            for (int i = 0; i < (width / 2); i++)
            {
                for (int j = 0; j < (width / 2) - 1 - i; j++)
                {
                    result.Append(".");
                }

                result.Append("#");

                for (int j = 0; j < i * 2; j++)
                {
                    result.Append(".");
                }

                result.Append("#");

                for (int j = 0; j < (width / 2) - 1 - i; j++)
                {
                    result.Append(".");
                }
                result.AppendLine();
            }
            result.Append("#");
            for (int i = 0; i < width-2; i++)
            {
                result.Append(".");
            }
            result.Append("#");

            result.AppendLine();
            for (int i = 0; i < width/4-1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                     result.Append(".");
                }
                result.Append("#");

                for (int k = 0; k < width - 2*(i+2); k++)
                {
                    result.Append(".");
                }
                result.Append("#");

                for (int j = 0; j <= i; j++)
                {
                    result.Append(".");
                }
                result.AppendLine();
            }

            for (int i = 0; i < width; i++)
            {
                 result.Append("-");
            }
            result.AppendLine();

            for (int i = 0; i < width/2; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    result.Append(".");
                }
                for (int k = 0; k < width/2 - i; k++)
                {
                     result.Append("\\");
                }
                for (int k = 0; k < width / 2 - i; k++)
                {
                    result.Append("/");
                }
                for (int j = 0; j < i; j++)
                {
                    result.Append(".");
                }
                result.AppendLine();
            }
            Console.WriteLine(result.ToString());
        }
    }
}
