using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody2D>().velocity = new Vector2(sx, sy) * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "LeftWall")
        {
            Destroy(this.gameObject);
            Destroy(GameObject.FindGameObjectWithTag("Player1"));
            Destroy(GameObject.FindGameObjectWithTag("Player2"));
            Debug.Log("Player 1 Wins!");
            SceneManager sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();
            if(sceneManager != null)
            {
                sceneManager.Menu.SetActive(true);
            }
        }
        else if(col.tag == "RightWall")
        {
            Destroy(this.gameObject);
            Destroy(GameObject.FindGameObjectWithTag("Player1"));
            Destroy(GameObject.FindGameObjectWithTag("Player2"));
            Debug.Log("Player 2 Wins!");
            SceneManager sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();
            if (sceneManager != null)
            {
                sceneManager.Menu.SetActive(true);
            }
        }
        else if(col.tag == "Roof")
        {
            FindObjectOfType<AudioManager>().Play("Bounce");
        }
        else if(col.tag == "Floor")
        {
            FindObjectOfType<AudioManager>().Play("Bounce");
        }
        else if(col.tag == "Player1")
        {
            FindObjectOfType<AudioManager>().Play("Bounce");
        }
        else if (col.tag == "Player2")
        {
            FindObjectOfType<AudioManager>().Play("Bounce");
        }
    }

}
