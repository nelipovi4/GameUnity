
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public GameManager gm;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
    if(rb.transform.position.y <= -30){
            gm.EndGame();
        }
    }


}
