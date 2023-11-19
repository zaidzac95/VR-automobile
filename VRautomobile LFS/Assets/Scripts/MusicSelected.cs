using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSelected : MonoBehaviour
{
    private int SelectedMusicIndex;

    [Header("List of MusicStation")]
    [SerializeField] private List<MusicSelectedList> musicList = new List<MusicSelectedList>();

    [Header("Reference")]
    [SerializeField] private Text stationName;
    [SerializeField] private Image stationDesign;
    [SerializeField] private AudioSource songTitle;
    public bool startBtnOn = false;
    AudioSource currentSong;

    void Start()
    {
        UpdateMusicSelection(SelectedMusicIndex);
    }

    public void LeftArrow()
    {
        SelectedMusicIndex--;
        currentSong.Stop(); // Added 04 May 2023
        if (SelectedMusicIndex < 0)
            SelectedMusicIndex = musicList.Count - 1;
        

        UpdateMusicSelection(SelectedMusicIndex);
    }

    public void RightArrow()
    {
        SelectedMusicIndex++;
        currentSong.Stop(); // Added 04 May 2023
        if (SelectedMusicIndex == musicList.Count)
            SelectedMusicIndex = 0;

        UpdateMusicSelection(SelectedMusicIndex);
    }
    public void OnMusicStation()
    {
        startBtnOn = true;
        UpdateMusicSelection(SelectedMusicIndex);
    }

    public void UpdateMusicSelection(int index)
    {
        if (startBtnOn)
        {
            SelectedMusicIndex = index;
            stationDesign.sprite = musicList[SelectedMusicIndex].webStation;
            stationName.text = musicList[SelectedMusicIndex].station;
            songTitle = musicList[SelectedMusicIndex].music;
            currentSong = songTitle; // Added 04 May 2023
            currentSong.Play(); // Added 04 May 2023 original songTitle.Play();
        }
    }

    public void OffRadio()
    {
        currentSong.Stop();
    }

    public void SaveMusic()
    {
        ES3.Save<int>("Musicsave", SelectedMusicIndex);
    }

    public void LoadMusic()
    {
        SelectedMusicIndex = ES3.Load<int>("Musicsave", 0);
        UpdateMusicSelection(SelectedMusicIndex);
    }

    [System.Serializable]
    public class MusicSelectedList
    {
        public Sprite webStation;
        public string station;
        public AudioSource music;
    }
}
