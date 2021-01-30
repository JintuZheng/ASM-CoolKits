using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASM_SCAU
{
    public class WatcherProcess
    {
        private object sender;
        private object eParam;

        public event RenamedEventHandler OnRenamed;
        public event FileSystemEventHandler OnChanged;
        public event FileSystemEventHandler OnCreated;
        public event FileSystemEventHandler OnDeleted;
        public event Completed OnCompleted;

        public WatcherProcess(object sender, object eParam)
        {
            this.sender = sender;
            this.eParam = eParam;
        }

        public void Process()
        {
            if (eParam.GetType() == typeof(RenamedEventArgs))
            {
                OnRenamed(sender, (RenamedEventArgs)eParam);
                OnCompleted(((RenamedEventArgs)eParam).FullPath);
            }
            else
            {
                FileSystemEventArgs e = (FileSystemEventArgs)eParam;
                if (e.ChangeType == WatcherChangeTypes.Created)
                {
                    OnCreated(sender, e);
                    OnCompleted(e.FullPath);
                }
                else if (e.ChangeType == WatcherChangeTypes.Changed)
                {
                    OnChanged(sender, e);
                    OnCompleted(e.FullPath);
                }
                else if (e.ChangeType == WatcherChangeTypes.Deleted)
                {
                    OnDeleted(sender, e);
                    OnCompleted(e.FullPath);
                }
                else
                {
                    OnCompleted(e.FullPath);
                }
            }
        }
    }

}
