/**
 * Script untuk lanjut scene, setelah scene tutorial (lanjut ke loading screen)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterTutorial : MonoBehaviour
{

    private int loadingScene = 2;

    // Start is called before the first frame update
    void Start()
    {
    }
    //Ketika tutorial telah diselesaikan, scene akan berpindah ke loading scene
    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Player'sCar")
        {
            SceneManager.LoadScene(loadingScene);

        }
    }
            // Update is called once per frame
    void Update()
    {
    }
}
