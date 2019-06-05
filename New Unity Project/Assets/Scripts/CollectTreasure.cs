
using UnityEngine;


public class CollectTreasure : MonoBehaviour
{
    public GameObject panel;
    
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        panel.SetActive(true);
    }
}
