using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task2._3._10
{
    class Reader
    {
        public string read(string name)
        {//why null?
            var assembly = Assembly.GetExecutingAssembly();
            //var resourceName = String.Format("_2._3._10.Resources.{0}.txt", name);

            //using (Stream stream =assembly.GetManifestResourceStream(resourceName))
            using (Stream stream = GetResourceStream(assembly, "temp.txt"))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public Stream GetResourceStream(Assembly assembly, string name )
        {
            foreach (string resourcename in assembly.GetManifestResourceNames())
                if (resourcename.EndsWith(name))
                    return assembly.GetManifestResourceStream(resourcename);

            return null;
        }
    }
}
