
using System.Collections.Generic;
using System.IO;

namespace ConvertResx
{
    public static class ResourceFolderManager
    {
        private static readonly DirectoryInfo FILE_DIRECTORY;
        private static Dictionary<string, DirectoryInfo> controlledFolders;
        public static string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        static ResourceFolderManager()
        {
            FILE_DIRECTORY = new DirectoryInfo(exePath);
            controlledFolders = new Dictionary<string, DirectoryInfo>();

            if (!FILE_DIRECTORY.Exists)
                FILE_DIRECTORY.Create();

            foreach (DirectoryInfo d in FILE_DIRECTORY.GetDirectories("*", SearchOption.TopDirectoryOnly))
                controlledFolders.Add(d.Name, d);
        }

        public static DirectoryInfo GetRegisteredFolder(string folder)
        {
            return (controlledFolders.ContainsKey(folder) ? controlledFolders[folder] : null);
        }

        public static string GetRegisteredFolderPath(string folder)
        {
            return (controlledFolders.ContainsKey(folder) ? controlledFolders[folder].FullName : null);
        }

        public static bool Register(string name)
        {
            if (controlledFolders.ContainsKey(name))
                return false;

            controlledFolders.Add(name, new DirectoryInfo(FILE_DIRECTORY + name));

            if (!controlledFolders[name].Exists)
                controlledFolders[name].Create();

            return true;
        }

        public static bool Unregister(string name)
        {
            if (!controlledFolders.ContainsKey(name))
                return false;

            try { controlledFolders[name].Delete(true); }
            catch { return false; }

            return controlledFolders.Remove(name);
        }
    }
}
