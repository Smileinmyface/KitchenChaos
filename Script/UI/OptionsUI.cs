using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsUI : MonoBehaviour
{
    [SerializeField] private Button soundEffectsButton;
    [SerializeField] private Button musicButton;

    private void Awake()
    {
        soundEffectsButton.onClick.AddListener(()=>{

        });
        musicButton.onClick.AddListener(() =>
        {

        });
    }
}
