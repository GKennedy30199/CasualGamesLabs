using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileButtonController : MonoBehaviour
{
   
    public Image background;
    public Text usernametxt;
    public void UpdateButton(UserProfile profile)
    {
        usernametxt.text = profile.Username;
        background.color = profile.Color;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
