
using UnityEngine;

public class PaulMove : MonoBehaviour
{
        float degAD = 0f, degWS = 0f;
        bool w = false, a = false, s = false, d = false;

    
    private void Start() {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    private void Update() {
        if(Input.GetKey("w")){
            w = true;
        }
        else{
            w = false;
        }

        if(Input.GetKey("a")){
            a = true;
        }
        else{
            a = false;
        }

        if(Input.GetKey("s")){
            s = true;
        }
        else{
            s = false;
        }

        if(Input.GetKey("d")){
            d = true;
        }
        else{
            d = false;
        }

        
    }

    private void FixedUpdate() {
        if (a && degAD <= 12){
            degAD += 0.3f;
            transform.rotation = Quaternion.Euler(degWS, 0, degAD);
        }
        if (d && degAD >= -12){
            degAD -= 0.3f;
            transform.rotation = Quaternion.Euler(degWS, 0, degAD);
        }

        if (w && degWS <= 12){
            degWS += 0.3f;
            transform.rotation = Quaternion.Euler(degWS, 0, degAD);
        }

        if (s && degWS >= -12){
            degWS -= 0.3f;
            transform.rotation = Quaternion.Euler(degWS, 0, degAD);
        }
}

    
}
