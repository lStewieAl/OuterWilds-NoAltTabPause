using OWML.ModHelper;
using UnityEngine;

namespace lStewieAl
{
    public class RunInBackground : ModBehaviour
    {
        private void Start()
        {
            Application.runInBackground = true;
        }
    }
}