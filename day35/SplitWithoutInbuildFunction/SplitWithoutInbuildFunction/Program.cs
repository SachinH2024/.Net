namespace SplitWithoutInbuildFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] urls = { "abc.edu", "pqr.com", "lmno.org" };
            string[] extensions = GetExtensions(urls);
            foreach (string extension in extensions)
            {
                Console.WriteLine(extension);
            }
        }


        public static string GetExtension(string url)
        {
            int index = url.LastIndexOf('.');
            if (index == -1)
            {
                return string.Empty;
            }
            return url.Substring(index + 1);
        }

        public static string[] GetExtensions(string[] urls)
        {
            string[] extensions = new string[urls.Length];
            for (int i = 0; i < urls.Length; i++)
            {
                extensions[i] = GetExtension(urls[i]);
            }
            return extensions;
        }



        }
    }

