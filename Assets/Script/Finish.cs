
using UnityEngine;

public class Finish : MonoBehaviour
{
        private void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "finish")
        {
            Debug.Log("Прошёл");
        }
    }
}
