using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.Play("opening_anim");
        }
    }
}
