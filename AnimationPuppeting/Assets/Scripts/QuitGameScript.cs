using UnityEngine;

public class QuitGameScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quit Game");
            Application.Quit();
        }
    }
}
