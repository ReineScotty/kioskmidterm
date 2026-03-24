using UnityEngine;


public class ToggleObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject objectToToggle;
    public void ToggleVisibility()
    {
       if (objectToToggle != null) 
       {
        objectToToggle.SetActive(!objectToToggle.activeInHierarchy);
       }
    }
}

