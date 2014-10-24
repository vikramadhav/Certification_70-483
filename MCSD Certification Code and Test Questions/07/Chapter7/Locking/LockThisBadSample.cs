using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locking {
public class LockThisBadSample {
    public void MyMethod() {
        lock (this) {
            // Do Something here
        }
    }
}

public class UsingTheLockedObject {
    public void OneMethod(){
        LockThisBadSample lockObject = new LockThisBadSample();
        lock (lockObject) {
            // Do something else
        }
    }
}
}
