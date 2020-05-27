using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace StatePattern
{
    public class Timer
    {
        private bool started = false;
        private bool running = false;
        private float elapsedTime;
        public float time;

        public bool Started 
        { 
            get { return started; }
        }
        public bool Finished
        {
            get { return started && !running; }
        }

        public Timer(float time)
        {
            this.time = time;
            started = false;
            running = false;
            elapsedTime = 0;
        }

        public void Start()
        {
            // Only run when duration is greater than 0
            if (time > 0)
            {
                Console.WriteLine(time);
                started = true;
                Console.WriteLine("timer started");
                while (elapsedTime < time)
                {
                    elapsedTime += 0.5f;
                }

                running = false;
                //started = false;
                elapsedTime = 0;
                Console.WriteLine("timer finished");
            }

        }
    }
}
