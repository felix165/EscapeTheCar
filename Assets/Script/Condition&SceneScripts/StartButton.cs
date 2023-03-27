using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public AudioSource ClickSoundEffect; //sound effect ketika tombol start ditekan
    public ArrayList sceneLoaded = new ArrayList(); //array berisi scene yang telah pernah diload
    public float delta_time = 900f; //waktu tersedia untuk bermain dalam format detik
    
    bool clicked;
    private float delayTime = 0.5f; //waktu delay sebelum berpindah scene saat tombol diklik
    int tutorialScene = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        delta_time = 900f;
        clicked = false;
        delayTime = 0.5f;
        sceneLoaded.Clear();
    }
    private void OnMouseDown()
    {
        //array sceneLoaded akan direset setiap tombol start ditekan
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
                sceneLoaded.Clear();

                SceneManager.LoadScene(tutorialScene);
            }
        }
    }
}
