using UnityEngine;

public class LeverMovement : MonoBehaviour
{
    [SerializeField] private GameObject lever;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            
        }
    }
}
