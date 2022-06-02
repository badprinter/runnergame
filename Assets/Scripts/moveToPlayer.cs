using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToPlayer : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float offset =  (player.transform.position.z - 5) * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, transform.position.y, offset);

       // transform.LookAt(player.transform.position + offsetVidion);
    }
}
