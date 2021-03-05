using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class UI_SkillTree : MonoBehaviour
{

    private void Awake() {

        transform.Find("skillBtn").GetComponent<Button_UI>().ClickFunc = () =>
        {

            Debug.Log("Click");
        };
    }
}