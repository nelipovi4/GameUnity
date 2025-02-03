using UnityEngine.UI;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Text text;
    int coin = 0;

    private void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "Coin")
        {
            coin++;
            text.text = coin.ToString() + "/5";
            Destroy(other.gameObject);
            if (coin == 5){
                GameObject object_delete = GameObject.FindWithTag("Delete");
                if (object_delete != null)
                {
                    Destroy(object_delete);
                }
            }
        }
    }
}
