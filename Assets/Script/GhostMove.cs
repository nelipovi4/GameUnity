
using UnityEngine;


public class GhostMove : MonoBehaviour
{
    float pos = 3f;
    bool flag = true;
    void Update()
    {
        if (!flag)
        {
            transform.position +=  transform.forward * pos * Time.deltaTime;
            if (transform.position.z <= -3){
                //transform.rotation = Quaternion.Euler(0, 0, 0);
                flag = true;
            }
        }
        else if (transform.position.z <= 23f && flag)
        {
            transform.position +=  transform.forward * -pos * Time.deltaTime;
        }
        else{
            //transform.rotation = Quaternion.Euler(0, -180, 0);
            flag = false;
        }
    }
    
}
