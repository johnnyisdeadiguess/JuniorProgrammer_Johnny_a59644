using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //estabelece o objecto que a camera irá seguir
    public GameObject player;

    //Estabelce o posicionamento da camera em relaçao ao objeto
    private Vector3 offset = new Vector3(0, 7, -13);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //movimento da camera
        transform.position = player.transform.position + offset;
    }
}