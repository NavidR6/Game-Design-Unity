using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject explosion_player;

    // Detect when another object collides with this object
    void OnCollisionEnter2D(Collision2D other)
    {
        //Check if the other object is the player
        if(other.gameObject.CompareTag("Player"))
        {
            // Collided with the player
            Instantiate(explosion_player, other.transform.position, other.transform.rotation);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        // Create and position explosion
        Instantiate(explosion, transform.position, transform.rotation);

        // Delete "other" object
        // Delete this object
        Destroy(other.gameObject);
        Destroy(this.gameObject);

        if(other.gameObject.CompareTag("Laser"))
        {
            ScoreText.scoreValue += 50;
        }
    }
}
