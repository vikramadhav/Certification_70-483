using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Threading;

namespace MethodSyncronization {
    class Program {
        static void Main(string[] args) {

            var handle = new EventWaitHandle(true, EventResetMode.AutoReset);
            var handle2 = new EventWaitHandle(true, EventResetMode.ManualReset);
            var handle3 = new AutoResetEvent(true);

            CountdownEvent ce = new CountdownEvent(4);

            WaitHandle.WaitAny(new WaitHandle[] { ce.WaitHandle });


            var instance = new SingleThreaded();
            new Thread(() => {

                instance.OneCallInstance1();
                ce.Signal();
            }).Start();

            new Thread(() => {

                lock (instance) {
                    Console.WriteLine("Main");
                    Console.ReadLine();
                    Console.WriteLine("Main");

                }
                ce.Signal();
            }).Start();

            new Thread(() => {

                instance.OneCallInstance2();
                ce.Signal();
            }).Start();

            new Thread(() => {

                instance.OneCallLockThis();
                ce.Signal();
            }).Start();

            //new Thread(() => {

            //    SingleThreaded.OneCallStatic1();
            //}).Start();

            //new Thread(() => {

            //    SingleThreaded.OneCallStatic2();
            //}).Start();

            ce.Wait();
            //Console.ReadLine();
        }

    }

    class SingleThreaded {

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void OneCallInstance1() {

            Console.WriteLine("OneCallInstance1");
            Console.ReadLine();
            Console.WriteLine("OneCallInstance1");
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void OneCallInstance2() {
            Console.WriteLine("OneCallInstance2");
            Console.ReadLine();
            Console.WriteLine("OneCallInstance2");
        }

        public void OneCallLockThis() {

            lock (this) {
                Console.WriteLine("OneCallLockThis");
                Console.ReadLine();
                Console.WriteLine("OneCallLockThis");
            }
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void OneCallStatic1() {
            Console.WriteLine("OneCallStatic1");
            Console.ReadLine();
            Console.WriteLine("OneCallStatic1");
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void OneCallStatic2() {
            Console.WriteLine("OneCallStatic2");
            Console.ReadLine();
            Console.WriteLine("OneCallStatic2");
        }
    }
}
