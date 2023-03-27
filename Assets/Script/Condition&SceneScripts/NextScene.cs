using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private int nextSceneIndex;


    public GameObject gameObj;
    //scene game urutan 3 hingga 53 (terdapat 50 level yang disedikan)
    int batasBawah = 3; 
    int batasAtas = 52; 
    int gameOverScene = 53;

    // Start is called before the first frame update
    void Start()
    {
    }
    void OnTriggerEnter2D (Collider2D obj)
    {
        if(obj.gameObject.tag == "Player'sCar")
        {
            if(gameObj.GetComponent<StartButton>().sceneLoaded.Count < batasAtas-batasBawah+1) { 
            do
            {
                //random scene
                nextSceneIndex =(int) Random.Range(batasBawah, batasAtas);

            } while (checkSimiliar(gameObj.GetComponent<StartButton>().sceneLoaded, nextSceneIndex));

            gameObj.GetComponent<StartButton>().sceneLoaded.Add(nextSceneIndex);
            Debug.Log("count");
            Debug.Log(gameObj.GetComponent<StartButton>().sceneLoaded.Count);

            SceneManager.LoadScene(nextSceneIndex);
            }
            else
            {
                Debug.Log("GameOver");
                SceneManager.LoadScene(gameOverScene);
            }
        }
    }
    
    void Update()
    {

    }
    /**Function untuk mengecek apakah scene yang akan dituju telah pernah atau belum
     * data merupakan array berisi data scene yang telah pernah digunakan sebelumnya
     * counter merupakan jumlah scene yang telah digunakan
     * scene merupakan scene yang ingin dituju dan ingin dicek
     */

    static bool checkSimiliar ( ArrayList data , int scene)
    {
        for (int index = 0; index < data.Count; ++index)
        {
            if (data [index].Equals(scene))
            {
                return true;
            }
        }
        return false;
    }
}
