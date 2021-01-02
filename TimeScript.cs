using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimeScript : MonoBehaviour
{
	    public Text text1;

		float seconds=50,miliseconds;
		public bool isGameStarted;
    // Start is called before the first frame update
    void Start()
    {
        isGameStarted=true;
    }

    // Update is called once per frame
    void Update()
    {
        timer();
    }
	public void timer(){
		if(miliseconds<=0 && seconds >0){
		seconds--;
		miliseconds=100;
		}
		else if(miliseconds <=0&& seconds<=0){
			SceneManager.LoadScene("basarisiz");
		}
		miliseconds-=Time.deltaTime*100;
		if(seconds<=10){
			text1.color=Color.red;
		}
		text1.text=string.Format("{0},{1}",seconds,(int)miliseconds);
	}
}
