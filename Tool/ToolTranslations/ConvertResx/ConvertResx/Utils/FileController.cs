
using System;
using System.Collections.Generic;

namespace ConvertResx
{
    public sealed class FileController
    {
        private const string CONTROLLER_FOLDER = "";
        private static readonly Dictionary<string, string> RESOURCES = new Dictionary<string, string>
        {
            {"ResGen.exe",""},
        };

        private static FileController instance;

        private string resourceDirectory;
        private bool Extract_Resources = false;

 
        public static FileController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FileController();
                    instance.CreateResourceDirectories();
                    instance.ExtractResources();
                }

                return instance;
            }
        }

        internal string ResourceDirectory
        {
            get { return this.resourceDirectory; }
        }

        private FileController()
        {
            ResourceFolderManager.Register(CONTROLLER_FOLDER);
            this.resourceDirectory = ResourceFolderManager.GetRegisteredFolderPath(CONTROLLER_FOLDER);
        }

        private void CreateResourceDirectories()
        {
            try
            {
                ResourceFolderManager.Unregister(CONTROLLER_FOLDER);
                Extract_Resources = true;
            }
            catch (Exception)
            {
                Extract_Resources = true;
            }
            ResourceFolderManager.Register(CONTROLLER_FOLDER);
        }

        private void ExtractResources()
        {
            if (this.Extract_Resources)
            {
                string[] res = new string[RESOURCES.Count];
                RESOURCES.Keys.CopyTo(res, 0);
                Extract.Resources(this, this.resourceDirectory, "Resources", res);
            }
        }

        public void Dispose()
        {
            FileController.instance = null;
        }
    }
}
