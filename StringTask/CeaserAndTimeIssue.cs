using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTask
{
    internal class CeaserAndTimeIssue
    {
        #region encryption
        //public static string Ceaser(int k, string s)
        //{
        //    string result = "";

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (char.IsLetter(s[i]))
        //        {
        //            if (char.IsUpper(s[i]))
        //            {
        //                int a = (s[i] - 64 + k) % 26 + 64;
        //                result += (char)a;
        //            }
        //            else
        //            {
        //                int A = (s[i] - 96 + k) % 26 + 96;
        //                result += (char)A;
        //            }
        //        }
        //        else
        //        {
        //            result += s[i];
        //        }
        //    }
        //    return result;
        //}

        #endregion'
        #region decryption
        //public static string CeaserMethod()
        //{
        //    Console.Write("Surusdurmek istediyiniz herfin sayi:");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("Sozu daxil edin:");
        //    string s = Console.ReadLine();
        //    string result = "";

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (char.IsUpper(s[i]))
        //        {
        //            int b = (s[i] - 64 +a) % 26 + 64;

        //            if (b <= 64)
        //                b = b + 26;

        //            result += (char)b;
        //        }
        //        else
        //        {
        //            int c = (s[i] - 96 - a) % 26 + 96;

        //            if (c <= 96)
        //                c = c + 26;

        //            result += (char)c;
        //        }
        //    }

        //    return result;
        //}
        #endregion
        #region Time
        internal static string TimeIssue(string time1, string time2, out string time3)
        {
            int h1 = int.Parse(time1.Substring(0, 2));
            int m1 = int.Parse(time1.Substring(3, 2));
            int s1 = int.Parse(time1.Substring(6, 2));

            int h2 = int.Parse(time2.Substring(0, 2));
            int m2 = int.Parse(time2.Substring(3, 2));
            int s2 = int.Parse(time2.Substring(6, 2));

            int h3, m3, s3;

            s3 = s2 - s1;

            if (s2 < s1)
            {
                s3 = (s2 + 60) - s1;
                m2 = m2 - 1;
            }

            m3 = m2 - m1;

            if (m2 < m1)
            {
                m3 = (m2 + 60) - m1;
                h2 = h2 - 1;
            }

            h3 = h2 - h1;

            if (h2 < h1)
            {
                h3 = (h2 + 24) - h1;
            }

            string x = h3.ToString();
            string y = m3.ToString();
            string z = s3.ToString();

            if (h3 < 10 || m3 < 10 || s3 < 10)
            {
                x = h3.ToString();
                y = m3.ToString();
                z = s3.ToString();
            }

            time3 = ($"{x}:{y}:{z}");

            return time3;

        }
        #endregion

    }
}
