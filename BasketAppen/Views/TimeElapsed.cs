using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BasketAppen.Views
{
    public partial class  TimeElapsed : ObservableObject
    {
    
        private static TimeElapsed _instance;
        
        private readonly Stopwatch _stopwatch;

        private TimeElapsed()
        {
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
        }

        public static TimeElapsed Instance => _instance ??= new TimeElapsed();

        public TimeSpan GetElapsedTime()
        {
            return _stopwatch.Elapsed;
        }
    }
}

