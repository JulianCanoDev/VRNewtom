using UnityEngine;

public class TargetTrigger : MonoBehaviour
{
    private PointsCounter pointCounter;
    [SerializeField] private int targetPoints;

    private void Start()
    {
        pointCounter = gameObject.GetComponentInParent<PointsCounter>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Apple")
        {
            pointCounter.AddPoints(targetPoints);
            pointCounter.ShowScore();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
