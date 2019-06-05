
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject Block1, Block2;
    private void OnTriggerEnter( Collider other)
    {
        Block1.GetComponent<MovingObstacle>().enabled = true;
        Block2.GetComponent<MovingObstacle>().enabled = true;
    }
}
