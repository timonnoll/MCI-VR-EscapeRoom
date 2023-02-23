using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript: MonoBehaviour
{
    
	[SerializeField] private float currentTime;
	[SerializeField] private float displayTime;
	[SerializeField] private TMP_Text displayText;
// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
	displayTime = Mathf.Round(currentTime);
	displayText.text = displayTime.ToString();

	if(currentTime < 0){
		displayText.text = "GameOver";
	}
	else{
		displayText.text = displayTime.ToString() + "s";
	}
    }
}
