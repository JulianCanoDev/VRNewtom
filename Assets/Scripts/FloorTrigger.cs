using System.Collections;
using UnityEngine;

public class FloorTrigger : MonoBehaviour
{
    private Collision col;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Apple")
        {
            col = collision;
            StartCoroutine(DestroyApple(2f));            
        }
    }

    IEnumerator DestroyApple(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(col.gameObject);
    }
}
