using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown qualityDropdown;

    /// <summary>
    /// Resolutions
    /// </summary>
    private Resolution[] resolutions;
    private List<Resolution> filteredResolutions;

    private float currentRefreshRate;
    private int currentResolutionIndex = 0;

    /// <summary>
    /// Saved values
    /// </summary>
    private bool isFullScreen;
    private Resolution newResolution;

    // Start is called before the first frame update
    void Start()
    {
        isFullScreen = Screen.fullScreen;
        resolutions = Screen.resolutions;
        filteredResolutions = new List<Resolution>();

        qualityDropdown.ClearOptions();
        currentRefreshRate = Screen.currentResolution.refreshRate;

        for (int i = 0; i < resolutions.Length; i++)
        {
            if (resolutions[i].refreshRate == currentRefreshRate)
            {
                filteredResolutions.Add(resolutions[i]);
            }
        }

        List<string> options = new List<string>();
        for (int i = 0; i < filteredResolutions.Count; i++)
        {
            options.Add(filteredResolutions[i].width + "x" + filteredResolutions[i].height + " " + filteredResolutions[i].refreshRate + " Hz");
            if (filteredResolutions[i].width == Screen.width && filteredResolutions[i].height == Screen.height) 
            {
                currentResolutionIndex = i;
            }
        }

        qualityDropdown.AddOptions(options);
        qualityDropdown.value = currentResolutionIndex;
        qualityDropdown.RefreshShownValue();
    }

    /// <summary>
    /// Sets the resolution
    /// </summary>
    /// <param name="index"></param>
    public void SetResolution(int index) 
    {
        newResolution = filteredResolutions[index];
    }

    /// <summary>
    /// Sets the screen to full screen
    /// </summary>
    /// <param name="fullScreen"></param>
    public void SetFullScreen(bool fullScreen) 
    {
        isFullScreen = fullScreen;
    }

    /// <summary>
    /// Saves values
    /// </summary>
    public void SaveValues() 
    {
        Screen.fullScreen = isFullScreen;
        Screen.SetResolution(newResolution.width, newResolution.height, isFullScreen);
    }
}
