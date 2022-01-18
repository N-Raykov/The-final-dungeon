using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Portal : Collidable
{
    public string[] sceneNames;
    public bool canUse = false;

    protected override void OnCollide(Collider2D coll)
    {
        if (canUse == true && coll.name == "Player")
        {
            //GameManager.instance.SaveState();
            string sceneName = sceneNames[Random.Range(0, sceneNames.Length)];
            SceneManager.LoadScene(sceneName);
        }
    }
}
