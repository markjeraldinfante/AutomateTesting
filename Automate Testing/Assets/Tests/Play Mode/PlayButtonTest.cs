using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButtonTest
{
  
    [UnityTest, Order(1)]
    public IEnumerator playButtonTest()
    {
        //Arrange
        SceneManager.LoadScene("Main Menu");
        yield return null;
        Button playButton = GameObject.Find("PlayButton").GetComponent<Button>();
        //Act

        //Assert
        yield return null;
        Assert.IsNotNull(playButton, "Play button is null");
        Assert.IsTrue(playButton.enabled, "Play button is not enable");
        Assert.IsTrue(playButton.interactable, "Play button is not interactable");
    }

    [UnityTest, Order(2)]
    public IEnumerator playButtonFunctionalityTest()
    {
        //Arrange
        SceneManager.LoadScene("Main Menu");
        yield return null;
        Button playButton = GameObject.Find("PlayButton").GetComponent<Button>();

        yield return null;
       //Act
        playButton.onClick.Invoke();
        yield return new WaitForSeconds(2f);

        //Assert
        Assert.AreEqual("SampleScene", SceneManager.GetActiveScene().name, "Scene was not reloaded.");
    }
   
}
