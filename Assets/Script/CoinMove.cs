
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    float deg = 0f;
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, deg, 0);
        deg ++;
    }
}
