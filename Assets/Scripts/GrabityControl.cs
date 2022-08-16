using UnityEngine;

public class GrabityControl : MonoBehaviour
{
    private void Start() =>
        Physics.gravity = new Vector3(0, -9.81f, 0);

    public void GravityControlManager(float gravity) => 
        Physics.gravity = new Vector3(0, gravity, 0);    
}
