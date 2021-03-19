using System;
using DotNetify;
using System.Threading;

namespace ElectronVueDotnetify.ViewModel
{
    public class HelloWorldVM : BaseVM
    {
        private Timer _timer;

        public string Greetings {
            get {
                return "Hello World!";
            }
        } 

        public int ClickCount
        {
            get => Get<int>(); 
            set => Set(value); 
        }

        public DateTime ServerTime
        {
            get => Get<DateTime>();
            set => Set(value);
        }

        public HelloWorldVM()
        {
            _timer = new Timer(state =>
            {
                ServerTime = DateTime.Now;
                PushUpdates();
            }, null, 0, 1000);
        }

        public override void Dispose() => _timer.Dispose();

        // from HelloWorld.vue
        // this.vm.$dispatch({ ButtonClicked: true });
        public void ButtonClicked(bool args1)
        {
            ClickCount++;
        }
    }
}