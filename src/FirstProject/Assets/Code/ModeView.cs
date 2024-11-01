using UnityEngine;

namespace Code
{
    public class ModeView : MonoBehaviour
    {
        [SerializeField] private MoverX _moverX;

        private void Update()
        {
            if (_moverX.Speed > 0)
            {
                transform.localScale = new Vector3(
                    x: Mathf.Abs(transform.localScale.x),
                    y: transform.localScale.y,
                    z: transform.localScale.z);
            }
            else if (_moverX.Speed < 0)
            {
                transform.localScale = new Vector3(
                    x: -Mathf.Abs(transform.localScale.x),
                    y: transform.localScale.y,
                    z: transform.localScale.z);
            }
        }
    }
}