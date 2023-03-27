using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skipTutorial : MonoBehaviour
{
    public AudioSource ClickSoundEffect; //sound effect ketika tombol skip ditekan
    bool clicked;
    private float delayTime = 0.5f; //waktu delay sebelum berpindah scene saat tombol diklik
    private int loadingScene = 2;
    // Start is called before the first frame update
    void Start()
    {
        clicked = false;
    }
    private void OnMouseDown()
    {
        //skip tutorial, masuk ke loading scene
        ClickSoundEffect.Play();
        clicked = true;
        
    }
    // Update is called once per frame
    void Update()
    {
        if (clicked == true)
        {
            delayTime -= Time.deltaTime;
            if (delayTime <= 0)
            {
                SceneManager.LoadScene(loadingScene);

            }
        }
    }
}
