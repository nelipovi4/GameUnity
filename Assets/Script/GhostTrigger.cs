using UnityEngine.UI;
using UnityEngine;

public class GhostTrigger : MonoBehaviour
{
    int heart = 3;
    public GameManager gm;
    public Text text;

    private void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "Ghost")
        {
            heart--;
            if (heart == 0){
                gm.EndGame();
            }
            else{
                text.text = heart.ToString();
            }
        }
    }
}
