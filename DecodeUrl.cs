using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeUrl
{
    class DecodeUrl
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            Console.WriteLine(DecodingUrl(input));


        }
        private static string DecodingUrl(string chars)
        {
            string result = string.Empty;
            StringBuilder builder = new StringBuilder();
            int lenght = chars.Length;
            int symbolCoutDown = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (symbolCoutDown == 0)
                {
                    if (i <= lenght - 1 && chars[i] == '%')
                    {
                        if (i + 1 <= lenght - 1 && chars[i + 1] == '2')
                        {
                            if (i + 2 <= lenght - 1 && chars[i + 2] == '0')
                            {
                                builder.Append(' ');
                                symbolCoutDown = 2;
                            }
                            else if (i + 2 <= lenght - 1 && chars[i + 2] == 'F')
                            {
                                builder.Append('/');
                                symbolCoutDown = 2;
                            }

                        }
                        else if (i + 1 <= lenght - 1 && chars[i + 1] == '3')
                        {
                            if (i + 2 <= lenght - 1 && chars[i + 2] == 'A')
                            {
                                builder.Append(':');
                                symbolCoutDown = 2;
                            }
                            else if (i + 2 <= lenght - 1 && chars[i + 2] == 'D')
                            {
                                builder.Append('?');
                                symbolCoutDown = 2;
                            }

                        }
                    }
                    else
                    {
                        builder.Append(chars[i]);
                    }

                }
                else
                {
                    symbolCoutDown--;
                }



            }
            return builder.ToString();
        }

    }
   
    


}

