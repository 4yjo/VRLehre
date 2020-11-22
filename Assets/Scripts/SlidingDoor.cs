using UnityEngine;

//source code by tutorial https://www.youtube.com/watch?v=gmH-t68jnKk

public class SlidingDoor : MonoBehaviour
{
    public GameObject trigger;
    public GameObject door;

    Animator animator;

    void Start()
    {
        animator = door.GetComponent<Animator>();
    }

   void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entereeeeed");
        if (other.gameObject.tag == "Player") { SlideDoors(true); }
    }   

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exiiiiit");
        if (other.gameObject.tag == "Player") { SlideDoors(false); }
    }

    void SlideDoors(bool state)
    {
        animator.SetBool("slide", state);
    }

}

