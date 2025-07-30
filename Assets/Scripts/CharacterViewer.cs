using UnityEngine;
using TMPro;

public class CharacterViewer : MonoBehaviour
{
    [Header("Highlight Object")]
    public GameObject thumbnailHighlighter;  // The object we want to move

    [Header("Thumbnail Highlighters")]
/*    public GameObject boyHighlighterPosition;
    public GameObject girlHighlighterPosition;
    public GameObject newBoyHighlighterPosition;
    public GameObject newGirlHighlighterPosition;
    public GameObject EgyptQueenHighlighterPosition;
    public GameObject WitchHighlighterPosition;
    public GameObject GwenHighlighterPosition;*/
    public GameObject ElonHighlighterPosition;
    /*public GameObject MansaHighlighterPosition;
    public GameObject HotbHighlighterPosition;
    public GameObject HotgHighlighterPosition;
    public GameObject MJHighlighterPosition;*/
  //  public GameObject ChubbsHighlighterPosition;
    public GameObject OfficeGirlHighlighterPosition;

    [Header("Thumbnails")]
/*    public GameObject boyTick;
    public GameObject girlTick;
    public GameObject newBoyTick;
    public GameObject newGirlTick;
    public GameObject EgyptQueenTick;
    public GameObject GwenTick;
    public GameObject WitchTick;

    public GameObject MansaTick;
    public GameObject HotbTick;
    public GameObject HotgTick;
    public GameObject MJTick;
    public GameObject ChubbsTick;*/
    public GameObject OfficeGirlTick;
    public GameObject ElonTick;

    public GameStartManager gameStartManager;

    [Header("Character Models for Viewing")]
/*    public GameObject boyCharacterModel;
    public GameObject girlCharacterModel;
    public GameObject newBoyCharacterModel;
    public GameObject newGirlCharacterModel;
    public GameObject EgyptQueenCharacterModel;
    public GameObject WitchCharacterModel;
    public GameObject GwenCharacterModel;
   
    public GameObject MansaCharacterModel;
    public GameObject HotbCharacterModel;
    public GameObject HotgCharacterModel;
    public GameObject MJCharacterModel;
    public GameObject ChubbsCharacterModel;*/
    public GameObject OfficeGirlCharacterModel;
    public GameObject ElonCharacterModel;

    [SerializeField] private GameObject Selection_Camera;


    // Method to actually show/hide models
    private void ShowCharacterByKey(string characterKey)
    {
        // Disable all character models
        ElonCharacterModel.SetActive(false);
        OfficeGirlCharacterModel.SetActive(false);

        // Move the highlighter to the correct position
        switch (characterKey)
        {
            case "Elon":
                ElonCharacterModel.SetActive(true);
                thumbnailHighlighter.transform.position = ElonHighlighterPosition.transform.position;

                // Move the camera for Elon
                Selection_Camera.transform.position = new Vector3(-41.80926513671f, 4.477111816f, 0.28228759765625f);
                Selection_Camera.transform.rotation = new Quaternion(-0.1373901069164276f, 0.14152227342128755f, -0.05253278836607933f, -0.9789462685585022f);
                break;

            case "OfficeGirl":
                OfficeGirlCharacterModel.SetActive(true);
                thumbnailHighlighter.transform.position = OfficeGirlHighlighterPosition.transform.position;

                // Move the camera for Office Girl
                Selection_Camera.transform.position = new Vector3(-42.0482177734375f, 4.33514404296875f, 0.47430419921875f);
                Selection_Camera.transform.rotation = new Quaternion(-0.1373901218175888f, 0.14152225852012635f, -0.05253278836607933f, -0.9789462685585022f); 
                break;

            default:
                Debug.LogWarning($"Unknown character key: {characterKey}");
                break;
        }
    }

    // Called by each thumbnail button (e.g., boy, girl, newBoy, newGirl)
    // so the user can preview it visually.
    public void OnThumbnailClicked(string characterKey)
    {
        ShowCharacterByKey(characterKey);
    }

    // Called by your "Exit" button to restore the truly selected character visually
    public void ViewSelectedCharacter()
    {
        string selectedKey = gameStartManager.GetCurrentlySelectedCharacter();
        ShowCharacterByKey(selectedKey);

        // Ensure the UI reflects the currently selected character
        gameStartManager.selectedCharacterNameText.text = gameStartManager.characterDisplayNames[selectedKey];

        if (gameStartManager.characterCosts.TryGetValue(selectedKey, out int cost))
        {
            gameStartManager.currentViewedCharacter = selectedKey;
            gameStartManager.currentViewedCharacterCost = cost;

            gameStartManager.RefreshBigActionButton();
        }
    }
    public void RefreshThumbnailTicks()
    {
        // Boy (always owned)
       /* boyTick.SetActive(true);

        // Girl (always owned)
        girlTick.SetActive(true);

        // New Boy
        bool newBoyOwned = gameStartManager.IsCharacterBought("newBoy");
        newBoyTick.SetActive(newBoyOwned);

        // New Girl
        bool newGirlOwned = gameStartManager.IsCharacterBought("newGirl");
        newGirlTick.SetActive(newGirlOwned);

        // Gwen
        bool GwenOwned = gameStartManager.IsCharacterBought("Gwen");
        GwenTick.SetActive(GwenOwned);

        // Egypt Queen
        bool EgyptQueenOwned = gameStartManager.IsCharacterBought("EgyptQueen");
        EgyptQueenTick.SetActive(EgyptQueenOwned);

        // Witch
        bool WitchOwned = gameStartManager.IsCharacterBought("Witch");
        WitchTick.SetActive(WitchOwned);*/

        // Elon
        bool ElonOwned = gameStartManager.IsCharacterBought("Elon");
        ElonTick.SetActive(ElonOwned);

        /*   // Mansa
           bool MansaOwned = gameStartManager.IsCharacterBought("Mansa");
           MansaTick.SetActive(MansaOwned);

           // Hotb
           bool HotbOwned = gameStartManager.IsCharacterBought("Hotb");
           HotbTick.SetActive(HotbOwned);

           // Hotg
           bool HotgOwned = gameStartManager.IsCharacterBought("Hotg");
           HotgTick.SetActive(HotgOwned);

           // MJ
           bool MJOwed = gameStartManager.IsCharacterBought("MJ");
           MJTick.SetActive(MJOwed);

           // Chubbs
           bool ChubbsOwned = gameStartManager.IsCharacterBought("Chubbs");
           ChubbsTick.SetActive(ChubbsOwned);
        */

        // Office Girl
        bool OfficeGirlOwned = gameStartManager.IsCharacterBought("OfficeGirl");
        OfficeGirlTick.SetActive(OfficeGirlOwned);
    }


}
