using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testss
{
    public class StringFormatter
    {
        public string WebString(string s)
        {
            if (s is null)
                throw new NullReferenceException("Input string is null");

            if (s == String.Empty)
                return s;

            if (s.EndsWith(".git"))
            {
                if (!s.StartsWith("http://") && !s.StartsWith("git://"))
                    return "git://" + s;

                return s;
            }

            if (!s.StartsWith("http://"))
                return "http://" + s;

            return s;
        }
    }
}
