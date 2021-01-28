using GTA;
using GTA.Native;

namespace Allow_Pause_when_Dead
{
    public class Main : Script
    {
        public Main()
        {
            Tick += (sender, e) => Function.Call(Hash._ALLOW_PAUSE_MENU_WHEN_DEAD_THIS_FRAME);
        }
    }
}