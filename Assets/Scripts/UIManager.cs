using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance = null;

    public Image BGEffect;
    public TextMeshProUGUI Timer_Text;
    public float Text_speed;
    private void Awake()
    {
        if (instance == null || instance != this)
        {
            instance = this;
        }
    }
    private void Start()
    {
        TimerText();
    }

    public void ShowBloodEffect()
    {
            Debug.Log("Call me");
            LeanTween.alpha(BGEffect.rectTransform, 1.0f, 1f).setOnComplete(BGEffectCompleted);  
    }
    public void BGEffectCompleted()
    {

        LeanTween.alpha(BGEffect.rectTransform, 0.0f, 0.5f).setDelay(1f);

    }
    public void TimerText()
    {
        LeanTween.cancel(Timer_Text.gameObject);
        Timer_Text.transform.localScale = Vector3.one;
        LeanTween.scale(Timer_Text.gameObject, Vector3.one * 2, Text_speed).setEasePunch();
        LeanTween.value(Timer_Text.gameObject,10, 0, 10).setOnUpdate(SetText);
        
    }

    private void SetText(float Value)
    {
        Timer_Text.text = Value.ToString("0");
        if(Value <3)
        {
            Timer_Text.color = Color.red;
        }
    }
}
