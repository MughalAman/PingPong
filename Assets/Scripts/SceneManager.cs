using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject ball;
    public GameObject P1;
    public GameObject P2;
    public GameObject Menu;

    public Vector2 P1SpawnPos;
    public Vector2 P2SpawnPos;

    private Coroutine co_HideCursor;

    void Start()
    {

    }

    public void StartGame()
    {
        Instantiate(ball, new Vector2(0, 0), Quaternion.identity);
        Instantiate(P1, P1SpawnPos, Quaternion.identity);
        Instantiate(P2, P2SpawnPos, Quaternion.identity);
        Menu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    private IEnumerator HideCursor()
    {
        yield return new WaitForSeconds(3);
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetAxis("Mouse X") == 0 && (Input.GetAxis("Mouse Y") == 0))
        {
            if (co_HideCursor == null)
            {
                co_HideCursor = StartCoroutine(HideCursor());
            }
        }
        else
        {
            if (co_HideCursor != null)
            {
                StopCoroutine(co_HideCursor);
                co_HideCursor = null;
                Cursor.visible = true;
            }
        }
    }

}
