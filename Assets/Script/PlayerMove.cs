using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
    if(rb.transform.position.y <= -30){
            EndGame();
        }
    }

    public void EndGame(){
        Invoke("Restart", 2f);
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
