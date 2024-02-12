using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SampleSceneButtonTest
{
    [UnityTest]
    public IEnumerator HealButtonTest()
    {
        SceneManager.LoadScene("SampleScene");
        yield return null;

        Button healButton = GameObject.Find("Heal").GetComponent<Button>();

        yield return null;

        Assert.IsTrue(healButton.enabled, "Heal Button is enable");
        Assert.IsTrue(healButton.interactable, "Heal Button is clickable");
      
    }
    [UnityTest]
    public IEnumerator DamageButtonTest()
    {
        SceneManager.LoadScene("SampleScene");
        yield return null;

        Button damageButton = GameObject.Find("Damage").GetComponent<Button>();

        yield return null;


        Assert.IsTrue(damageButton.interactable);

    }
}
