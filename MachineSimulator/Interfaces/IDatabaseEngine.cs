using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineSimulator.Interfaces
{
    public interface IDatabaseEngine
    {
        string Extension { get; }
        
        void Connect(string dbName);
        void Close();

        void TruncateDatabase();
    }
}
