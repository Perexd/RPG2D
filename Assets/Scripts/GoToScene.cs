using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToScene : MonoBehaviour
{
    public string uuid;
    public string sceneName = "New Scene name here";
    public bool isAutomatic;
    private bool manualEnter;

    private void Update()
    {
        if (!isAutomatic && !manualEnter)
        {
            manualEnter = Input.GetButtonDown("Fire1");
        }
    }
    //automatico
    private void OnTriggerEnter2D(Collider2D other)
    {
        Teleport(other.name);
    }
    //manual
    private void OnTriggerStay2D(Collider2D other)
    {
        Teleport(other.name);
    }
    private void Teleport(string objName)
    {
        if (objName == "player")
        {
            if (isAutomatic || (!isAutomatic && manualEnter))
            {
                FindObjectOfType<playercontroler>().nextUuid = uuid;
                SceneManager.LoadScene(sceneName);
            }
        }

    }
}
