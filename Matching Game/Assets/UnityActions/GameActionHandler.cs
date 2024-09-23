using UnityEngine;
using UnityEngine.Events;

namespace UnityActions
{
    public class GameActionHandler : MonoBehaviour
    {
        public GameAction gameActionObj;
        public UnityEvent onRaiseEvent;
        public void Start()
        {
            gameActionObj.raise += Raise;
        }

        private void Raise()
        {
            onRaiseEvent.Invoke();
        }
    }
}
