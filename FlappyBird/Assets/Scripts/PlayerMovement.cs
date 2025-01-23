using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerRB;
    [SerializeField] private float _rotationSpeed = 10F;
    [SerializeField] private float _velocity = 1.5F;




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Flappy Birdy Start The Game!");

        //Conectas el rigidBody del Game amb el Script 
        playerRB = GetComponent<Rigidbody>(); 


        
    }

    // Update is called once per frame
    void Update()
    {
       //Debug.Log("Playing The Game!");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Flap!");

            playerRB.AddForce(new Vector3(0, 5, 0),ForceMode.Impulse);


        }



    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, playerRB.velocity.y * _rotationSpeed);
    }
}

