using UnityEngine;


namespace Managers
{
    public class InputManager : MonoBehaviour
    {
        public MyControls input;

        private void Awake()
        {
            input = new MyControls();
        }

        private void OnEnable()
        {
            input.Enable();
        }

        private void OnDisable()
        {
            input.Disable();
        }
    }

}
