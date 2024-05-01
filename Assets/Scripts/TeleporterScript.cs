using UnityEngine;

public class Example : MonoBehaviour
{
    public float distanceBackToTravel;
    private void OnTriggerEnter(Collider other)
    {
	Debug.Log(other.transform);
        other.gameObject.GetComponent<CharacterController>().enabled = false;
        other.transform.position += new Vector3(0.0f, 0.0f, distanceBackToTravel);
        other.gameObject.GetComponent<CharacterController>().enabled = true;
    }
}