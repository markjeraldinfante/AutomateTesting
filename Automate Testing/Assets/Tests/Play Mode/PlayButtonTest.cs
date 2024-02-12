using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButtonTest
{
  
    [UnityTest]
    public IEnumerator PlayButtonTestWithEnumeratorPasses()
    {
        SceneManager.LoadScene("Main Menu");
        yield return null;

        Button playButton = GameObject.Find("PlayButton").GetComponent<Button>();

        yield return null;

        playButton.onClick.Invoke();
        yield return new WaitForSeconds(2f);
        Assert.AreEqual("SampleScene", SceneManager.GetActiveScene().name, "Scene was not reloaded.");
    }
}
