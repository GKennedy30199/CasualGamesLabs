using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateProfileController : MonoBehaviour
{
    public InputField UserName;
    Color defaultcolor=Color.red;

    public void SetProfileColor(Button ClickedButton)
    {
        if(ClickedButton!=null)
        {
            defaultcolor=ClickedButton.GetComponent<Image>().color;
            Debug.Log(defaultcolor);
        }
    }
    public void CreateProfile()
    {
        if(!string.IsNullOrEmpty(UserName.text))
        {
            string username = UserName.text;
            UserProfile profile = new UserProfile()
            {
                Username = username,
                CreatedOn = DateTime.UtcNow,
                Color = defaultcolor
            };
            AddProfileToList(profile);
            Debug.Log(profile.Username + ":" + profile.CreatedOn);
        }
    }
    public void AddProfileToList(UserProfile profile)
    {
        if(profile!=null)
        {
            ProfileButtonController profileButton = 
            Instantiate<ProfileButtonController>
            (ProfileButtonPrefab, IsProfilesContent.transform);

            profileButton.UpdateButton(profile);
        }
    }

    public ProfileButtonController ProfileButtonPrefab;
    public GameObject IsProfilesContent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
