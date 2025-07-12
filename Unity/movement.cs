using JetBrains.Annotations;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody player;

    public float forwardForce = 200;
    public float upwardForce = 20;
    public float sideForce = 20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //x,y,z
        player.useGravity = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    //FixedUpdate is called once per frame and is used to calc physics
    private void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            //CAREFUL! "forwardForce" is multiplied by neg1 because our "forward"/main direction is -x.
            player.AddForce(-1 * forwardForce * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("d"))
        {
            player.AddForce(0, 0, sideForce * Time.deltaTime);
        }
    }
}
