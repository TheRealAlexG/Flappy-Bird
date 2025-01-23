using UnityEngine;

public class PlayerCollideManager : MonoBehaviour
{
    [SerializeField]ScoreManager scoreManager;
    [SerializeField]GameOverManager gameOverManager;
    [SerializeField] AudioSource audioPointPlayer;
    [SerializeField] AudioSource audioGameOverPlayer;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");

            gameOverManager.SetGameOver();
            audioGameOverPlayer.Play();
            Destroy(gameObject);

        }
        
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Point"))
        {
            Debug.Log("Add Point , Lets GOO!");

            scoreManager.AddPoint();
            audioPointPlayer.Play();



        }

    }

}
