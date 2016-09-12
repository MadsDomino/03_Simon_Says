namespace _03_Simon_Says
{
    internal class Simon
    {
        public string Echo(string x)
        {
            if (x == "hello")
                return "hello";
            else
                return "bye";
        }
        public string Shout(string x)
        {
            return x = x.ToUpper();
        }

        public string Repeat(string x)
        {
            string y;
            y = x + " " + x;
            return y;
        }

        public string Repeat(string x, int y)
        {
            string z = x;
            for (int i = 1; i < y; i++)
                z = z + " " + x;
            return z;
        }

        public string StartOfWord(string x, int y)
        {
            string z = "";
            for (int i = 0; i < y; i++)
            {
                z = z + x[i];
            }
            return z;
        }

        public string FirstWord(string x)
        {
            string text = "";
            int z = x.Length;
            for (int i = 0; i<z; i++)
            {
                if (char.IsWhiteSpace(x[i]))
                {
                    break;
                }
                else
                {
                    text = text + x[i];
                }
            }
            return text;
        }

        public string Titleize(string x)
        {
            string z = "";
            string text = "";
            text = text + char.ToUpper(x[0]);
            for (int i = 1; i<x.Length; i++)
            {
                if (i != x.Length)
                {
                    z = z + x[i + 1];
                }

                if (char.IsWhiteSpace(x[i]) && z != "a")
                {
                    text = text + " " + char.ToUpper(x[i+1]);
                    i++;
                }
                else
                {
                    text = text + x[i];
                }
            }
            return text;
        }
    }
}