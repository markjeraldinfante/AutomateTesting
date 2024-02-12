using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EntityTest
{
    GameObject prefab;
    Collider collider;
    MeshRenderer meshRenderer;
    EntityController controller;

    [SetUp]
    public void EntitySetup()
    {
        prefab = Resources.Load<GameObject>("Prefab/SampleObject");
        collider = prefab.GetComponent<Collider>();
        meshRenderer = prefab.GetComponent<MeshRenderer>();
        controller = prefab.GetComponent<EntityController>();
    }

    [Test]
    public void testNullCollider()
    {
        Assert.IsNotNull(collider, "Collider Component is Null");
        Assert.IsTrue(collider.enabled, "Collider Component is Disabled");
    }

    [Test]
    public void testNullMesh()
    {
        Assert.IsNotNull(meshRenderer, "Mesh Renderer Component is Null");
        Assert.IsTrue(meshRenderer.enabled, "Mesh Renderer Component is Disabled");
    }

    [Test]
    public void testNullEntityController()
    {
        Assert.IsNotNull(controller, "Entity Controller Script is Null");
        Assert.IsTrue(controller.enabled, "Entity Controller Script is Disabled");
    }
}
