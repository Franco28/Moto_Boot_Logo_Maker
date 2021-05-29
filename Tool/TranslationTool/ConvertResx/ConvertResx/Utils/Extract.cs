
using System.IO;
using System.Reflection;

namespace ConvertResx
{
    internal static class Extract
    {
        internal static void Resources(object obj, string outDirectory, string internalFolderPath, params string[] fullPathOfItems)
        {
            Assembly assembly = Assembly.GetCallingAssembly();
            string defaultNamespace = obj.GetType().Namespace;

            foreach (string item in fullPathOfItems)
                using (Stream s = assembly.GetManifestResourceStream(defaultNamespace + "." + (internalFolderPath == null ? "" : internalFolderPath + ".") + item))
                using (BinaryReader r = new BinaryReader(s))
                using (FileStream fs = new FileStream(outDirectory + "\\" + item, FileMode.OpenOrCreate))
                using (BinaryWriter w = new BinaryWriter(fs))
                    w.Write(r.ReadBytes((int)s.Length));
        }

        internal static void Resources(string nameSpace, string outDirectory, string internalFolderPath, params string[] fullPathOfItems)
        {
            Assembly assembly = Assembly.GetCallingAssembly();

            foreach (string item in fullPathOfItems)
                using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFolderPath == null ? "" : internalFolderPath + ".") + item))
                using (BinaryReader r = new BinaryReader(s))
                using (FileStream fs = new FileStream(outDirectory + "\\" + item, FileMode.OpenOrCreate))
                using (BinaryWriter w = new BinaryWriter(fs))
                    w.Write(r.ReadBytes((int)s.Length));
        }
    }
}
