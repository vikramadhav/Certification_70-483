using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Locking {
    class Program {
        static void Main(string[] args) {

object syncObject = new object();

// wrong usage
Monitor.Enter(syncObject);

// Code updating some shared data
Monitor.Exit(syncObject);


// Exception safe usage
Monitor.Enter(syncObject);

try {
    // Code updating some shared data
}
finally {
    Monitor.Exit(syncObject);
}

// C# way of using locks

lock (syncObject) {
    // Code updating some shared data
}
        }
    }
}
