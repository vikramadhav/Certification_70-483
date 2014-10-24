using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BarrierSample {
    class Program {
        static void Main(string[] args) {
            var participants = 5;

            Barrier barrier = new Barrier(participants + 1, // We add one for the main thread.
                b => {
                    Console.WriteLine("{0} paricipants are at rendez-vous point {1}.",
                                    b.ParticipantCount - 1, // We substract the main thread .
                                    b.CurrentPhaseNumber);
                });

            for (int i = 0; i < participants; i++) {
                var localCopy = i;
                Task.Run(() => {
                    Console.WriteLine("Task {0} left point A!", localCopy);
                    Thread.Sleep(1000 * localCopy + 1); // Do some "work"
                    if (localCopy % 2 == 0) {
                        Console.WriteLine("Task {0} arrived at point B!", localCopy);
                        barrier.SignalAndWait();
                    }
                    else {
                        Console.WriteLine("Task {0} changed its mind and went back!", localCopy);
                        barrier.RemoveParticipant();
                        return;
                    }
                    Thread.Sleep(1000 * (participants - localCopy));
                    Console.WriteLine("Task {0} arrived at point C!", localCopy);
                    barrier.SignalAndWait();
                });
            }

            Console.WriteLine("Main thread is waiting for {0} tasks!", barrier.ParticipantsRemaining - 1);
            barrier.SignalAndWait(); // Waiting at the first phase
            barrier.SignalAndWait(); // Waiting at the second phase
            Console.WriteLine("Main thread is done!");
        }
    }
}
