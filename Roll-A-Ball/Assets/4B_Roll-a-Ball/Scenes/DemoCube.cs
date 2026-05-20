using UnityEngine;

public class DemoCube : MonoBehaviour
{
    public AudioSource sfx;
    private void OnTriggerEnter(Collider other)
    {
        sfx.Play();
        //Destroy(gameObject);
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false; // Hier eigenen Col verwenden
    }
}
