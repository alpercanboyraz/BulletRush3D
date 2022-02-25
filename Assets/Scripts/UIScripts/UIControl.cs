using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class UIControl : MonoBehaviour
{
    

    [SerializeField] TextMeshProUGUI smallEnemyText;
    [SerializeField] TextMeshProUGUI bigEnemyText;
    [SerializeField] TextMeshProUGUI levelText;

    int smallEnemyCount,bigEnemyCount;

    public GameObject levelUpScreen;
    public TMP_Text textComponent;
    
    void Update(){
       
        smallEnemyCount =  GameObject.FindGameObjectsWithTag("smallEnemy").Length;
        bigEnemyCount =    GameObject.FindGameObjectsWithTag("bigEnemy").Length;
        
        smallEnemyText.text = "SMALL ENEMY : " + smallEnemyCount.ToString();
        bigEnemyText.text = "BIG ENEMY : " + bigEnemyCount.ToString();


        if(smallEnemyCount == 0 && bigEnemyCount == 0){

              levelUpScreen.SetActive(true);
              textComponent.ForceMeshUpdate();
              var textInfo = textComponent.textInfo;

              for (int i = 0; i < textInfo.characterCount; i++)
              {
                  var charInfo = textInfo.characterInfo[i];

                  if(!charInfo.isVisible){
                      continue;
                  }

                  var verts = textInfo.meshInfo[charInfo.materialReferenceIndex].vertices;
                  for (int j = 0; j < 4; ++j)
                  {
                      var orig = verts[charInfo.vertexIndex +j];
                      verts[charInfo.vertexIndex +j] = orig + new Vector3(0,Mathf.Sin(Time.time*2f + orig.x*0.01f)*10f,0);
                  }  
                }  
            
                for (int i = 0; i < textInfo.meshInfo.Length; ++i)
                {
                        var meshInfo = textInfo.meshInfo[i];
                        meshInfo.mesh.vertices = meshInfo.vertices;
                        textComponent.UpdateGeometry(meshInfo.mesh,i);
                }
            }
    }
    
    public void ResetTheGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        print("button is working");
    }
    public void PlayNewLevel(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
