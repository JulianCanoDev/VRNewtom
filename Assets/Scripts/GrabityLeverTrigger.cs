using UnityEngine;

public class GrabityLeverTrigger : MonoBehaviour
{
    [SerializeField] private float gravity;
    private GrabityControl gravityControl;

    private void Start() =>
        gravityControl = gameObject.GetComponentInParent<GrabityControl>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hand")
            gravityControl.GravityControlManager(gravity);
    }
}
