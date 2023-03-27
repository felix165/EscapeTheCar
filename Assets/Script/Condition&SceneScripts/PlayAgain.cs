using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public GameObject gameObj;
    public AudioSource ClickSoundEffect; //sound effect ketika tombol start ditekan
    private float delayTime; //waktu delay sebelum berpindah scene saat tombol diklik

    public float delta_Time = 900f; //waktu tersedia untuk bermain dalam format detik

    public bool playAgain;
    int tutorialScene = 1;

    // Start is called before the first frame update
    void Start()
    {
        delayTime = 0.5f;
        playAgain = false;
    }
    private void OnMouseDown()
    {
        //array sceneLoaded akan direset setiap tombol playAgain ditekan
        ClickSoundEffect.Play();
        playAgain = true;
    }
    // Update is called once per frame
    void Update()
    {

        if (playAgain == true)
        {
            delayTime -= Time.deltaTime;
            if (delayTime <= 0)
            {
                gameObj.GetComponent<StartButton>().sceneLoaded.Clear();
                gameObj.GetComponent<StartButton>().delta_time = delta_Time;

                SceneManager.LoadScene(tutorialScene);

            }
        }
    }
}
